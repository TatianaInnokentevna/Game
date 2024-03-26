namespace ItprogerApp
{
    partial class AuthForm
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
            this.AuthBtn = new System.Windows.Forms.Button();
            this.UserPasswordField = new System.Windows.Forms.TextBox();
            this.UserLoginField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkToReg = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AuthBtn
            // 
            this.AuthBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AuthBtn.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthBtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.AuthBtn.Location = new System.Drawing.Point(83, 195);
            this.AuthBtn.Name = "AuthBtn";
            this.AuthBtn.Size = new System.Drawing.Size(127, 40);
            this.AuthBtn.TabIndex = 8;
            this.AuthBtn.Text = "Войти";
            this.AuthBtn.UseVisualStyleBackColor = false;
            this.AuthBtn.Click += new System.EventHandler(this.AuthBtn_Click);
            // 
            // UserPasswordField
            // 
            this.UserPasswordField.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UserPasswordField.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPasswordField.ForeColor = System.Drawing.Color.Blue;
            this.UserPasswordField.Location = new System.Drawing.Point(46, 138);
            this.UserPasswordField.Name = "UserPasswordField";
            this.UserPasswordField.Size = new System.Drawing.Size(199, 25);
            this.UserPasswordField.TabIndex = 7;
            this.UserPasswordField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserPasswordField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // UserLoginField
            // 
            this.UserLoginField.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UserLoginField.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLoginField.ForeColor = System.Drawing.Color.Blue;
            this.UserLoginField.Location = new System.Drawing.Point(46, 87);
            this.UserLoginField.Name = "UserLoginField";
            this.UserLoginField.Size = new System.Drawing.Size(199, 25);
            this.UserLoginField.TabIndex = 6;
            this.UserLoginField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserLoginField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Авторизация";
            // 
            // LinkToReg
            // 
            this.LinkToReg.AutoSize = true;
            this.LinkToReg.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkToReg.LinkColor = System.Drawing.Color.White;
            this.LinkToReg.Location = new System.Drawing.Point(80, 259);
            this.LinkToReg.Name = "LinkToReg";
            this.LinkToReg.Size = new System.Drawing.Size(131, 18);
            this.LinkToReg.TabIndex = 9;
            this.LinkToReg.TabStop = true;
            this.LinkToReg.Text = "Зарегистрироваться";
            this.LinkToReg.VisitedLinkColor = System.Drawing.Color.White;
            this.LinkToReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToReg_LinkClicked);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.LinkToReg);
            this.Controls.Add(this.AuthBtn);
            this.Controls.Add(this.UserPasswordField);
            this.Controls.Add(this.UserLoginField);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthForm";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthBtn;
        private System.Windows.Forms.TextBox UserPasswordField;
        private System.Windows.Forms.TextBox UserLoginField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkToReg;
    }
}