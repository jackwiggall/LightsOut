//Group 14: Himanshu Sharma (2417550), Jack Wiggall (2413924), and Sandy Steuart Fothringham (2407175)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media; //sound effects
using WMPLib; //music
using System.IO; //input output

namespace Assignment1V3
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer mPlayer = new WindowsMediaPlayer(); //for music, will probably only work on windows
        bool isPlaying = true;

        int seconds = 0; int minutes = 0; //initialises timer values
        int moves = 0; //initialises 'move' counter
        int size = 5; //initialises default grid size
        bool[,] isYell = new bool[9, 9];

        Label score = new Label(); //timer display
        Label move = new Label(); //move count display
        ListView list = new ListView(); //scoreboard
        Timer time = new Timer(); //timer
        Button[,] btn = new Button[9, 9]; //button grid
        Random r = new Random(); //randomizer
        
        public Form1()
        {
            InitializeComponent();

            //sets up timer text
            score.SetBounds(25, 300, 100, 20);
            score.Text = "Time: 00:00";
            tabPlay.Controls.Add(score);

            //sets up move-counter text
            move.SetBounds(127, 300, 100, 20);
            move.Text = "Moves: 0";
            tabPlay.Controls.Add(move);

            //sets up scoreboard
            list.SetBounds(25, 25, 275, 275);
            tabLeaderboard.Controls.Add(list);
            list.View = View.Details;
            list.Columns.Add("   Time    ", 93, HorizontalAlignment.Center);
            list.Columns.Add("   Moves   ", 91, HorizontalAlignment.Center);
            list.Columns.Add(" Size ", 91, HorizontalAlignment.Center);
            list.BackColor = Color.LightYellow;


            //timer setup
            time.Interval = 1000; //1000ms interval = 1s
            time.Tick += new EventHandler(this.timer1_Tick);
            createGrid(); //loads the grid

            //background music
            mPlayer.URL = "jellyfish.mp3"; //song of choice in the Debug folder
            mPlayer.settings.setMode("loop", true);

            read(); //reads saved scoreboard
        }

        void createGrid()
        {

            int offset = 0; //grid width formula (offset+1)*size
            if (size == 5) //size 5x5
            {
                offset = 55; //total grid 280
            }
            else if (size == 7) //size 7x7
            {
                offset = 39; //total grid 280
            }
            else
            { //size 9x9
                offset = 30; //total grid 279
            }

            //nested loop to set up grid of buttons, dependent on given size
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(25 + (offset * i), 25 + (offset * j), offset + 1, offset + 1); //sets the size of the buttons, dependent on given grid size
                    btn[i, j].BackColor = Color.DarkGray;    // sets colour
                    btn[i, j].Image = Assignment1V3.Properties.Resources.lightOut; //adds lightbulb off image
                    //btn[i, j].BackgroundImageLayout = ImageLayout.Stretch; //resizes image?
                    btn[i, j].Click += new EventHandler(this.btnEvent_Click);
                    tabPlay.Controls.Add(btn[i, j]);
                }
            }

        }

        private void btnEvent_Click(object sender, EventArgs e)
        {

            //following section of code adapted from https://stackoverflow.com/a/31814238
            //sets up the 'light switch' sound effect, taken from https://www.fesliyanstudios.com/royalty-free-sound-effects-download/light-switch-24
            System.Media.SoundPlayer player =
                new System.Media.SoundPlayer();
            player.SoundLocation = "switchSoundV3.wav"; //in debug folder so no pathfinding
            //player.Load();
            player.Play();
            //end section

            //adds 1 move to the move counter
            moves++;
            move.Text = "Moves: " + moves;

            //starts timer once player has made their first move
            //so timer doesnt start as soon as they press restart or new game
            if (moves == 1)
            { 
                time.Enabled = true;
                time.Start();
            }

            //finds which button was pressed
            int px = 0;
            int py = 0;
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if (btn[x, y] == sender)
                    {
                        px = x;
                        py = y;
                        colorFlip(sender, e);
                    }
                }
            }

            //checks if colour-flips next to the clicked button are possible or at edge
            if (px > 0)
            { //left check
                colorFlip(btn[px - 1, py], e);
            }
            if (px < size - 1)
            { //right check
                colorFlip(btn[px + 1, py], e);
            }
            if (py > 0)
            { //down check
                colorFlip(btn[px, py - 1], e);
            }
            if (py < size - 1)
            { //up check
                colorFlip(btn[px, py + 1], e);
            }

            Console.WriteLine("Clicked " + px + "," + py);
            checkDone(); //check if the game has finished

        }

        void checkDone()
        {
            //counts up all buttons which are turned off
            int count = 0;
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++) 
                {
                    if (btn[x, y].BackColor == Color.DarkGray) //'DarkGray' is the goal colour
                    { 
                        count++;
                    }
                }
            }
            //if all buttons are turned off - i.e.: of 'DarkGray' colour - then end the game
            if (count == size * size)
            {
                //stops timer
                time.Stop();
                time.Enabled = false;
                string timeRes; //time result in form 1m02s for display

                //adds the number of minutes taken to 'timeRes'
                string m = minutes.ToString();
                timeRes = m + "m";
                //adds a 0 to the start of minutes for consistency
                if (minutes < 10)
                {
                    m = "0" + minutes.ToString();
                }

                //adds the number of seconds taken to 'timeRes'
                string s = seconds.ToString();
                timeRes += s + "s";
                //adds a 0 to the start of seconds for consistency
                if (seconds < 10)
                {
                    s = "0" + seconds.ToString();
                }

                string sizeG = size + "x" + size; //size of grid
                var newItem = new ListViewItem(new[] { m + ":" + s, moves.ToString(), sizeG }); //newItem to add to scoreboard
                list.Items.Add(newItem); //adds all above data to the scoreboard
                Console.WriteLine("Completed");

                //display end-game message
                DialogResult result;
                result = MessageBox.Show("You finished " + sizeG + " in " + timeRes + " and " + moves.ToString() + " moves.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Save(m, s, moves.ToString(), sizeG); //calls function to save all above data to a file

                //resets move counter and timer
                moves = 0;
                seconds = 0;
                minutes = 0;
            }
        }

        //saves scoreboard to .txt file
        void Save(string m, string s, string moves, string size)
        {

            StreamWriter Writer = new StreamWriter("saves.txt", true);

            Writer.WriteLine(m + ":" + s + "," + moves + "," + size + ",");
            Writer.Close();
        }

        //reads the information from the saves file into the scoreboard
        void read() 
        {
            //loads in a line from the saves file
            String line;
            StreamReader Reader = new StreamReader("saves.txt");
            line = Reader.ReadLine();

            //adds to scoreboard
            while (line != null) //checks to see if the line is empty before proceeding
            {
                string[] words = line.Split(','); //splits the line into time, moves, and grid size
                var newItem = new ListViewItem(new[] { words[0], words[1], words[2] });
                list.Items.Add(newItem);
                line = Reader.ReadLine(); //fetches the next line from the file
            }
            Reader.Close();
        }
        
       
        //flips colour of button of sender
        void colorFlip(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.LightYellow) //is the button that was clicked yellow?
            {                                                    
                ((Button)sender).BackColor = Color.DarkGray;    //if yes, change its colour to dark grey
                ((Button)sender).Image = Assignment1V3.Properties.Resources.lightOut; //and change the image to a switched-off lightbulb
            }
            else
            { 
                ((Button)sender).BackColor = Color.LightYellow; //if no, the colour is dark grey so change it to yellow
                ((Button)sender).Image = Assignment1V3.Properties.Resources.lightOn; //and change the image to a switched-on lightbulb
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxGridSizeSelect.SelectedItem = "5x5"; //sets displayed grid size option in the drop-down list to 5x5 when loading
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); //quits the game
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //displays game credits
            DialogResult result;
            result = MessageBox.Show("Lights Off game by Jack Wiggall, Himanshu Sharma, & Sandy Steuart Fothringham", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBasicInstructions_Click(object sender, EventArgs e)
        {

        }

        //clears the grid for the new size
        void deleteGrid()
        {
            //clears button one by one
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    tabPlay.Controls.Remove(btn[i, j]);
                }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //resets timer and move count
            seconds = 0;
            minutes = 0;
            moves = 0;
            move.Text = "Moves: " + moves;
            score.Text = "Time: 00:00";

            //the following checks if the size changed and resizes the grid if so
            if (comboBoxGridSizeSelect.SelectedItem == "5x5") //the size wanted is 5x5
            {
                if (size != 5) //checks if current grid is not 5x5
                {
                    deleteGrid();
                    size = 5;
                    createGrid(); //need to regen grid
                }
            }
            else if (comboBoxGridSizeSelect.SelectedItem == "7x7") //the size wanted is 7x7
            {
                if (size != 7) //checks if current grid is not 7x7
                {
                    deleteGrid();
                    size = 7;
                    createGrid(); //need to regen grid
                }
            }
            else
            { //the size wanted is 9x9
                if (size != 9) //checks if current grid is not 9x9
                {
                    deleteGrid();
                    size = 9;
                    createGrid(); //need to regen grid
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int result = r.Next(1, 3); //chance of button being lit, (1,2) is guaranted yellow?
                    if (result == 1)
                    {
                        btn[i, j].BackColor = Color.LightYellow; //button is lit
                        btn[i, j].Image = Assignment1V3.Properties.Resources.lightOn;
                        isYell[i, j] = true; //saves for later for if the user restarts the game
                    }
                    else
                    {
                        btn[i, j].BackColor = Color.DarkGray; //button is off
                        btn[i, j].Image = Assignment1V3.Properties.Resources.lightOut;
                        isYell[i, j] = false; //saves for later for if the user restarts the game
                    }
                }
            }

            //stops timer
            time.Stop();
            time.Enabled = false;
        }
        //timer to ticks up
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds += 1;
            if (seconds == 60)
            { //1 minute has passed
                seconds = 0;
                minutes += 1;
            }
            string s = seconds.ToString(); ;
            if (seconds < 10)
            { //adds a 0 to the start of seconds for consistency
                s = "0" + seconds.ToString();
            }
            string m = seconds.ToString();
            if (minutes < 10)
            { //adds a 0 to the start of minutes for consistency
                m = "0" + minutes.ToString();
            }

            updateControls(m, s);
        }

        private void updateControls(string m, string s)
        {   //updates timer
            score.Text = "Time: " + m + ":" + s;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //restarts timer and move count
            seconds = 0;
            minutes = 0;
            moves = 0;
            move.Text = "Moves: " + moves;
            score.Text = "Time: 00:00";

            //restarts/loads previous game if possible, otherwise will be empty grid
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (isYell[i, j] == true)
                    {
                        btn[i, j].BackColor = Color.LightYellow;
                        btn[i, j].Image = Assignment1V3.Properties.Resources.lightOn;
                    }
                    else
                    {
                        btn[i, j].BackColor = Color.DarkGray;
                        btn[i, j].Image = Assignment1V3.Properties.Resources.lightOut;
                    }
                }
            }

            //stops timer
            time.Stop();
            time.Enabled = false;
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //following code section adapted from the question posed in this forum: https://social.msdn.microsoft.com/forums/en-US/e2904da6-48a2-4ce6-97f0-8e1c15729c38/how-to-open-another-form-when-clicking-on-a-button-or-a-link-label-and-close-the-first-form-at-the
            //opens a separate window which displays the full instructions
            InstructionsForm frm = new InstructionsForm();
            frm.Show();
            //end section
        }

        //music toggle function
        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            { //if music is playing stop
                isPlaying = false;
                mPlayer.settings.setMode("loop", false);
                mPlayer.controls.stop();
            }
            else { //no music is playing so start
                isPlaying = true;
                mPlayer.URL = "jellyfish.mp3";
                mPlayer.settings.setMode("loop", true);
                mPlayer.controls.play();
            }
        }
    }
}
