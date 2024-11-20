using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Level_Editor
{
    public partial class EditorForm : Form
    {
        // Fields:        
        protected int numRowBoxes;
        protected int numColumnBoxes;
        protected int totalBoxes;
        protected int boxSize;
        protected List<Button> colorChoice;
        protected List<PictureBox> pictureList;
        protected bool unsavedChanges;
        protected bool isMouseDown;
        protected bool isGrid;
        protected bool isGreen;
        protected bool isPurple;
        protected PictureBox greenBox;
        protected PictureBox purpleBox;

        // Constructors:
        // Constructor for a new Level
        // Loads everything in the level except for picture boxes
        public EditorForm(int height, int width)
        {
            InitializeComponent();

            // Set the fields to their starting values
            numColumnBoxes = height;
            numRowBoxes = width;
            totalBoxes = numRowBoxes * numColumnBoxes;
            boxSize = mapGroupBox.Height / numColumnBoxes;

            // Create a list of the color buttons and hook them up to the same event
            colorChoice = new List<Button>();
            colorChoice.Add(playerColor);
            colorChoice.Add(enemyColor);
            colorChoice.Add(collectibleColor);
            colorChoice.Add(groundColor);
            colorChoice.Add(platformColor);
            colorChoice.Add(finishColor);
            colorChoice.Add(eraser);

            for (int i = 0; i < colorChoice.Count; i++)
            {
                colorChoice[i].Click += ColorClick;
            }

            pictureList = new List<PictureBox>();

            // Will accomodate all of the boxes
            mapGroupBox.Width = numRowBoxes * boxSize + 10;

            // Change the size of the form to show everything
            this.Width += 25;
            this.Height += 200;

            // There are currently 0 unsaved changes
            unsavedChanges = false;

            // Mark grid as on
            isGrid = true;

            // Mark there to be 0 spawn points
            isGreen = false;

            // Mark there are 0 finish lines
            isPurple = false;
        }

        // Creates a new level's pictureBoxes
        private void EditorForm_Load(object sender, EventArgs e)
        {
            // Create all of the pictureBoxes:
            // Create a count of how many pictureBoxes have been created in a row
            int pictureCount = 0;

            // The first coordinates of a picture in the group box will be x = 6 and y = 21
            int buttonX = 6;
            int buttonY = 15;

            // Create all of the picture boxes for the user to create
            for (int i = 0; i < totalBoxes; i++)
            {
                // Create a picture box
                PictureBox p = new PictureBox();

                // Scale the pictureBox size based on how many buttons the user requested
                // Make sure that they are square

                p.Height = boxSize;
                p.Width = boxSize;
                p.BorderStyle = BorderStyle.FixedSingle;
                p.BackColor = Color.White;
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.BackgroundImage = eraser.BackgroundImage;

                // Add the pictureBox to groupBox
                mapGroupBox.Controls.Add(p);

                // Set the current location of the pictureBox and increase the picture count
                p.Location = new Point(buttonX, buttonY);

                // Change the x and y of the button for the future
                // If there are 10 buttons in a row, change it back to 0 and adjust the x and y elements accordingly
                if (pictureCount < numRowBoxes - 1)
                {
                    buttonX += p.Width;
                    pictureCount++;
                }
                else
                {
                    pictureCount = 0;
                    buttonX = 6;
                    buttonY += p.Height;
                }

                // Hook up the pictureBox's click method to PictureClick
                p.MouseDown += Mouse_Down;
                p.MouseEnter += Mouse_Enter;

                // Add the picture box to the list of picture boxes
                pictureList.Add(p);
            }
        }

        // Constructor for a preexisting level loaded from the beginning form
        public EditorForm(string fileName)
        {
            InitializeComponent();
            levelStartHelper(fileName);
        }

        // Methods:
        // Drawing Methods:
        // Changes the current selection based on what color button was pressed
        private void ColorClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                // Cast the sender as a button
                Button b = (Button)sender;

                // Change the current color selection to the color button that was pressed
                currentTile.BackColor = b.BackColor;
                currentTile.BackgroundImage = b.BackgroundImage;
            }
        }

        // Change the color of a picture box based on the current color that has been picked by the user
        private void Mouse_Down(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                // Cast the sender as a picture box
                PictureBox p = (PictureBox)sender;

                p.Capture = false;

                if (p.BackColor != currentTile.BackColor && MouseButtons == MouseButtons.Left)
                {
                    if (currentTile.BackColor == Color.Green)
                    {
                        if (isGreen == true)
                        {
                            DialogResult closingMessage = MessageBox.Show("There is already a spawn point on the map!",
                            "There may only be 1 spawn point on the map at a time.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Change the color of the picture box
                            p.BackColor = currentTile.BackColor;
                            p.BackgroundImage = currentTile.BackgroundImage;

                            if(p.BackColor == Color.Green)
                            {
                                isGreen = true;
                                greenBox = p;
                            }
                        }
                    }
                    else if(currentTile.BackColor == Color.Purple)
                    {
                        if (isPurple == true)
                        {
                            DialogResult closingMessage = MessageBox.Show("There is already an end point on the map!",
                            "There may only be 1 end point on the map at a time.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // Change the color of the picture box
                            p.BackColor = currentTile.BackColor;
                            p.BackgroundImage = currentTile.BackgroundImage;

                            if (p.BackColor == Color.Purple)
                            {
                                isPurple = true;
                                purpleBox = p;
                            }
                        }
                    }
                    else
                    {
                        if(p == greenBox)
                        {
                            greenBox = null;
                            isGreen = false;
                        }
                        else if(p == purpleBox)
                        {
                            purpleBox = null;
                            isPurple = false;
                        }

                        p.BackColor = currentTile.BackColor;
                        p.BackgroundImage = currentTile.BackgroundImage;
                    }

                    // There are now unsaved changes
                    unsavedChanges = true;
                }

                if (unsavedChanges == true)
                {
                    // If the title doesn't already have a *, add it
                    // Avoids * being added when one already has been added

                    if (this.Text.Contains("*") == false)
                    {
                        this.Text += "*";
                    }
                }
            }
        }

        // Allows for click and drag functionality
        private void Mouse_Enter(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                // Cast the sender as a picture box
                PictureBox p = (PictureBox)sender;

                if (MouseButtons == MouseButtons.Left)
                {
                    if(currentTile.BackColor != Color.Green && currentTile.BackColor != Color.Purple)
                    {
                        // Change the color of the picture box
                        p.BackColor = currentTile.BackColor;
                        p.BackgroundImage = currentTile.BackgroundImage;
                    }
                }
            }
        }

        // Turns grid functionality on and off
        private void gridButton_Click(object sender, EventArgs e)
        {
            if (isGrid == true)
            {
                for (int i = 0; i < pictureList.Count; i++)
                {
                    pictureList[i].BorderStyle = BorderStyle.None;
                }

                isGrid = false;
                gridButton.Text = "Turn Grid On";
            }
            else
            {
                for (int i = 0; i < pictureList.Count; i++)
                {
                    pictureList[i].BorderStyle = BorderStyle.FixedSingle;
                }

                isGrid = true;
                gridButton.Text = "Turn Grid Off";
            }
        }


        // Saving Methods and Exitiing Methods:
        // Prompt the user to save the file and write the information to a file
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Create a save file dialog and ask the user where they would like to save their file
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.Title = "Save a Level File";
            fileSave.Filter = "Level Files| *.level";

            // Show the Dialog and allow the user to choose a file
            if (fileSave.ShowDialog() == DialogResult.OK)
            {
                bool savedSuccessfully = true;
                FileStream outStream = null;
                StreamWriter output = null;

                try
                {
                    outStream = File.OpenWrite(fileSave.FileName);
                    output = new StreamWriter(outStream);

                    // Write the height and width to the file
                    output.WriteLine(numRowBoxes);
                    output.WriteLine(numColumnBoxes);
                    output.WriteLine(boxSize);

                    // Write all of the attributes to the file
                    for (int i = 0; i < pictureList.Count; i++)
                    {
                        //output.WriteLine(pictureList[i].BackColor.ToArgb());
                        if (pictureList[i].BackColor == Color.Green)
                        {
                            output.WriteLine('P');
                        }
                        else if (pictureList[i].BackColor == Color.Red)
                        {
                            output.WriteLine('E');
                        }
                        else if (pictureList[i].BackColor == Color.DeepSkyBlue)
                        {
                            output.WriteLine('=');
                        }
                        else if (pictureList[i].BackColor == Color.Goldenrod)
                        {
                            output.WriteLine('C');
                        }
                        else if (pictureList[i].BackColor == Color.SaddleBrown)
                        {
                            output.WriteLine('-');
                        }
                        else if(pictureList[i].BackColor == Color.Purple)
                        {
                            output.WriteLine('X');
                        }
                        else
                        {
                            output.WriteLine('*');
                        }
                    }
                }
                catch (Exception ex)
                {
                    savedSuccessfully = false;

                    DialogResult result = MessageBox.Show(ex.Message,
                    "Error Saving Map", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    output.Close();

                    if (savedSuccessfully == true)
                    {
                        DialogResult result = MessageBox.Show("File Saved Successfully",
                        "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Text = fileSave.FileName;

                        unsavedChanges = false;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("File Saved Unsuccessfully",
                        "File Didn't Saved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Change the text to reflect the file name having no changes to it
                    this.Text = fileSave.FileName;
                }
            }
        }

        // Check if the file has any unsaved changes
        // If so, ask the user if they are sure they want to exit, and cancel exiting if they aren't
        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If the user has unsaved changes, warn them
            if (unsavedChanges == true)
            {
                DialogResult closingMessage = MessageBox.Show("There are unsaved changes, are you sure you want to quit?",
                "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (closingMessage == DialogResult.No)
                {
                    // If the user does not want to quit, stop the closing of the form
                    e.Cancel = true;
                }
            }
        }


        // Loading Methods:
        private void levelStartHelper(string fileName)
        {
            // Leaves a blank slate for the program
            mapGroupBox.Controls.Clear();
            isGreen = false;

            // Read a file and overwrite the blank map
            FileStream inStream = null;
            StreamReader input = null;
            pictureList = new List<PictureBox>();
            this.Text = fileName;

            try
            {
                inStream = File.OpenRead(fileName);
                input = new StreamReader(inStream);

                // The way the file is written, the first three lines are the row count, column count, and box size
                int.TryParse(input.ReadLine(), out numRowBoxes);
                int.TryParse(input.ReadLine(), out numColumnBoxes);
                int.TryParse(input.ReadLine(), out boxSize);

                totalBoxes = numRowBoxes * numColumnBoxes;

                // Read the rest of the remaining picture box data
                string line;
                while ((line = input.ReadLine()) != null)
                {
                    // Create a new Picture box from the written info
                    // Add that picture box to the pictureList
                    PictureBox p = new PictureBox();
                    p.Height = boxSize;
                    p.Width = boxSize;
                    p.BackgroundImageLayout = ImageLayout.Stretch;
                    p.BorderStyle = BorderStyle.FixedSingle;
                    char pColor = Char.Parse(line);


                    switch (pColor)
                    {
                        case 'P':
                            {
                                p.BackColor = Color.Green;
                                p.BackgroundImage = playerColor.BackgroundImage;
                                isGreen = true;
                                greenBox = p;
                                break;
                            }
                        case 'E':
                            {
                                p.BackColor = Color.Red;
                                p.BackgroundImage = enemyColor.BackgroundImage;
                                break;
                            }
                        case '=':
                            {
                                p.BackColor = Color.DeepSkyBlue;
                                p.BackgroundImage = platformColor.BackgroundImage;
                                break;
                            }
                        case 'C':
                            {
                                p.BackColor = Color.Goldenrod;
                                p.BackgroundImage = collectibleColor.BackgroundImage;
                                break;
                            }
                        case '-':
                            {
                                p.BackColor = Color.SaddleBrown;
                                p.BackgroundImage = groundColor.BackgroundImage;
                                break;
                            }
                        case 'X':
                            {
                                p.BackColor = Color.Purple;
                                p.BackgroundImage = finishColor.BackgroundImage;
                                isPurple = true;
                                purpleBox = p;
                                break;
                            }
                        case '*':
                            {
                                p.BackColor = Color.White;
                                p.BackgroundImage = eraser.BackgroundImage;
                                break;
                            }
                    }

                    pictureList.Add(p);

                    // Hook up the pictureBox's click method to PictureClick
                    p.MouseDown += Mouse_Down;
                    p.MouseEnter += Mouse_Enter;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading the file: " + e.Message);
            }
            finally
            {
                if (input != null)
                {
                    input.Close();
                }
            }

            // Now set up the rest of the form
            // Create a list of the color buttons and hook them up to the same event
            colorChoice = new List<Button>();
            colorChoice.Add(playerColor);
            colorChoice.Add(enemyColor);
            colorChoice.Add(collectibleColor);
            colorChoice.Add(groundColor);
            colorChoice.Add(platformColor);
            colorChoice.Add(finishColor);
            colorChoice.Add(eraser);

            for (int i = 0; i < colorChoice.Count; i++)
            {
                colorChoice[i].Click += ColorClick;
            }

            // Will accomodate all of the boxes
            mapGroupBox.Width = numRowBoxes * boxSize + 10;

            // Change the size of the form to show everything
            this.Width += 25;
            this.Height += 100;

            // There are currently 0 unsaved changes
            unsavedChanges = false;

            // Now make the picture boxes on the form
            int pictureCount = 0;
            int buttonX = 6;
            int buttonY = 21;

            for (int i = 0; i < pictureList.Count; i++)
            {
                // Add the pictureBox to groupBox
                mapGroupBox.Controls.Add(pictureList[i]);

                // Set the current location of the pictureBox and increase the picture count
                pictureList[i].Location = new Point(buttonX, buttonY);

                // Change the x and y of the button for the future
                // If there are 10 buttons in a row, change it back to 0 and adjust the x and y elements accordingly
                if (pictureCount < numRowBoxes - 1)
                {
                    buttonX += pictureList[i].Width;
                    pictureCount++;
                }
                else
                {
                    pictureCount = 0;
                    buttonX = 6;
                    buttonY += pictureList[i].Height;
                }
            }

            // let the user know the file has been loaded
            DialogResult result = MessageBox.Show("File Loaded Successfully",
                        "File Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Text = fileName;

            unsavedChanges = false;

            // Mark grid as on
            isGrid = true;
        }

        // Load a preexisting level from the level editor
        private void loadButton_Click(object sender, EventArgs e)
        {
            // Create a new Open File Dialog and customize its properties
            OpenFileDialog fileChoice = new OpenFileDialog();
            fileChoice.Title = "Open a Level File";
            fileChoice.Filter = "Level Files| *.level";
            string fileName = "";

            // Erase everything from the groupBox
            mapGroupBox.Controls.Clear();

            // Show the Dialog and allow the user to choose a file
            if (fileChoice.ShowDialog() == DialogResult.OK)
            {
                fileName = fileChoice.FileName;
            }

            levelStartHelper(fileName);
        }
    }
}
