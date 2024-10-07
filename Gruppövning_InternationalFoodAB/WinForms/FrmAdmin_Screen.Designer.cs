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
            btnUpdate = new Button();
            btnAdminSearch = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnOpenRecipe = new Button();
            labelAdminWelcome = new Label();
            lbxAdminView = new ListBox();
            txtSearchItem = new TextBox();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(129, 148);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(111, 46);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Skapa";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(129, 200);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 46);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Uppdatera";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdminSearch
            // 
            btnAdminSearch.Location = new Point(559, 345);
            btnAdminSearch.Name = "btnAdminSearch";
            btnAdminSearch.Size = new Size(111, 46);
            btnAdminSearch.TabIndex = 2;
            btnAdminSearch.Text = "Sök";
            btnAdminSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(129, 252);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 46);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Ta Bort";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(129, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 46);
            btnSave.TabIndex = 4;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnOpenRecipe
            // 
            btnOpenRecipe.Location = new Point(12, 12);
            btnOpenRecipe.Name = "btnOpenRecipe";
            btnOpenRecipe.Size = new Size(111, 46);
            btnOpenRecipe.TabIndex = 5;
            btnOpenRecipe.Text = "Öppna recept";
            btnOpenRecipe.UseVisualStyleBackColor = true;
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
            lbxAdminView.Location = new Point(246, 12);
            lbxAdminView.Name = "lbxAdminView";
            lbxAdminView.Size = new Size(424, 284);
            lbxAdminView.TabIndex = 7;
            // 
            // txtSearchItem
            // 
            txtSearchItem.Location = new Point(507, 312);
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.Size = new Size(163, 27);
            txtSearchItem.TabIndex = 8;
            // 
            // FrmAdminScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearchItem);
            Controls.Add(lbxAdminView);
            Controls.Add(labelAdminWelcome);
            Controls.Add(btnOpenRecipe);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnAdminSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Name = "FrmAdminScreen";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnUpdate;
        private Button btnAdminSearch;
        private Button btnDelete;
        private Button btnSave;
        private Button btnOpenRecipe;
        private Label labelAdminWelcome;
        private ListBox lbxAdminView;
        private TextBox txtSearchItem;
    }
}