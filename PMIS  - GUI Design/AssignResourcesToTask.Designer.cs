namespace PMIS____GUI_Design
{
    partial class AssignResourcesToTask
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
            button2 = new Button();
            textBox1 = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            MMLabel4 = new Label();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(420, 92);
            button2.Name = "button2";
            button2.Size = new Size(193, 29);
            button2.TabIndex = 22;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 27);
            textBox1.TabIndex = 21;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 126);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(601, 314);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Resource ID";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Resource Name";
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Description";
            columnHeader3.Width = 250;
            // 
            // MMLabel4
            // 
            MMLabel4.AutoSize = true;
            MMLabel4.BorderStyle = BorderStyle.FixedSingle;
            MMLabel4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            MMLabel4.Location = new Point(140, 11);
            MMLabel4.Name = "MMLabel4";
            MMLabel4.Size = new Size(343, 71);
            MMLabel4.TabIndex = 19;
            MMLabel4.Text = "ITSS-440-M01\r\nProject Management Information System\r\nAssign Resources";
            MMLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(489, 52);
            button1.Name = "button1";
            button1.Size = new Size(124, 30);
            button1.TabIndex = 23;
            button1.Text = "Assign Resource";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(489, 11);
            button3.Name = "button3";
            button3.Size = new Size(124, 29);
            button3.TabIndex = 24;
            button3.Text = "New Resource";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AssignResourcesToTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(MMLabel4);
            Controls.Add(button1);
            Name = "AssignResourcesToTask";
            Text = "Assign Resources to Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label MMLabel4;
        private Button button1;
        private Button button3;
    }
}