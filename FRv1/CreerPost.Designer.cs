namespace IHMFR
{
    partial class CreerPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreerPost));
            this.btValider = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.txtPostContent = new System.Windows.Forms.TextBox();
            this.gpBxCreatePost = new System.Windows.Forms.GroupBox();
            this.gpBxCreatePost.SuspendLayout();
            this.SuspendLayout();
            // 
            // btValider
            // 
            this.btValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(196, 272);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(109, 40);
            this.btValider.TabIndex = 21;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(32, 272);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(109, 40);
            this.btAnnuler.TabIndex = 20;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // txtPostContent
            // 
            this.txtPostContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPostContent.Location = new System.Drawing.Point(14, 19);
            this.txtPostContent.Multiline = true;
            this.txtPostContent.Name = "txtPostContent";
            this.txtPostContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPostContent.Size = new System.Drawing.Size(283, 217);
            this.txtPostContent.TabIndex = 18;
            // 
            // gpBxCreatePost
            // 
            this.gpBxCreatePost.Controls.Add(this.txtPostContent);
            this.gpBxCreatePost.Location = new System.Drawing.Point(12, 12);
            this.gpBxCreatePost.Name = "gpBxCreatePost";
            this.gpBxCreatePost.Size = new System.Drawing.Size(303, 254);
            this.gpBxCreatePost.TabIndex = 22;
            this.gpBxCreatePost.TabStop = false;
            this.gpBxCreatePost.Text = "Création d\'un post";
            // 
            // CreerPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 323);
            this.Controls.Add(this.gpBxCreatePost);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.btAnnuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreerPost";
            this.Text = "Alors on bouge !";
            this.Load += new System.EventHandler(this.CreerPost_Load);
            this.gpBxCreatePost.ResumeLayout(false);
            this.gpBxCreatePost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.TextBox txtPostContent;
        private System.Windows.Forms.GroupBox gpBxCreatePost;
    }
}