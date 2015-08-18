namespace ObserverPatternMessageClient
{
    partial class MessageClient
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
            this.NewsItemTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewsItemTextBox
            // 
            this.NewsItemTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NewsItemTextBox.Location = new System.Drawing.Point(12, 18);
            this.NewsItemTextBox.Multiline = true;
            this.NewsItemTextBox.Name = "NewsItemTextBox";
            this.NewsItemTextBox.ReadOnly = true;
            this.NewsItemTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NewsItemTextBox.Size = new System.Drawing.Size(518, 288);
            this.NewsItemTextBox.TabIndex = 1;
            // 
            // MessageClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 318);
            this.Controls.Add(this.NewsItemTextBox);
            this.Name = "MessageClient";
            this.Text = "MessageClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewsItemTextBox;
    }
}