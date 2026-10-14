namespace SimpleWin
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSimpleWinFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtTransformed = new System.Windows.Forms.TextBox();
            this.btnReverseWords = new System.Windows.Forms.Button();
            this.btnReverseLetters = new System.Windows.Forms.Button();
            this.btnRemoveVowels = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.btnLoadText = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSimpleWinFormToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutSimpleWinFormToolStripMenuItem
            // 
            this.aboutSimpleWinFormToolStripMenuItem.Name = "aboutSimpleWinFormToolStripMenuItem";
            this.aboutSimpleWinFormToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.aboutSimpleWinFormToolStripMenuItem.Text = "About Simple WinForm";
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(140, 27);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(273, 299);
            this.txtOriginal.TabIndex = 1;
            // 
            // txtTransformed
            // 
            this.txtTransformed.Location = new System.Drawing.Point(419, 27);
            this.txtTransformed.Multiline = true;
            this.txtTransformed.Name = "txtTransformed";
            this.txtTransformed.Size = new System.Drawing.Size(273, 299);
            this.txtTransformed.TabIndex = 2;
            // 
            // btnReverseWords
            // 
            this.btnReverseWords.Location = new System.Drawing.Point(12, 85);
            this.btnReverseWords.Name = "btnReverseWords";
            this.btnReverseWords.Size = new System.Drawing.Size(122, 23);
            this.btnReverseWords.TabIndex = 3;
            this.btnReverseWords.Text = "Reverse Words";
            this.btnReverseWords.UseVisualStyleBackColor = true;
            this.btnReverseWords.Click += new System.EventHandler(this.btnReverseWords_Click);
            // 
            // btnReverseLetters
            // 
            this.btnReverseLetters.Location = new System.Drawing.Point(12, 114);
            this.btnReverseLetters.Name = "btnReverseLetters";
            this.btnReverseLetters.Size = new System.Drawing.Size(122, 23);
            this.btnReverseLetters.TabIndex = 4;
            this.btnReverseLetters.Text = "Reverse Letters";
            this.btnReverseLetters.UseVisualStyleBackColor = true;
            this.btnReverseLetters.Click += new System.EventHandler(this.btnReverseLetters_Click);
            // 
            // btnRemoveVowels
            // 
            this.btnRemoveVowels.Location = new System.Drawing.Point(12, 143);
            this.btnRemoveVowels.Name = "btnRemoveVowels";
            this.btnRemoveVowels.Size = new System.Drawing.Size(122, 23);
            this.btnRemoveVowels.TabIndex = 6;
            this.btnRemoveVowels.Text = "Remove Vowels";
            this.btnRemoveVowels.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(12, 301);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(122, 23);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Location = new System.Drawing.Point(12, 272);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(122, 23);
            this.btnClearOutput.TabIndex = 9;
            this.btnClearOutput.Text = "Clear Output";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
            // 
            // btnLoadText
            // 
            this.btnLoadText.Location = new System.Drawing.Point(12, 27);
            this.btnLoadText.Name = "btnLoadText";
            this.btnLoadText.Size = new System.Drawing.Size(122, 23);
            this.btnLoadText.TabIndex = 10;
            this.btnLoadText.Text = "Load Text";
            this.btnLoadText.UseVisualStyleBackColor = true;
            this.btnLoadText.Click += new System.EventHandler(this.btnLoadText_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 336);
            this.Controls.Add(this.btnLoadText);
            this.Controls.Add(this.btnClearOutput);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemoveVowels);
            this.Controls.Add(this.btnReverseLetters);
            this.Controls.Add(this.btnReverseWords);
            this.Controls.Add(this.txtTransformed);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple WinForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtTransformed;
        private System.Windows.Forms.ToolStripMenuItem aboutSimpleWinFormToolStripMenuItem;
        private System.Windows.Forms.Button btnReverseWords;
        private System.Windows.Forms.Button btnReverseLetters;
        private System.Windows.Forms.Button btnRemoveVowels;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.Button btnLoadText;
    }
}

