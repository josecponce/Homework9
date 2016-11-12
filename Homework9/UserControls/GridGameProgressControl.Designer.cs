namespace Homework9.UserControls
{
    partial class GridGameProgressControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameProgressGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gameProgressGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gameProgressGrid
            // 
            this.gameProgressGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameProgressGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameProgressGrid.Location = new System.Drawing.Point(0, 0);
            this.gameProgressGrid.Name = "gameProgressGrid";
            this.gameProgressGrid.Size = new System.Drawing.Size(635, 199);
            this.gameProgressGrid.TabIndex = 0;
            // 
            // GridGameProgressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gameProgressGrid);
            this.Name = "GridGameProgressControl";
            this.Size = new System.Drawing.Size(635, 199);
            ((System.ComponentModel.ISupportInitialize)(this.gameProgressGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gameProgressGrid;
    }
}
