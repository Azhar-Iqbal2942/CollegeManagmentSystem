namespace College_Managment_System.UserControls
{
    partial class DashBoardUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardUC));
            this.systemPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.systemPic)).BeginInit();
            this.SuspendLayout();
            // 
            // systemPic
            // 
            this.systemPic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.systemPic.Image = ((System.Drawing.Image)(resources.GetObject("systemPic.Image")));
            this.systemPic.Location = new System.Drawing.Point(0, 0);
            this.systemPic.Name = "systemPic";
            this.systemPic.Size = new System.Drawing.Size(805, 519);
            this.systemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.systemPic.TabIndex = 0;
            this.systemPic.TabStop = false;
            this.systemPic.Click += new System.EventHandler(this.systemPic_Click);
            // 
            // DashBoardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.systemPic);
            this.Name = "DashBoardUC";
            this.Size = new System.Drawing.Size(805, 519);
            ((System.ComponentModel.ISupportInitialize)(this.systemPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox systemPic;
    }
}
