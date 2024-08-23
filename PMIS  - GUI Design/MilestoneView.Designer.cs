namespace PMIS____GUI_Design
{
    partial class MilestoneView
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
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            DALabel1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(144, 232);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 42;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(20, 232);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 41;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 187);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(343, 27);
            textBox2.TabIndex = 40;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 119);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(343, 27);
            textBox1.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 164);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 38;
            label2.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 96);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 37;
            label1.Text = "Milestone Name";
            // 
            // DALabel1
            // 
            DALabel1.AutoSize = true;
            DALabel1.BorderStyle = BorderStyle.FixedSingle;
            DALabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            DALabel1.Location = new Point(20, 9);
            DALabel1.Name = "DALabel1";
            DALabel1.Size = new Size(343, 71);
            DALabel1.TabIndex = 36;
            DALabel1.Text = "ITSS-440-M01\r\nProject Management Information System\r\nMilestone View";
            DALabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(269, 232);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 43;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MilestoneView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 281);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DALabel1);
            Name = "MilestoneView";
            Text = "Milestone View";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label DALabel1;
        private Button button3;
    }
}