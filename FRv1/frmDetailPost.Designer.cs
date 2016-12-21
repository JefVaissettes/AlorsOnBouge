namespace IHMFR
{
    partial class frmDetailPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailPost));
            this.tlpPost = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblDateCreation = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOK = new System.Windows.Forms.Button();
            this.tlpPost.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPost
            // 
            this.tlpPost.ColumnCount = 3;
            this.tlpPost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.626506F));
            this.tlpPost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.3735F));
            this.tlpPost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpPost.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tlpPost.Controls.Add(this.txtPost, 1, 1);
            this.tlpPost.Controls.Add(this.panel1, 1, 2);
            this.tlpPost.Location = new System.Drawing.Point(1, 0);
            this.tlpPost.Name = "tlpPost";
            this.tlpPost.RowCount = 3;
            this.tlpPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.99237F));
            this.tlpPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.00764F));
            this.tlpPost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpPost.Size = new System.Drawing.Size(353, 283);
            this.tlpPost.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblAuteur, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDateCreation, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 45);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(3, 19);
            this.lblAuteur.Margin = new System.Windows.Forms.Padding(3, 19, 3, 0);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(79, 13);
            this.lblAuteur.TabIndex = 10;
            this.lblAuteur.Text = "Post créé par : ";
            // 
            // lblDateCreation
            // 
            this.lblDateCreation.AutoSize = true;
            this.lblDateCreation.Location = new System.Drawing.Point(154, 19);
            this.lblDateCreation.Margin = new System.Windows.Forms.Padding(3, 19, 3, 0);
            this.lblDateCreation.Name = "lblDateCreation";
            this.lblDateCreation.Size = new System.Drawing.Size(28, 13);
            this.lblDateCreation.TabIndex = 11;
            this.lblDateCreation.Text = "Le : ";
            // 
            // txtPost
            // 
            this.txtPost.BackColor = System.Drawing.SystemColors.Window;
            this.txtPost.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPost.Location = new System.Drawing.Point(24, 54);
            this.txtPost.Multiline = true;
            this.txtPost.Name = "txtPost";
            this.txtPost.ReadOnly = true;
            this.txtPost.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPost.Size = new System.Drawing.Size(303, 187);
            this.txtPost.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Location = new System.Drawing.Point(24, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 33);
            this.panel1.TabIndex = 21;
            // 
            // btOK
            // 
            this.btOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOK.Location = new System.Drawing.Point(226, 3);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 27);
            this.btOK.TabIndex = 0;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // frmDetailPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 282);
            this.Controls.Add(this.tlpPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetailPost";
            this.Text = "Alors on bouge !";
            this.tlpPost.ResumeLayout(false);
            this.tlpPost.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPost;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.Label lblAuteur;
        internal System.Windows.Forms.TextBox txtPost;
        internal System.Windows.Forms.Label lblDateCreation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btOK;
    }
}