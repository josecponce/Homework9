namespace Homework9.Forms
{
    partial class UserInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.enterName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addPlayerName = new System.Windows.Forms.Button();
            this.HighScoreView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(29, 47);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.playerNameTextBox.TabIndex = 3;
            // 
            // enterName
            // 
            this.enterName.AutoSize = true;
            this.enterName.Location = new System.Drawing.Point(103, 9);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(63, 13);
            this.enterName.TabIndex = 5;
            this.enterName.Text = "Enter Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "High Score";
            // 
            // addPlayerName
            // 
            this.addPlayerName.Location = new System.Drawing.Point(181, 47);
            this.addPlayerName.Name = "addPlayerName";
            this.addPlayerName.Size = new System.Drawing.Size(75, 23);
            this.addPlayerName.TabIndex = 7;
            this.addPlayerName.Text = "Add Name";
            this.addPlayerName.UseVisualStyleBackColor = true;
            this.addPlayerName.Click += new System.EventHandler(this.addPlayerName_Click);
            // 
            // HighScoreView
            // 
            this.HighScoreView.Location = new System.Drawing.Point(12, 125);
            this.HighScoreView.Name = "HighScoreView";
            this.HighScoreView.Size = new System.Drawing.Size(261, 392);
            this.HighScoreView.TabIndex = 8;
            this.HighScoreView.UseCompatibleStateImageBehavior = false;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 529);
            this.Controls.Add(this.HighScoreView);
            this.Controls.Add(this.addPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterName);
            this.Controls.Add(this.playerNameTextBox);
            this.Name = "UserInfo";
            this.Text = "User Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label enterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPlayerName;
        private System.Windows.Forms.ListView HighScoreView;
    }
}