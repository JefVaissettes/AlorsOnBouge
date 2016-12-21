namespace IHMFR
{
    partial class Identification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Identification));
            this.gpbxIdentification = new System.Windows.Forms.GroupBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.gpbxIdentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxIdentification
            // 
            this.gpbxIdentification.Controls.Add(this.txtPwd);
            this.gpbxIdentification.Controls.Add(this.txtLogin);
            this.gpbxIdentification.Controls.Add(this.label3);
            this.gpbxIdentification.Controls.Add(this.label2);
            this.gpbxIdentification.Location = new System.Drawing.Point(21, 48);
            this.gpbxIdentification.Name = "gpbxIdentification";
            this.gpbxIdentification.Size = new System.Drawing.Size(343, 119);
            this.gpbxIdentification.TabIndex = 11;
            this.gpbxIdentification.TabStop = false;
            // 
            // txtPwd
            // 
            this.txtPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPwd.Location = new System.Drawing.Point(129, 75);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(190, 20);
            this.txtPwd.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.Location = new System.Drawing.Point(129, 35);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(190, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom utilisateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Identification";
            // 
            // btAnnuler
            // 
            this.btAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(21, 186);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(109, 40);
            this.btAnnuler.TabIndex = 3;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btConnect
            // 
            this.btConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(255, 186);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(109, 40);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "Valider";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // Identification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 243);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.gpbxIdentification);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Identification";
            this.Text = "Alors on bouge !";
            this.Load += new System.EventHandler(this.Identification_Load);
            this.gpbxIdentification.ResumeLayout(false);
            this.gpbxIdentification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxIdentification;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btConnect;
    }
}