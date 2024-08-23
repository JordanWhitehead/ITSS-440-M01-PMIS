namespace PMIS____GUI_Design
{
    partial class ResourceMgmtView
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            labelID = new Label();
            textBoxResID = new TextBox();
            labelName = new Label();
            textBoxResName = new TextBox();
            labelDescr = new Label();
            textBoxResDescr = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.Location = new Point(14, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(70, 28);
            labelTitle.TabIndex = 23;
            labelTitle.Text = "label1";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelID);
            panel1.Controls.Add(textBoxResID);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(textBoxResName);
            panel1.Controls.Add(labelDescr);
            panel1.Controls.Add(textBoxResDescr);
            panel1.Location = new Point(14, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 203);
            panel1.TabIndex = 22;
            // 
            // button3
            // 
            button3.Location = new Point(134, 124);
            button3.Name = "button3";
            button3.Size = new Size(117, 29);
            button3.TabIndex = 20;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(11, 159);
            button2.Name = "button2";
            button2.Size = new Size(117, 29);
            button2.TabIndex = 19;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(11, 124);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 18;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(11, 16);
            labelID.Name = "labelID";
            labelID.Size = new Size(88, 20);
            labelID.TabIndex = 0;
            labelID.Text = "Resource ID";
            // 
            // textBoxResID
            // 
            textBoxResID.Location = new Point(142, 13);
            textBoxResID.Name = "textBoxResID";
            textBoxResID.ReadOnly = true;
            textBoxResID.Size = new Size(388, 27);
            textBoxResID.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(11, 49);
            labelName.Name = "labelName";
            labelName.Size = new Size(113, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Resource Name";
            // 
            // textBoxResName
            // 
            textBoxResName.Location = new Point(142, 46);
            textBoxResName.Name = "textBoxResName";
            textBoxResName.ReadOnly = true;
            textBoxResName.Size = new Size(388, 27);
            textBoxResName.TabIndex = 3;
            // 
            // labelDescr
            // 
            labelDescr.AutoSize = true;
            labelDescr.Location = new Point(11, 82);
            labelDescr.Name = "labelDescr";
            labelDescr.Size = new Size(85, 20);
            labelDescr.TabIndex = 4;
            labelDescr.Text = "Description";
            // 
            // textBoxResDescr
            // 
            textBoxResDescr.Location = new Point(142, 79);
            textBoxResDescr.Name = "textBoxResDescr";
            textBoxResDescr.ReadOnly = true;
            textBoxResDescr.Size = new Size(388, 27);
            textBoxResDescr.TabIndex = 5;
            // 
            // ResourceMgmtView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 280);
            Controls.Add(labelTitle);
            Controls.Add(panel1);
            Name = "ResourceMgmtView";
            Text = "Resource View";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Panel panel1;
        private Button button1;
        private Label labelID;
        private TextBox textBoxResID;
        private Label labelName;
        private TextBox textBoxResName;
        private Label labelDescr;
        private TextBox textBoxResDescr;
        private Button button3;
        private Button button2;
    }
}