namespace PMIS____GUI_Design
{
    partial class ViewAssignedResources
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            MMLabel4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 85);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(526, 355);
            listView1.TabIndex = 25;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            MMLabel4.Location = new Point(104, 11);
            MMLabel4.Name = "MMLabel4";
            MMLabel4.Size = new Size(343, 71);
            MMLabel4.TabIndex = 24;
            MMLabel4.Text = "ITSS-440-M01\r\nProject Management Information System\r\nView Assigned Resources";
            MMLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(4, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 67);
            button1.TabIndex = 26;
            button1.Text = "Delete Assignment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ViewAssignedResources
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 450);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(MMLabel4);
            Name = "ViewAssignedResources";
            Text = "Assigned Resources";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label MMLabel4;
        private Button button1;
    }
}