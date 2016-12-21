namespace IHMFR
{
    partial class frmCreerSujet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreerSujet));
            this.gBxTitreSujet = new System.Windows.Forms.GroupBox();
            this.txtBxTitreSujet = new System.Windows.Forms.TextBox();
            this.gBxDescription = new System.Windows.Forms.GroupBox();
            this.txtBxDescSujet = new System.Windows.Forms.TextBox();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.gBxTitreSujet.SuspendLayout();
            this.gBxDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBxTitreSujet
            // 
            this.gBxTitreSujet.Controls.Add(this.txtBxTitreSujet);
            this.gBxTitreSujet.Location = new System.Drawing.Point(28, 22);
            this.gBxTitreSujet.Name = "gBxTitreSujet";
            this.gBxTitreSujet.Size = new System.Drawing.Size(366, 76);
            this.gBxTitreSujet.TabIndex = 1;
            this.gBxTitreSujet.TabStop = false;
            this.gBxTitreSujet.Text = "Titre du sujet";
            // 
            // txtBxTitreSujet
            // 
            this.txtBxTitreSujet.Location = new System.Drawing.Point(17, 30);
            this.txtBxTitreSujet.Name = "txtBxTitreSujet";
            this.txtBxTitreSujet.Size = new System.Drawing.Size(337, 20);
            this.txtBxTitreSujet.TabIndex = 0;
            // 
            // gBxDescription
            // 
            this.gBxDescription.Controls.Add(this.txtBxDescSujet);
            this.gBxDescription.Location = new System.Drawing.Point(28, 115);
            this.gBxDescription.Name = "gBxDescription";
            this.gBxDescription.Size = new System.Drawing.Size(366, 170);
            this.gBxDescription.TabIndex = 2;
            this.gBxDescription.TabStop = false;
            this.gBxDescription.Text = "Description sujet";
            // 
            // txtBxDescSujet
            // 
            this.txtBxDescSujet.Location = new System.Drawing.Point(17, 31);
            this.txtBxDescSujet.Multiline = true;
            this.txtBxDescSujet.Name = "txtBxDescSujet";
            this.txtBxDescSujet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxDescSujet.Size = new System.Drawing.Size(337, 133);
            this.txtBxDescSujet.TabIndex = 0;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(45, 304);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(109, 40);
            this.btAnnuler.TabIndex = 11;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btValider
            // 
            this.btValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(273, 304);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(109, 40);
            this.btValider.TabIndex = 12;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // frmCreerSujet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 356);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.gBxDescription);
            this.Controls.Add(this.gBxTitreSujet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreerSujet";
            this.Text = "Alors on bouge !";
            this.Load += new System.EventHandler(this.frmCreerSujet_Load);
            this.gBxTitreSujet.ResumeLayout(false);
            this.gBxTitreSujet.PerformLayout();
            this.gBxDescription.ResumeLayout(false);
            this.gBxDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBxTitreSujet;
        private System.Windows.Forms.TextBox txtBxTitreSujet;
        private System.Windows.Forms.GroupBox gBxDescription;
        private System.Windows.Forms.TextBox txtBxDescSujet;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btValider;
    }
}