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
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            chkName = new CheckBox();
            chkType = new CheckBox();
            txtSearch = new TextBox();
            cbxCategory = new ComboBox();
            lblTitle = new Label();
            lblCategory = new Label();
            btnGetAllRecipes = new Button();
            lblDescription = new Label();
            txtNewCategory = new TextBox();
            label1 = new Label();
            lblNewCategory = new Label();
            btnNewCategory = new Button();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(173, 397);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(111, 46);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Skapa";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
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
            // txtTitle
            // 
            txtTitle.Location = new Point(35, 71);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(190, 27);
            txtTitle.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(35, 257);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(290, 134);
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
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(35, 137);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(190, 28);
            cbxCategory.TabIndex = 14;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(37, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(54, 20);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "Rubrik:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(35, 111);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 16;
            lblCategory.Text = "Kategori:";
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
            lblDescription.Location = new Point(36, 234);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(84, 20);
            lblDescription.TabIndex = 18;
            lblDescription.Text = "Beskrivning";
            // 
            // txtNewCategory
            // 
            txtNewCategory.Location = new Point(38, 195);
            txtNewCategory.Name = "txtNewCategory";
            txtNewCategory.Size = new Size(187, 27);
            txtNewCategory.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 172);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 20;
            // 
            // lblNewCategory
            // 
            lblNewCategory.AutoSize = true;
            lblNewCategory.Location = new Point(36, 171);
            lblNewCategory.Name = "lblNewCategory";
            lblNewCategory.Size = new Size(144, 20);
            lblNewCategory.TabIndex = 21;
            lblNewCategory.Text = "Lägg till ny kategori:";
            // 
            // btnNewCategory
            // 
            btnNewCategory.Location = new Point(231, 195);
            btnNewCategory.Name = "btnNewCategory";
            btnNewCategory.Size = new Size(94, 29);
            btnNewCategory.TabIndex = 22;
            btnNewCategory.Text = "Lägg till";
            btnNewCategory.UseVisualStyleBackColor = true;
            btnNewCategory.Click += btnNewCategory_Click;
            // 
            // FrmAdminScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNewCategory);
            Controls.Add(lblNewCategory);
            Controls.Add(label1);
            Controls.Add(txtNewCategory);
            Controls.Add(lblDescription);
            Controls.Add(btnGetAllRecipes);
            Controls.Add(lblCategory);
            Controls.Add(lblTitle);
            Controls.Add(cbxCategory);
            Controls.Add(txtSearch);
            Controls.Add(chkType);
            Controls.Add(chkName);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
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
        private TextBox txtTitle;
        private TextBox txtDescription;
        private CheckBox chkName;
        private CheckBox chkType;
        private TextBox txtSearch;
        private ComboBox cbxCategory;
        private Label lblTitle;
        private Label lblCategory;
        private Button btnGetAllRecipes;
        private Label lblDescription;
        private TextBox txtNewCategory;
        private Label label1;
        private Label lblNewCategory;
        private Button btnNewCategory;
    }
}