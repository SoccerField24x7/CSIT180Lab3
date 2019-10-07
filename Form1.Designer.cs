namespace GolfScores
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
            this.btnDetermineWinner = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddScoreP1 = new System.Windows.Forms.Button();
            this.txtHoleScoreP1 = new System.Windows.Forms.TextBox();
            this.lblHoleNumberP1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstP1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameP1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddScoreP2 = new System.Windows.Forms.Button();
            this.lstP2 = new System.Windows.Forms.ListBox();
            this.txtHoleScoreP2 = new System.Windows.Forms.TextBox();
            this.lblHoleNumberP2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameP2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetermineWinner
            // 
            this.btnDetermineWinner.Location = new System.Drawing.Point(146, 451);
            this.btnDetermineWinner.Name = "btnDetermineWinner";
            this.btnDetermineWinner.Size = new System.Drawing.Size(122, 23);
            this.btnDetermineWinner.TabIndex = 0;
            this.btnDetermineWinner.Text = "Determine Winner";
            this.btnDetermineWinner.UseVisualStyleBackColor = true;
            this.btnDetermineWinner.Click += new System.EventHandler(this.btnDetermineWinner_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddScoreP1);
            this.groupBox1.Controls.Add(this.txtHoleScoreP1);
            this.groupBox1.Controls.Add(this.lblHoleNumberP1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lstP1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNameP1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(33, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 377);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 1";
            // 
            // btnAddScoreP1
            // 
            this.btnAddScoreP1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddScoreP1.Location = new System.Drawing.Point(204, 78);
            this.btnAddScoreP1.Name = "btnAddScoreP1";
            this.btnAddScoreP1.Size = new System.Drawing.Size(75, 23);
            this.btnAddScoreP1.TabIndex = 3;
            this.btnAddScoreP1.Text = "Add Score";
            this.btnAddScoreP1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddScoreP1.UseVisualStyleBackColor = true;
            this.btnAddScoreP1.Click += new System.EventHandler(this.btnAddScoreP1_Click);
            // 
            // txtHoleScoreP1
            // 
            this.txtHoleScoreP1.Location = new System.Drawing.Point(121, 80);
            this.txtHoleScoreP1.Name = "txtHoleScoreP1";
            this.txtHoleScoreP1.Size = new System.Drawing.Size(43, 20);
            this.txtHoleScoreP1.TabIndex = 2;
            // 
            // lblHoleNumberP1
            // 
            this.lblHoleNumberP1.AutoSize = true;
            this.lblHoleNumberP1.Location = new System.Drawing.Point(65, 81);
            this.lblHoleNumberP1.Name = "lblHoleNumberP1";
            this.lblHoleNumberP1.Size = new System.Drawing.Size(19, 13);
            this.lblHoleNumberP1.TabIndex = 4;
            this.lblHoleNumberP1.Text = "18";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hole";
            // 
            // lstP1
            // 
            this.lstP1.FormattingEnabled = true;
            this.lstP1.Location = new System.Drawing.Point(41, 112);
            this.lstP1.Name = "lstP1";
            this.lstP1.Size = new System.Drawing.Size(273, 238);
            this.lstP1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // txtNameP1
            // 
            this.txtNameP1.Location = new System.Drawing.Point(41, 44);
            this.txtNameP1.Name = "txtNameP1";
            this.txtNameP1.Size = new System.Drawing.Size(273, 20);
            this.txtNameP1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddScoreP2);
            this.groupBox2.Controls.Add(this.lstP2);
            this.groupBox2.Controls.Add(this.txtHoleScoreP2);
            this.groupBox2.Controls.Add(this.lblHoleNumberP2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNameP2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(416, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 377);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 2";
            // 
            // btnAddScoreP2
            // 
            this.btnAddScoreP2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddScoreP2.Location = new System.Drawing.Point(207, 77);
            this.btnAddScoreP2.Name = "btnAddScoreP2";
            this.btnAddScoreP2.Size = new System.Drawing.Size(75, 23);
            this.btnAddScoreP2.TabIndex = 9;
            this.btnAddScoreP2.Text = "Add Score";
            this.btnAddScoreP2.UseVisualStyleBackColor = true;
            this.btnAddScoreP2.Click += new System.EventHandler(this.btnAddScoreP2_Click);
            // 
            // lstP2
            // 
            this.lstP2.FormattingEnabled = true;
            this.lstP2.Location = new System.Drawing.Point(44, 112);
            this.lstP2.Name = "lstP2";
            this.lstP2.Size = new System.Drawing.Size(272, 238);
            this.lstP2.TabIndex = 8;
            // 
            // txtHoleScoreP2
            // 
            this.txtHoleScoreP2.Location = new System.Drawing.Point(126, 78);
            this.txtHoleScoreP2.Name = "txtHoleScoreP2";
            this.txtHoleScoreP2.Size = new System.Drawing.Size(43, 20);
            this.txtHoleScoreP2.TabIndex = 7;
            // 
            // lblHoleNumberP2
            // 
            this.lblHoleNumberP2.AutoSize = true;
            this.lblHoleNumberP2.Location = new System.Drawing.Point(73, 79);
            this.lblHoleNumberP2.Name = "lblHoleNumberP2";
            this.lblHoleNumberP2.Size = new System.Drawing.Size(19, 13);
            this.lblHoleNumberP2.TabIndex = 6;
            this.lblHoleNumberP2.Text = "18";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hole";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // txtNameP2
            // 
            this.txtNameP2.Location = new System.Drawing.Point(44, 44);
            this.txtNameP2.Name = "txtNameP2";
            this.txtNameP2.Size = new System.Drawing.Size(272, 20);
            this.txtNameP2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Golf Score-O-Matic";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(697, 451);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(801, 486);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDetermineWinner);
            this.Name = "Form1";
            this.Text = "Golf Score Tracker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetermineWinner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameP1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameP2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddScoreP1;
        private System.Windows.Forms.TextBox txtHoleScoreP1;
        private System.Windows.Forms.Label lblHoleNumberP1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstP2;
        private System.Windows.Forms.TextBox txtHoleScoreP2;
        private System.Windows.Forms.Label lblHoleNumberP2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddScoreP2;
        private System.Windows.Forms.Button btnQuit;
    }
}

