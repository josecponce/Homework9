namespace Homework9.HighScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.addPlayerName = new System.Windows.Forms.Button();
            this.playerListView = new System.Windows.Forms.ListView();
            this.NameColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScoreColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(23, 50);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.playerNameTextBox.TabIndex = 1;
            // 
            // addPlayerName
            // 
            this.addPlayerName.Location = new System.Drawing.Point(188, 47);
            this.addPlayerName.Name = "addPlayerName";
            this.addPlayerName.Size = new System.Drawing.Size(75, 23);
            this.addPlayerName.TabIndex = 2;
            this.addPlayerName.Text = "Add";
            this.addPlayerName.UseVisualStyleBackColor = true;
            this.addPlayerName.Click += new System.EventHandler(this.addPlayerName_Click);
            // 
            // playerListView
            // 
            this.playerListView.BackgroundImageTiled = true;
            this.playerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColum,
            this.ScoreColumn});
            this.playerListView.LabelWrap = false;
            this.playerListView.Location = new System.Drawing.Point(12, 93);
            this.playerListView.Name = "playerListView";
            this.playerListView.Size = new System.Drawing.Size(316, 347);
            this.playerListView.TabIndex = 3;
            this.playerListView.UseCompatibleStateImageBehavior = false;
            this.playerListView.View = System.Windows.Forms.View.List;
            // 
            // NameColum
            // 
            this.NameColum.Text = "Name";
            // 
            // ScoreColumn
            // 
            this.ScoreColumn.Text = "Score";
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 452);
            this.Controls.Add(this.playerListView);
            this.Controls.Add(this.addPlayerName);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInfo";
            this.Text = "High Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Button addPlayerName;
        private System.Windows.Forms.ListView playerListView;
        public System.Windows.Forms.ColumnHeader NameColum;
        private System.Windows.Forms.ColumnHeader ScoreColumn;
    }
}