namespace StrongPassGenerator
{
    partial class GeneratePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePasswordForm));
            GenerateButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            passwordLengthTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            cbIncludeSymbols = new System.Windows.Forms.CheckBox();
            cbIncludeNumbers = new System.Windows.Forms.CheckBox();
            cbIncludeLowercase = new System.Windows.Forms.CheckBox();
            cbIncludeUppercase = new System.Windows.Forms.CheckBox();
            cbExcludeSimilarChars = new System.Windows.Forms.CheckBox();
            cbExcludeAmbiguous = new System.Windows.Forms.CheckBox();
            generatedPassword = new System.Windows.Forms.TextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            readHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            CopyButton = new System.Windows.Forms.Button();
            cbExcludeDuplicateChars = new System.Windows.Forms.CheckBox();
            label8 = new System.Windows.Forms.Label();
            cbStartWithLetter = new System.Windows.Forms.CheckBox();
            label9 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GenerateButton
            // 
            GenerateButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            GenerateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            GenerateButton.Location = new System.Drawing.Point(211, 433);
            GenerateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new System.Drawing.Size(113, 35);
            GenerateButton.TabIndex = 0;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = false;
            GenerateButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(28, 55);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 19);
            label1.TabIndex = 1;
            label1.Text = "Password Length:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(28, 89);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 19);
            label2.TabIndex = 2;
            label2.Text = "Include Symbols:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(28, 121);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(122, 19);
            label3.TabIndex = 3;
            label3.Text = "Include Numbers:";
            // 
            // passwordLengthTextBox
            // 
            passwordLengthTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            passwordLengthTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            passwordLengthTextBox.ForeColor = System.Drawing.SystemColors.Window;
            passwordLengthTextBox.Location = new System.Drawing.Point(285, 55);
            passwordLengthTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            passwordLengthTextBox.Name = "passwordLengthTextBox";
            passwordLengthTextBox.Size = new System.Drawing.Size(50, 27);
            passwordLengthTextBox.TabIndex = 1;
            passwordLengthTextBox.Text = "16";
            passwordLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(28, 155);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(207, 19);
            label4.TabIndex = 6;
            label4.Text = "Include Lowercase Characters:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(28, 187);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(207, 19);
            label5.TabIndex = 7;
            label5.Text = "Include Uppercase Characters:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(28, 254);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(206, 19);
            label6.TabIndex = 8;
            label6.Text = "Exclude Confusing Characters:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(29, 286);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(172, 19);
            label7.TabIndex = 9;
            label7.Text = "Exclude Hard Characters:";
            // 
            // cbIncludeSymbols
            // 
            cbIncludeSymbols.AutoSize = true;
            cbIncludeSymbols.Checked = true;
            cbIncludeSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            cbIncludeSymbols.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbIncludeSymbols.Location = new System.Drawing.Point(285, 89);
            cbIncludeSymbols.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbIncludeSymbols.Name = "cbIncludeSymbols";
            cbIncludeSymbols.Size = new System.Drawing.Size(115, 23);
            cbIncludeSymbols.TabIndex = 2;
            cbIncludeSymbols.Text = "( e.g. @#$% )";
            cbIncludeSymbols.UseVisualStyleBackColor = true;
            // 
            // cbIncludeNumbers
            // 
            cbIncludeNumbers.AutoSize = true;
            cbIncludeNumbers.Checked = true;
            cbIncludeNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            cbIncludeNumbers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbIncludeNumbers.Location = new System.Drawing.Point(285, 121);
            cbIncludeNumbers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbIncludeNumbers.Name = "cbIncludeNumbers";
            cbIncludeNumbers.Size = new System.Drawing.Size(122, 23);
            cbIncludeNumbers.TabIndex = 3;
            cbIncludeNumbers.Text = "( e.g. 123456 )";
            cbIncludeNumbers.UseVisualStyleBackColor = true;
            // 
            // cbIncludeLowercase
            // 
            cbIncludeLowercase.AutoSize = true;
            cbIncludeLowercase.Checked = true;
            cbIncludeLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            cbIncludeLowercase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbIncludeLowercase.Location = new System.Drawing.Point(285, 155);
            cbIncludeLowercase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbIncludeLowercase.Name = "cbIncludeLowercase";
            cbIncludeLowercase.Size = new System.Drawing.Size(134, 23);
            cbIncludeLowercase.TabIndex = 4;
            cbIncludeLowercase.Text = "( e.g. abcdefgh )";
            cbIncludeLowercase.UseVisualStyleBackColor = true;
            // 
            // cbIncludeUppercase
            // 
            cbIncludeUppercase.AutoSize = true;
            cbIncludeUppercase.Checked = true;
            cbIncludeUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            cbIncludeUppercase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbIncludeUppercase.Location = new System.Drawing.Point(285, 187);
            cbIncludeUppercase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbIncludeUppercase.Name = "cbIncludeUppercase";
            cbIncludeUppercase.Size = new System.Drawing.Size(146, 23);
            cbIncludeUppercase.TabIndex = 5;
            cbIncludeUppercase.Text = "( e.g. ABCDEFGH )";
            cbIncludeUppercase.UseVisualStyleBackColor = true;
            // 
            // cbExcludeSimilarChars
            // 
            cbExcludeSimilarChars.AutoSize = true;
            cbExcludeSimilarChars.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbExcludeSimilarChars.Location = new System.Drawing.Point(285, 254);
            cbExcludeSimilarChars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbExcludeSimilarChars.Name = "cbExcludeSimilarChars";
            cbExcludeSimilarChars.Size = new System.Drawing.Size(176, 23);
            cbExcludeSimilarChars.TabIndex = 7;
            cbExcludeSimilarChars.Text = "( e.g.  |, l, 1, I, o, 0, O )";
            cbExcludeSimilarChars.UseVisualStyleBackColor = true;
            // 
            // cbExcludeAmbiguous
            // 
            cbExcludeAmbiguous.AutoSize = true;
            cbExcludeAmbiguous.Checked = true;
            cbExcludeAmbiguous.CheckState = System.Windows.Forms.CheckState.Checked;
            cbExcludeAmbiguous.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbExcludeAmbiguous.Location = new System.Drawing.Point(285, 286);
            cbExcludeAmbiguous.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbExcludeAmbiguous.Name = "cbExcludeAmbiguous";
            cbExcludeAmbiguous.Size = new System.Drawing.Size(211, 23);
            cbExcludeAmbiguous.TabIndex = 8;
            cbExcludeAmbiguous.Text = "( { } [ ] ( ) / \\ ' \" ` ~ , ; : . < > )";
            cbExcludeAmbiguous.UseVisualStyleBackColor = true;
            // 
            // generatedPassword
            // 
            generatedPassword.BackColor = System.Drawing.SystemColors.MenuText;
            generatedPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            generatedPassword.ForeColor = System.Drawing.SystemColors.Window;
            generatedPassword.Location = new System.Drawing.Point(31, 480);
            generatedPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            generatedPassword.Name = "generatedPassword";
            generatedPassword.ReadOnly = true;
            generatedPassword.Size = new System.Drawing.Size(409, 33);
            generatedPassword.TabIndex = 10;
            generatedPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { readHereToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            menuStrip1.Size = new System.Drawing.Size(554, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // readHereToolStripMenuItem
            // 
            readHereToolStripMenuItem.Name = "readHereToolStripMenuItem";
            readHereToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            readHereToolStripMenuItem.Text = "About";
            readHereToolStripMenuItem.Click += readHereToolStripMenuItem_Click;
            // 
            // CopyButton
            // 
            CopyButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            CopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CopyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            CopyButton.Location = new System.Drawing.Point(446, 480);
            CopyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new System.Drawing.Size(80, 35);
            CopyButton.TabIndex = 9;
            CopyButton.Text = "Copy";
            CopyButton.UseVisualStyleBackColor = false;
            CopyButton.Click += button1_Click_1;
            // 
            // cbExcludeDuplicateChars
            // 
            cbExcludeDuplicateChars.AutoSize = true;
            cbExcludeDuplicateChars.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbExcludeDuplicateChars.Location = new System.Drawing.Point(285, 220);
            cbExcludeDuplicateChars.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbExcludeDuplicateChars.Name = "cbExcludeDuplicateChars";
            cbExcludeDuplicateChars.Size = new System.Drawing.Size(132, 23);
            cbExcludeDuplicateChars.TabIndex = 6;
            cbExcludeDuplicateChars.Text = "( e.g.  aA,Bb,Cc)";
            cbExcludeDuplicateChars.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(28, 220);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(203, 19);
            label8.TabIndex = 19;
            label8.Text = "Exclude Duplicate Characters:";
            // 
            // cbStartWithLetter
            // 
            cbStartWithLetter.AutoSize = true;
            cbStartWithLetter.Checked = true;
            cbStartWithLetter.CheckState = System.Windows.Forms.CheckState.Checked;
            cbStartWithLetter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbStartWithLetter.Location = new System.Drawing.Point(286, 319);
            cbStartWithLetter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbStartWithLetter.Name = "cbStartWithLetter";
            cbStartWithLetter.Size = new System.Drawing.Size(186, 23);
            cbStartWithLetter.TabIndex = 20;
            cbStartWithLetter.Text = "( Must use a letter first )";
            cbStartWithLetter.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(31, 319);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(114, 19);
            label9.TabIndex = 21;
            label9.Text = "Start with letter:";
            // 
            // GeneratePasswordForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ClientSize = new System.Drawing.Size(554, 553);
            Controls.Add(cbStartWithLetter);
            Controls.Add(label9);
            Controls.Add(cbExcludeDuplicateChars);
            Controls.Add(label8);
            Controls.Add(CopyButton);
            Controls.Add(generatedPassword);
            Controls.Add(cbExcludeAmbiguous);
            Controls.Add(cbExcludeSimilarChars);
            Controls.Add(cbIncludeUppercase);
            Controls.Add(cbIncludeLowercase);
            Controls.Add(cbIncludeNumbers);
            Controls.Add(cbIncludeSymbols);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(passwordLengthTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GenerateButton);
            Controls.Add(menuStrip1);
            ForeColor = System.Drawing.SystemColors.ControlLightLight;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "GeneratePasswordForm";
            Text = "Strong Password Generator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passwordLengthTextBox;
        private System.Windows.Forms.CheckBox cbIncludeSymbols;
        private System.Windows.Forms.CheckBox cbIncludeNumbers;
        private System.Windows.Forms.CheckBox cbIncludeLowercase;
        private System.Windows.Forms.CheckBox cbIncludeUppercase;
        private System.Windows.Forms.CheckBox cbExcludeSimilarChars;
        private System.Windows.Forms.CheckBox cbExcludeAmbiguous;
        private System.Windows.Forms.TextBox generatedPassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem readHereToolStripMenuItem;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.CheckBox cbExcludeDuplicateChars;
        private System.Windows.Forms.CheckBox cbStartWithLetter;
    }
}

