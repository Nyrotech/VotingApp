namespace VotingApplication
{
    partial class Vote
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
            this.Count1 = new System.Windows.Forms.Label();
            this.Votes1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Vote1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.Votes2 = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.TextBox();
            this.Option2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Count1
            // 
            this.Count1.AutoSize = true;
            this.Count1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count1.Location = new System.Drawing.Point(137, 302);
            this.Count1.Name = "Count1";
            this.Count1.Size = new System.Drawing.Size(54, 17);
            this.Count1.TabIndex = 2;
            this.Count1.Text = "Votes:";
            // 
            // Votes1
            // 
            this.Votes1.AutoSize = true;
            this.Votes1.Location = new System.Drawing.Point(197, 306);
            this.Votes1.Name = "Votes1";
            this.Votes1.Size = new System.Drawing.Size(0, 13);
            this.Votes1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Votes:";
            // 
            // Vote1
            // 
            this.Vote1.Location = new System.Drawing.Point(140, 335);
            this.Vote1.Name = "Vote1";
            this.Vote1.Size = new System.Drawing.Size(75, 23);
            this.Vote1.TabIndex = 6;
            this.Vote1.Text = "Vote";
            this.Vote1.UseVisualStyleBackColor = true;
            this.Vote1.Click += new System.EventHandler(this.Vote1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Vote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(13, 13);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 8;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Votes2
            // 
            this.Votes2.AutoSize = true;
            this.Votes2.Location = new System.Drawing.Point(585, 304);
            this.Votes2.Name = "Votes2";
            this.Votes2.Size = new System.Drawing.Size(0, 13);
            this.Votes2.TabIndex = 9;
            // 
            // Option1
            // 
            this.Option1.BackColor = System.Drawing.SystemColors.Control;
            this.Option1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option1.Location = new System.Drawing.Point(140, 269);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(100, 19);
            this.Option1.TabIndex = 10;
            this.Option1.Text = "Name Here";
            // 
            // Option2
            // 
            this.Option2.BackColor = System.Drawing.SystemColors.Control;
            this.Option2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option2.Location = new System.Drawing.Point(521, 269);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(100, 19);
            this.Option2.TabIndex = 11;
            this.Option2.Text = "Name Here";
            // 
            // Vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.Votes2);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Vote1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Votes1);
            this.Controls.Add(this.Count1);
            this.Name = "Vote";
            this.Text = "Vote";
            this.Load += new System.EventHandler(this.Vote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Count1;
        private System.Windows.Forms.Label Votes1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Vote1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label Votes2;
        private System.Windows.Forms.TextBox Option1;
        private System.Windows.Forms.TextBox Option2;
    }
}