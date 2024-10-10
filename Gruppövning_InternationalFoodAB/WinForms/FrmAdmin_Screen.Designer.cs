namespace Gruppövning_InternationalFoodAB.WinForms
{
    partial class FrmAdminScreen
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
            btnCreate = new Button();
            btnAdminSearch = new Button();
            btnOpenRecipe = new Button();
            labelAdminWelcome = new Label();
            lbxAdminView = new ListBox();
            txtSearchItem = new TextBox();
            txtDescription = new TextBox();
            chkName = new CheckBox();
            chkType = new CheckBox();
            txtSearch = new TextBox();
            comboBox1 = new ComboBox();
            lblTitle = new Label();
            lblCategory = new Label();
            btnGetAllRecipes = new Button();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(175, 332);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(111, 46);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Skapa";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnAdminSearch
            // 
            btnAdminSearch.Location = new Point(666, 39);
            btnAdminSearch.Name = "btnAdminSearch";
            btnAdminSearch.Size = new Size(96, 33);
            btnAdminSearch.TabIndex = 2;
            btnAdminSearch.Text = "Sök";
            btnAdminSearch.UseVisualStyleBackColor = true;
            // 
            // btnOpenRecipe
            // 
            btnOpenRecipe.Location = new Point(607, 345);
            btnOpenRecipe.Name = "btnOpenRecipe";
            btnOpenRecipe.Size = new Size(111, 46);
            btnOpenRecipe.TabIndex = 5;
            btnOpenRecipe.Text = "Öppna recept";
            btnOpenRecipe.UseVisualStyleBackColor = true;
            btnOpenRecipe.Click += btnOpenRecipe_Click;
            // 
            // labelAdminWelcome
            // 
            labelAdminWelcome.AutoSize = true;
            labelAdminWelcome.Location = new Point(198, 71);
            labelAdminWelcome.Name = "labelAdminWelcome";
            labelAdminWelcome.Size = new Size(0, 20);
            labelAdminWelcome.TabIndex = 6;
            // 
            // lbxAdminView
            // 
            lbxAdminView.FormattingEnabled = true;
            lbxAdminView.Location = new Point(443, 126);
            lbxAdminView.Name = "lbxAdminView";
            lbxAdminView.Size = new Size(275, 204);
            lbxAdminView.TabIndex = 7;
            lbxAdminView.SelectedIndexChanged += lbxAdminView_SelectedIndexChanged;
            // 
            // txtSearchItem
            // 
            txtSearchItem.Location = new Point(35, 71);
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.Size = new Size(163, 27);
            txtSearchItem.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(37, 192);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(249, 134);
            txtDescription.TabIndex = 9;
            // 
            // chkName
            // 
            chkName.AutoSize = true;
            chkName.Location = new Point(443, 87);
            chkName.Name = "chkName";
            chkName.Size = new Size(71, 24);
            chkName.TabIndex = 10;
            chkName.Text = "Namn";
            chkName.UseVisualStyleBackColor = true;
            // 
            // chkType
            // 
            chkType.AutoSize = true;
            chkType.Location = new Point(550, 87);
            chkType.Name = "chkType";
            chkType.Size = new Size(54, 24);
            chkType.TabIndex = 11;
            chkType.Text = "Typ";
            chkType.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(443, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(208, 27);
            txtSearch.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(37, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 28);
            comboBox1.TabIndex = 14;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(37, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(51, 20);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "Rubrik";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(37, 110);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(66, 20);
            lblCategory.TabIndex = 16;
            lblCategory.Text = "Kategori";
            // 
            // btnGetAllRecipes
            // 
            btnGetAllRecipes.Location = new Point(443, 345);
            btnGetAllRecipes.Name = "btnGetAllRecipes";
            btnGetAllRecipes.Size = new Size(111, 46);
            btnGetAllRecipes.TabIndex = 17;
            btnGetAllRecipes.Text = "Hämta alla";
            btnGetAllRecipes.UseVisualStyleBackColor = true;
            btnGetAllRecipes.Click += btnGetAllRecipes_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(38, 169);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(84, 20);
            lblDescription.TabIndex = 18;
            lblDescription.Text = "Beskrivning";
            // 
            // FrmAdminScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDescription);
            Controls.Add(btnGetAllRecipes);
            Controls.Add(lblCategory);
            Controls.Add(lblTitle);
            Controls.Add(comboBox1);
            Controls.Add(txtSearch);
            Controls.Add(chkType);
            Controls.Add(chkName);
            Controls.Add(txtDescription);
            Controls.Add(txtSearchItem);
            Controls.Add(lbxAdminView);
            Controls.Add(labelAdminWelcome);
            Controls.Add(btnOpenRecipe);
            Controls.Add(btnAdminSearch);
            Controls.Add(btnCreate);
            Name = "FrmAdminScreen";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnAdminSearch;
        private Button btnOpenRecipe;
        private Label labelAdminWelcome;
        private ListBox lbxAdminView;
        private TextBox txtSearchItem;
        private TextBox txtDescription;
        private CheckBox chkName;
        private CheckBox chkType;
        private TextBox txtSearch;
        private ComboBox comboBox1;
        private Label lblTitle;
        private Label lblCategory;
        private Button btnGetAllRecipes;
        private Label lblDescription;
    }
}