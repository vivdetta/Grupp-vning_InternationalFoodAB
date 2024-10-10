namespace Gruppövning_InternationalFoodAB.WinForms
{
    partial class FormGuest_SelectedRecept
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
            label1 = new Label();
            btnGetList = new Button();
            btnGuestOpenRecipe = new Button();
            lbxGuestReceptSearch = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 42);
            label1.Name = "label1";
            label1.Size = new Size(408, 53);
            label1.TabIndex = 5;
            label1.Text = "Sök Efter Recept";
            // 
            // btnGetList
            // 
            btnGetList.Location = new Point(485, 340);
            btnGetList.Margin = new Padding(3, 2, 3, 2);
            btnGetList.Name = "btnGetList";
            btnGetList.Size = new Size(105, 28);
            btnGetList.TabIndex = 16;
            btnGetList.Text = "Hämta alla";
            btnGetList.UseVisualStyleBackColor = true;
            // 
            // btnGuestOpenRecipe
            // 
            btnGuestOpenRecipe.Location = new Point(485, 295);
            btnGuestOpenRecipe.Margin = new Padding(3, 2, 3, 2);
            btnGuestOpenRecipe.Name = "btnGuestOpenRecipe";
            btnGuestOpenRecipe.Size = new Size(105, 31);
            btnGuestOpenRecipe.TabIndex = 10;
            btnGuestOpenRecipe.Text = "Öppna recept";
            btnGuestOpenRecipe.UseVisualStyleBackColor = true;
            // 
            // lbxGuestReceptSearch
            // 
            lbxGuestReceptSearch.FormattingEnabled = true;
            lbxGuestReceptSearch.ItemHeight = 15;
            lbxGuestReceptSearch.Location = new Point(213, 200);
            lbxGuestReceptSearch.Margin = new Padding(3, 2, 3, 2);
            lbxGuestReceptSearch.Name = "lbxGuestReceptSearch";
            lbxGuestReceptSearch.Size = new Size(252, 169);
            lbxGuestReceptSearch.TabIndex = 9;
            // 
            // FormGuest_SelectedRecept
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetList);
            Controls.Add(btnGuestOpenRecipe);
            Controls.Add(lbxGuestReceptSearch);
            Controls.Add(label1);
            Name = "FormGuest_SelectedRecept";
            Text = "FormGuest_SelectedRecept";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGetList;
        private Label label2;
        private CheckBox chkSearchType;
        private CheckBox chkSearchName;
        private TextBox txtGuestSearch;
        private Button btnGuestSearch;
        private Button btnGuestOpenRecipe;
        private ListBox lbxGuestReceptSearch;
    }
}