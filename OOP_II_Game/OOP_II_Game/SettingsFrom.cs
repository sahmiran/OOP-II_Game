using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_II_Game.Properties;

namespace OOP_II_Game
{
    public partial class SettingsFrom : Form
    {
        public SettingsFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Difficulty = "";
            string Shape = "";
            string Color = "";

            if (easyCheckBox.Checked) Difficulty = easyCheckBox.Text;
            if(normalCheckBox.Checked) Difficulty = normalCheckBox.Text;
            if(hardCheckBox.Checked) Difficulty = hardCheckBox.Text;

            if(squareCheckBox.Checked) Shape = Shape + squareCheckBox.Text;
            if(triangleCheckBox.Checked) Shape= Shape + "  " + triangleCheckBox.Text;
            if(roundCheckBox.Checked) Shape=Shape + "  " + roundCheckBox.Text;

            if (greenCheckBox.Checked) Color = Color + greenCheckBox.Text;
            if (yellowChecBox.Checked) Color = Color + "  " + yellowChecBox.Text;
            if (redCheckBox.Checked) Color = Color + "  " + redCheckBox.Text;

            Settings.Default["Difficulty"] = Difficulty;
            difficultyLabel.Text = Difficulty;
            Settings.Default["Shape"] = Shape;
            shapeLabel.Text = Shape;
            Settings.Default["Color"] = Color;
            colorLabel.Text = Color;
            Settings.Default.Save();

            
            
        }
    }
}
