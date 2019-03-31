namespace PasswordsBase
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.BackBtn = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.confirmPasTB = new System.Windows.Forms.TextBox();
            this.confirmPasLabel = new System.Windows.Forms.Label();
            this.downLine = new System.Windows.Forms.PictureBox();
            this.upLine = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.downLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upLine)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.BackBtn.Location = new System.Drawing.Point(20, 16);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(125, 35);
            this.BackBtn.TabIndex = 14;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Registration
            // 
            this.Registration.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.Registration.Location = new System.Drawing.Point(170, 404);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(125, 35);
            this.Registration.TabIndex = 13;
            this.Registration.Text = "Sign Up";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(117, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Password";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(117, 108);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(63, 24);
            this.loginLabel.TabIndex = 11;
            this.loginLabel.Text = "Login";
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.passwordTB.Location = new System.Drawing.Point(120, 228);
            this.passwordTB.MaxLength = 20;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(220, 31);
            this.passwordTB.TabIndex = 10;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.loginTB.Location = new System.Drawing.Point(120, 138);
            this.loginTB.MaxLength = 20;
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(220, 31);
            this.loginTB.TabIndex = 9;
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPassword.Location = new System.Drawing.Point(117, 293);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(184, 24);
            this.confirmPassword.TabIndex = 19;
            this.confirmPassword.Text = "Confirm password";
            // 
            // confirmPasTB
            // 
            this.confirmPasTB.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.confirmPasTB.Location = new System.Drawing.Point(120, 320);
            this.confirmPasTB.MaxLength = 20;
            this.confirmPasTB.Name = "confirmPasTB";
            this.confirmPasTB.Size = new System.Drawing.Size(220, 31);
            this.confirmPasTB.TabIndex = 18;
            this.confirmPasTB.UseSystemPasswordChar = true;
            // 
            // confirmPasLabel
            // 
            this.confirmPasLabel.AutoSize = true;
            this.confirmPasLabel.Location = new System.Drawing.Point(123, 358);
            this.confirmPasLabel.Name = "confirmPasLabel";
            this.confirmPasLabel.Size = new System.Drawing.Size(139, 13);
            this.confirmPasLabel.TabIndex = 20;
            this.confirmPasLabel.Text = "passwords are not the same";
            this.confirmPasLabel.Visible = false;
            // 
            // downLine
            // 
            this.downLine.BackColor = System.Drawing.Color.Black;
            this.downLine.Location = new System.Drawing.Point(-5, 488);
            this.downLine.Name = "downLine";
            this.downLine.Size = new System.Drawing.Size(495, 10);
            this.downLine.TabIndex = 17;
            this.downLine.TabStop = false;
            // 
            // upLine
            // 
            this.upLine.BackColor = System.Drawing.Color.Black;
            this.upLine.Location = new System.Drawing.Point(-5, 69);
            this.upLine.Name = "upLine";
            this.upLine.Size = new System.Drawing.Size(495, 10);
            this.upLine.TabIndex = 16;
            this.upLine.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.confirmPasLabel);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.confirmPasTB);
            this.Controls.Add(this.downLine);
            this.Controls.Add(this.upLine);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.downLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox downLine;
        private System.Windows.Forms.PictureBox upLine;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.TextBox confirmPasTB;
        private System.Windows.Forms.Label confirmPasLabel;
        private System.Windows.Forms.Timer timer;
    }
}