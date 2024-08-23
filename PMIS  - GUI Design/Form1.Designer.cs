namespace PMIS____GUI_Design
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SearchButton = new Button();
            ShowAllButton = new Button();
            CreateProjButton = new Button();
            MMLabel2 = new Label();
            MMLabel3 = new Label();
            MMLabel4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            buttonStakeholderMgmt = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(11, 103);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(192, 29);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "Search Projects";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // ShowAllButton
            // 
            ShowAllButton.Location = new Point(11, 147);
            ShowAllButton.Name = "ShowAllButton";
            ShowAllButton.Size = new Size(192, 29);
            ShowAllButton.TabIndex = 1;
            ShowAllButton.Text = "Display All Projects";
            ShowAllButton.UseVisualStyleBackColor = true;
            ShowAllButton.Click += ShowAllButton_Click;
            // 
            // CreateProjButton
            // 
            CreateProjButton.Location = new Point(11, 191);
            CreateProjButton.Name = "CreateProjButton";
            CreateProjButton.Size = new Size(192, 29);
            CreateProjButton.TabIndex = 2;
            CreateProjButton.Text = "New Project";
            CreateProjButton.UseVisualStyleBackColor = true;
            CreateProjButton.Click += CreateProjButton_Click;
            // 
            // MMLabel2
            // 
            MMLabel2.AutoSize = true;
            MMLabel2.Location = new Point(208, 153);
            MMLabel2.Name = "MMLabel2";
            MMLabel2.Size = new Size(330, 20);
            MMLabel2.TabIndex = 4;
            MMLabel2.Text = "Display a list of all projects in the local database";
            // 
            // MMLabel3
            // 
            MMLabel3.AutoSize = true;
            MMLabel3.Location = new Point(209, 197);
            MMLabel3.Name = "MMLabel3";
            MMLabel3.Size = new Size(338, 20);
            MMLabel3.TabIndex = 5;
            MMLabel3.Text = "Create a new project to add to the local database";
            // 
            // MMLabel4
            // 
            MMLabel4.AutoSize = true;
            MMLabel4.BorderStyle = BorderStyle.FixedSingle;
            MMLabel4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            MMLabel4.Location = new Point(112, 9);
            MMLabel4.Name = "MMLabel4";
            MMLabel4.Size = new Size(343, 71);
            MMLabel4.TabIndex = 6;
            MMLabel4.Text = "ITSS-440-M01\r\nProject Management Information System\r\nMain Menu";
            MMLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 104);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 27);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(11, 235);
            button1.Name = "button1";
            button1.Size = new Size(192, 29);
            button1.TabIndex = 8;
            button1.Text = "Manage Resources";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 241);
            label1.Name = "label1";
            label1.Size = new Size(284, 20);
            label1.TabIndex = 9;
            label1.Text = "Manage resources to assign them to tasks";
            // 
            // buttonStakeholderMgmt
            // 
            buttonStakeholderMgmt.Location = new Point(11, 279);
            buttonStakeholderMgmt.Name = "buttonStakeholderMgmt";
            buttonStakeholderMgmt.Size = new Size(192, 29);
            buttonStakeholderMgmt.TabIndex = 10;
            buttonStakeholderMgmt.Text = "Stakeholder Management";
            buttonStakeholderMgmt.UseVisualStyleBackColor = true;
            buttonStakeholderMgmt.Click += buttonStakeholderMgmt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 285);
            label2.Name = "label2";
            label2.Size = new Size(326, 20);
            label2.TabIndex = 11;
            label2.Text = "Manage stakeholders to assign them to projects\r\n";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 322);
            Controls.Add(label2);
            Controls.Add(buttonStakeholderMgmt);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(MMLabel4);
            Controls.Add(MMLabel3);
            Controls.Add(MMLabel2);
            Controls.Add(CreateProjButton);
            Controls.Add(ShowAllButton);
            Controls.Add(SearchButton);
            Name = "MainMenu";
            Text = "PMIS - Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButton;
        private Button ShowAllButton;
        private Button CreateProjButton;
        private Label MMLabel2;
        private Label MMLabel3;
        private Label MMLabel4;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Button buttonStakeholderMgmt;
        private Label label2;
    }
}
