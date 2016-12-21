namespace IHMFR
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.btConsul = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btConsul
            // 
            this.btConsul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConsul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsul.Location = new System.Drawing.Point(319, 253);
            this.btConsul.Name = "btConsul";
            this.btConsul.Size = new System.Drawing.Size(132, 34);
            this.btConsul.TabIndex = 1;
            this.btConsul.Text = "Consulter le forum";
            this.btConsul.UseVisualStyleBackColor = true;
            this.btConsul.Click += new System.EventHandler(this.btConsul_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(37, 252);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(132, 34);
            this.btQuitter.TabIndex = 4;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IHMFR.Properties.Resources.logo310x150;
            this.pictureBox1.Location = new System.Drawing.Point(100, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 61);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alors on bouge !";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(486, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btConsul);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(502, 346);
            this.MinimumSize = new System.Drawing.Size(502, 346);
            this.Name = "Accueil";
            this.Text = "Alors on bouge !";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btConsul;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

