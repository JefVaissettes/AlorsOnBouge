using ClassesMetiers;
using MetiersPortable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHMFR
{
    public partial class CreerPost : Form
    {
        internal Subject subject;

        public CreerPost()
        {
            InitializeComponent();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if(Outil.AddReponse(Accueil.CurrentUsers.Id, subject.Id, txtPostContent.Text) == 1)
            {
                MessageBox.Show(Properties.Resources.MsgBoxAddReponseText, Properties.Resources.MsgBoxAddReponseTitre, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(Properties.Resources.MsgBoxErreurAddReponseText, Properties.Resources.MsgBoxErreurAddReponseTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(Properties.Resources.MsgBoxCancelText, Properties.Resources.MsgBoxCancelTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
