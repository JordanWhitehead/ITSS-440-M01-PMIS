namespace PMIS____GUI_Design
{
    partial class NewProjectWindow
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
            DALabel1 = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            NPCancel = new Button();
            NPSave = new Button();
            SuspendLayout();
            // 
            // DALabel1
            // 
            DALabel1.AutoSize = true;
            DALabel1.BorderStyle = BorderStyle.FixedSingle;
            DALabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            DALabel1.Location = new Point(21, 9);
            DALabel1.Name = "DALabel1";
            DALabel1.Size = new Size(343, 71);
            DALabel1.TabIndex = 12;
            DALabel1.Text = "ITSS-440-M01\r\nProject Management Information System\r\nNew Project";
            DALabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 96);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 13;
            label1.Text = "Project Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 164);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 14;
            label2.Text = "Project Manager";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 27);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 27);
            textBox2.TabIndex = 16;
            // 
            // NPCancel
            // 
            NPCancel.Location = new Point(270, 228);
            NPCancel.Name = "NPCancel";
            NPCancel.Size = new Size(94, 29);
            NPCancel.TabIndex = 18;
            NPCancel.Text = "Cancel";
            NPCancel.UseVisualStyleBackColor = true;
            NPCancel.Click += NPCancel_Click;
            // 
            // NPSave
            // 
            NPSave.Location = new Point(170, 228);
            NPSave.Name = "NPSave";
            NPSave.Size = new Size(94, 29);
            NPSave.TabIndex = 17;
            NPSave.Text = "Save";
            NPSave.UseVisualStyleBackColor = true;
            NPSave.Click += NPSave_Click;
            // 
            // NewProjectWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 269);
            Controls.Add(NPSave);
            Controls.Add(NPCancel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DALabel1);
            Name = "NewProjectWindow";
            Text = "New Project";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DALabel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button NPCancel;
        private Button NPSave;
    }
}