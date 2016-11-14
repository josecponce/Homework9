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
            this.components = new System.ComponentModel.Container();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.addPlayerName = new System.Windows.Forms.Button();
            this.playerListView = new System.Windows.Forms.ListView();
            this.NameColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScoreColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerAgeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AgeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ageError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageError)).BeginInit();
            this.SuspendLayout();
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(103, 25);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(97, 20);
            this.playerNameTextBox.TabIndex = 1;
            this.playerNameTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.playerNameTextBox_MouseMove);
            // 
            // addPlayerName
            // 
            this.addPlayerName.Location = new System.Drawing.Point(232, 48);
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
            this.playerListView.Location = new System.Drawing.Point(12, 152);
            this.playerListView.Name = "playerListView";
            this.playerListView.Size = new System.Drawing.Size(316, 288);
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
            // playerAgeTextBox
            // 
            this.playerAgeTextBox.Location = new System.Drawing.Point(103, 91);
            this.playerAgeTextBox.Name = "playerAgeTextBox";
            this.playerAgeTextBox.Size = new System.Drawing.Size(60, 20);
            this.playerAgeTextBox.TabIndex = 4;
            this.playerAgeTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.playerAgeTextBox_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age";
            // 
            // nameToolTip
            // 
            this.nameToolTip.IsBalloon = true;
            // 
            // AgeToolTip
            // 
            this.AgeToolTip.IsBalloon = true;
            this.AgeToolTip.UseAnimation = false;
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // ageError
            // 
            this.ageError.ContainerControl = this;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 452);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerAgeTextBox);
            this.Controls.Add(this.playerListView);
            this.Controls.Add(this.addPlayerName);
            this.Controls.Add(this.playerNameTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInfo";
            this.Text = "High Score";
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Button addPlayerName;
        private System.Windows.Forms.ListView playerListView;
        public System.Windows.Forms.ColumnHeader NameColum;
        private System.Windows.Forms.ColumnHeader ScoreColumn;
        private System.Windows.Forms.TextBox playerAgeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip nameToolTip;
        private System.Windows.Forms.ToolTip AgeToolTip;
        private System.Windows.Forms.ErrorProvider nameError;
        private System.Windows.Forms.ErrorProvider ageError;
    }
}