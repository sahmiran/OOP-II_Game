using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_II_Game.Properties;

namespace OOP_II_Game
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();

        }

        private void userSettingsButton_Click(object sender, EventArgs e)
        {
            SettingsFrom settingsFrom = new SettingsFrom();
            this.Hide();
            settingsFrom.Show();
        }

        private void userExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
