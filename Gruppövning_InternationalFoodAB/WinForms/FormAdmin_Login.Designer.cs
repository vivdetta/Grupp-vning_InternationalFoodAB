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
            btnLoggaIn = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(360, 266);
            txtUserName.Margin = new Padding(4, 4, 4, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(274, 31);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(360, 340);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(274, 31);
            txtPassword.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(361, 225);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(137, 25);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "Användarnamn:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(360, 311);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Lösenord:";
            // 
            // lblPleaseLogin
            // 
            lblPleaseLogin.AutoSize = true;
            lblPleaseLogin.Font = new Font("Showcard Gothic", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPleaseLogin.Location = new Point(178, 51);
            lblPleaseLogin.Margin = new Padding(4, 0, 4, 0);
            lblPleaseLogin.Name = "lblPleaseLogin";
            lblPleaseLogin.Size = new Size(633, 79);
            lblPleaseLogin.TabIndex = 4;
            lblPleaseLogin.Tag = "";
            lblPleaseLogin.Text = "Vänligen logga in";
            // 
            // btnLoggaIn
            // 
            btnLoggaIn.Location = new Point(395, 415);
            btnLoggaIn.Name = "btnLoggaIn";
            btnLoggaIn.Size = new Size(212, 65);
            btnLoggaIn.TabIndex = 5;
            btnLoggaIn.Text = "Logga In";
            btnLoggaIn.UseVisualStyleBackColor = true;
            btnLoggaIn.Click += btnLoggaIn_Click;
            // 
            // FormAdmin_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnLoggaIn);
            Controls.Add(lblPleaseLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Margin = new Padding(4, 4, 4, 4);
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
        private Button btnLoggaIn;
    }
}