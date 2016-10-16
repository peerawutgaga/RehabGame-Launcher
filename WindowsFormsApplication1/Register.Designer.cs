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
            this.sexSelector = new System.Windows.Forms.ComboBox();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.birthdayBox = new System.Windows.Forms.TextBox();
            this.birthyearBox = new System.Windows.Forms.TextBox();
            this.birthmonthSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(155, 92);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(193, 20);
            this.nameBox.TabIndex = 0;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(94, 130);
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
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(94, 481);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // banner
            // 
            this.banner.AutoSize = true;
            this.banner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.banner.Location = new System.Drawing.Point(107, 23);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(186, 31);
            this.banner.TabIndex = 4;
            this.banner.Text = "Register Form";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 92);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(13, 130);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 6;
            this.surnameLabel.Text = "Surname";
            // 
            // sexSelector
            // 
            this.sexSelector.FormattingEnabled = true;
            this.sexSelector.Items.AddRange(new object[] {
            "Mr.",
            "Ms.",
            "Mrs."});
            this.sexSelector.Location = new System.Drawing.Point(94, 89);
            this.sexSelector.Name = "sexSelector";
            this.sexSelector.Size = new System.Drawing.Size(55, 21);
            this.sexSelector.TabIndex = 7;
            this.sexSelector.Text = "-Sex-";
            this.sexSelector.SelectedIndexChanged += new System.EventHandler(this.sexSelector_SelectedIndexChanged);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(13, 178);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(45, 13);
            this.birthdayLabel.TabIndex = 9;
            this.birthdayLabel.Text = "Birthday";
            // 
            // birthdayBox
            // 
            this.birthdayBox.Location = new System.Drawing.Point(94, 175);
            this.birthdayBox.Multiline = true;
            this.birthdayBox.Name = "birthdayBox";
            this.birthdayBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.birthdayBox.Size = new System.Drawing.Size(55, 20);
            this.birthdayBox.TabIndex = 10;
            this.birthdayBox.Text = "-Day-";
            this.birthdayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthdayBox.Click += new System.EventHandler(this.birthdayBox_click);
            this.birthdayBox.TextChanged += new System.EventHandler(this.birthdayBox_TextChanged);
            // 
            // birthyearBox
            // 
            this.birthyearBox.Location = new System.Drawing.Point(280, 175);
            this.birthyearBox.Name = "birthyearBox";
            this.birthyearBox.Size = new System.Drawing.Size(67, 20);
            this.birthyearBox.TabIndex = 12;
            this.birthyearBox.Text = "-Year-";
            this.birthyearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthyearBox.Click += new System.EventHandler(this.birthyearBox_click);
            this.birthyearBox.TextChanged += new System.EventHandler(this.birthyearBox_TextChanged);
            // 
            // birthmonthSelector
            // 
            this.birthmonthSelector.FormattingEnabled = true;
            this.birthmonthSelector.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.birthmonthSelector.Location = new System.Drawing.Point(155, 174);
            this.birthmonthSelector.Name = "birthmonthSelector";
            this.birthmonthSelector.Size = new System.Drawing.Size(119, 21);
            this.birthmonthSelector.TabIndex = 14;
            this.birthmonthSelector.Text = "-Month-";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 529);
            this.Controls.Add(this.birthmonthSelector);
            this.Controls.Add(this.birthyearBox);
            this.Controls.Add(this.birthdayBox);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.sexSelector);
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
        private System.Windows.Forms.ComboBox sexSelector;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.TextBox birthdayBox;
        private System.Windows.Forms.TextBox birthyearBox;
        private System.Windows.Forms.ComboBox birthmonthSelector;
    }
}