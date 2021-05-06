using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


using System.Windows.Threading;

namespace Flappy_bird_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Adds a new DispatcherTimer named gameTimer
        DispatcherTimer gameTimer = new DispatcherTimer();

        //Variabels set
        double score;
        int gravity = 8;
        bool gameOver;
        Rect flappyBirdHitBox;


        /// <summary>
        /// This method starts a timer which is what gives images the option to move by a time perspective. It then starts the game
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            gameTimer.Tick += MainEventTimer;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            StartGame();

        }

        /// <summary>
        /// This is main method where score is set and which also makes the canvas move (pipes, clouds and bird). It also checks if the bird is touching any pipe and
        /// this is what moves the images with the help of the gameTimer. This method sets the score when a pipe goes to the left of the screen and then move that pipe 
        /// to the far right so the game can be endless. This method also checks if the game should end for exampel if the bird touches a pipe. 
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Event checker</param>
        private void MainEventTimer(object sender, EventArgs e)
        {
            txtScore.Content = "Score " + score;

            flappyBirdHitBox = new Rect(Canvas.GetLeft(flappyBird), Canvas.GetTop(flappyBird), flappyBird.Width - 8, flappyBird.Height - 30);

            Canvas.SetTop(flappyBird, Canvas.GetTop(flappyBird) + gravity);

            //This if statement checks if the bird is touching the bottom or top and if it does, the game ends. 
            if (Canvas.GetTop(flappyBird) < - 10 || Canvas.GetTop(flappyBird) > 458)
            {
                EndGame();
            }

            //This loops the images in the canvas
            foreach (var x in MyCanvas.Children.OfType<Image>())
            {
                //Checks if any of the obstacles has passed to the left of the screen and then moves them to the right again and gives the player 0,5 score
                //per pipe and since 2 pipes just passed the player gets 1 score
                if ((string)x.Tag == "obs1" || (string)x.Tag == "obs2" || (string)x.Tag == "obs3")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 5);

                    if (Canvas.GetLeft(x) < - 100)
                    {

                        Canvas.SetLeft(x, 800);

                        score += .5;
                    }

                    //Gets the hitbox for the pipe and makes it the height and width of the pipe
                    Rect pipeHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

                    //Checks if the bird is touching the pipe and if it does, jumps to EndGame method
                    if (flappyBirdHitBox.IntersectsWith(pipeHitBox))
                    {
                        EndGame();

                    }

                }

                //Cheks if the clouds passed to the left of the screen and moves them back to the right
                if ((string)x.Tag == "cloud")
                {

                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 2);

                    if (Canvas.GetLeft(x) < -250)
                    {
                        Canvas.SetLeft(x, 550);


                    }

                }


            }


        }


        /// <summary>
        /// This method checks if the space key is pressed down so it can determine if the bird should move up or down. This method also checks the "R" key so the
        /// game can restart
        /// </summary>
        /// <param name="sender">This is the object that is being sent by the user in the program</param>
        /// <param name="e">This is the event for exampel a key press</param>
        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            //Checks if space key is pressed down and changes the birds rotation, e is the event key
            if (e.Key == Key.Space)
            {
                flappyBird.RenderTransform = new RotateTransform(-20, flappyBird.Width /2, flappyBird.Height /2);
                gravity = -8;

            }

            //Same here as the if statement above, but checks if the R key is pressed and that gameOver equals true, will then go to the StartGame method
            if (e.Key == Key.R && gameOver == true)
            {
                StartGame();

            }


        }


        /// <summary>
        /// This method only checks if the space key is released and than rotates the bird to look down
        /// </summary>
        /// <param name="sender">Sends the obeject as the method above this but when the key is released</param>
        /// <param name="e">this is the event key</param
        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            flappyBird.RenderTransform = new RotateTransform(5, flappyBird.Width / 2, flappyBird.Height / 2);
            gravity = 8;

        }


        /// <summary>
        /// The StartGame method set some variabels to 0 and moves the pipes to their original position. It also starts the gameTimer
        /// </summary>
        private void StartGame()
        {

            MyCanvas.Focus();

            int temp = 300;

            score = 0;

            gameOver = false;
            Canvas.SetTop(flappyBird, 190);


            //loops thru if statements in the canvas that first checks the obstacle and then moves different obstacels and clouds to their 
            //original/correct position
            foreach (var x in MyCanvas.Children.OfType<Image>())
            {

                if ((string)x.Tag == "obs1")
                {
                    Canvas.SetLeft(x, 500);
                }

                if ((string)x.Tag == "obs2")
                {
                    Canvas.SetLeft(x, 800);
                }

                if ((string)x.Tag == "obs3")
                {
                    Canvas.SetLeft(x, 1100);
                }

                if ((string)x.Tag == "cloud")
                {
                    Canvas.SetLeft(x, 300 + temp);
                    temp = 800;
                }

                gameTimer.Start();

            }


        }


        /// <summary>
        /// The final method, the EndGame method stops the gameTimer so that everything stops moving. It also asks the player if he/she wants to play again by pressing "R"
        /// </summary>
        private void EndGame()
        {

            gameTimer.Stop();
            gameOver = true;
            txtScore.Content += " Game over !! Press R to try again";

        }


    }
}
