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

        private enum actions
        {
            ReverseLetters,
            ReverseWords,
            RemoveVowels
        }

        private void run_action(actions action)
        {
            WordService wordService = new WordService();
            string output = string.Empty;
            Boolean flag_default = false;

            switch (action) {
                case actions.ReverseLetters:
                    output = wordService.ReverseLetters(txtOriginal.Text);
                    break;
                case actions.ReverseWords:
                    output = wordService.ReverseWords(txtOriginal.Text);
                    break;
                case actions.RemoveVowels:
                    output = wordService.RemoveVowels(txtOriginal.Text);
                    break;
                default:
                    flag_default = true;
                    break;
            }

            if (!flag_default)
            {
                txtTransformed.Text = output;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnReverseWords_Click(object sender, EventArgs e)
        {
           run_action(actions.ReverseWords);
        }

        private void btnReverseLetters_Click(object sender, EventArgs e)
        {
            run_action(actions.ReverseLetters);
        }

        private void btnRemoveVowels_Click(object sender, EventArgs e)
        {
            run_action(actions.RemoveVowels);
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

        
    }
}
