namespace PMIS____GUI_Design
{
    partial class RequirementList
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
            searchButton = new Button();
            textBox1 = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            NewButton = new Button();
            taskListLabel1 = new Label();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Location = new Point(578, 96);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(193, 29);
            searchButton.TabIndex = 24;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(559, 27);
            textBox1.TabIndex = 23;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 129);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(758, 343);
            listView1.TabIndex = 22;
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
            columnHeader2.Text = "Requirement";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Description";
            columnHeader3.Width = 493;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(578, 52);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(193, 29);
            NewButton.TabIndex = 25;
            NewButton.Text = "New Requirement";
            NewButton.UseVisualStyleBackColor = true;
            NewButton.Click += NewButton_Click;
            // 
            // taskListLabel1
            // 
            taskListLabel1.AutoSize = true;
            taskListLabel1.BorderStyle = BorderStyle.FixedSingle;
            taskListLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            taskListLabel1.Location = new Point(220, 10);
            taskListLabel1.Name = "taskListLabel1";
            taskListLabel1.Size = new Size(343, 71);
            taskListLabel1.TabIndex = 21;
            taskListLabel1.Text = "ITSS-440-M01\r\nProject Management Information System\r\nRequirements List";
            taskListLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RequirementList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 483);
            Controls.Add(searchButton);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(NewButton);
            Controls.Add(taskListLabel1);
            Name = "RequirementList";
            Text = "Requirement List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button NewButton;
        private Label taskListLabel1;
    }
}