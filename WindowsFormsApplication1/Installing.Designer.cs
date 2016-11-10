namespace WindowsFormsApplication1
{
    partial class Installing
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
            this.processMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processMessage
            // 
            this.processMessage.AutoSize = true;
            this.processMessage.Location = new System.Drawing.Point(26, 26);
            this.processMessage.Name = "processMessage";
            this.processMessage.Size = new System.Drawing.Size(184, 13);
            this.processMessage.TabIndex = 0;
            this.processMessage.Text = "Copying software files to destination...";
            // 
            // Installing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 112);
            this.Controls.Add(this.processMessage);
            this.Name = "Installing";
            this.Text = "Installing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label processMessage;
    }
}