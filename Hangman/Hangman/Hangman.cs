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
        int Hints = 0;        

        public HangmanForm()
        {
            InitializeComponent();
            submitGuessBtn.Visible = false;
            hintBtn.Visible = false;
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

        // Button click for starting a new game
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
            hintBtn.Visible = true;

            MessageBox.Show("A new secret word has been selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Button click event for submitting a guessed letter
        private void submitGuessBtn_Click(object sender, EventArgs e)
        {
            // Checks if the user has input anything in the text box
            // to submit a guess. If not, warns them that nothing is in
            // text box. 
            if (string.IsNullOrEmpty(guessText.Text))
            {
                MessageBox.Show("Please enter a letter to guess in the text box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
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
            // Check if the submitted guess triggered a game win.

            GameWon();

             //Check if remaining lives has reached zero. If so game loss
             //is triggered.
             
            if (RemainingLives == 0)
            {
                livesLabel.ForeColor = Color.Red;
                Won = false;
                MessageBox.Show("You have run out of lives.\nThe secret word was: " + SecretWord + "." + "\nYou used " + Hints.ToString() + " hints.", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information);
                submitGuessBtn.Visible = false;
                hintBtn.Visible = false;
            }

            // Once the submit button event has run this
            // will reset the guess text box back to blank
            // so the user can input a new guess.

            guessText.Text = "";     

        }

        // Button click for receiving a hint
        private void hintBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want the next character revealed?", "Hint", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                // If Hint is pressed and C1 has not been guessed it will be filled.
                if (c1Guessed == false)
                {
                    letterLabel1.Text = c1.ToString();
                    c1Guessed = true;
                    Hints++;                   

                    // If C1 is the first hint and the same letter belongs to 
                    // another character it will also be filled and set true.
                        if (c1 == c2)
                        {
                            letterLabel2.Text = c2.ToString();
                            c2Guessed = true;
                            Hints++;
                        }
                        if (c1 == c3)
                        {
                            letterLabel3.Text = c3.ToString();
                            c3Guessed = true;
                            Hints++;
                        }
                        if (c1 == c4)
                        {
                            letterLabel4.Text = c4.ToString();
                            c4Guessed = true;
                            Hints++;
                        }
                        if (c1 == c5)
                        {
                            letterLabel5.Text = c5.ToString();
                            c5Guessed = true;
                            Hints++;
                        }
                        if (c1 == c6)
                        {
                            letterLabel6.Text = c6.ToString();
                            c6Guessed = true;
                            Hints++;
                        }
                    // Check if the hint triggered a win.
                    GameWon();
                    // Hint letters are added to the Guessed Text Box
                    if (guessedLettersText.Text.Contains(c1.ToString()))
                    {
                        guessedLettersText.Text = guessedLettersText.Text;
                    }
                    else
                    {
                        guessedLettersText.Text += c1.ToString();
                    }
                }
                
                else if (c2Guessed == false)
                {
                    // If hint is pressed and C1 is filled but C2 is not C2 will be filled.
                    letterLabel2.Text = c2.ToString();
                    c2Guessed = true;
                    Hints++;
                    
                    // If C2 is the first hint and the same letter belongs to 
                    // another character it will also be filled and set true.
                        
                        if (c2 == c3)
                        {
                            letterLabel3.Text = c3.ToString();
                            c3Guessed = true;
                            Hints++;
                        }
                        if (c2 == c4)
                        {
                            letterLabel4.Text = c4.ToString();
                            c4Guessed = true;
                            Hints++;
                        }
                        if (c2 == c5)
                        {
                            letterLabel5.Text = c5.ToString();
                            c5Guessed = true;
                            Hints++;
                        }
                        if (c2 == c6)
                        {
                            letterLabel6.Text = c6.ToString();
                            c6Guessed = true;
                            Hints++;
                        }
                    // Check if the hint triggered a game win.

                    GameWon();

                    // Hint letters are added to the Guessed Letters Text Box
                    if (guessedLettersText.Text.Contains(c2.ToString()))
                    {
                        guessedLettersText.Text = guessedLettersText.Text;
                    }
                    else
                    {
                        guessedLettersText.Text += c2.ToString();
                    }
                }
                else if (c3Guessed == false)
                {
                    letterLabel3.Text = c3.ToString();
                    c3Guessed = true;
                    Hints++;

                    // If C3 is the first hint and the same letter belongs to 
                    // another character it will also be filled and set true.
                        
                        if (c3 == c4)
                        {
                            letterLabel4.Text = c4.ToString();
                            c4Guessed = true;
                            Hints++;
                        }
                        if (c3 == c5)
                        {
                            letterLabel5.Text = c5.ToString();
                            c5Guessed = true;
                            Hints++;
                        }
                        if (c3 == c6)
                        {
                            letterLabel6.Text = c6.ToString();
                            c6Guessed = true;
                            Hints++;
                        }
                    // Check if the hint triggered a game win.

                    GameWon();

                    // Hint letters are added to the Guessed Letters Text Box
                    if (guessedLettersText.Text.Contains(c3.ToString()))
                    {
                        guessedLettersText.Text = guessedLettersText.Text;
                    }
                    else
                    {
                        guessedLettersText.Text += c3.ToString();
                    }
                }
                else if (c4Guessed == false)
                {
                    letterLabel4.Text = c4.ToString();
                    c4Guessed = true;
                    Hints++;

                    // If C4 is the first hint and the same letter belongs to 
                    // another character it will also be filled and set true.
                        
                        if (c4 == c5)
                        {
                            letterLabel5.Text = c5.ToString();
                            c5Guessed = true;
                            Hints++;
                        }
                        if (c4 == c6)
                        {
                            letterLabel6.Text = c6.ToString();
                            c6Guessed = true;
                            Hints++;
                        }
                    // Check if a hint triggered a game win.

                    GameWon();

                    // Hint letters are added to the Guessed Letters Text Box
                    if (guessedLettersText.Text.Contains(c4.ToString()))
                    {
                        guessedLettersText.Text = guessedLettersText.Text;
                    }
                    else
                    {
                        guessedLettersText.Text += c4.ToString();
                    }
                }
                else if (c5Guessed == false)
                {
                    letterLabel5.Text = c5.ToString();
                    c5Guessed = true;
                    Hints++;

                    // If C5 is the first hint and the same letter belongs to 
                    // another character it will also be filled and set true.
                    
                        if (c5 == c6)
                        {
                            letterLabel6.Text = c6.ToString();
                            c6Guessed = true;
                            Hints++;
                        }

                    // Check if a hint triggered a game win.

                    GameWon();

                    // Hint letters are added to the Guessed Letters Text Box
                    
                    if (guessedLettersText.Text.Contains(c5.ToString()))
                    {
                        guessedLettersText.Text = guessedLettersText.Text;
                    }
                    else
                    {
                        guessedLettersText.Text += c5.ToString();
                    }
                }
                // If hints = 5 then no other hints can be given. There is no hint key for C6
                // if C6 is ever the next available character it will be the only character
                // left hidden so it's not given away to make the player guess at least 1 character.
                // The player can have no more than 5 hints. 
                if (Hints == 5)
                {
                    hintBtn.Visible = false;
                }
                // If C1 thru C5 are already guessed the hints button goes away.
                // This makes the user solve at least one letter on their own.
                if (c1Guessed && c2Guessed && c3Guessed && c4Guessed && c5Guessed)
                {
                    hintBtn.Visible = false;
                }
            }
            //if (dialog == DialogResult.No)
            //{
                //Nothing needs to be here for this to function. It's just here because No was an option.
            //}
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
            Hints = 0;
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

        private void GameWon()
        {
            // This method checks if the game win state has been met.
            // If It has been met the game win is triggered.
            // If it hasn't nothing happens. 
            if (c1Guessed && c2Guessed && c3Guessed && c4Guessed && c5Guessed && c6Guessed)
            {
                Won = true;
                if (Won)
                {
                    MessageBox.Show("You have correctly guessed the secret word.\nYou had " + RemainingLives.ToString() + " lives remaining." + " You used " + Hints.ToString() + " hints.", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    submitGuessBtn.Visible = false;
                    hintBtn.Visible = false;
                }               
            }
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

        //*******************************************************
        //**************** Keypress Events *********************
        //*******************************************************

        // This event allows the user to press Enter in the guess text box
        // to trigger the submit button without needing to click it manually.        
        private void guessText_KeyDown(object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
            {
                submitGuessBtn.PerformClick();
            }            
        }
    }
}