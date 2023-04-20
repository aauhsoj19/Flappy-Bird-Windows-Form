namespace Flappy_Bird_Windows_Form
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
            this.components = new System.ComponentModel.Container();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop1 = new System.Windows.Forms.PictureBox();
            this.pipeBottom1 = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.startLabel = new System.Windows.Forms.Label();
            this.CreatorText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(126, 325);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(50, 38);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-1, 613);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1609, 79);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // pipeTop1
            // 
            this.pipeTop1.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipedown;
            this.pipeTop1.Location = new System.Drawing.Point(399, -108);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(57, 324);
            this.pipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop1.TabIndex = 2;
            this.pipeTop1.TabStop = false;
            // 
            // pipeBottom1
            // 
            this.pipeBottom1.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipe;
            this.pipeBottom1.Location = new System.Drawing.Point(399, 422);
            this.pipeBottom1.Name = "pipeBottom1";
            this.pipeBottom1.Size = new System.Drawing.Size(57, 303);
            this.pipeBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom1.TabIndex = 3;
            this.pipeBottom1.TabStop = false;
            this.pipeBottom1.Click += new System.EventHandler(this.pipeBottom1_Click);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(92, -4);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(178, 46);
            this.scoreText.TabIndex = 8;
            this.scoreText.Text = "Score: 0";
            this.scoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(49, 244);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(407, 46);
            this.startLabel.TabIndex = 9;
            this.startLabel.Text = "Press Space to Start";
            this.startLabel.Click += new System.EventHandler(this.startLabel_Click);
            // 
            // CreatorText
            // 
            this.CreatorText.AutoSize = true;
            this.CreatorText.BackColor = System.Drawing.Color.Wheat;
            this.CreatorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatorText.Location = new System.Drawing.Point(12, 648);
            this.CreatorText.Name = "CreatorText";
            this.CreatorText.Size = new System.Drawing.Size(0, 20);
            this.CreatorText.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(508, 692);
            this.Controls.Add(this.CreatorText);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.pipeBottom1);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game - Joshua Roasa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeTop1;
        private System.Windows.Forms.PictureBox pipeBottom1;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label CreatorText;
    }
}

