namespace Gruppövning_InternationalFoodAB.WinForms
{
    partial class FrmGuest_Screen
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
            lbxGuestResults = new ListBox();
            btnGuestOpenRecipe = new Button();
            btnGuestSearch = new Button();
            txtGuestSearch = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbxGuestResults
            // 
            lbxGuestResults.FormattingEnabled = true;
            lbxGuestResults.Location = new Point(190, 99);
            lbxGuestResults.Name = "lbxGuestResults";
            lbxGuestResults.Size = new Size(424, 224);
            lbxGuestResults.TabIndex = 0;
            // 
            // btnGuestOpenRecipe
            // 
            btnGuestOpenRecipe.Location = new Point(190, 331);
            btnGuestOpenRecipe.Name = "btnGuestOpenRecipe";
            btnGuestOpenRecipe.Size = new Size(120, 49);
            btnGuestOpenRecipe.TabIndex = 1;
            btnGuestOpenRecipe.Text = "Öppna recept";
            btnGuestOpenRecipe.UseVisualStyleBackColor = true;
            // 
            // btnGuestSearch
            // 
            btnGuestSearch.Location = new Point(494, 364);
            btnGuestSearch.Name = "btnGuestSearch";
            btnGuestSearch.Size = new Size(120, 49);
            btnGuestSearch.TabIndex = 2;
            btnGuestSearch.Text = "Sök";
            btnGuestSearch.UseVisualStyleBackColor = true;
            // 
            // txtGuestSearch
            // 
            txtGuestSearch.Location = new Point(423, 331);
            txtGuestSearch.Name = "txtGuestSearch";
            txtGuestSearch.Size = new Size(191, 27);
            txtGuestSearch.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 27);
            label1.Name = "label1";
            label1.Size = new Size(415, 67);
            label1.TabIndex = 4;
            label1.Text = "Öppna Recept";
            // 
            // FrmGuest_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtGuestSearch);
            Controls.Add(btnGuestSearch);
            Controls.Add(btnGuestOpenRecipe);
            Controls.Add(lbxGuestResults);
            Name = "FrmGuest_Screen";
            Text = "Gäst";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxGuestResults;
        private Button btnGuestOpenRecipe;
        private Button btnGuestSearch;
        private TextBox txtGuestSearch;
        private Label label1;
    }
}