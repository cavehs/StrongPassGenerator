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
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbIncludeSymbols = new System.Windows.Forms.CheckBox();
            this.cbIncludeNumbers = new System.Windows.Forms.CheckBox();
            this.cbIncludeLowercase = new System.Windows.Forms.CheckBox();
            this.cbIncludeUppercase = new System.Windows.Forms.CheckBox();
            this.cbExcludeSimilarChars = new System.Windows.Forms.CheckBox();
            this.cbExcludeAmbiguous = new System.Windows.Forms.CheckBox();
            this.generatedPassword = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.readHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GenerateButton.Location = new System.Drawing.Point(273, 415);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(146, 46);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password Length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Include Symbols:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Include Numbers:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(366, 74);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 37);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "15";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Include Lowercase Characters:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Include Uppercase Characters:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Exclude Similar Characters:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 335);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Exclude Ambiguous Characters:";
            // 
            // cbIncludeSymbols
            // 
            this.cbIncludeSymbols.AutoSize = true;
            this.cbIncludeSymbols.Checked = true;
            this.cbIncludeSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIncludeSymbols.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIncludeSymbols.Location = new System.Drawing.Point(366, 118);
            this.cbIncludeSymbols.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIncludeSymbols.Name = "cbIncludeSymbols";
            this.cbIncludeSymbols.Size = new System.Drawing.Size(165, 33);
            this.cbIncludeSymbols.TabIndex = 10;
            this.cbIncludeSymbols.Text = "( e.g. @#$% )";
            this.cbIncludeSymbols.UseVisualStyleBackColor = true;
            // 
            // cbIncludeNumbers
            // 
            this.cbIncludeNumbers.AutoSize = true;
            this.cbIncludeNumbers.Checked = true;
            this.cbIncludeNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIncludeNumbers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIncludeNumbers.Location = new System.Drawing.Point(366, 160);
            this.cbIncludeNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIncludeNumbers.Name = "cbIncludeNumbers";
            this.cbIncludeNumbers.Size = new System.Drawing.Size(175, 33);
            this.cbIncludeNumbers.TabIndex = 11;
            this.cbIncludeNumbers.Text = "( e.g. 123456 )";
            this.cbIncludeNumbers.UseVisualStyleBackColor = true;
            // 
            // cbIncludeLowercase
            // 
            this.cbIncludeLowercase.AutoSize = true;
            this.cbIncludeLowercase.Checked = true;
            this.cbIncludeLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIncludeLowercase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIncludeLowercase.Location = new System.Drawing.Point(366, 200);
            this.cbIncludeLowercase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIncludeLowercase.Name = "cbIncludeLowercase";
            this.cbIncludeLowercase.Size = new System.Drawing.Size(193, 33);
            this.cbIncludeLowercase.TabIndex = 12;
            this.cbIncludeLowercase.Text = "( e.g. abcdefgh )";
            this.cbIncludeLowercase.UseVisualStyleBackColor = true;
            // 
            // cbIncludeUppercase
            // 
            this.cbIncludeUppercase.AutoSize = true;
            this.cbIncludeUppercase.Checked = true;
            this.cbIncludeUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIncludeUppercase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIncludeUppercase.Location = new System.Drawing.Point(366, 245);
            this.cbIncludeUppercase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIncludeUppercase.Name = "cbIncludeUppercase";
            this.cbIncludeUppercase.Size = new System.Drawing.Size(211, 33);
            this.cbIncludeUppercase.TabIndex = 13;
            this.cbIncludeUppercase.Text = "( e.g. ABCDEFGH )";
            this.cbIncludeUppercase.UseVisualStyleBackColor = true;
            // 
            // cbExcludeSimilarChars
            // 
            this.cbExcludeSimilarChars.AutoSize = true;
            this.cbExcludeSimilarChars.Checked = true;
            this.cbExcludeSimilarChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExcludeSimilarChars.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExcludeSimilarChars.Location = new System.Drawing.Point(366, 292);
            this.cbExcludeSimilarChars.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbExcludeSimilarChars.Name = "cbExcludeSimilarChars";
            this.cbExcludeSimilarChars.Size = new System.Drawing.Size(250, 33);
            this.cbExcludeSimilarChars.TabIndex = 14;
            this.cbExcludeSimilarChars.Text = "( e.g.  |, l, 1, I, o, 0, O )";
            this.cbExcludeSimilarChars.UseVisualStyleBackColor = true;
            // 
            // cbExcludeAmbiguous
            // 
            this.cbExcludeAmbiguous.AutoSize = true;
            this.cbExcludeAmbiguous.Checked = true;
            this.cbExcludeAmbiguous.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExcludeAmbiguous.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExcludeAmbiguous.Location = new System.Drawing.Point(366, 337);
            this.cbExcludeAmbiguous.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbExcludeAmbiguous.Name = "cbExcludeAmbiguous";
            this.cbExcludeAmbiguous.Size = new System.Drawing.Size(292, 33);
            this.cbExcludeAmbiguous.TabIndex = 15;
            this.cbExcludeAmbiguous.Text = "( { } [ ] ( ) / \\ \' \" ` ~ , ; : . < > )";
            this.cbExcludeAmbiguous.UseVisualStyleBackColor = true;
            // 
            // generatedPassword
            // 
            this.generatedPassword.BackColor = System.Drawing.SystemColors.MenuText;
            this.generatedPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.generatedPassword.Location = new System.Drawing.Point(43, 478);
            this.generatedPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generatedPassword.Name = "generatedPassword";
            this.generatedPassword.ReadOnly = true;
            this.generatedPassword.Size = new System.Drawing.Size(524, 46);
            this.generatedPassword.TabIndex = 16;
            this.generatedPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readHereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // readHereToolStripMenuItem
            // 
            this.readHereToolStripMenuItem.Name = "readHereToolStripMenuItem";
            this.readHereToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.readHereToolStripMenuItem.Text = "About";
            this.readHereToolStripMenuItem.Click += new System.EventHandler(this.readHereToolStripMenuItem_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CopyButton.Location = new System.Drawing.Point(575, 478);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(104, 46);
            this.CopyButton.TabIndex = 18;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GeneratePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(712, 577);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.generatedPassword);
            this.Controls.Add(this.cbExcludeAmbiguous);
            this.Controls.Add(this.cbExcludeSimilarChars);
            this.Controls.Add(this.cbIncludeUppercase);
            this.Controls.Add(this.cbIncludeLowercase);
            this.Controls.Add(this.cbIncludeNumbers);
            this.Controls.Add(this.cbIncludeSymbols);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "GeneratePasswordForm";
            this.Text = "Strong Password Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
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
    }
}

