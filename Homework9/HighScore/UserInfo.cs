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
            playerListView.Items.Add(playerNameTextBox.Text);
            playerNameTextBox.Clear();
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
    }
}
