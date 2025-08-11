namespace widget_form
{
    partial class empireSystemsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empireSystemsForm));
            submitBtn = new Button();
            widgetTypeGroupBox = new GroupBox();
            widgetTypeOpt2 = new RadioButton();
            widgetTypeOpt1 = new RadioButton();
            widgetTypeOptB = new RadioButton();
            widgetTypeOptA = new RadioButton();
            widgetNameTextBox = new TextBox();
            widgetNameLabel = new Label();
            typeASubtypesComboBox = new ComboBox();
            typeASubtypesLabel = new Label();
            typeBSubtypesLabel = new Label();
            typeBSubtypesComboBox = new ComboBox();
            type1SubtypesLabel = new Label();
            type1SubtypesComboBox = new ComboBox();
            type2SubtypesLabel = new Label();
            type2SubtypesComboBox = new ComboBox();
            widgetTypeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(335, 375);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(140, 40);
            submitBtn.TabIndex = 0;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            // 
            // widgetTypeGroupBox
            // 
            widgetTypeGroupBox.Controls.Add(widgetTypeOpt2);
            widgetTypeGroupBox.Controls.Add(widgetTypeOpt1);
            widgetTypeGroupBox.Controls.Add(widgetTypeOptB);
            widgetTypeGroupBox.Controls.Add(widgetTypeOptA);
            widgetTypeGroupBox.Location = new Point(278, 122);
            widgetTypeGroupBox.Name = "widgetTypeGroupBox";
            widgetTypeGroupBox.Size = new Size(250, 157);
            widgetTypeGroupBox.TabIndex = 1;
            widgetTypeGroupBox.TabStop = false;
            widgetTypeGroupBox.Text = "Type";
            // 
            // widgetTypeOpt2
            // 
            widgetTypeOpt2.AutoSize = true;
            widgetTypeOpt2.Location = new Point(33, 117);
            widgetTypeOpt2.Name = "widgetTypeOpt2";
            widgetTypeOpt2.Size = new Size(38, 24);
            widgetTypeOpt2.TabIndex = 3;
            widgetTypeOpt2.Text = "2";
            widgetTypeOpt2.UseVisualStyleBackColor = true;
            widgetTypeOpt2.CheckedChanged += widgetTypeOpt2_CheckedChanged;
            // 
            // widgetTypeOpt1
            // 
            widgetTypeOpt1.AutoSize = true;
            widgetTypeOpt1.Location = new Point(33, 87);
            widgetTypeOpt1.Name = "widgetTypeOpt1";
            widgetTypeOpt1.Size = new Size(38, 24);
            widgetTypeOpt1.TabIndex = 2;
            widgetTypeOpt1.Text = "1";
            widgetTypeOpt1.UseVisualStyleBackColor = true;
            widgetTypeOpt1.CheckedChanged += widgetTypeOpt1_CheckedChanged;
            // 
            // widgetTypeOptB
            // 
            widgetTypeOptB.AutoSize = true;
            widgetTypeOptB.Location = new Point(33, 57);
            widgetTypeOptB.Name = "widgetTypeOptB";
            widgetTypeOptB.Size = new Size(39, 24);
            widgetTypeOptB.TabIndex = 1;
            widgetTypeOptB.Text = "B";
            widgetTypeOptB.UseVisualStyleBackColor = true;
            widgetTypeOptB.CheckedChanged += widgetTypeOptB_CheckedChanged;
            // 
            // widgetTypeOptA
            // 
            widgetTypeOptA.AutoSize = true;
            widgetTypeOptA.Checked = true;
            widgetTypeOptA.Location = new Point(32, 27);
            widgetTypeOptA.Name = "widgetTypeOptA";
            widgetTypeOptA.Size = new Size(40, 24);
            widgetTypeOptA.TabIndex = 0;
            widgetTypeOptA.TabStop = true;
            widgetTypeOptA.Text = "A";
            widgetTypeOptA.UseVisualStyleBackColor = true;
            widgetTypeOptA.CheckedChanged += widgetTypeOptA_CheckedChanged;
            // 
            // widgetNameTextBox
            // 
            widgetNameTextBox.Location = new Point(278, 71);
            widgetNameTextBox.MaxLength = 500;
            widgetNameTextBox.Name = "widgetNameTextBox";
            widgetNameTextBox.Size = new Size(250, 27);
            widgetNameTextBox.TabIndex = 2;
            // 
            // widgetNameLabel
            // 
            widgetNameLabel.AutoSize = true;
            widgetNameLabel.Location = new Point(275, 48);
            widgetNameLabel.Name = "widgetNameLabel";
            widgetNameLabel.Size = new Size(102, 20);
            widgetNameLabel.TabIndex = 3;
            widgetNameLabel.Text = "Widget Name";
            // 
            // typeASubtypesComboBox
            // 
            typeASubtypesComboBox.FormattingEnabled = true;
            typeASubtypesComboBox.Items.AddRange(new object[] { "Apple", "Aardvark", "Astronaut" });
            typeASubtypesComboBox.Location = new Point(302, 317);
            typeASubtypesComboBox.Name = "typeASubtypesComboBox";
            typeASubtypesComboBox.Size = new Size(207, 28);
            typeASubtypesComboBox.TabIndex = 4;
            typeASubtypesComboBox.Text = " -- SELECT ONE --";
            // 
            // typeASubtypesLabel
            // 
            typeASubtypesLabel.AutoSize = true;
            typeASubtypesLabel.Location = new Point(299, 294);
            typeASubtypesLabel.Name = "typeASubtypesLabel";
            typeASubtypesLabel.Size = new Size(118, 20);
            typeASubtypesLabel.TabIndex = 5;
            typeASubtypesLabel.Text = "Type A Subtypes";
            // 
            // typeBSubtypesLabel
            // 
            typeBSubtypesLabel.AutoSize = true;
            typeBSubtypesLabel.Location = new Point(567, 147);
            typeBSubtypesLabel.Name = "typeBSubtypesLabel";
            typeBSubtypesLabel.Size = new Size(117, 20);
            typeBSubtypesLabel.TabIndex = 7;
            typeBSubtypesLabel.Text = "Type B Subtypes";
            // 
            // typeBSubtypesComboBox
            // 
            typeBSubtypesComboBox.FormattingEnabled = true;
            typeBSubtypesComboBox.Items.AddRange(new object[] { "Bear", "Bobcat", "Beaver" });
            typeBSubtypesComboBox.Location = new Point(570, 170);
            typeBSubtypesComboBox.Name = "typeBSubtypesComboBox";
            typeBSubtypesComboBox.Size = new Size(207, 28);
            typeBSubtypesComboBox.TabIndex = 6;
            typeBSubtypesComboBox.Text = " -- SELECT ONE --";
            // 
            // type1SubtypesLabel
            // 
            type1SubtypesLabel.AutoSize = true;
            type1SubtypesLabel.Location = new Point(564, 223);
            type1SubtypesLabel.Name = "type1SubtypesLabel";
            type1SubtypesLabel.Size = new Size(116, 20);
            type1SubtypesLabel.TabIndex = 9;
            type1SubtypesLabel.Text = "Type 1 Subtypes";
            // 
            // type1SubtypesComboBox
            // 
            type1SubtypesComboBox.FormattingEnabled = true;
            type1SubtypesComboBox.Items.AddRange(new object[] { "First", "One", "Primary", "Uno" });
            type1SubtypesComboBox.Location = new Point(567, 246);
            type1SubtypesComboBox.Name = "type1SubtypesComboBox";
            type1SubtypesComboBox.Size = new Size(207, 28);
            type1SubtypesComboBox.TabIndex = 8;
            type1SubtypesComboBox.Text = " -- SELECT ONE --";
            // 
            // type2SubtypesLabel
            // 
            type2SubtypesLabel.AutoSize = true;
            type2SubtypesLabel.Location = new Point(567, 315);
            type2SubtypesLabel.Name = "type2SubtypesLabel";
            type2SubtypesLabel.Size = new Size(116, 20);
            type2SubtypesLabel.TabIndex = 11;
            type2SubtypesLabel.Text = "Type 2 Subtypes";
            // 
            // type2SubtypesComboBox
            // 
            type2SubtypesComboBox.FormattingEnabled = true;
            type2SubtypesComboBox.Items.AddRange(new object[] { "Second", "Two", "Secondary", "Dos" });
            type2SubtypesComboBox.Location = new Point(570, 338);
            type2SubtypesComboBox.Name = "type2SubtypesComboBox";
            type2SubtypesComboBox.Size = new Size(207, 28);
            type2SubtypesComboBox.TabIndex = 10;
            type2SubtypesComboBox.Text = " -- SELECT ONE --";
            // 
            // empireSystemsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 483);
            Controls.Add(type2SubtypesLabel);
            Controls.Add(type2SubtypesComboBox);
            Controls.Add(type1SubtypesLabel);
            Controls.Add(type1SubtypesComboBox);
            Controls.Add(typeBSubtypesLabel);
            Controls.Add(typeBSubtypesComboBox);
            Controls.Add(typeASubtypesLabel);
            Controls.Add(typeASubtypesComboBox);
            Controls.Add(widgetNameLabel);
            Controls.Add(widgetNameTextBox);
            Controls.Add(widgetTypeGroupBox);
            Controls.Add(submitBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "empireSystemsForm";
            Text = "Empire Systems - Widget Submission";
            widgetTypeGroupBox.ResumeLayout(false);
            widgetTypeGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitBtn;
        private GroupBox widgetTypeGroupBox;
        private RadioButton widgetTypeOpt2;
        private RadioButton widgetTypeOpt1;
        private RadioButton widgetTypeOptB;
        private RadioButton widgetTypeOptA;
        private TextBox widgetNameTextBox;
        private Label widgetNameLabel;
        private ComboBox typeASubtypesComboBox;
        private Label typeASubtypesLabel;
        private Label typeBSubtypesLabel;
        private ComboBox typeBSubtypesComboBox;
        private Label type1SubtypesLabel;
        private ComboBox type1SubtypesComboBox;
        private Label type2SubtypesLabel;
        private ComboBox type2SubtypesComboBox;
    }
}
