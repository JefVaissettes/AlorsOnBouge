using BLLFR;
using MetiersPortable;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IHMFR
{
    public partial class frmPrincipale : Form
    {
        public frmPrincipale()
        {
            InitializeComponent();
            dGVPost.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        #region Load

        private void frmPrincipale_Load(object sender, EventArgs e)
        {
            displaycbBxRubric(Outil.GetAllRubrics());
            displaycbBxSubject(Outil.GetSujetsByCategorieID((int)cbBxRubric.SelectedValue));
            visibiliteModerateur();
        }

        #endregion

        #region buttons click

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btConnecter_Click(object sender, EventArgs e)
        {
            using (Identification frmIdentity = new Identification())
            {
                frmIdentity.ShowDialog();
            }
            visibiliteModerateur();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSeDeconnect_Click(object sender, EventArgs e)
        {
            Accueil.IsConnected = false;
            Accueil.IsRmodo = false;
            MessageBox.Show(Properties.Resources.MsgBoxDeconnexionText, Properties.Resources.MsgBoxDeconnexionTitre, MessageBoxButtons.OK, MessageBoxIcon.Information);
            visibiliteModerateur();
        }

        private void btModifMdp_Click(object sender, EventArgs e)
        {
            using (modifpwd frmmodifpwd = new modifpwd())
            {
                frmmodifpwd.ShowDialog();
            }
            visibiliteModerateur();
        }

        private void btCreerSujet_Click(object sender, EventArgs e)
        {            
                using (frmCreerSujet creerSujet = new frmCreerSujet())
                {
                    creerSujet.rubric = (Rubric)cbBxRubric.SelectedItem;
                    creerSujet.Text = string.Format("Ajouter le sujet dans la rubrique {0}", creerSujet.rubric.Libelle);
                    creerSujet.ShowDialog();
                    displaycbBxSubject(Outil.GetSujetsByCategorieID((int)cbBxRubric.SelectedValue));
                }        
        }

        private void btCreerPost_Click(object sender, EventArgs e)
        {
            using (CreerPost frmCreerPost = new CreerPost())
            {
                frmCreerPost.subject = (Subject)cbBxSubject.SelectedItem;
                frmCreerPost.Text = string.Format("Ajout du post au sujet {0}", frmCreerPost.subject.Titre);
                frmCreerPost.ShowDialog();
                displaydgVPost(Outil.GetAllReponseBySujet((int)cbBxSubject.SelectedValue));
            }
        }

        #endregion

        #region modérateur

        private void btModifSujet_Click(object sender, EventArgs e)
        {
            using (frmCreerSujet Modifsubject = new frmCreerSujet())
            {
                Modifsubject.rubric = (Rubric)cbBxRubric.SelectedItem;
                Modifsubject.subject = (Subject)cbBxSubject.SelectedItem;
                Modifsubject.Text = string.Format("Changer le sujet {0} dans la rubrique {1}", Modifsubject.subject.Titre, Modifsubject.subject.Desc);
                Modifsubject.ShowDialog();
                displaycbBxSubject(Outil.GetSujetsByCategorieID((int)cbBxRubric.SelectedValue));
            }
        }

        private void btSupSujet_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Properties.Resources.MsgBoxDeleteSujetText, Properties.Resources.MsgBoxDeleteSujetTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                if (Outil.DeleteSujet((int)cbBxSubject.SelectedValue) != 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurDeleteSujetText, Properties.Resources.MsgBoxErreurDeleteSujetTitre);

                }
                List<Subject> subjects = Outil.GetSujetsByCategorieID((int)cbBxRubric.SelectedValue);
                if (subjects != null)
                {
                    displaycbBxSubject(subjects);
                }
            }
            if (visibiliteSujets())
            {
                PanelSujetVisible();
            }
            else
            {
                PanelSujetInvisible();
            }
        }

        private void btSupPost_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Properties.Resources.MsgBoxDeletePostText, Properties.Resources.MsgBoxDeletePostTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                if (Outil.DeleteReponse((int)dGVPost.CurrentRow.Cells["ID"].Value) != 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurDeletePostText, Properties.Resources.MsgBoxErreurDeletePostTitre);
                }
                List<Post> posts = Outil.GetAllReponseBySujet((int)cbBxSubject.SelectedValue);


                if (posts != null)
                {
                    displaydgVPost(posts);
                }

                if (visibilitePost())
                {
                    PanelPostVisible();
                }
                else
                {
                    PanelPostInvisible();
                }
            }
        }

        #endregion

        #region event indexchanged

        private void cbBxRubric_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Subject> subjects = Outil.GetSujetsByCategorieID((int)cbBxRubric.SelectedValue);
            if (subjects != null)
            {
                PanelSujetVisible();
                displaycbBxSubject(subjects);
            }
            else
            {
                PanelSujetInvisible();
                PanelPostInvisible();
            }
        }

        private void cbBxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (visibiliteSujets())
            {
                PanelSujetVisible();
                Subject subject = (Subject)cbBxSubject.SelectedItem;
                txtDescSujet.Text = subject.Desc + Environment.NewLine + "de, " + subject.Auteur + Environment.NewLine + "le, " + subject.Date;

                if (visibilitePost())
                {
                    PanelPostVisible();
                    List<Post> posts = Outil.GetAllReponseBySujet((int)cbBxSubject.SelectedValue);
                    if (posts != null)
                    {
                        displaydgVPost(posts);
                    }
                }
                else
                {
                    PanelPostInvisible();
                }
            }
            else
            {
                PanelSujetInvisible();
            }
        }

        private void dGVPost_SelectionChanged(object sender, EventArgs e)
        {
            if (visibilitePost())
            {
                PanelPostVisible();
            }
            else
            {
                PanelPostInvisible();
            }
        }

        #endregion

        #region Méthode

        private void displaycbBxRubric(List<Rubric> rubrics)
        {
            cbBxRubric.ValueMember = "Id";
            cbBxRubric.DisplayMember = "Libelle";
            cbBxRubric.DataSource = rubrics;
        }

        private void displaycbBxSubject(List<Subject> subjects)
        {
            cbBxSubject.ValueMember = "Id";
            cbBxSubject.DisplayMember = "Titre";
            cbBxSubject.DataSource = subjects;
            Subject subject = (Subject)cbBxSubject.SelectedItem;
        }

        private void visibiliteModerateur()
        {
            tbLPUserLogged.Visible = Accueil.IsConnected;
            gbxModerator.Visible = Accueil.IsRmodo;
            btModifMdp.Visible = Accueil.IsConnected;
            btConnecter.Visible = !Accueil.IsConnected;
        }



        private void displaydgVPost(List<Post> posts)
        {
            if (posts != null)
            {
                dGVPost.DataSource = posts;
                dGVPost.Columns["ID"].Visible = false;
                dGVPost.Columns["SUJET"].Visible = false;
                dGVPost.Columns["UTILISATEUR"].Visible = false;
            }
        }

        private bool visibiliteSujets()
        {
            if (cbBxRubric.SelectedIndex != -1)
            {
                if (Outil.GetSujetsByCategorieID((int)cbBxRubric.SelectedValue) != null)
                {
                    return true;
                }
            }
            return false;
        }

        private void PanelSujetVisible()
        {
            cbBxSubject.Visible = true;
            gpBxDescSubject.Visible = true;
            lbPasDeSujet.Visible = false;
            btModifSujet.Enabled = true;
            btSupSujet.Enabled = true;
        }

        private void PanelSujetInvisible()
        {
            cbBxSubject.Visible = false;
            gpBxDescSubject.Visible = false;
            lbPasDeSujet.Visible = true;
            btModifSujet.Enabled = false;
            btSupSujet.Enabled = false;
        }

        private bool visibilitePost()
        {
            if (cbBxSubject.SelectedIndex != -1)
            {
                if (Outil.GetAllReponseBySujet((int)cbBxSubject.SelectedValue) != null)
                {
                    return true;
                }
            }
            return false;
        }

        private void PanelPostVisible()
        {
            dGVPost.Visible = true;
            lbPasDePost.Visible = false;
            btSupPost.Enabled = true;
        }

        private void PanelPostInvisible()
        {
            dGVPost.Visible = false;
            lbPasDePost.Visible = true;
            btSupPost.Enabled = false;
        }

        #endregion

        #region méthode readonly dans les outils d'affichage

        private void cbBxSubject_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbBxRubric_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void txtDescSujet_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        #endregion

        #region Affichage des posts en détail                

        private void dGVPost_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentRow = e.RowIndex;

            DataGridViewRow row = dGVPost.Rows[CurrentRow];
            using (frmDetailPost frmdetailpost = new frmDetailPost())
            {
                frmdetailpost.txtPost.Text = row.Cells["PostContent"].Value.ToString();
                frmdetailpost.lblAuteur.Text += row.Cells["Auteur"].Value.ToString();
                frmdetailpost.lblDateCreation.Text += row.Cells["Date"].Value.ToString();
                frmdetailpost.ShowDialog();
            }

        }

        #endregion

    }
}
