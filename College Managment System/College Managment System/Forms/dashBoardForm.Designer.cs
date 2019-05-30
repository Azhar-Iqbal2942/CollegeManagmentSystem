namespace College_Managment_System.Forms
{
    partial class dashBoardForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashBoardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.feeForm1 = new College_Managment_System.UserControls.FeeForm();
            this.aboutUs1 = new College_Managment_System.UserControls.AboutUs();
            this.removeStudent1 = new College_Managment_System.UserControls.RemoveStudent();
            this.searchStudent1 = new College_Managment_System.UserControls.SearchStudent();
            this.admissionFormUC2 = new College_Managment_System.UserControls.AdmissionFormUC();
            this.dashBoardUC2 = new College_Managment_System.UserControls.DashBoardUC();
            this.admissionFormUC1 = new College_Managment_System.UserControls.AdmissionFormUC();
            this.dashBoardUC1 = new College_Managment_System.UserControls.DashBoardUC();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dragControl1 = new College_Managment_System.DragControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.panelLabel);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelLabel
            // 
            this.panelLabel.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panelLabel, "panelLabel");
            this.panelLabel.Name = "panelLabel";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button6, "button6");
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonDashBoard_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button5, "button5");
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_AboutUs);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_StRemove);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_StDetail);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Fee);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAdmission_click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(66)))), ((int)(((byte)(86)))));
            this.lblTitle.Name = "lblTitle";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.feeForm1);
            this.panelContainer.Controls.Add(this.aboutUs1);
            this.panelContainer.Controls.Add(this.removeStudent1);
            this.panelContainer.Controls.Add(this.searchStudent1);
            this.panelContainer.Controls.Add(this.admissionFormUC2);
            this.panelContainer.Controls.Add(this.dashBoardUC2);
            this.panelContainer.Controls.Add(this.admissionFormUC1);
            this.panelContainer.Controls.Add(this.dashBoardUC1);
            resources.ApplyResources(this.panelContainer, "panelContainer");
            this.panelContainer.Name = "panelContainer";
            // 
            // feeForm1
            // 
            this.feeForm1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.feeForm1, "feeForm1");
            this.feeForm1.Name = "feeForm1";
            // 
            // aboutUs1
            // 
            this.aboutUs1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.aboutUs1, "aboutUs1");
            this.aboutUs1.Name = "aboutUs1";
            // 
            // removeStudent1
            // 
            this.removeStudent1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.removeStudent1, "removeStudent1");
            this.removeStudent1.Name = "removeStudent1";
            // 
            // searchStudent1
            // 
            this.searchStudent1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.searchStudent1, "searchStudent1");
            this.searchStudent1.Name = "searchStudent1";
            // 
            // admissionFormUC2
            // 
            this.admissionFormUC2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.admissionFormUC2, "admissionFormUC2");
            this.admissionFormUC2.Name = "admissionFormUC2";
            this.admissionFormUC2.Load += new System.EventHandler(this.admissionFormUC2_Load);
            // 
            // dashBoardUC2
            // 
            resources.ApplyResources(this.dashBoardUC2, "dashBoardUC2");
            this.dashBoardUC2.Name = "dashBoardUC2";
            // 
            // admissionFormUC1
            // 
            this.admissionFormUC1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.admissionFormUC1, "admissionFormUC1");
            this.admissionFormUC1.Name = "admissionFormUC1";
            // 
            // dashBoardUC1
            // 
            resources.ApplyResources(this.dashBoardUC1, "dashBoardUC1");
            this.dashBoardUC1.Name = "dashBoardUC1";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // dashBoardForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashBoardForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContainer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControls.DashBoardUC dashBoardUC1;
        private UserControls.AdmissionFormUC admissionFormUC1;
        private UserControls.DashBoardUC dashBoardUC2;
        private UserControls.AdmissionFormUC admissionFormUC2;
        private System.Windows.Forms.Button button6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private DragControl dragControl1;
        private UserControls.SearchStudent searchStudent1;
        private UserControls.RemoveStudent removeStudent1;
        private UserControls.AboutUs aboutUs1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private UserControls.FeeForm feeForm1;
        private System.Windows.Forms.Panel panelLabel;
    }
}