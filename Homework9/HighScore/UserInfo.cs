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
        Dictionary<string, int> highScores = new Dictionary<string, int>();
        public UserInfo()
        {
            InitializeComponent();
        }
        int score = 0;
        internal void LoadOrders(int length)
        {
            score = length-3;
        }


        // Add Name to List View
        private void addPlayerName_Click(object sender, EventArgs e)
        {
            bool validName = true;
            bool validAge = true;
            
            
            if (playerNameTextBox.Text.Equals(""))
            {
                nameError.SetError(playerNameTextBox, "Name can't be empty");
                validName = false;
            }
            if (playerAgeTextBox.Text.Equals("")){
                ageError.SetError(playerAgeTextBox, "Age can't be empty");
                validAge = false;
            }
            
                if (validName == true && validAge == true)
            {

                addName(playerNameTextBox.Text, score);

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
        private void addName(string name, int score)
        {
            playerNameTextBox.Clear();
            playerAgeTextBox.Clear();
            nameError.Clear();
            ageError.Clear();

            if (highScores.ContainsKey(name))
            {
                highScores[name] = score;
            }
            else
            {
                highScores.Add(name, score);
            }
            var list = from pair in highScores orderby pair.Value descending select pair;
            nameListView.Clear();
            scoreListView.Clear();
            foreach(KeyValuePair<string, int> pair in list)
            {
                nameListView.Items.Add("{0}:{1}", pair.Key, pair.Value);
                string intScore = Convert.ToString(pair.Value);
                scoreListView.Items.Add(intScore);
            }
        }



    }
}
