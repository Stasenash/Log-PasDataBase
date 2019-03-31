namespace PasswordsBase
{
    partial class DataForm
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
            this.downLine = new System.Windows.Forms.PictureBox();
            this.upLine = new System.Windows.Forms.PictureBox();
            this.LessonsList = new System.Windows.Forms.ListBox();
            this.TimeList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addLTBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personNameLabel = new System.Windows.Forms.Label();
            this.signOutBtn = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.downLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // downLine
            // 
            this.downLine.BackColor = System.Drawing.Color.Black;
            this.downLine.Location = new System.Drawing.Point(-5, 484);
            this.downLine.Name = "downLine";
            this.downLine.Size = new System.Drawing.Size(495, 10);
            this.downLine.TabIndex = 19;
            this.downLine.TabStop = false;
            // 
            // upLine
            // 
            this.upLine.BackColor = System.Drawing.Color.Black;
            this.upLine.Location = new System.Drawing.Point(-5, 65);
            this.upLine.Name = "upLine";
            this.upLine.Size = new System.Drawing.Size(495, 10);
            this.upLine.TabIndex = 18;
            this.upLine.TabStop = false;
            // 
            // LessonsList
            // 
            this.LessonsList.BackColor = System.Drawing.Color.LightYellow;
            this.LessonsList.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LessonsList.FormattingEnabled = true;
            this.LessonsList.ItemHeight = 24;
            this.LessonsList.Location = new System.Drawing.Point(12, 120);
            this.LessonsList.Name = "LessonsList";
            this.LessonsList.Size = new System.Drawing.Size(228, 340);
            this.LessonsList.TabIndex = 20;
            // 
            // TimeList
            // 
            this.TimeList.BackColor = System.Drawing.Color.LightYellow;
            this.TimeList.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.TimeList.FormattingEnabled = true;
            this.TimeList.ItemHeight = 24;
            this.TimeList.Location = new System.Drawing.Point(246, 120);
            this.TimeList.Name = "TimeList";
            this.TimeList.Size = new System.Drawing.Size(228, 340);
            this.TimeList.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Lesson";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(242, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Time";
            // 
            // addLTBtn
            // 
            this.addLTBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addLTBtn.Location = new System.Drawing.Point(156, 514);
            this.addLTBtn.Name = "addLTBtn";
            this.addLTBtn.Size = new System.Drawing.Size(167, 35);
            this.addLTBtn.TabIndex = 24;
            this.addLTBtn.Text = "Add new lesson-time";
            this.addLTBtn.UseVisualStyleBackColor = true;
            this.addLTBtn.Click += new System.EventHandler(this.addLTBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PasswordsBase.Properties.Resources.pm_avatar;
            this.pictureBox1.Location = new System.Drawing.Point(16, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // personNameLabel
            // 
            this.personNameLabel.AutoSize = true;
            this.personNameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.personNameLabel.Location = new System.Drawing.Point(77, 23);
            this.personNameLabel.Name = "personNameLabel";
            this.personNameLabel.Size = new System.Drawing.Size(128, 24);
            this.personNameLabel.TabIndex = 26;
            this.personNameLabel.Text = "PersonName";
            // 
            // signOutBtn
            // 
            this.signOutBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signOutBtn.Location = new System.Drawing.Point(383, 14);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(87, 36);
            this.signOutBtn.TabIndex = 27;
            this.signOutBtn.Text = "Sign out";
            this.signOutBtn.UseVisualStyleBackColor = true;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh.Location = new System.Drawing.Point(383, 88);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 28;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.signOutBtn);
            this.Controls.Add(this.personNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addLTBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeList);
            this.Controls.Add(this.LessonsList);
            this.Controls.Add(this.downLine);
            this.Controls.Add(this.upLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.downLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox downLine;
        private System.Windows.Forms.PictureBox upLine;
        private System.Windows.Forms.ListBox LessonsList;
        private System.Windows.Forms.ListBox TimeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addLTBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label personNameLabel;
        private System.Windows.Forms.Button signOutBtn;
        private System.Windows.Forms.Button refresh;
    }
}