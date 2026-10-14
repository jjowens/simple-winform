using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleWin.Library;

namespace SimpleWin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnReverseWords_Click(object sender, EventArgs e)
        {
            WordService wordService = new WordService();

            string output = wordService.ReverseWords(txtOriginal.Text);
            txtTransformed.Text = output;
        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            txtTransformed.Text = "";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtOriginal.Text = "";
            txtTransformed.Text = "";
        }

        private void btnLoadText_Click(object sender, EventArgs e)
        {
            WordService wordService = new WordService();
            txtOriginal.Text = wordService.LoadText();
        }

        private void btnReverseLetters_Click(object sender, EventArgs e)
        {
            WordService wordService = new WordService();

            string output = wordService.ReverseLetters(txtOriginal.Text);
            txtTransformed.Text = output;
        }

        private void btnRemoveVowels_Click(object sender, EventArgs e)
        {
            WordService wordService = new WordService();

            string output = wordService.RemoveVowels(txtOriginal.Text);
            txtTransformed.Text = output;
        }
    }
}
