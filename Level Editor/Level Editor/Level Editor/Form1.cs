using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level_Editor
{
    public partial class LevelEditor : Form
    {
        // Fields:
        int height;
        int width;

        // Constructor:
        public LevelEditor()
        {
            InitializeComponent();
            height = int.Parse(heightText.Text);
            width = int.Parse(widthText.Text);
        }

        private void createMapButton_Click(object sender, EventArgs e)
        {
            // First check to make sure that the input is a number

            if(int.TryParse(heightText.Text, out int tempHeight) == false)
            {
                DialogResult result = MessageBox.Show("Please input a valid integer for height",
                    "Error Creating Map", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.height = tempHeight;
            }

            if(int.TryParse(widthText.Text, out int tempWidth) == false)
            {
                DialogResult result = MessageBox.Show("Please input a valid integer for width",
                    "Error Creating Map", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.width = tempWidth;
            }

            // Next check to make sure that the width and height inputs are within the required value range
            if(height < 0)
            {
                DialogResult result = MessageBox.Show("Please input a valid integer greater than 0 for the height",
                    "Error Creating Map", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (width < 0)
            {
                DialogResult result = MessageBox.Show("Please input a valid integer greater than 0 for the width",
                    "Error Creating Map", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // If everything is correct, create the map
            if(int.TryParse(heightText.Text, out int checkHeight) == true &&
               int.TryParse(widthText.Text, out int checkWidth) == true &&
               width > 0 && height > 0)
            {
                EditorForm ef = new EditorForm(height, width);
                ef.Show();
            }
        }

        private void loadMapButton_Click(object sender, EventArgs e)
        {
            // Create a new Open File Dialog and customize its properties
            OpenFileDialog fileChoice = new OpenFileDialog();
            fileChoice.Title = "Open a Level File";
            fileChoice.Filter = "Level Files| *.level";

            // Show the Dialog and allow the user to choose a file
            if (fileChoice.ShowDialog() == DialogResult.OK)
            {
                EditorForm ef = new EditorForm(fileChoice.FileName);
                ef.Show();
            }
        }
    }
}
