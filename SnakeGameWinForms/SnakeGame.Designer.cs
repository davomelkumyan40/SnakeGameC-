namespace SnakeGameWinForms
{
    partial class SnakeGame
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
            this.score_panel = new System.Windows.Forms.Panel();
            this.lose_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snake = new System.Windows.Forms.PictureBox();
            this.game_panel = new System.Windows.Forms.Panel();
            this.key_Checker = new System.Windows.Forms.Timer(this.components);
            this.score_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snake)).BeginInit();
            this.game_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // score_panel
            // 
            this.score_panel.Controls.Add(this.lose_label);
            this.score_panel.Controls.Add(this.menuStrip1);
            this.score_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.score_panel.Location = new System.Drawing.Point(0, 0);
            this.score_panel.Name = "score_panel";
            this.score_panel.Size = new System.Drawing.Size(600, 100);
            this.score_panel.TabIndex = 0;
            // 
            // lose_label
            // 
            this.lose_label.AutoSize = true;
            this.lose_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lose_label.Location = new System.Drawing.Point(248, 34);
            this.lose_label.Name = "lose_label";
            this.lose_label.Size = new System.Drawing.Size(0, 24);
            this.lose_label.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(102, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.scoresToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // scoresToolStripMenuItem
            // 
            this.scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
            this.scoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scoresToolStripMenuItem.Text = "Scores";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // snake
            // 
            this.snake.BackColor = System.Drawing.Color.Blue;
            this.snake.Enabled = false;
            this.snake.Location = new System.Drawing.Point(0, 0);
            this.snake.Name = "snake";
            this.snake.Size = new System.Drawing.Size(25, 25);
            this.snake.TabIndex = 0;
            this.snake.TabStop = false;
            this.snake.Visible = false;
            // 
            // game_panel
            // 
            this.game_panel.BackColor = System.Drawing.Color.LimeGreen;
            this.game_panel.Controls.Add(this.snake);
            this.game_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game_panel.Location = new System.Drawing.Point(0, 100);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(600, 600);
            this.game_panel.TabIndex = 1;
            // 
            // key_Checker
            // 
            this.key_Checker.Interval = 10;
            this.key_Checker.Tick += new System.EventHandler(this.key_Checker_Tick);
            // 
            // SnakeGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.game_panel);
            this.Controls.Add(this.score_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.score_panel.ResumeLayout(false);
            this.score_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snake)).EndInit();
            this.game_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel score_panel;
        private System.Windows.Forms.PictureBox snake;
        private System.Windows.Forms.Panel game_panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Timer key_Checker;
        private System.Windows.Forms.Label lose_label;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

