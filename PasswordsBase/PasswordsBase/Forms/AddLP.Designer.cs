namespace PasswordsBase
{
    partial class AddLP
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
            this.lessonTB = new System.Windows.Forms.TextBox();
            this.timeTB = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.emptyLesTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lessonTB
            // 
            this.lessonTB.Location = new System.Drawing.Point(58, 69);
            this.lessonTB.Name = "lessonTB";
            this.lessonTB.Size = new System.Drawing.Size(205, 20);
            this.lessonTB.TabIndex = 0;
            // 
            // timeTB
            // 
            this.timeTB.Location = new System.Drawing.Point(58, 138);
            this.timeTB.Name = "timeTB";
            this.timeTB.Size = new System.Drawing.Size(205, 20);
            this.timeTB.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(54, 40);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(53, 16);
            this.loginLabel.TabIndex = 12;
            this.loginLabel.Text = "Lesson";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Time";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.confirmBtn.Location = new System.Drawing.Point(104, 210);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(114, 40);
            this.confirmBtn.TabIndex = 14;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // emptyLesTime
            // 
            this.emptyLesTime.AutoSize = true;
            this.emptyLesTime.ForeColor = System.Drawing.Color.Red;
            this.emptyLesTime.Location = new System.Drawing.Point(101, 174);
            this.emptyLesTime.Name = "emptyLesTime";
            this.emptyLesTime.Size = new System.Drawing.Size(112, 13);
            this.emptyLesTime.TabIndex = 16;
            this.emptyLesTime.Text = "lesson or time is empty";
            this.emptyLesTime.Visible = false;
            // 
            // AddLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(317, 272);
            this.Controls.Add(this.emptyLesTime);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.timeTB);
            this.Controls.Add(this.lessonTB);
            this.Name = "AddLP";
            this.Text = "AddLP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lessonTB;
        private System.Windows.Forms.TextBox timeTB;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label emptyLesTime;
    }
}