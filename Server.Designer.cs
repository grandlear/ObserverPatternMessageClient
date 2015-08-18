namespace ObserverPatternMessageClient
{
    partial class Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.MessageButton = new System.Windows.Forms.Button();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.ActionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Message";
            // 
            // MessageButton
            // 
            this.MessageButton.Location = new System.Drawing.Point(172, 140);
            this.MessageButton.Name = "MessageButton";
            this.MessageButton.Size = new System.Drawing.Size(100, 55);
            this.MessageButton.TabIndex = 7;
            this.MessageButton.Text = "Send Message To Clients";
            this.MessageButton.UseVisualStyleBackColor = true;
            this.MessageButton.Click += new System.EventHandler(this.MessageButton_Click);
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(13, 82);
            this.MessageText.Name = "MessageText";
            this.MessageText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MessageText.Size = new System.Drawing.Size(259, 20);
            this.MessageText.TabIndex = 6;
            // 
            // ActionButton
            // 
            this.ActionButton.Location = new System.Drawing.Point(13, 167);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(123, 28);
            this.ActionButton.TabIndex = 5;
            this.ActionButton.Text = "Launch Chat Client";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageButton);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.ActionButton);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MessageButton;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Button ActionButton;
    }
}

