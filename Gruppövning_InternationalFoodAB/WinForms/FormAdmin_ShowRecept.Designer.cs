namespace Gruppövning_InternationalFoodAB.WinForms
{
    partial class FormAdmin_ShowRecept
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
            txtName = new TextBox();
            lblName = new Label();
            lblTypeOfRecept = new Label();
            txtTypeOfRecept = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(165, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 31);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(54, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Namn";
            // 
            // lblTypeOfRecept
            // 
            lblTypeOfRecept.AutoSize = true;
            lblTypeOfRecept.Location = new Point(54, 116);
            lblTypeOfRecept.Name = "lblTypeOfRecept";
            lblTypeOfRecept.Size = new Size(78, 25);
            lblTypeOfRecept.TabIndex = 3;
            lblTypeOfRecept.Text = "Kategori";
            // 
            // txtTypeOfRecept
            // 
            txtTypeOfRecept.Location = new Point(165, 114);
            txtTypeOfRecept.Name = "txtTypeOfRecept";
            txtTypeOfRecept.Size = new Size(237, 31);
            txtTypeOfRecept.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(54, 174);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(93, 25);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Gör så här";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(165, 171);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(467, 158);
            txtDescription.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(493, 354);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(139, 58);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Ta Bort";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(335, 354);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(139, 58);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Uppdatera";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormAdmin_SelectedRecept
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 529);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblTypeOfRecept);
            Controls.Add(txtTypeOfRecept);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Name = "FormAdmin_SelectedRecept";
            Text = "FormAdmin_SelectedRecept";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private Label lblTypeOfRecept;
        private TextBox txtTypeOfRecept;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnDelete;
        private Button btnUpdate;
    }
}