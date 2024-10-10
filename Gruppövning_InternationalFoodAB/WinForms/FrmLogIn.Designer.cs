namespace Gruppövning_InternationalFoodAB
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLogin = new Label();
            buttonGuest = new Button();
            buttonAdmin = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(132, 29);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(706, 70);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "International Food AB";
            // 
            // buttonGuest
            // 
            buttonGuest.Location = new Point(380, 226);
            buttonGuest.Margin = new Padding(4);
            buttonGuest.Name = "buttonGuest";
            buttonGuest.Size = new Size(164, 79);
            buttonGuest.TabIndex = 1;
            buttonGuest.Text = "Gäst";
            buttonGuest.UseVisualStyleBackColor = true;
            buttonGuest.Click += buttonGuest_Click;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Location = new Point(380, 312);
            buttonAdmin.Margin = new Padding(4);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(164, 76);
            buttonAdmin.TabIndex = 2;
            buttonAdmin.Text = "Admin";
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(buttonAdmin);
            Controls.Add(buttonGuest);
            Controls.Add(lblLogin);
            Margin = new Padding(4);
            Name = "FrmLogin";
            Text = "Logga in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Button buttonGuest;
        private Button buttonAdmin;
    }
}
