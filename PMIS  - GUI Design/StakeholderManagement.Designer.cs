namespace PMIS____GUI_Design
{
    partial class StakeholderManagement
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
            resourceMgmtSearchButton = new Button();
            textBox1 = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            stakeholderMgmtNewButton = new Button();
            stakeholderMgmtLabel1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // resourceMgmtSearchButton
            // 
            resourceMgmtSearchButton.Location = new Point(578, 96);
            resourceMgmtSearchButton.Name = "resourceMgmtSearchButton";
            resourceMgmtSearchButton.Size = new Size(193, 29);
            resourceMgmtSearchButton.TabIndex = 19;
            resourceMgmtSearchButton.Text = "Search";
            resourceMgmtSearchButton.UseVisualStyleBackColor = true;
            resourceMgmtSearchButton.Click += resourceMgmtSearchButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(559, 27);
            textBox1.TabIndex = 18;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 129);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(758, 343);
            listView1.Sorting = SortOrder.Ascending;
            listView1.TabIndex = 17;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Title";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Role";
            columnHeader4.Width = 235;
            // 
            // stakeholderMgmtNewButton
            // 
            stakeholderMgmtNewButton.Location = new Point(578, 12);
            stakeholderMgmtNewButton.Name = "stakeholderMgmtNewButton";
            stakeholderMgmtNewButton.Size = new Size(193, 69);
            stakeholderMgmtNewButton.TabIndex = 20;
            stakeholderMgmtNewButton.Text = "New Stakeholder";
            stakeholderMgmtNewButton.UseVisualStyleBackColor = true;
            stakeholderMgmtNewButton.Click += stakeholderMgmtNewButton_Click;
            // 
            // stakeholderMgmtLabel1
            // 
            stakeholderMgmtLabel1.AutoSize = true;
            stakeholderMgmtLabel1.BorderStyle = BorderStyle.FixedSingle;
            stakeholderMgmtLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            stakeholderMgmtLabel1.Location = new Point(220, 10);
            stakeholderMgmtLabel1.Name = "stakeholderMgmtLabel1";
            stakeholderMgmtLabel1.Size = new Size(343, 71);
            stakeholderMgmtLabel1.TabIndex = 16;
            stakeholderMgmtLabel1.Text = "ITSS-440-M01\r\nProject Management Information System\r\nStakeholder Management";
            stakeholderMgmtLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(194, 69);
            button1.TabIndex = 21;
            button1.Text = "Delete Stakeholder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StakeholderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 483);
            Controls.Add(button1);
            Controls.Add(resourceMgmtSearchButton);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(stakeholderMgmtNewButton);
            Controls.Add(stakeholderMgmtLabel1);
            Name = "StakeholderManagement";
            Text = "Stakeholder Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resourceMgmtSearchButton;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button stakeholderMgmtNewButton;
        private Label stakeholderMgmtLabel1;
        private ColumnHeader columnHeader4;
        private Button button1;
    }
}