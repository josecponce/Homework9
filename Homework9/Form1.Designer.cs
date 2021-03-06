﻿namespace Homework9 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.graphGameProgressControl = new Homework9.GraphGameProgressControl();
            this.gridGameProgressControl = new Homework9.UserControls.GridGameProgressControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.pauseGameToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.printScoreToolStripMenuItem,
            this.highScoreToolStripMenuItem,
            this.switchViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(976, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.StartNewGame);
            // 
            // pauseGameToolStripMenuItem
            // 
            this.pauseGameToolStripMenuItem.Name = "pauseGameToolStripMenuItem";
            this.pauseGameToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.pauseGameToolStripMenuItem.Text = "Pause Game";
            this.pauseGameToolStripMenuItem.Click += new System.EventHandler(this.pauseGameToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.saveToolStripMenuItem.Text = "Save Game";
            // 
            // printScoreToolStripMenuItem
            // 
            this.printScoreToolStripMenuItem.Name = "printScoreToolStripMenuItem";
            this.printScoreToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.printScoreToolStripMenuItem.Text = "Print Score";
            this.printScoreToolStripMenuItem.Click += new System.EventHandler(this.printScoreToolStripMenuItem_Click);
            // 
            // highScoreToolStripMenuItem
            // 
            this.highScoreToolStripMenuItem.Name = "highScoreToolStripMenuItem";
            this.highScoreToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.highScoreToolStripMenuItem.Text = "High Score";
            this.highScoreToolStripMenuItem.Click += new System.EventHandler(this.highScoreToolStripMenuItem_Click);
            // 
            // switchViewToolStripMenuItem
            // 
            this.switchViewToolStripMenuItem.Name = "switchViewToolStripMenuItem";
            this.switchViewToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.switchViewToolStripMenuItem.Text = "Switch View";
            this.switchViewToolStripMenuItem.Click += new System.EventHandler(this.switchViewToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(976, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gamePanel.Location = new System.Drawing.Point(16, 153);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(924, 249);
            this.gamePanel.TabIndex = 2;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(17, 43);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(129, 102);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.pictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            this.pictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // graphGameProgressControl
            // 
            this.graphGameProgressControl.Location = new System.Drawing.Point(17, 410);
            this.graphGameProgressControl.Margin = new System.Windows.Forms.Padding(5);
            this.graphGameProgressControl.Name = "graphGameProgressControl";
            this.graphGameProgressControl.Size = new System.Drawing.Size(923, 239);
            this.graphGameProgressControl.TabIndex = 3;
            // 
            // gridGameProgressControl
            // 
            this.gridGameProgressControl.Location = new System.Drawing.Point(17, 410);
            this.gridGameProgressControl.Margin = new System.Windows.Forms.Padding(5);
            this.gridGameProgressControl.Name = "gridGameProgressControl";
            this.gridGameProgressControl.Size = new System.Drawing.Size(923, 238);
            this.gridGameProgressControl.TabIndex = 4;
            this.gridGameProgressControl.Visible = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 676);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.graphGameProgressControl);
            this.Controls.Add(this.gridGameProgressControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Snake Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private GraphGameProgressControl graphGameProgressControl;
        private UserControls.GridGameProgressControl gridGameProgressControl;
        private System.Windows.Forms.ToolStripMenuItem printScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchViewToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

