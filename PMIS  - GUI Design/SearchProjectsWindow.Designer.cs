namespace PMIS____GUI_Design
{
    partial class SearchProjectsWindow
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
            SMLabel1 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            textBox1 = new TextBox();
            SMSearchButton = new Button();
            SuspendLayout();
            // 
            // SMLabel1
            // 
            SMLabel1.AutoSize = true;
            SMLabel1.BorderStyle = BorderStyle.FixedSingle;
            SMLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            SMLabel1.Location = new Point(220, 9);
            SMLabel1.Name = "SMLabel1";
            SMLabel1.Size = new Size(343, 71);
            SMLabel1.TabIndex = 7;
            SMLabel1.Text = "ITSS-440-M01\r\nProject Management Information System\r\nSearch for a Project";
            SMLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(11, 128);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(758, 343);
            listView1.TabIndex = 8;
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
            columnHeader2.Text = "Project Name";
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Project Manager";
            columnHeader3.Width = 250;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(559, 27);
            textBox1.TabIndex = 9;
            // 
            // SMSearchButton
            // 
            SMSearchButton.Location = new Point(577, 95);
            SMSearchButton.Name = "SMSearchButton";
            SMSearchButton.Size = new Size(193, 29);
            SMSearchButton.TabIndex = 10;
            SMSearchButton.Text = "Search";
            SMSearchButton.UseVisualStyleBackColor = true;
            SMSearchButton.Click += SMSearchButton_Click;
            // 
            // SearchProjectsWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 483);
            Controls.Add(SMSearchButton);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(SMLabel1);
            Name = "SearchProjectsWindow";
            Text = "Project Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SMLabel1;
        private ListView listView1;
        private TextBox textBox1;
        private Button SMSearchButton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}