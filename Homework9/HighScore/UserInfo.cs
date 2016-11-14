using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework9.HighScore
{
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        // Add Name to List View
        private void addPlayerName_Click(object sender, EventArgs e)
        {
            bool validName = true;
            bool validAge = true;
            if(playerNameTextBox.Text.Equals("")){
                nameError.SetError(playerNameTextBox, "Name can't be empty");
                validName = false;
            }
            int age = Convert.ToInt32(playerAgeTextBox.Text);

            if (playerAgeTextBox.Text.Equals("")){
                ageError.SetError(playerAgeTextBox, "Age can't be empty");
                validAge = false;
            }
            

                if (validName == true && validAge == true)
            {
                playerListView.Items.Add(playerNameTextBox.Text, playerAgeTextBox.Text);
                playerNameTextBox.Clear();
                playerAgeTextBox.Clear();
                nameError.Clear();
                ageError.Clear();
            }
            
         }

        //Cut, Copy, Paste
        private void Menu_Cut(Object sender, EventArgs e)
        {
            if (playerNameTextBox.SelectedText != "")
                playerNameTextBox.Cut();
        }
        private void Menu_Copy(Object sender, EventArgs e)
        {
            if (playerNameTextBox.SelectionLength > 0)
                playerNameTextBox.Copy();
        }
        private void Menu_Paste(Object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
                playerNameTextBox.Paste();
        }

        private void playerNameTextBox_MouseMove(Object sender, MouseEventArgs e)
        {
            nameToolTip.SetToolTip(playerNameTextBox, "Enter Your Name");
        }
        private void playerAgeTextBox_MouseMove(Object sender, MouseEventArgs e)
        {
            AgeToolTip.SetToolTip(playerAgeTextBox, "Enter Your Age");
        }
  
    }
}
