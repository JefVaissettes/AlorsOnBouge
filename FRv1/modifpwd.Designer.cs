namespace IHMFR
{
    partial class modifpwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifpwd));
            this.label1 = new System.Windows.Forms.Label();
            this.gpbxModifIdentity = new System.Windows.Forms.GroupBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.gpbxModifIdentity.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Modification du Password";
            // 
            // gpbxModifIdentity
            // 
            this.gpbxModifIdentity.Controls.Add(this.txtNewPwd);
            this.gpbxModifIdentity.Controls.Add(this.txtConfirmNewPwd);
            this.gpbxModifIdentity.Controls.Add(this.label5);
            this.gpbxModifIdentity.Controls.Add(this.label4);
            this.gpbxModifIdentity.Location = new System.Drawing.Point(22, 60);
            this.gpbxModifIdentity.Name = "gpbxModifIdentity";
            this.gpbxModifIdentity.Size = new System.Drawing.Size(343, 116);
            this.gpbxModifIdentity.TabIndex = 17;
            this.gpbxModifIdentity.TabStop = false;
            this.gpbxModifIdentity.Text = "Modification Password";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(130, 34);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(190, 20);
            this.txtNewPwd.TabIndex = 2;
            this.txtNewPwd.TextChanged += new System.EventHandler(this.txtNewPwd_TextChanged);
            // 
            // txtConfirmNewPwd
            // 
            this.txtConfirmNewPwd.Location = new System.Drawing.Point(130, 76);
            this.txtConfirmNewPwd.Name = "txtConfirmNewPwd";
            this.txtConfirmNewPwd.Size = new System.Drawing.Size(190, 20);
            this.txtConfirmNewPwd.TabIndex = 3;
            this.txtConfirmNewPwd.TextChanged += new System.EventHandler(this.txtConfirmNewPwd_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Confirm nv mdp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nouveau mdp";
            // 
            // btValider
            // 
            this.btValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(256, 202);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(109, 40);
            this.btValider.TabIndex = 4;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(22, 202);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(109, 40);
            this.btAnnuler.TabIndex = 5;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // modifpwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 265);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.gpbxModifIdentity);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modifpwd";
            this.Text = "Alors on bouge !";
            this.gpbxModifIdentity.ResumeLayout(false);
            this.gpbxModifIdentity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbxModifIdentity;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtConfirmNewPwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
    }
}