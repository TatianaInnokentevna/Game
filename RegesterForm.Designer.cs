namespace ItprogerApp
{
    partial class RegesterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserLoginField = new System.Windows.Forms.TextBox();
            this.UserEmailField = new System.Windows.Forms.TextBox();
            this.UserPasswordField = new System.Windows.Forms.TextBox();
            this.RegBtn = new System.Windows.Forms.Button();
            this.LinkToAuth = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(110, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // UserLoginField
            // 
            this.UserLoginField.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UserLoginField.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLoginField.ForeColor = System.Drawing.Color.Blue;
            this.UserLoginField.Location = new System.Drawing.Point(116, 118);
            this.UserLoginField.Name = "UserLoginField";
            this.UserLoginField.Size = new System.Drawing.Size(199, 25);
            this.UserLoginField.TabIndex = 1;
            this.UserLoginField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserLoginField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // UserEmailField
            // 
            this.UserEmailField.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UserEmailField.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserEmailField.ForeColor = System.Drawing.Color.Blue;
            this.UserEmailField.Location = new System.Drawing.Point(116, 172);
            this.UserEmailField.Name = "UserEmailField";
            this.UserEmailField.Size = new System.Drawing.Size(199, 25);
            this.UserEmailField.TabIndex = 2;
            this.UserEmailField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserEmailField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // UserPasswordField
            // 
            this.UserPasswordField.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.UserPasswordField.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPasswordField.ForeColor = System.Drawing.Color.Blue;
            this.UserPasswordField.Location = new System.Drawing.Point(116, 222);
            this.UserPasswordField.Name = "UserPasswordField";
            this.UserPasswordField.Size = new System.Drawing.Size(199, 25);
            this.UserPasswordField.TabIndex = 3;
            this.UserPasswordField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserPasswordField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // RegBtn
            // 
            this.RegBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RegBtn.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.RegBtn.Location = new System.Drawing.Point(116, 281);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(199, 40);
            this.RegBtn.TabIndex = 4;
            this.RegBtn.Text = "Зарегистрироваться";
            this.RegBtn.UseVisualStyleBackColor = false;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // LinkToAuth
            // 
            this.LinkToAuth.AutoSize = true;
            this.LinkToAuth.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkToAuth.LinkColor = System.Drawing.Color.White;
            this.LinkToAuth.Location = new System.Drawing.Point(156, 346);
            this.LinkToAuth.Name = "LinkToAuth";
            this.LinkToAuth.Size = new System.Drawing.Size(110, 24);
            this.LinkToAuth.TabIndex = 10;
            this.LinkToAuth.TabStop = true;
            this.LinkToAuth.Text = "Авторизация";
            this.LinkToAuth.VisitedLinkColor = System.Drawing.Color.WhiteSmoke;
            this.LinkToAuth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToAuth_LinkClicked);
            // 
            // RegesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(434, 406);
            this.Controls.Add(this.LinkToAuth);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.UserPasswordField);
            this.Controls.Add(this.UserEmailField);
            this.Controls.Add(this.UserLoginField);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "RegesterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegesterForm";
            this.Load += new System.EventHandler(this.RegesterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserLoginField;
        private System.Windows.Forms.TextBox UserEmailField;
        private System.Windows.Forms.TextBox UserPasswordField;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.LinkLabel LinkToAuth;
    }
}