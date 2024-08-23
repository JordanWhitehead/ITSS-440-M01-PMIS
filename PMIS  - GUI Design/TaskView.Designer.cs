namespace PMIS____GUI_Design
{
    partial class TaskView
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
            labelTitle = new Label();
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            labelProjectID = new Label();
            labelProjectCompletion = new Label();
            textBoxTaskID = new TextBox();
            labelProjectName = new Label();
            textBoxTaskName = new TextBox();
            textBoxTaskEnd = new TextBox();
            labelProjectDescr = new Label();
            labelProjectEnd = new Label();
            textBoxTaskDescr = new TextBox();
            textBoxTaskStart = new TextBox();
            labelProjectStart = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.Location = new Point(14, 13);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(70, 28);
            labelTitle.TabIndex = 21;
            labelTitle.Text = "label1";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelProjectID);
            panel1.Controls.Add(labelProjectCompletion);
            panel1.Controls.Add(textBoxTaskID);
            panel1.Controls.Add(labelProjectName);
            panel1.Controls.Add(textBoxTaskName);
            panel1.Controls.Add(textBoxTaskEnd);
            panel1.Controls.Add(labelProjectDescr);
            panel1.Controls.Add(labelProjectEnd);
            panel1.Controls.Add(textBoxTaskDescr);
            panel1.Controls.Add(textBoxTaskStart);
            panel1.Controls.Add(labelProjectStart);
            panel1.Location = new Point(14, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 300);
            panel1.TabIndex = 20;
            // 
            // button5
            // 
            button5.Location = new Point(257, 223);
            button5.Name = "button5";
            button5.Size = new Size(117, 64);
            button5.TabIndex = 36;
            button5.Text = "View Assigned Resources";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(134, 223);
            button4.Name = "button4";
            button4.Size = new Size(117, 64);
            button4.TabIndex = 35;
            button4.Text = "Assign Resources";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(380, 258);
            button3.Name = "button3";
            button3.Size = new Size(117, 29);
            button3.TabIndex = 34;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(11, 258);
            button2.Name = "button2";
            button2.Size = new Size(117, 29);
            button2.TabIndex = 33;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Location = new Point(142, 181);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(90, 27);
            numericUpDown1.TabIndex = 32;
            // 
            // button1
            // 
            button1.Location = new Point(11, 223);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 18;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelProjectID
            // 
            labelProjectID.AutoSize = true;
            labelProjectID.Location = new Point(11, 16);
            labelProjectID.Name = "labelProjectID";
            labelProjectID.Size = new Size(55, 20);
            labelProjectID.TabIndex = 0;
            labelProjectID.Text = "Task ID";
            // 
            // labelProjectCompletion
            // 
            labelProjectCompletion.AutoSize = true;
            labelProjectCompletion.Location = new Point(11, 181);
            labelProjectCompletion.Name = "labelProjectCompletion";
            labelProjectCompletion.Size = new Size(87, 20);
            labelProjectCompletion.TabIndex = 16;
            labelProjectCompletion.Text = "Completion";
            // 
            // textBoxTaskID
            // 
            textBoxTaskID.Location = new Point(142, 13);
            textBoxTaskID.Name = "textBoxTaskID";
            textBoxTaskID.ReadOnly = true;
            textBoxTaskID.Size = new Size(388, 27);
            textBoxTaskID.TabIndex = 1;
            // 
            // labelProjectName
            // 
            labelProjectName.AutoSize = true;
            labelProjectName.Location = new Point(11, 49);
            labelProjectName.Name = "labelProjectName";
            labelProjectName.Size = new Size(80, 20);
            labelProjectName.TabIndex = 2;
            labelProjectName.Text = "Task Name";
            // 
            // textBoxTaskName
            // 
            textBoxTaskName.Location = new Point(142, 46);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.ReadOnly = true;
            textBoxTaskName.Size = new Size(388, 27);
            textBoxTaskName.TabIndex = 3;
            // 
            // textBoxTaskEnd
            // 
            textBoxTaskEnd.Location = new Point(142, 145);
            textBoxTaskEnd.Name = "textBoxTaskEnd";
            textBoxTaskEnd.ReadOnly = true;
            textBoxTaskEnd.Size = new Size(388, 27);
            textBoxTaskEnd.TabIndex = 13;
            // 
            // labelProjectDescr
            // 
            labelProjectDescr.AutoSize = true;
            labelProjectDescr.Location = new Point(11, 82);
            labelProjectDescr.Name = "labelProjectDescr";
            labelProjectDescr.Size = new Size(85, 20);
            labelProjectDescr.TabIndex = 4;
            labelProjectDescr.Text = "Description";
            // 
            // labelProjectEnd
            // 
            labelProjectEnd.AutoSize = true;
            labelProjectEnd.Location = new Point(11, 148);
            labelProjectEnd.Name = "labelProjectEnd";
            labelProjectEnd.Size = new Size(70, 20);
            labelProjectEnd.TabIndex = 12;
            labelProjectEnd.Text = "End Date";
            // 
            // textBoxTaskDescr
            // 
            textBoxTaskDescr.Location = new Point(142, 79);
            textBoxTaskDescr.Name = "textBoxTaskDescr";
            textBoxTaskDescr.ReadOnly = true;
            textBoxTaskDescr.Size = new Size(388, 27);
            textBoxTaskDescr.TabIndex = 5;
            // 
            // textBoxTaskStart
            // 
            textBoxTaskStart.Location = new Point(142, 112);
            textBoxTaskStart.Name = "textBoxTaskStart";
            textBoxTaskStart.ReadOnly = true;
            textBoxTaskStart.Size = new Size(388, 27);
            textBoxTaskStart.TabIndex = 11;
            // 
            // labelProjectStart
            // 
            labelProjectStart.AutoSize = true;
            labelProjectStart.Location = new Point(11, 115);
            labelProjectStart.Name = "labelProjectStart";
            labelProjectStart.Size = new Size(76, 20);
            labelProjectStart.TabIndex = 10;
            labelProjectStart.Text = "Start Date";
            // 
            // TaskView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 370);
            Controls.Add(labelTitle);
            Controls.Add(panel1);
            Name = "TaskView";
            Text = "Task View";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Panel panel1;
        private Button button1;
        private Label labelProjectID;
        private Label labelProjectCompletion;
        private TextBox textBoxTaskID;
        private Label labelProjectName;
        private TextBox textBoxTaskName;
        private TextBox textBoxTaskEnd;
        private Label labelProjectDescr;
        private Label labelProjectEnd;
        private TextBox textBoxTaskDescr;
        private TextBox textBoxTaskStart;
        private Label labelProjectStart;
        private NumericUpDown numericUpDown1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
    }
}