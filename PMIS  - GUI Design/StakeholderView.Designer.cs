namespace PMIS____GUI_Design
{
    partial class StakeholderView
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
            label2 = new Label();
            textBoxStakeholderDescription = new TextBox();
            label1 = new Label();
            textBoxStakeholderRole = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            labelID = new Label();
            textBoxStakeholderID = new TextBox();
            labelName = new Label();
            textBoxStakeholderName = new TextBox();
            labelDescr = new Label();
            textBoxStakeholderTitle = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.Location = new Point(14, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(70, 28);
            labelTitle.TabIndex = 25;
            labelTitle.Text = "label1";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxStakeholderDescription);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxStakeholderRole);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelID);
            panel1.Controls.Add(textBoxStakeholderID);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(textBoxStakeholderName);
            panel1.Controls.Add(labelDescr);
            panel1.Controls.Add(textBoxStakeholderTitle);
            panel1.Location = new Point(14, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 265);
            panel1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 148);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 23;
            label2.Text = "Description";
            // 
            // textBoxStakeholderDescription
            // 
            textBoxStakeholderDescription.Location = new Point(142, 145);
            textBoxStakeholderDescription.Name = "textBoxStakeholderDescription";
            textBoxStakeholderDescription.ReadOnly = true;
            textBoxStakeholderDescription.Size = new Size(388, 27);
            textBoxStakeholderDescription.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 115);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 21;
            label1.Text = "Role";
            // 
            // textBoxStakeholderRole
            // 
            textBoxStakeholderRole.Location = new Point(142, 112);
            textBoxStakeholderRole.Name = "textBoxStakeholderRole";
            textBoxStakeholderRole.ReadOnly = true;
            textBoxStakeholderRole.Size = new Size(388, 27);
            textBoxStakeholderRole.TabIndex = 22;
            // 
            // button3
            // 
            button3.Location = new Point(134, 187);
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
            button2.Location = new Point(11, 222);
            button2.Name = "button2";
            button2.Size = new Size(117, 29);
            button2.TabIndex = 19;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(11, 187);
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
            labelID.Size = new Size(107, 20);
            labelID.TabIndex = 0;
            labelID.Text = "Stakeholder ID";
            // 
            // textBoxStakeholderID
            // 
            textBoxStakeholderID.Location = new Point(142, 13);
            textBoxStakeholderID.Name = "textBoxStakeholderID";
            textBoxStakeholderID.ReadOnly = true;
            textBoxStakeholderID.Size = new Size(388, 27);
            textBoxStakeholderID.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(11, 49);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            // 
            // textBoxStakeholderName
            // 
            textBoxStakeholderName.Location = new Point(142, 46);
            textBoxStakeholderName.Name = "textBoxStakeholderName";
            textBoxStakeholderName.ReadOnly = true;
            textBoxStakeholderName.Size = new Size(388, 27);
            textBoxStakeholderName.TabIndex = 3;
            // 
            // labelDescr
            // 
            labelDescr.AutoSize = true;
            labelDescr.Location = new Point(11, 82);
            labelDescr.Name = "labelDescr";
            labelDescr.Size = new Size(38, 20);
            labelDescr.TabIndex = 4;
            labelDescr.Text = "Title";
            // 
            // textBoxStakeholderTitle
            // 
            textBoxStakeholderTitle.Location = new Point(142, 79);
            textBoxStakeholderTitle.Name = "textBoxStakeholderTitle";
            textBoxStakeholderTitle.ReadOnly = true;
            textBoxStakeholderTitle.Size = new Size(388, 27);
            textBoxStakeholderTitle.TabIndex = 5;
            // 
            // StakeholderView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 341);
            Controls.Add(labelTitle);
            Controls.Add(panel1);
            Name = "StakeholderView";
            Text = "Stakeholder View";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Panel panel1;
        private Label label2;
        private TextBox textBoxStakeholderDescription;
        private Label label1;
        private TextBox textBoxStakeholderRole;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label labelID;
        private TextBox textBoxStakeholderID;
        private Label labelName;
        private TextBox textBoxStakeholderName;
        private Label labelDescr;
        private TextBox textBoxStakeholderTitle;
    }
}