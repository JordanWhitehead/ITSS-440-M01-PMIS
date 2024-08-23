namespace PMIS____GUI_Design
{
    partial class NewStakeholder
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
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            DALabel1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(269, 362);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 43;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(164, 362);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 42;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(20, 325);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(343, 27);
            textBox4.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 302);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 39;
            label4.Text = "Description";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 260);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(343, 27);
            textBox3.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 237);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 37;
            label3.Text = "Role";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 27);
            textBox2.TabIndex = 36;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 27);
            textBox1.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 165);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 34;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 97);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 33;
            label1.Text = "Stakeholder Name";
            // 
            // DALabel1
            // 
            DALabel1.AutoSize = true;
            DALabel1.BorderStyle = BorderStyle.FixedSingle;
            DALabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            DALabel1.Location = new Point(20, 10);
            DALabel1.Name = "DALabel1";
            DALabel1.Size = new Size(343, 71);
            DALabel1.TabIndex = 32;
            DALabel1.Text = "ITSS-440-M01\r\nProject Management Information System\r\nNew Stakeholder";
            DALabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NewStakeholder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 403);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DALabel1);
            Name = "NewStakeholder";
            Text = "New Stakeholder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label DALabel1;
    }
}