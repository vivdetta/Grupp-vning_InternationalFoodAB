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
            chkSearchName = new CheckBox();
            chkSearchType = new CheckBox();
            label2 = new Label();
            btnGetList = new Button();
            SuspendLayout();
            // 
            // lbxGuestResults
            // 
            lbxGuestResults.FormattingEnabled = true;
            lbxGuestResults.Location = new Point(238, 213);
            lbxGuestResults.Name = "lbxGuestResults";
            lbxGuestResults.Size = new Size(288, 224);
            lbxGuestResults.TabIndex = 0;
            lbxGuestResults.SelectedIndexChanged += lbxGuestResults_SelectedIndexChanged;
            // 
            // btnGuestOpenRecipe
            // 
            btnGuestOpenRecipe.Location = new Point(548, 340);
            btnGuestOpenRecipe.Name = "btnGuestOpenRecipe";
            btnGuestOpenRecipe.Size = new Size(120, 41);
            btnGuestOpenRecipe.TabIndex = 1;
            btnGuestOpenRecipe.Text = "Öppna recept";
            btnGuestOpenRecipe.UseVisualStyleBackColor = true;
            btnGuestOpenRecipe.Click += btnGuestOpenRecipe_Click;
            // 
            // btnGuestSearch
            // 
            btnGuestSearch.Location = new Point(444, 120);
            btnGuestSearch.Name = "btnGuestSearch";
            btnGuestSearch.Size = new Size(80, 33);
            btnGuestSearch.TabIndex = 2;
            btnGuestSearch.Text = "Sök";
            btnGuestSearch.UseVisualStyleBackColor = true;
            // 
            // txtGuestSearch
            // 
            txtGuestSearch.Location = new Point(238, 120);
            txtGuestSearch.Name = "txtGuestSearch";
            txtGuestSearch.Size = new Size(191, 27);
            txtGuestSearch.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 24);
            label1.Name = "label1";
            label1.Size = new Size(415, 67);
            label1.TabIndex = 4;
            label1.Text = "Öppna Recept";
            // 
            // chkSearchName
            // 
            chkSearchName.AutoSize = true;
            chkSearchName.Location = new Point(301, 159);
            chkSearchName.Name = "chkSearchName";
            chkSearchName.Size = new Size(71, 24);
            chkSearchName.TabIndex = 5;
            chkSearchName.Text = "Namn";
            chkSearchName.UseVisualStyleBackColor = true;
            // 
            // chkSearchType
            // 
            chkSearchType.AutoSize = true;
            chkSearchType.Location = new Point(378, 159);
            chkSearchType.Name = "chkSearchType";
            chkSearchType.Size = new Size(54, 24);
            chkSearchType.TabIndex = 6;
            chkSearchType.Text = "Typ";
            chkSearchType.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 159);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 7;
            label2.Text = "Sök på:";
            // 
            // btnGetList
            // 
            btnGetList.Location = new Point(548, 400);
            btnGetList.Name = "btnGetList";
            btnGetList.Size = new Size(120, 37);
            btnGetList.TabIndex = 8;
            btnGetList.Text = "Hämta alla";
            btnGetList.UseVisualStyleBackColor = true;
            btnGetList.Click += btnGetList_Click;
            // 
            // FrmGuest_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 497);
            Controls.Add(btnGetList);
            Controls.Add(label2);
            Controls.Add(chkSearchType);
            Controls.Add(chkSearchName);
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
        private CheckBox chkSearchName;
        private CheckBox chkSearchType;
        private Label label2;
        private Button btnGetList;
    }
}