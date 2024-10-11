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
            buttonStänga = new Button();
            SuspendLayout();
            // 
            // lbxGuestResults
            // 
            lbxGuestResults.FormattingEnabled = true;
            lbxGuestResults.ItemHeight = 25;
            lbxGuestResults.Location = new Point(298, 266);
            lbxGuestResults.Margin = new Padding(4);
            lbxGuestResults.Name = "lbxGuestResults";
            lbxGuestResults.Size = new Size(359, 279);
            lbxGuestResults.TabIndex = 0;
            lbxGuestResults.SelectedIndexChanged += lbxGuestResults_SelectedIndexChanged;
            // 
            // btnGuestOpenRecipe
            // 
            btnGuestOpenRecipe.Location = new Point(685, 425);
            btnGuestOpenRecipe.Margin = new Padding(4);
            btnGuestOpenRecipe.Name = "btnGuestOpenRecipe";
            btnGuestOpenRecipe.Size = new Size(150, 51);
            btnGuestOpenRecipe.TabIndex = 1;
            btnGuestOpenRecipe.Text = "Öppna recept";
            btnGuestOpenRecipe.UseVisualStyleBackColor = true;
            btnGuestOpenRecipe.Click += btnGuestOpenRecipe_Click;
            // 
            // btnGuestSearch
            // 
            btnGuestSearch.Location = new Point(555, 150);
            btnGuestSearch.Margin = new Padding(4);
            btnGuestSearch.Name = "btnGuestSearch";
            btnGuestSearch.Size = new Size(100, 41);
            btnGuestSearch.TabIndex = 2;
            btnGuestSearch.Text = "Sök";
            btnGuestSearch.UseVisualStyleBackColor = true;
            btnGuestSearch.Click += btnGuestSearch_Click;
            // 
            // txtGuestSearch
            // 
            txtGuestSearch.Location = new Point(298, 150);
            txtGuestSearch.Margin = new Padding(4);
            txtGuestSearch.Name = "txtGuestSearch";
            txtGuestSearch.Size = new Size(238, 31);
            txtGuestSearch.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(495, 79);
            label1.TabIndex = 4;
            label1.Text = "Öppna Recept";
            // 
            // chkSearchName
            // 
            chkSearchName.AutoSize = true;
            chkSearchName.Location = new Point(376, 199);
            chkSearchName.Margin = new Padding(4);
            chkSearchName.Name = "chkSearchName";
            chkSearchName.Size = new Size(86, 29);
            chkSearchName.TabIndex = 5;
            chkSearchName.Text = "Namn";
            chkSearchName.UseVisualStyleBackColor = true;
            // 
            // chkSearchType
            // 
            chkSearchType.AutoSize = true;
            chkSearchType.Location = new Point(472, 199);
            chkSearchType.Margin = new Padding(4);
            chkSearchType.Name = "chkSearchType";
            chkSearchType.Size = new Size(66, 29);
            chkSearchType.TabIndex = 6;
            chkSearchType.Text = "Typ";
            chkSearchType.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 199);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 7;
            label2.Text = "Sök på:";
            // 
            // btnGetList
            // 
            btnGetList.Location = new Point(685, 500);
            btnGetList.Margin = new Padding(4);
            btnGetList.Name = "btnGetList";
            btnGetList.Size = new Size(150, 46);
            btnGetList.TabIndex = 8;
            btnGetList.Text = "Hämta alla";
            btnGetList.UseVisualStyleBackColor = true;
            btnGetList.Click += btnGetList_Click;
            // 
            // buttonStänga
            // 
            buttonStänga.Location = new Point(91, 490);
            buttonStänga.Name = "buttonStänga";
            buttonStänga.Size = new Size(173, 55);
            buttonStänga.TabIndex = 9;
            buttonStänga.Text = "Stäng Allt";
            buttonStänga.UseVisualStyleBackColor = true;
            buttonStänga.Click += buttonStänga_Click;
            // 
            // FrmGuest_Screen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 621);
            Controls.Add(buttonStänga);
            Controls.Add(btnGetList);
            Controls.Add(label2);
            Controls.Add(chkSearchType);
            Controls.Add(chkSearchName);
            Controls.Add(label1);
            Controls.Add(txtGuestSearch);
            Controls.Add(btnGuestSearch);
            Controls.Add(btnGuestOpenRecipe);
            Controls.Add(lbxGuestResults);
            Margin = new Padding(4);
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
        private Button buttonStänga;
    }
}