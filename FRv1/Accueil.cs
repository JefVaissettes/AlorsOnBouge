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
    public partial class Accueil : Form
    {
        static internal bool IsRmodo;
        static internal Utilisateur CurrentUsers;
        static internal bool IsConnected;

        public Accueil()
        {
            InitializeComponent();
        }

        private void btConsul_Click(object sender, EventArgs e)
        {
            using (frmPrincipale frmMain = new frmPrincipale())
            {
                frmMain.ShowDialog();
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
