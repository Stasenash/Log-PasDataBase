namespace PasswordsBase
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.TryLabel = new System.Windows.Forms.Label();
            this.upLine = new System.Windows.Forms.PictureBox();
            this.downLine = new System.Windows.Forms.PictureBox();
            this.incorrectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downLine)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.loginTB.Location = new System.Drawing.Point(120, 230);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(220, 31);
            this.loginTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.passwordTB.Location = new System.Drawing.Point(120, 325);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(220, 31);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(117, 200);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(63, 24);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(117, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // SignInBtn
            // 
            this.SignInBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.SignInBtn.Location = new System.Drawing.Point(170, 400);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(125, 35);
            this.SignInBtn.TabIndex = 4;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.SignUpBtn.Location = new System.Drawing.Point(347, 12);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(125, 35);
            this.SignUpBtn.TabIndex = 5;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // TryLabel
            // 
            this.TryLabel.AutoSize = true;
            this.TryLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.TryLabel.Location = new System.Drawing.Point(232, 23);
            this.TryLabel.Name = "TryLabel";
            this.TryLabel.Size = new System.Drawing.Size(108, 24);
            this.TryLabel.TabIndex = 6;
            this.TryLabel.Text = "Try it now";
            // 
            // upLine
            // 
            this.upLine.BackColor = System.Drawing.Color.Black;
            this.upLine.Location = new System.Drawing.Point(-5, 65);
            this.upLine.Name = "upLine";
            this.upLine.Size = new System.Drawing.Size(495, 10);
            this.upLine.TabIndex = 7;
            this.upLine.TabStop = false;
            // 
            // downLine
            // 
            this.downLine.BackColor = System.Drawing.Color.Black;
            this.downLine.Location = new System.Drawing.Point(-5, 484);
            this.downLine.Name = "downLine";
            this.downLine.Size = new System.Drawing.Size(495, 10);
            this.downLine.TabIndex = 8;
            this.downLine.TabStop = false;
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.AutoSize = true;
            this.incorrectLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.incorrectLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectLabel.Location = new System.Drawing.Point(103, 157);
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(276, 24);
            this.incorrectLabel.TabIndex = 9;
            this.incorrectLabel.Text = "Incorrect login or password";
            this.incorrectLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.incorrectLabel);
            this.Controls.Add(this.downLine);
            this.Controls.Add(this.upLine);
            this.Controls.Add(this.TryLabel);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.Name = "Form1";
            this.Text = "Autorization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.upLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Label TryLabel;
        private System.Windows.Forms.PictureBox upLine;
        private System.Windows.Forms.PictureBox downLine;
        private System.Windows.Forms.Label incorrectLabel;
    }
}

