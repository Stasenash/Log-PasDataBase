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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.emptyLogin = new System.Windows.Forms.Label();
            this.emptyPas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 35);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 207);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 35);
            this.textBox2.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(77, 60);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(63, 24);
            this.loginLabel.TabIndex = 12;
            this.loginLabel.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F);
            this.confirmBtn.Location = new System.Drawing.Point(127, 278);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(114, 40);
            this.confirmBtn.TabIndex = 14;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            // 
            // emptyLogin
            // 
            this.emptyLogin.AutoSize = true;
            this.emptyLogin.ForeColor = System.Drawing.Color.Red;
            this.emptyLogin.Location = new System.Drawing.Point(90, 134);
            this.emptyLogin.Name = "emptyLogin";
            this.emptyLogin.Size = new System.Drawing.Size(70, 13);
            this.emptyLogin.TabIndex = 15;
            this.emptyLogin.Text = "login is empty";
            this.emptyLogin.Visible = false;
            // 
            // emptyPas
            // 
            this.emptyPas.AutoSize = true;
            this.emptyPas.ForeColor = System.Drawing.Color.Red;
            this.emptyPas.Location = new System.Drawing.Point(90, 245);
            this.emptyPas.Name = "emptyPas";
            this.emptyPas.Size = new System.Drawing.Size(93, 13);
            this.emptyPas.TabIndex = 16;
            this.emptyPas.Text = "password is empty";
            this.emptyPas.Visible = false;
            // 
            // AddLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.emptyPas);
            this.Controls.Add(this.emptyLogin);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AddLP";
            this.Text = "AddLP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label emptyLogin;
        private System.Windows.Forms.Label emptyPas;
    }
}