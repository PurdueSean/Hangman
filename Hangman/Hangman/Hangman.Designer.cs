namespace Hangman
{
    partial class HangmanForm
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
            this.livesLabel = new System.Windows.Forms.Label();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.submitGuessBtn = new System.Windows.Forms.Button();
            this.guessText = new System.Windows.Forms.TextBox();
            this.livesLeft = new System.Windows.Forms.Label();
            this.letterLabel1 = new System.Windows.Forms.Label();
            this.letterLabel2 = new System.Windows.Forms.Label();
            this.letterLabel3 = new System.Windows.Forms.Label();
            this.letterLabel4 = new System.Windows.Forms.Label();
            this.letterLabel5 = new System.Windows.Forms.Label();
            this.letterLabel6 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.guessedLettersText = new System.Windows.Forms.TextBox();
            this.guessedLettersLabel = new System.Windows.Forms.Label();
            this.gallowsPictureBox = new System.Windows.Forms.PictureBox();
            this.hintBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gallowsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // livesLabel
            // 
            this.livesLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.livesLabel.AutoSize = true;
            this.livesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.Location = new System.Drawing.Point(454, 664);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(174, 26);
            this.livesLabel.TabIndex = 7;
            this.livesLabel.Text = "Remaining Lives";
            // 
            // newGameBtn
            // 
            this.newGameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newGameBtn.Location = new System.Drawing.Point(989, 668);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(100, 23);
            this.newGameBtn.TabIndex = 0;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // submitGuessBtn
            // 
            this.submitGuessBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitGuessBtn.Location = new System.Drawing.Point(883, 668);
            this.submitGuessBtn.Name = "submitGuessBtn";
            this.submitGuessBtn.Size = new System.Drawing.Size(100, 23);
            this.submitGuessBtn.TabIndex = 2;
            this.submitGuessBtn.Text = "Submit Guess";
            this.submitGuessBtn.UseVisualStyleBackColor = true;
            this.submitGuessBtn.Click += new System.EventHandler(this.submitGuessBtn_Click);
            // 
            // guessText
            // 
            this.guessText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guessText.Location = new System.Drawing.Point(777, 670);
            this.guessText.Name = "guessText";
            this.guessText.Size = new System.Drawing.Size(100, 20);
            this.guessText.TabIndex = 1;
            this.guessText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guessText_KeyDown);
            this.guessText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guessText_KeyPress);
            // 
            // livesLeft
            // 
            this.livesLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.livesLeft.AutoSize = true;
            this.livesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLeft.Location = new System.Drawing.Point(625, 664);
            this.livesLeft.Name = "livesLeft";
            this.livesLeft.Size = new System.Drawing.Size(24, 26);
            this.livesLeft.TabIndex = 11;
            this.livesLeft.Text = "6";
            // 
            // letterLabel1
            // 
            this.letterLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.letterLabel1.AutoSize = true;
            this.letterLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterLabel1.Location = new System.Drawing.Point(493, 372);
            this.letterLabel1.Name = "letterLabel1";
            this.letterLabel1.Size = new System.Drawing.Size(32, 39);
            this.letterLabel1.TabIndex = 12;
            this.letterLabel1.Text = "*";
            // 
            // letterLabel2
            // 
            this.letterLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.letterLabel2.AutoSize = true;
            this.letterLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterLabel2.Location = new System.Drawing.Point(597, 372);
            this.letterLabel2.Name = "letterLabel2";
            this.letterLabel2.Size = new System.Drawing.Size(32, 39);
            this.letterLabel2.TabIndex = 13;
            this.letterLabel2.Text = "*";
            // 
            // letterLabel3
            // 
            this.letterLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.letterLabel3.AutoSize = true;
            this.letterLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterLabel3.Location = new System.Drawing.Point(706, 372);
            this.letterLabel3.Name = "letterLabel3";
            this.letterLabel3.Size = new System.Drawing.Size(32, 39);
            this.letterLabel3.TabIndex = 14;
            this.letterLabel3.Text = "*";
            // 
            // letterLabel4
            // 
            this.letterLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.letterLabel4.AutoSize = true;
            this.letterLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterLabel4.Location = new System.Drawing.Point(809, 372);
            this.letterLabel4.Name = "letterLabel4";
            this.letterLabel4.Size = new System.Drawing.Size(32, 39);
            this.letterLabel4.TabIndex = 15;
            this.letterLabel4.Text = "*";
            // 
            // letterLabel5
            // 
            this.letterLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.letterLabel5.AutoSize = true;
            this.letterLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterLabel5.Location = new System.Drawing.Point(919, 372);
            this.letterLabel5.Name = "letterLabel5";
            this.letterLabel5.Size = new System.Drawing.Size(32, 39);
            this.letterLabel5.TabIndex = 16;
            this.letterLabel5.Text = "*";
            // 
            // letterLabel6
            // 
            this.letterLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.letterLabel6.AutoSize = true;
            this.letterLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterLabel6.Location = new System.Drawing.Point(1025, 372);
            this.letterLabel6.Name = "letterLabel6";
            this.letterLabel6.Size = new System.Drawing.Size(32, 39);
            this.letterLabel6.TabIndex = 17;
            this.letterLabel6.Text = "*";
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(555, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(484, 55);
            this.titleLabel.TabIndex = 18;
            this.titleLabel.Text = "PGIP-Tech Hangman";
            // 
            // guessedLettersText
            // 
            this.guessedLettersText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guessedLettersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessedLettersText.Location = new System.Drawing.Point(610, 124);
            this.guessedLettersText.Multiline = true;
            this.guessedLettersText.Name = "guessedLettersText";
            this.guessedLettersText.Size = new System.Drawing.Size(338, 196);
            this.guessedLettersText.TabIndex = 19;
            this.guessedLettersText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guessedLettersText_KeyDown);
            this.guessedLettersText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guessedLettersText_KeyPress);
            // 
            // guessedLettersLabel
            // 
            this.guessedLettersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guessedLettersLabel.AutoSize = true;
            this.guessedLettersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessedLettersLabel.Location = new System.Drawing.Point(697, 94);
            this.guessedLettersLabel.Name = "guessedLettersLabel";
            this.guessedLettersLabel.Size = new System.Drawing.Size(171, 26);
            this.guessedLettersLabel.TabIndex = 20;
            this.guessedLettersLabel.Text = "Guessed Letters";
            // 
            // gallowsPictureBox
            // 
            this.gallowsPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gallowsPictureBox.InitialImage = null;
            this.gallowsPictureBox.Location = new System.Drawing.Point(12, 12);
            this.gallowsPictureBox.Name = "gallowsPictureBox";
            this.gallowsPictureBox.Size = new System.Drawing.Size(426, 679);
            this.gallowsPictureBox.TabIndex = 21;
            this.gallowsPictureBox.TabStop = false;
            // 
            // hintBtn
            // 
            this.hintBtn.Location = new System.Drawing.Point(655, 668);
            this.hintBtn.Name = "hintBtn";
            this.hintBtn.Size = new System.Drawing.Size(100, 23);
            this.hintBtn.TabIndex = 3;
            this.hintBtn.Text = "Hint";
            this.hintBtn.UseVisualStyleBackColor = true;
            this.hintBtn.Click += new System.EventHandler(this.hintBtn_Click);
            // 
            // HangmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 720);
            this.Controls.Add(this.hintBtn);
            this.Controls.Add(this.gallowsPictureBox);
            this.Controls.Add(this.guessedLettersLabel);
            this.Controls.Add(this.guessedLettersText);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.letterLabel6);
            this.Controls.Add(this.letterLabel5);
            this.Controls.Add(this.letterLabel4);
            this.Controls.Add(this.letterLabel3);
            this.Controls.Add(this.letterLabel2);
            this.Controls.Add(this.letterLabel1);
            this.Controls.Add(this.livesLeft);
            this.Controls.Add(this.guessText);
            this.Controls.Add(this.submitGuessBtn);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.livesLabel);
            this.Name = "HangmanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman PGIP-Tech";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HangmanForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gallowsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button submitGuessBtn;
        private System.Windows.Forms.TextBox guessText;
        private System.Windows.Forms.Label livesLeft;
        private System.Windows.Forms.Label letterLabel1;
        private System.Windows.Forms.Label letterLabel2;
        private System.Windows.Forms.Label letterLabel3;
        private System.Windows.Forms.Label letterLabel4;
        private System.Windows.Forms.Label letterLabel5;
        private System.Windows.Forms.Label letterLabel6;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox guessedLettersText;
        private System.Windows.Forms.Label guessedLettersLabel;
        private System.Windows.Forms.PictureBox gallowsPictureBox;
        private System.Windows.Forms.Button hintBtn;
    }
}

