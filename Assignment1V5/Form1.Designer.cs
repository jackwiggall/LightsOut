
namespace Assignment1V3
{
    partial class Form1
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
            this.tabWindow = new System.Windows.Forms.TabControl();
            this.tabPlay = new System.Windows.Forms.TabPage();
            this.lblBasicInstructions = new System.Windows.Forms.Label();
            this.lblGridSizeSelect = new System.Windows.Forms.Label();
            this.comboBoxGridSizeSelect = new System.Windows.Forms.ComboBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.tabLeaderboard = new System.Windows.Forms.TabPage();
            this.tabMusic = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabWindow.SuspendLayout();
            this.tabPlay.SuspendLayout();
            this.tabMusic.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabWindow
            // 
            this.tabWindow.Controls.Add(this.tabPlay);
            this.tabWindow.Controls.Add(this.tabLeaderboard);
            this.tabWindow.Controls.Add(this.tabMusic);
            this.tabWindow.Location = new System.Drawing.Point(19, 31);
            this.tabWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabWindow.Name = "tabWindow";
            this.tabWindow.SelectedIndex = 0;
            this.tabWindow.Size = new System.Drawing.Size(489, 372);
            this.tabWindow.TabIndex = 0;
            // 
            // tabPlay
            // 
            this.tabPlay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPlay.Controls.Add(this.lblBasicInstructions);
            this.tabPlay.Controls.Add(this.lblGridSizeSelect);
            this.tabPlay.Controls.Add(this.comboBoxGridSizeSelect);
            this.tabPlay.Controls.Add(this.btnRestart);
            this.tabPlay.Controls.Add(this.btnNewGame);
            this.tabPlay.Location = new System.Drawing.Point(4, 22);
            this.tabPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPlay.Name = "tabPlay";
            this.tabPlay.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPlay.Size = new System.Drawing.Size(481, 346);
            this.tabPlay.TabIndex = 0;
            this.tabPlay.Text = "Play";
            // 
            // lblBasicInstructions
            // 
            this.lblBasicInstructions.BackColor = System.Drawing.SystemColors.Info;
            this.lblBasicInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBasicInstructions.Location = new System.Drawing.Point(362, 195);
            this.lblBasicInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasicInstructions.Name = "lblBasicInstructions";
            this.lblBasicInstructions.Size = new System.Drawing.Size(94, 137);
            this.lblBasicInstructions.TabIndex = 4;
            this.lblBasicInstructions.Text = "Clicking on a square will change the colour of itself and its \r\nneighbouring squa" +
    "res. Change all of the squares to grey to win!\r\n";
            this.lblBasicInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBasicInstructions.Click += new System.EventHandler(this.lblBasicInstructions_Click);
            // 
            // lblGridSizeSelect
            // 
            this.lblGridSizeSelect.BackColor = System.Drawing.SystemColors.Info;
            this.lblGridSizeSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGridSizeSelect.Location = new System.Drawing.Point(363, 25);
            this.lblGridSizeSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGridSizeSelect.Name = "lblGridSizeSelect";
            this.lblGridSizeSelect.Size = new System.Drawing.Size(90, 20);
            this.lblGridSizeSelect.TabIndex = 3;
            this.lblGridSizeSelect.Text = "Select Grid Size";
            this.lblGridSizeSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxGridSizeSelect
            // 
            this.comboBoxGridSizeSelect.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxGridSizeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGridSizeSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxGridSizeSelect.FormattingEnabled = true;
            this.comboBoxGridSizeSelect.Items.AddRange(new object[] {
            "5x5",
            "7x7",
            "9x9"});
            this.comboBoxGridSizeSelect.Location = new System.Drawing.Point(363, 44);
            this.comboBoxGridSizeSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxGridSizeSelect.Name = "comboBoxGridSizeSelect";
            this.comboBoxGridSizeSelect.Size = new System.Drawing.Size(90, 21);
            this.comboBoxGridSizeSelect.TabIndex = 2;
            this.comboBoxGridSizeSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.Info;
            this.btnRestart.Location = new System.Drawing.Point(362, 139);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(92, 33);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.Info;
            this.btnNewGame.Location = new System.Drawing.Point(362, 86);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(92, 33);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // tabLeaderboard
            // 
            this.tabLeaderboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabLeaderboard.Location = new System.Drawing.Point(4, 22);
            this.tabLeaderboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabLeaderboard.Name = "tabLeaderboard";
            this.tabLeaderboard.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabLeaderboard.Size = new System.Drawing.Size(481, 346);
            this.tabLeaderboard.TabIndex = 1;
            this.tabLeaderboard.Text = "Scoreboard";
            // 
            // tabMusic
            // 
            this.tabMusic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabMusic.Controls.Add(this.label1);
            this.tabMusic.Controls.Add(this.btnToggle);
            this.tabMusic.Location = new System.Drawing.Point(4, 22);
            this.tabMusic.Name = "tabMusic";
            this.tabMusic.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabMusic.Size = new System.Drawing.Size(481, 346);
            this.tabMusic.TabIndex = 2;
            this.tabMusic.Text = "Music";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 137);
            this.label1.TabIndex = 5;
            this.label1.Text = "Song is Jellyfish by Jason Shaw\r\n\r\nAll music produced by Jason Shaw on Audionauti" +
    "X is released under\r\nCreative Commons Attribution 4.0 International License\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.SystemColors.Info;
            this.btnToggle.Location = new System.Drawing.Point(153, 86);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(161, 42);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.Text = "Toggle Music";
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(534, 437);
            this.Controls.Add(this.tabWindow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(545, 461);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Lights Off";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabWindow.ResumeLayout(false);
            this.tabPlay.ResumeLayout(false);
            this.tabMusic.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabWindow;
        private System.Windows.Forms.TabPage tabPlay;
        private System.Windows.Forms.TabPage tabLeaderboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ComboBox comboBoxGridSizeSelect;
        private System.Windows.Forms.Label lblGridSizeSelect;
        private System.Windows.Forms.Label lblBasicInstructions;
        private System.Windows.Forms.TabPage tabMusic;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Label label1;
    }
}

