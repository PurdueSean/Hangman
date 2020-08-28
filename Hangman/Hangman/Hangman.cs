using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hangman
{
    public partial class HangmanForm : Form
    {
        //*******************************************************
        //**************** General Variables ********************
        //*******************************************************
        string SecretWord;
        int  RemainingLives = 6;
        bool c1Guessed, c2Guessed, c3Guessed, c4Guessed, c5Guessed, c6Guessed, Won;
        char c1, c2, c3, c4, c5, c6;        

        public HangmanForm()
        {
            InitializeComponent();
            submitGuessBtn.Visible = false;
            gallowsPictureBox.Image = Properties.Resources.HangmanGallows1;
            livesLabel.ForeColor = Color.Green;

            //*******************************************************
            //**************** General Validation *******************
            //*******************************************************
            guessText.MaxLength = 1;
            guessText.ShortcutsEnabled = false;
            guessedLettersText.ShortcutsEnabled = false;
            guessText.CharacterCasing = CharacterCasing.Upper;            
        }
        //*******************************************************
        //**************** Button Clicks ************************
        //*******************************************************
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            // Runs the resetter and gets a new secret word.
            // Breaks the secret word up into individual characters
            // and assigns them to the correct character value.
            Resetter();
            SecretWord = GetWord.WordGetter();
            c1 = SecretWord[0];
            c2 = SecretWord[1];
            c3 = SecretWord[2];
            c4 = SecretWord[3];
            c5 = SecretWord[4];
            c6 = SecretWord[5];
            submitGuessBtn.Visible = true;
            
            MessageBox.Show("A new secret word has been selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void submitGuessBtn_Click(object sender, EventArgs e)
        {
            // Checks if the submitted input has been previously
            // guessed. If so it shows an error and returns.
            // This prevents the guessed letters text box from being
            // filled up with duplicate letters for a cleaner product.
            if (guessedLettersText.Text.Contains(guessText.Text))
            {
                MessageBox.Show("You have already guessed this letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // These statements check the input from the submitted guess.
            // The check finds where the letter should belong in the secret
            // word. If it belongs in the word it changes the appropriate label(s)
            // and sets the guessed character to the guessed letters textbox.
            // A second nested check prevents words that have repeating characters
            // from being placed in the guessed letters textbox more than once.
            // If the guess is incorrect a life is removed, remaining lives is updated
            // and the guessed letter is added to the guessed letters text box.
            
            if (SecretWord.Contains(guessText.Text))
            {
                if(guessText.Text == c1.ToString())
                {
                    c1Guessed = true;
                    letterLabel1.Text = c1.ToString();
                    if (guessedLettersText.Text.Contains(c1.ToString()))
                    {
                        guessedLettersText.Text = guessedLettersText.Text;
                    }
                    else
                    {
                        guessedLettersText.Text += c1.ToString();
                    }                    
                }
                if(guessText.Text == c2.ToString())
                {
                    c2Guessed = true;
                    letterLabel2.Text = c2.ToString();
                    if (guessedLettersText.Text.Contains(c2.ToString()))
                    {
                        guessedLettersText.Text = guessedLettersText.Text;
                    }
                    else
                    {
                        guessedLettersText.Text += c2.ToString();
                    }
                }
                if (guessText.Text == c3.ToString())
                {
                    c3Guessed = true;
                    letterLabel3.Text = c3.ToString();
                    if (guessedLettersText.Text.Contains(c3.ToString()))
                    {
                        guessedLettersText.Text = guessedLettersText.Text;
                    }
                    else
                    {
                        guessedLettersText.Text += c3.ToString();
                    }
                    
                }
                if (guessText.Text == c4.ToString())
                {
                    c4Guessed = true;
                    letterLabel4.Text = c4.ToString();
                    if (guessedLettersText.Text.Contains(c4.ToString()))
                    {
                        guessedLettersText.Text = guessedLettersText.Text;
                    }
                    else
                    {
                        guessedLettersText.Text += c4.ToString();
                    }
                }
                if (guessText.Text == c5.ToString())
                {
                    c5Guessed = true;
                    letterLabel5.Text = c5.ToString();
                    if (guessedLettersText.Text.Contains(c5.ToString()))
                    {
                        guessedLettersText.Text = guessedLettersText.Text;
                    }
                    else
                    {
                        guessedLettersText.Text += c5.ToString();
                    }
                }
                if (guessText.Text == c6.ToString())
                {
                    c6Guessed = true;
                    letterLabel6.Text = c6.ToString();
                    if (guessedLettersText.Text.Contains(c6.ToString()))
                    {
                        guessedLettersText.Text = guessedLettersText.Text;
                    }
                    else
                    {
                        guessedLettersText.Text += c6.ToString();
                    }
                }
            }
            else
            {
                RemainingLives --;
                livesLeft.Text = RemainingLives.ToString();
                guessedLettersText.Text += guessText.Text;
                PictureChange();
            }
            // The following two statements change the state of Won.
            // If all characters are true then won is set to true and
            // a messagebox informs the user of the win and how many lives
            // they had remaining. If RemainingLives reaches 0 then a 
            // messagebox informs the user they have lost and tells them
            // the secret word they were trying to guess.

            if(c1Guessed && c2Guessed && c3Guessed && c4Guessed && c5Guessed && c6Guessed)
            {
                Won = true;
                if (Won)
                {
                    MessageBox.Show("You have correctly guessed the secret word. You had " + RemainingLives.ToString() + " lives remaining.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
            if(RemainingLives == 0)
            {
                livesLabel.ForeColor = Color.Red;
                Won = false;
                MessageBox.Show("You have run out of lives.\nThe secret word was: " + SecretWord + ".", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information);
                submitGuessBtn.Visible = false;                
            }

            // Once the submit button event has run this
            // will reset the guess text box back to blank
            // so the user can input a new guess.

            guessText.Text = "";     

        }

        //*******************************************************
        //**************** Form Closing Event *******************
        //*******************************************************
        private void HangmanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Exit?\nYou will lose any current game progress.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //*******************************************************
        //**************** General Methods **********************
        //*******************************************************
        private void Resetter()
        {
            // This method resets all the variables to their defaults.
            // It also clears all the letters to be guessed back to *.
            // It also resets the Gallows Image back to an empty Gallows.
            letterLabel1.Text = "*";
            letterLabel2.Text = "*";
            letterLabel3.Text = "*";
            letterLabel4.Text = "*";
            letterLabel5.Text = "*";
            letterLabel6.Text = "*";
            guessedLettersText.Text = "";
            RemainingLives = 6;
            livesLeft.Text = RemainingLives.ToString();
            gallowsPictureBox.Image = Properties.Resources.HangmanGallows1;
            livesLabel.ForeColor = Color.Green;
            Won = false;
            c1Guessed = false;
            c2Guessed = false;
            c3Guessed = false;
            c4Guessed = false;
            c5Guessed = false;
            c6Guessed = false;
            
        }
        //*******************************************************
        //**************** Image Control ************************
        //*******************************************************

        private void PictureChange()
        {
            // This controls the picture box for the gallows.
            // As the user loses lives the picture is changed
            // to reflect the classic hangman style.
            // The images are pulled from the project resources folder.
            // All images were created by the developer for this project.            

            if (RemainingLives == 6)
            {
                gallowsPictureBox.Image = Properties.Resources.HangmanGallows1;
            }
            if (RemainingLives == 5)
            {
                gallowsPictureBox.Image = Properties.Resources.HangmanGallows2;
            }
            if (RemainingLives == 4)
            {
                gallowsPictureBox.Image = Properties.Resources.HangmanGallows3;
            }
            if (RemainingLives == 3)
            {
                gallowsPictureBox.Image = Properties.Resources.HangmanGallows4;
            }
            if (RemainingLives == 2)
            {
                gallowsPictureBox.Image = Properties.Resources.HangmanGallows5;
            }
            if (RemainingLives == 1)
            {
                gallowsPictureBox.Image = Properties.Resources.HangmanGallows6;
            }
            if (RemainingLives == 0)
            {
                gallowsPictureBox.Image = Properties.Resources.HangmanGallows7;
            }
        }

        //*******************************************************
        //**************** Input Validation *********************
        //*******************************************************

        // This stops users from inputting anything other than letters
        // in the text box for guesses. It also allows use of the control
        // keys such as backspace, delete, and arrow keys. 
        private void guessText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
        // This stops the user from being able to use any keys in the guessed
        // letters text box. The cursor will exist in the text box if clicked,
        // but there is no control that can be input by the user.
        private void guessedLettersText_KeyPress(object sender, KeyPressEventArgs e)
        {            
            e.Handled = true;
        }
        // This stops the user from being able to use the delete or backspace key
        // to modify the text in the guessedLettersText box. The above statement
        // stops all other meaningful action. Arrow keys can still be used.
        private void guessedLettersText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
            }            
        }
    }
}
