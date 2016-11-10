namespace WindowsFormsApplication1
{
    partial class Register
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.banner = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.birthdayBox = new System.Windows.Forms.TextBox();
            this.birthyearBox = new System.Windows.Forms.TextBox();
            this.birthmonthSelector = new System.Windows.Forms.ComboBox();
            this.mr = new System.Windows.Forms.RadioButton();
            this.sexLabel = new System.Windows.Forms.Label();
            this.ms = new System.Windows.Forms.RadioButton();
            this.mrs = new System.Windows.Forms.RadioButton();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(98, 169);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(254, 20);
            this.nameBox.TabIndex = 0;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(98, 207);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(254, 20);
            this.surnameBox.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(228, 481);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "ยกเลิก";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(94, 481);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "เพิ่ม";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // banner
            // 
            this.banner.AutoSize = true;
            this.banner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.banner.Location = new System.Drawing.Point(88, 22);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(222, 31);
            this.banner.TabIndex = 4;
            this.banner.Text = "ลงทะเบียนผู้ป่วยใหม่";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 169);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(20, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "ชื่อ";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(16, 207);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(46, 13);
            this.surnameLabel.TabIndex = 6;
            this.surnameLabel.Text = "นามสกุล";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(16, 242);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(73, 13);
            this.birthdayLabel.TabIndex = 9;
            this.birthdayLabel.Text = "วันเดือนปีเกิด";
            // 
            // birthdayBox
            // 
            this.birthdayBox.Location = new System.Drawing.Point(98, 242);
            this.birthdayBox.Multiline = true;
            this.birthdayBox.Name = "birthdayBox";
            this.birthdayBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.birthdayBox.Size = new System.Drawing.Size(55, 20);
            this.birthdayBox.TabIndex = 10;
            this.birthdayBox.Text = "-วัน-";
            this.birthdayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthdayBox.Click += new System.EventHandler(this.birthdayBox_click);
            this.birthdayBox.TextChanged += new System.EventHandler(this.birthdayBox_TextChanged);
            // 
            // birthyearBox
            // 
            this.birthyearBox.Location = new System.Drawing.Point(285, 243);
            this.birthyearBox.Name = "birthyearBox";
            this.birthyearBox.Size = new System.Drawing.Size(67, 20);
            this.birthyearBox.TabIndex = 12;
            this.birthyearBox.Text = "-ปี (พ.ศ.)-";
            this.birthyearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthyearBox.Click += new System.EventHandler(this.birthyearBox_click);
            this.birthyearBox.TextChanged += new System.EventHandler(this.birthyearBox_TextChanged);
            // 
            // birthmonthSelector
            // 
            this.birthmonthSelector.FormattingEnabled = true;
            this.birthmonthSelector.Items.AddRange(new object[] {
            "มกราคม",
            "กุมภาพันธ์",
            "มีนาคม",
            "เมษายน",
            "พฤศภาคม",
            "มิถุนายน",
            "กรกฎาคม",
            "สิงหาคม",
            "กันยายน",
            "ตุลาคม",
            "พฤษจิการยน",
            "ธันวาคม"});
            this.birthmonthSelector.Location = new System.Drawing.Point(159, 242);
            this.birthmonthSelector.Name = "birthmonthSelector";
            this.birthmonthSelector.Size = new System.Drawing.Size(119, 21);
            this.birthmonthSelector.TabIndex = 14;
            this.birthmonthSelector.Text = "-เดือน-";
            // 
            // mr
            // 
            this.mr.AutoSize = true;
            this.mr.Location = new System.Drawing.Point(98, 132);
            this.mr.Name = "mr";
            this.mr.Size = new System.Drawing.Size(45, 17);
            this.mr.TabIndex = 15;
            this.mr.TabStop = true;
            this.mr.Text = "นาย";
            this.mr.UseVisualStyleBackColor = true;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(20, 132);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(28, 13);
            this.sexLabel.TabIndex = 16;
            this.sexLabel.Text = "เพศ";
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.Location = new System.Drawing.Point(218, 132);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(60, 17);
            this.ms.TabIndex = 17;
            this.ms.TabStop = true;
            this.ms.Text = "นางสาว";
            this.ms.UseVisualStyleBackColor = true;
            // 
            // mrs
            // 
            this.mrs.AutoSize = true;
            this.mrs.Location = new System.Drawing.Point(159, 132);
            this.mrs.Name = "mrs";
            this.mrs.Size = new System.Drawing.Size(43, 17);
            this.mrs.TabIndex = 18;
            this.mrs.TabStop = true;
            this.mrs.Text = "นาง";
            this.mrs.UseVisualStyleBackColor = true;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(20, 100);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(53, 13);
            this.IDLabel.TabIndex = 19;
            this.IDLabel.Text = "รหัสผู้ป่วย";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(98, 100);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(254, 20);
            this.IDBox.TabIndex = 20;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 529);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.mrs);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.mr);
            this.Controls.Add(this.birthmonthSelector);
            this.Controls.Add(this.birthyearBox);
            this.Controls.Add(this.birthdayBox);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label banner;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.TextBox birthdayBox;
        private System.Windows.Forms.TextBox birthyearBox;
        private System.Windows.Forms.ComboBox birthmonthSelector;
        private System.Windows.Forms.RadioButton mr;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.RadioButton ms;
        private System.Windows.Forms.RadioButton mrs;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDBox;
    }
}