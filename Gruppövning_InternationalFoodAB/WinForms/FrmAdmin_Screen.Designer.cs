﻿namespace Gruppövning_InternationalFoodAB.WinForms
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
            buttonStänga = new Button();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(209, 468);
            btnCreate.Margin = new Padding(4, 4, 4, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(139, 58);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Skapa";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnAdminSearch
            // 
            btnAdminSearch.Location = new Point(832, 49);
            btnAdminSearch.Margin = new Padding(4, 4, 4, 4);
            btnAdminSearch.Name = "btnAdminSearch";
            btnAdminSearch.Size = new Size(120, 41);
            btnAdminSearch.TabIndex = 2;
            btnAdminSearch.Text = "Sök";
            btnAdminSearch.UseVisualStyleBackColor = true;
            btnAdminSearch.Click += btnAdminSearch_Click;
            // 
            // btnOpenRecipe
            // 
            btnOpenRecipe.Location = new Point(759, 431);
            btnOpenRecipe.Margin = new Padding(4, 4, 4, 4);
            btnOpenRecipe.Name = "btnOpenRecipe";
            btnOpenRecipe.Size = new Size(139, 58);
            btnOpenRecipe.TabIndex = 5;
            btnOpenRecipe.Text = "Öppna recept";
            btnOpenRecipe.UseVisualStyleBackColor = true;
            btnOpenRecipe.Click += btnOpenRecipe_Click;
            // 
            // labelAdminWelcome
            // 
            labelAdminWelcome.AutoSize = true;
            labelAdminWelcome.Location = new Point(236, 64);
            labelAdminWelcome.Margin = new Padding(4, 0, 4, 0);
            labelAdminWelcome.Name = "labelAdminWelcome";
            labelAdminWelcome.Size = new Size(0, 25);
            labelAdminWelcome.TabIndex = 6;
            // 
            // lbxAdminView
            // 
            lbxAdminView.FormattingEnabled = true;
            lbxAdminView.ItemHeight = 25;
            lbxAdminView.Location = new Point(554, 158);
            lbxAdminView.Margin = new Padding(4, 4, 4, 4);
            lbxAdminView.Name = "lbxAdminView";
            lbxAdminView.Size = new Size(343, 254);
            lbxAdminView.TabIndex = 7;
            lbxAdminView.SelectedIndexChanged += lbxAdminView_SelectedIndexChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(35, 80);
            txtTitle.Margin = new Padding(4, 4, 4, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(203, 31);
            txtTitle.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(35, 281);
            txtDescription.Margin = new Padding(4, 4, 4, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(310, 166);
            txtDescription.TabIndex = 9;
            // 
            // chkName
            // 
            chkName.AutoSize = true;
            chkName.Location = new Point(554, 109);
            chkName.Margin = new Padding(4, 4, 4, 4);
            chkName.Name = "chkName";
            chkName.Size = new Size(86, 29);
            chkName.TabIndex = 10;
            chkName.Text = "Namn";
            chkName.UseVisualStyleBackColor = true;
            // 
            // chkType
            // 
            chkType.AutoSize = true;
            chkType.Location = new Point(688, 109);
            chkType.Margin = new Padding(4, 4, 4, 4);
            chkType.Name = "chkType";
            chkType.Size = new Size(66, 29);
            chkType.TabIndex = 11;
            chkType.Text = "Typ";
            chkType.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(554, 56);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(259, 31);
            txtSearch.TabIndex = 12;
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(32, 146);
            cbxCategory.Margin = new Padding(4, 4, 4, 4);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(205, 33);
            cbxCategory.TabIndex = 14;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(35, 51);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(67, 25);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "Rubrik:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(32, 118);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(82, 25);
            lblCategory.TabIndex = 16;
            lblCategory.Text = "Kategori:";
            // 
            // btnGetAllRecipes
            // 
            btnGetAllRecipes.Location = new Point(554, 431);
            btnGetAllRecipes.Margin = new Padding(4, 4, 4, 4);
            btnGetAllRecipes.Name = "btnGetAllRecipes";
            btnGetAllRecipes.Size = new Size(139, 58);
            btnGetAllRecipes.TabIndex = 17;
            btnGetAllRecipes.Text = "Hämta alla";
            btnGetAllRecipes.UseVisualStyleBackColor = true;
            btnGetAllRecipes.Click += btnGetAllRecipes_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(35, 252);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 18;
            lblDescription.Text = "Beskrivning";
            // 
            // txtNewCategory
            // 
            txtNewCategory.Location = new Point(32, 211);
            txtNewCategory.Margin = new Padding(2);
            txtNewCategory.Name = "txtNewCategory";
            txtNewCategory.Size = new Size(186, 31);
            txtNewCategory.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 59);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 20;
            // 
            // lblNewCategory
            // 
            lblNewCategory.AutoSize = true;
            lblNewCategory.Location = new Point(32, 184);
            lblNewCategory.Margin = new Padding(2, 0, 2, 0);
            lblNewCategory.Name = "lblNewCategory";
            lblNewCategory.Size = new Size(172, 25);
            lblNewCategory.TabIndex = 21;
            lblNewCategory.Text = "Lägg till ny kategori:";
            // 
            // btnNewCategory
            // 
            btnNewCategory.Location = new Point(232, 211);
            btnNewCategory.Margin = new Padding(2);
            btnNewCategory.Name = "btnNewCategory";
            btnNewCategory.Size = new Size(110, 34);
            btnNewCategory.TabIndex = 22;
            btnNewCategory.Text = "Lägg till";
            btnNewCategory.UseVisualStyleBackColor = true;
            btnNewCategory.Click += btnNewCategory_Click;
            // 
            // buttonStänga
            // 
            buttonStänga.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStänga.Location = new Point(678, 527);
            buttonStänga.Name = "buttonStänga";
            buttonStänga.Size = new Size(222, 51);
            buttonStänga.TabIndex = 23;
            buttonStänga.Text = "Stäng Allt";
            buttonStänga.UseVisualStyleBackColor = true;
            buttonStänga.Click += buttonStänga_Click;
            // 
            // FrmAdminScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 619);
            Controls.Add(buttonStänga);
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
            Margin = new Padding(4, 4, 4, 4);
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
        private Button buttonStänga;
    }
}