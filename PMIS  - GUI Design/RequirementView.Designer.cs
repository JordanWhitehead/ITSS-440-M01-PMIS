namespace PMIS____GUI_Design
{
    partial class RequirementView
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
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            DALabel1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 188);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(550, 219);
            textBox2.TabIndex = 47;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(218, 413);
            button2.Name = "button2";
            button2.Size = new Size(150, 29);
            button2.TabIndex = 49;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(18, 413);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 48;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 120);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(550, 27);
            textBox1.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 165);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 45;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 97);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 44;
            label1.Text = "Requirement Name";
            // 
            // DALabel1
            // 
            DALabel1.AutoSize = true;
            DALabel1.BorderStyle = BorderStyle.FixedSingle;
            DALabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            DALabel1.Location = new Point(120, 10);
            DALabel1.Name = "DALabel1";
            DALabel1.Size = new Size(343, 71);
            DALabel1.TabIndex = 43;
            DALabel1.Text = "ITSS-440-M01\r\nProject Management Information System\r\nRequirement View";
            DALabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(418, 413);
            button3.Name = "button3";
            button3.Size = new Size(150, 29);
            button3.TabIndex = 50;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // RequirementView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 453);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DALabel1);
            Name = "RequirementView";
            Text = "Requirement View";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label DALabel1;
        private Button button3;
    }
}