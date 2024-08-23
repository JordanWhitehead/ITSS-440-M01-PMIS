namespace PMIS____GUI_Design
{
    partial class TaskListView
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
            taskListSearchButton = new Button();
            textBox1 = new TextBox();
            listView1 = new ListView();
            columnHeader0 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            taskListLabel1 = new Label();
            TaskListNewTaskButton = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // taskListSearchButton
            // 
            taskListSearchButton.Location = new Point(578, 96);
            taskListSearchButton.Name = "taskListSearchButton";
            taskListSearchButton.Size = new Size(193, 29);
            taskListSearchButton.TabIndex = 14;
            taskListSearchButton.Text = "Search";
            taskListSearchButton.UseVisualStyleBackColor = true;
            taskListSearchButton.Click += SMSearchButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(559, 27);
            textBox1.TabIndex = 13;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 129);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(758, 343);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader0
            // 
            columnHeader0.Text = "Sequence";
            columnHeader0.Width = 76;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Task ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Task Name";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Description";
            columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Resource";
            columnHeader4.Width = 244;
            // 
            // taskListLabel1
            // 
            taskListLabel1.AutoSize = true;
            taskListLabel1.BorderStyle = BorderStyle.FixedSingle;
            taskListLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            taskListLabel1.Location = new Point(220, 10);
            taskListLabel1.Name = "taskListLabel1";
            taskListLabel1.Size = new Size(343, 71);
            taskListLabel1.TabIndex = 11;
            taskListLabel1.Text = "ITSS-440-M01\r\nProject Management Information System\r\nSearch for a Task\r\n";
            taskListLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TaskListNewTaskButton
            // 
            TaskListNewTaskButton.Location = new Point(578, 52);
            TaskListNewTaskButton.Name = "TaskListNewTaskButton";
            TaskListNewTaskButton.Size = new Size(193, 29);
            TaskListNewTaskButton.TabIndex = 15;
            TaskListNewTaskButton.Text = "New Task";
            TaskListNewTaskButton.UseVisualStyleBackColor = true;
            TaskListNewTaskButton.Click += TaskListNewTaskButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(578, 10);
            button1.Name = "button1";
            button1.Size = new Size(192, 29);
            button1.TabIndex = 16;
            button1.Text = "Manage Task Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 10);
            button2.Name = "button2";
            button2.Size = new Size(202, 71);
            button2.TabIndex = 17;
            button2.Text = "Generate Task List";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TaskListView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 483);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TaskListNewTaskButton);
            Controls.Add(taskListSearchButton);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(taskListLabel1);
            Name = "TaskListView";
            Text = "Task List View";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button taskListSearchButton;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label taskListLabel1;
        private Button TaskListNewTaskButton;
        private ColumnHeader columnHeader4;
        private Button button1;
        private ColumnHeader columnHeader0;
        private Button button2;
    }
}