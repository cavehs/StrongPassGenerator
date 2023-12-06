using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongPassGenerator
{
    public partial class GeneratePasswordForm : Form
    {
        Password password = new Password();
        public GeneratePasswordForm()
        {
            InitializeComponent();
        }

        private void readHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generatedPassword.Text = string.Empty;

            PasswordOptions options = new PasswordOptions()
            {
                PasswordLength = (int.Parse(passwordLengthTextBox.Text)),
                IncludeSymbols = cbIncludeSymbols.Checked,
                IncludeNumbers = cbIncludeNumbers.Checked,
                IncludeLowercase = cbIncludeLowercase.Checked,
                IncludeUppercase = cbIncludeUppercase.Checked,
                ExcludeDuplicates = cbExcludeDuplicateChars.Checked,
                ExcludeSimilar = cbExcludeSimilarChars.Checked,
                ExcludeAmbiguous = cbExcludeAmbiguous.Checked,
                StartWithLetter = cbStartWithLetter.Checked
            };

            generatedPassword.Text = password.Generate(options);
            // Copy to clipboard to make it easier to use
            Clipboard.SetText(generatedPassword.Text);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(generatedPassword.Text);
        }

    }
}
