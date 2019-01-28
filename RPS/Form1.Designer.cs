namespace RPS
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
            this.scissors = new System.Windows.Forms.PictureBox();
            this.paper = new System.Windows.Forms.PictureBox();
            this.rock = new System.Windows.Forms.PictureBox();
            this.playerPic = new System.Windows.Forms.PictureBox();
            this.compPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.compScore = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compPic)).BeginInit();
            this.SuspendLayout();
            // 
            // scissors
            // 
            this.scissors.ErrorImage = null;
            this.scissors.Image = global::RPS.Properties.Resources.Scissors;
            this.scissors.InitialImage = null;
            this.scissors.Location = new System.Drawing.Point(12, 206);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(119, 83);
            this.scissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scissors.TabIndex = 1;
            this.scissors.TabStop = false;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // paper
            // 
            this.paper.ErrorImage = null;
            this.paper.Image = global::RPS.Properties.Resources.Paper;
            this.paper.InitialImage = null;
            this.paper.Location = new System.Drawing.Point(12, 117);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(119, 83);
            this.paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paper.TabIndex = 1;
            this.paper.TabStop = false;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // rock
            // 
            this.rock.ErrorImage = null;
            this.rock.Image = global::RPS.Properties.Resources.Rock;
            this.rock.InitialImage = null;
            this.rock.Location = new System.Drawing.Point(12, 28);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(119, 83);
            this.rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock.TabIndex = 1;
            this.rock.TabStop = false;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // playerPic
            // 
            this.playerPic.Location = new System.Drawing.Point(272, 28);
            this.playerPic.Name = "playerPic";
            this.playerPic.Size = new System.Drawing.Size(119, 83);
            this.playerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPic.TabIndex = 2;
            this.playerPic.TabStop = false;
            // 
            // compPic
            // 
            this.compPic.Location = new System.Drawing.Point(272, 206);
            this.compPic.Name = "compPic";
            this.compPic.Size = new System.Drawing.Size(119, 83);
            this.compPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.compPic.TabIndex = 3;
            this.compPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "VS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // compScore
            // 
            this.compScore.AutoSize = true;
            this.compScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compScore.Location = new System.Drawing.Point(267, 305);
            this.compScore.Name = "compScore";
            this.compScore.Size = new System.Drawing.Size(25, 25);
            this.compScore.TabIndex = 7;
            this.compScore.Text = "0";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.Location = new System.Drawing.Point(366, 305);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(25, 25);
            this.playerScore.TabIndex = 7;
            this.playerScore.Text = "0";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(13, 306);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(118, 23);
            this.Reset.TabIndex = 8;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "You";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Computer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 352);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.compScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compPic);
            this.Controls.Add(this.playerPic);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.scissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox rock;
        private System.Windows.Forms.PictureBox paper;
        private System.Windows.Forms.PictureBox scissors;
        private System.Windows.Forms.PictureBox playerPic;
        private System.Windows.Forms.PictureBox compPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label compScore;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

