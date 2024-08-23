namespace PMIS____GUI_Design
{
    partial class ResourceMgmtAdd
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 27);
            textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 27);
            textBox1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 164);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 24;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 96);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 23;
            label1.Text = "Resource Name";
            // 
            // DALabel1
            // 
            DALabel1.AutoSize = true;
            DALabel1.BorderStyle = BorderStyle.FixedSingle;
            DALabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            DALabel1.Location = new Point(20, 9);
            DALabel1.Name = "DALabel1";
            DALabel1.Size = new Size(343, 71);
            DALabel1.TabIndex = 22;
            DALabel1.Text = "ITSS-440-M01\r\nProject Management Information System\r\nNew Resource";
            DALabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(169, 224);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 27;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(269, 224);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 28;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ResourceMgmtAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 262);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DALabel1);
            Name = "ResourceMgmtAdd";
            Text = "New Resource";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label DALabel1;
        private Button button1;
        private Button button2;
    }
}