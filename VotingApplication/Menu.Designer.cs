namespace VotingApplication
{
    partial class Menu
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
            this.MainMessage = new System.Windows.Forms.Label();
            this.NewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMessage
            // 
            this.MainMessage.AutoSize = true;
            this.MainMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMessage.Location = new System.Drawing.Point(256, 40);
            this.MainMessage.Name = "MainMessage";
            this.MainMessage.Size = new System.Drawing.Size(291, 39);
            this.MainMessage.TabIndex = 0;
            this.MainMessage.Text = "Voting Application";
            this.MainMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(353, 143);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 23);
            this.NewBtn.TabIndex = 1;
            this.NewBtn.Text = "New Vote";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.MainMessage);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainMessage;
        private System.Windows.Forms.Button NewBtn;
    }
}

