using BLLFR;
using MetiersPortable;
using System;
using System.Windows.Forms;

namespace IHMFR
{
    public partial class frmCreerSujet : Form
    {
        internal Rubric rubric;
        internal Subject subject;

        public frmCreerSujet()
        {
            InitializeComponent();
        }

        private void frmCreerSujet_Load(object sender, EventArgs e)
        {
            ActiveControl = txtBxTitreSujet;

            if(subject == null)
            {
                txtBxTitreSujet.Text = string.Empty;
                txtBxDescSujet.Text = string.Empty;
                btValider.Text = "Valider l'ajout";
            }
            else
            {
                txtBxTitreSujet.Text = subject.Titre;
                txtBxDescSujet.Text = subject.Desc;
                btValider.Text = "Valider la modification";
            }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if(subject == null)
            {
                if(Outil.AddSujet(Accueil.CurrentUsers.Id, rubric.Id, txtBxTitreSujet.Text, txtBxDescSujet.Text) == 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxAddSujetText, Properties.Resources.MsgBoxAddSujetTitre, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurAddSujetText, Properties.Resources.MsgBoxErreurAddSujetTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if(Outil.ModifierSujet(subject.Id, subject.Titre ,subject.Desc,txtBxTitreSujet.Text, txtBxDescSujet.Text) == 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxEditSujetText, Properties.Resources.MsgBoxEditSujetText, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurEditSujetText, Properties.Resources.MsgBoxErreurEditSujetTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            this.Close();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Grisage du bouton de validation tant que les champs ne sont pas renseignés
        /// </summary>
        private void fonctionGrisageBtSujet()
        {
            btValider.Enabled = !String.IsNullOrWhiteSpace(txtBxTitreSujet.Text) && !String.IsNullOrWhiteSpace(txtBxDescSujet.Text);
        }

        /// <summary>
        /// Appel de la fonction grisage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxTitreSujet_TextChanged(object sender, EventArgs e)
        {
            fonctionGrisageBtSujet();
        }

        /// <summary>
        /// Appel de la fonction grisage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxDescSujet_TextChanged(object sender, EventArgs e)
        {
            fonctionGrisageBtSujet();
        }
    }
}
