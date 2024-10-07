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
            btnSave = new Button();
            btnOpenRecipe = new Button();
            labelAdminWelcome = new Label();
            lbxAdminView = new ListBox();
            txtSearchItem = new TextBox();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(161, 185);
            btnCreate.Margin = new Padding(4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(139, 58);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Skapa";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnAdminSearch
            // 
            btnAdminSearch.Location = new Point(699, 431);
            btnAdminSearch.Margin = new Padding(4);
            btnAdminSearch.Name = "btnAdminSearch";
            btnAdminSearch.Size = new Size(139, 58);
            btnAdminSearch.TabIndex = 2;
            btnAdminSearch.Text = "Sök";
            btnAdminSearch.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(161, 15);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 58);
            btnSave.TabIndex = 4;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnOpenRecipe
            // 
            btnOpenRecipe.Location = new Point(15, 15);
            btnOpenRecipe.Margin = new Padding(4);
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
            labelAdminWelcome.Location = new Point(248, 89);
            labelAdminWelcome.Margin = new Padding(4, 0, 4, 0);
            labelAdminWelcome.Name = "labelAdminWelcome";
            labelAdminWelcome.Size = new Size(0, 25);
            labelAdminWelcome.TabIndex = 6;
            // 
            // lbxAdminView
            // 
            lbxAdminView.FormattingEnabled = true;
            lbxAdminView.ItemHeight = 25;
            lbxAdminView.Location = new Point(308, 15);
            lbxAdminView.Margin = new Padding(4);
            lbxAdminView.Name = "lbxAdminView";
            lbxAdminView.Size = new Size(529, 354);
            lbxAdminView.TabIndex = 7;
            lbxAdminView.SelectedIndexChanged += lbxAdminView_SelectedIndexChanged;
            // 
            // txtSearchItem
            // 
            txtSearchItem.Location = new Point(634, 390);
            txtSearchItem.Margin = new Padding(4);
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.Size = new Size(203, 31);
            txtSearchItem.TabIndex = 8;
            // 
            // FrmAdminScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(txtSearchItem);
            Controls.Add(lbxAdminView);
            Controls.Add(labelAdminWelcome);
            Controls.Add(btnOpenRecipe);
            Controls.Add(btnSave);
            Controls.Add(btnAdminSearch);
            Controls.Add(btnCreate);
            Margin = new Padding(4);
            Name = "FrmAdminScreen";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnAdminSearch;
        private Button btnSave;
        private Button btnOpenRecipe;
        private Label labelAdminWelcome;
        private ListBox lbxAdminView;
        private TextBox txtSearchItem;
    }
}