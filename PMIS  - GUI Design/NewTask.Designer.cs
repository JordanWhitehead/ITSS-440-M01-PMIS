namespace PMIS____GUI_Design
{
    partial class NewTask
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            DALabel1 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            buttonNewTaskOK = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 27);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 27);
            textBox1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 164);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 19;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 96);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 18;
            label1.Text = "Task Name";
            // 
            // DALabel1
            // 
            DALabel1.AutoSize = true;
            DALabel1.BorderStyle = BorderStyle.FixedSingle;
            DALabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            DALabel1.Location = new Point(20, 9);
            DALabel1.Name = "DALabel1";
            DALabel1.Size = new Size(343, 71);
            DALabel1.TabIndex = 17;
            DALabel1.Text = "ITSS-440-M01\r\nProject Management Information System\r\nNew Task";
            DALabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 259);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(343, 27);
            textBox3.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 236);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 22;
            label3.Text = "Start Date";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(20, 324);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(343, 27);
            textBox4.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 301);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 24;
            label4.Text = "End Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 373);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 26;
            label5.Text = "Completion:";
            // 
            // buttonNewTaskOK
            // 
            buttonNewTaskOK.Location = new Point(164, 462);
            buttonNewTaskOK.Name = "buttonNewTaskOK";
            buttonNewTaskOK.Size = new Size(94, 29);
            buttonNewTaskOK.TabIndex = 29;
            buttonNewTaskOK.Text = "Save";
            buttonNewTaskOK.UseVisualStyleBackColor = true;
            buttonNewTaskOK.Click += buttonNewTaskOK_Click;
            // 
            // button2
            // 
            button2.Location = new Point(269, 462);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 30;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Location = new Point(20, 396);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(90, 27);
            numericUpDown1.TabIndex = 31;
            // 
            // NewTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 503);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(buttonNewTaskOK);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DALabel1);
            Name = "NewTask";
            Text = "New Task";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label DALabel1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Button buttonNewTaskOK;
        private Button button2;
        private NumericUpDown numericUpDown1;
    }
}