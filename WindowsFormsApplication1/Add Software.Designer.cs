namespace WindowsFormsApplication1
{
    partial class Add_Software
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
            this.browseButton = new System.Windows.Forms.Button();
            this.swNameLabel = new System.Windows.Forms.Label();
            this.swLocation = new System.Windows.Forms.Label();
            this.currentLocation = new System.Windows.Forms.RadioButton();
            this.customLocation = new System.Windows.Forms.RadioButton();
            this.defaultLocation = new System.Windows.Forms.RadioButton();
            this.customLocationButton = new System.Windows.Forms.Button();
            this.customLocationLabel = new System.Windows.Forms.Label();
            this.installButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.currentLocationShow = new System.Windows.Forms.Label();
            this.swNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(112, 35);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(250, 37);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "ค้นหาเกม";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // swNameLabel
            // 
            this.swNameLabel.AutoSize = true;
            this.swNameLabel.Location = new System.Drawing.Point(22, 102);
            this.swNameLabel.Name = "swNameLabel";
            this.swNameLabel.Size = new System.Drawing.Size(42, 13);
            this.swNameLabel.TabIndex = 1;
            this.swNameLabel.Text = "ชื่อเกม:";
            // 
            // swLocation
            // 
            this.swLocation.AutoSize = true;
            this.swLocation.Location = new System.Drawing.Point(22, 142);
            this.swLocation.Name = "swLocation";
            this.swLocation.Size = new System.Drawing.Size(108, 13);
            this.swLocation.TabIndex = 3;
            this.swLocation.Text = "ตำแหน่งของการติดตั้ง";
            // 
            // currentLocation
            // 
            this.currentLocation.AutoSize = true;
            this.currentLocation.Location = new System.Drawing.Point(37, 206);
            this.currentLocation.Name = "currentLocation";
            this.currentLocation.Size = new System.Drawing.Size(112, 17);
            this.currentLocation.TabIndex = 4;
            this.currentLocation.TabStop = true;
            this.currentLocation.Text = "ใช้ตำแหน่งปัจจุบัน";
            this.currentLocation.UseVisualStyleBackColor = true;
            this.currentLocation.CheckedChanged += new System.EventHandler(this.currentLocation_CheckedChanged);
            // 
            // customLocation
            // 
            this.customLocation.AutoSize = true;
            this.customLocation.Location = new System.Drawing.Point(37, 293);
            this.customLocation.Name = "customLocation";
            this.customLocation.Size = new System.Drawing.Size(105, 17);
            this.customLocation.TabIndex = 5;
            this.customLocation.TabStop = true;
            this.customLocation.Text = "เลือกตำแหน่งเอง";
            this.customLocation.UseVisualStyleBackColor = true;
            this.customLocation.CheckedChanged += new System.EventHandler(this.custonLocation_checked);
            // 
            // defaultLocation
            // 
            this.defaultLocation.AutoSize = true;
            this.defaultLocation.Location = new System.Drawing.Point(37, 169);
            this.defaultLocation.Name = "defaultLocation";
            this.defaultLocation.Size = new System.Drawing.Size(103, 17);
            this.defaultLocation.TabIndex = 6;
            this.defaultLocation.TabStop = true;
            this.defaultLocation.Text = "คลังเกม (default)";
            this.defaultLocation.UseVisualStyleBackColor = true;
            this.defaultLocation.CheckedChanged += new System.EventHandler(this.defaultLocation_CheckedChanged);
            // 
            // customLocationButton
            // 
            this.customLocationButton.Location = new System.Drawing.Point(170, 287);
            this.customLocationButton.Name = "customLocationButton";
            this.customLocationButton.Size = new System.Drawing.Size(75, 23);
            this.customLocationButton.TabIndex = 7;
            this.customLocationButton.Text = "เลือก";
            this.customLocationButton.UseVisualStyleBackColor = true;
            this.customLocationButton.Click += new System.EventHandler(this.customLocationButton_Click);
            // 
            // customLocationLabel
            // 
            this.customLocationLabel.AutoSize = true;
            this.customLocationLabel.Location = new System.Drawing.Point(56, 327);
            this.customLocationLabel.Name = "customLocationLabel";
            this.customLocationLabel.Size = new System.Drawing.Size(30, 13);
            this.customLocationLabel.TabIndex = 8;
            this.customLocationLabel.Text = "ที่อยู่:";
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(112, 423);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(117, 42);
            this.installButton.TabIndex = 9;
            this.installButton.Text = "ติดตั้ง";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(249, 423);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 42);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "ยกเลิก";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // currentLocationShow
            // 
            this.currentLocationShow.AutoSize = true;
            this.currentLocationShow.Location = new System.Drawing.Point(56, 240);
            this.currentLocationShow.Name = "currentLocationShow";
            this.currentLocationShow.Size = new System.Drawing.Size(30, 13);
            this.currentLocationShow.TabIndex = 11;
            this.currentLocationShow.Text = "ที่อยู่:";
            // 
            // swNameBox
            // 
            this.swNameBox.Location = new System.Drawing.Point(84, 99);
            this.swNameBox.Name = "swNameBox";
            this.swNameBox.Size = new System.Drawing.Size(290, 20);
            this.swNameBox.TabIndex = 12;
            this.swNameBox.TextChanged += new System.EventHandler(this.swNameBox_TextChanged);
            // 
            // Add_Software
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 487);
            this.Controls.Add(this.swNameBox);
            this.Controls.Add(this.currentLocationShow);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.customLocationLabel);
            this.Controls.Add(this.customLocationButton);
            this.Controls.Add(this.defaultLocation);
            this.Controls.Add(this.customLocation);
            this.Controls.Add(this.currentLocation);
            this.Controls.Add(this.swLocation);
            this.Controls.Add(this.swNameLabel);
            this.Controls.Add(this.browseButton);
            this.Name = "Add_Software";
            this.Text = "Add Software";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label swNameLabel;
        private System.Windows.Forms.Label swLocation;
        private System.Windows.Forms.RadioButton currentLocation;
        private System.Windows.Forms.RadioButton customLocation;
        private System.Windows.Forms.RadioButton defaultLocation;
        private System.Windows.Forms.Button customLocationButton;
        private System.Windows.Forms.Label customLocationLabel;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label currentLocationShow;
        private System.Windows.Forms.TextBox swNameBox;
    }
}