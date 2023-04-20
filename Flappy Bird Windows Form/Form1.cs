//Joshua Roasa, CPS*3330*01
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Flappy_Bird_Windows_Form
{
    public partial class Form1 : Form
    {

        // Variables start here
        int pipeSpeed = 5; // default pipe speed defined with an integer
        int gravity = 15; // default gravity speed defined with an integer
        int score = 0; // default score integer set to 0
        Random rand = new Random(); // create a new instance of the Random class
        bool gameStarted = false; // set gameStarted flag to false initially
        private bool birdPassedPipes = false; // create a new boolean flag for whether the bird has passed the pipes
        private int currentScore = 0; // create a new integer variable to keep track of the current score
        private int highScore = 0; // create a new integer variable to keep track of the high score

        bool gameOver = false; // set gameOver flag to false initially

        SoundPlayer hitSound; // create a new SoundPlayer instance for the hit sound effect
        SoundPlayer wingSound; // create a new SoundPlayer instance for the wing sound effect
        SoundPlayer pointSound; // create a new SoundPlayer instance for the point sound effect

        // variable ends
        public Form1()
        {
            InitializeComponent(); // call the InitializeComponent method to initialize the form
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            // Move the bird downwards
            flappyBird.Top += gravity;

            // Move the pipes towards the left
            pipeBottom1.Left -= pipeSpeed;
            pipeTop1.Left -= pipeSpeed;

            // Check if the bird has passed the pipes
            if (!birdPassedPipes && flappyBird.Right > pipeBottom1.Left)
            {
                pointSound = new SoundPlayer(@"sfx_point.wav"); // create a new instance of the SoundPlayer for the point sound effect
                score++; // increase the score
                birdPassedPipes = true; // set the birdPassedPipes flag to true
                scoreText.Text = "Score: " + score; // update the score text label
                pointSound.Play(); // play the point sound effect

                // Increase pipe speed every 5 points
                if (score % 5 == 0)
                {
                    pipeSpeed += 5;
                }
            }

            // Reset the birdPassedPipes flag if the bird is before the pipes again
            if (flappyBird.Right < pipeBottom1.Left)
            {
                birdPassedPipes = false; // set the birdPassedPipes flag to false
            }

            // If the pipes have left the screen, move them back to the right
            if (pipeBottom1.Right < 0)
            {
                // Generate a new random height for the top pipe
                int newPipeTopHeight = rand.Next(15, 300); // generate a random integer between 15 and 300 (exclusive)

                // Set the position and height of the top pipe
                pipeTop1.Top = newPipeTopHeight - pipeTop1.Height;

                // Set the position and height of the bottom pipe
                int pipeGap = 200; // define the gap between the top and bottom pipes
                int newPipeBottomTop = newPipeTopHeight + pipeGap;
                pipeBottom1.Top = newPipeBottomTop;
                pipeBottom1.Height = this.ClientSize.Height - newPipeBottomTop;
                pipeBottom1.Left = 399;
                pipeTop1.Left = 399;
            }

            // Check for collisions with the pipes or ground
            if (flappyBird.Bounds.IntersectsWith(pipeBottom1.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop1.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < -25)
            {
                endGame(); // end the game
                birdPassedPipes = false; // reset the variable

            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            //wingSound = new SoundPlayer(@"sfx_wing.wav");
            if (e.KeyCode == Keys.Space) // check if the space bar is pressed
            {

                if (!gameStarted) // check if the game has started
                {
                    startLabel.Visible = false; // hide the start label
                    gameStarted = true; // indicate that the game has started
                    gameTimer.Start(); // start the game timer
                }
                gravity = -15; // apply upward force to Flappy Bird
               //wingSound.Play(); // play the wing sound effect

            }
        }
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // check if the space bar is released
            {
                gravity = 9; // reset the gravity to simulate downward force on Flappy Bird
            }

            if (e.KeyCode == Keys.R && gameOver) // check if the game is over and the 'R' key is pressed
            {
                //run the restart function
                RestartGame(); // restart the game
            }
        }


        private void endGame()
        {
            gameTimer.Stop(); // stop the game timer
            currentScore = score; // set the current score to the final score achieved
            hitSound = new SoundPlayer(@"sfx_hit.wav"); // create a sound player object for the hit sound effect
            if (currentScore > highScore) // check if the current score is greater than the high score
            {
                highScore = currentScore; // set the high score to the current score
            }
            scoreText.Text = "Score: " + currentScore + "   \nHigh Score: " + highScore + "   \nPress R to restart"; // update the score text to display the current score and high score

            gameOver = true; // indicate that the game has ended
            hitSound.Play(); // play the hit sound effect
            CreatorText.Text = "by Joshua Roasa, CPS*3330*01, 04/20/2023"; // display the creator information

        }
        private void RestartGame()
        {
            gameOver = false; // indicate that the game has not ended
            flappyBird.Location = new Point(126, 325); // reset the position of Flappy Bird
            pipeTop1.Left = 800; // reset the position of the top pipe
            pipeBottom1.Left = 800; // reset the position of the bottom pipe
            score = 0; // reset the score to 0
            pipeSpeed = 5; // reset the pipe speed to the original value
            scoreText.Text = "Score: 0"; // update the score text to display the current score
            gameTimer.Start(); // start the game timer
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            startLabel.Text = "Press Space to start"; // Set the text of the start label to "Press Space to start"
            startLabel.Visible = true; // Make the start label visible to the user

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pipeBottom1_Click(object sender, EventArgs e)
        {

        }

        private void startLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}