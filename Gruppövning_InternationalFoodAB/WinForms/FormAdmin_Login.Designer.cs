namespace Gruppövning_InternationalFoodAB.WinForms
{
    partial class FormAdmin_Login
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblUserName = new Label();
            lblPassword = new Label();
            lblPleaseLogin = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(288, 213);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(220, 27);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(288, 272);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 27);
            txtPassword.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(289, 180);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(112, 20);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "Användarnamn:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(288, 249);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Lösenord:";
            // 
            // lblPleaseLogin
            // 
            lblPleaseLogin.AutoSize = true;
            lblPleaseLogin.Font = new Font("Showcard Gothic", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPleaseLogin.Location = new Point(142, 41);
            lblPleaseLogin.Name = "lblPleaseLogin";
            lblPleaseLogin.Size = new Size(530, 67);
            lblPleaseLogin.TabIndex = 4;
            lblPleaseLogin.Tag = "";
            lblPleaseLogin.Text = "Vänligen logga in";
            // 
            // FormAdmin_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPleaseLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Name = "FormAdmin_Login";
            Text = "Admin Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblUserName;
        private Label lblPassword;
        private Label lblPleaseLogin;
    }
}