﻿namespace Gruppövning_InternationalFoodAB.WinForms
{
    partial class FrmGuest_ShowRecept
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
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblTypeOfRecept = new Label();
            txtTypeOfRecept = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblReciept = new Label();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(120, 275);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(93, 25);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "Gör så här";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ButtonHighlight;
            txtDescription.Location = new Point(231, 272);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(688, 237);
            txtDescription.TabIndex = 10;
            txtDescription.TabStop = false;
            // 
            // lblTypeOfRecept
            // 
            lblTypeOfRecept.AutoSize = true;
            lblTypeOfRecept.Location = new Point(120, 217);
            lblTypeOfRecept.Name = "lblTypeOfRecept";
            lblTypeOfRecept.Size = new Size(78, 25);
            lblTypeOfRecept.TabIndex = 9;
            lblTypeOfRecept.Text = "Kategori";
            // 
            // txtTypeOfRecept
            // 
            txtTypeOfRecept.BackColor = SystemColors.ButtonHighlight;
            txtTypeOfRecept.Location = new Point(231, 215);
            txtTypeOfRecept.Name = "txtTypeOfRecept";
            txtTypeOfRecept.ReadOnly = true;
            txtTypeOfRecept.Size = new Size(237, 31);
            txtTypeOfRecept.TabIndex = 8;
            txtTypeOfRecept.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(120, 162);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 25);
            lblName.TabIndex = 7;
            lblName.Text = "Namn";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonHighlight;
            txtName.Location = new Point(231, 160);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(237, 31);
            txtName.TabIndex = 6;
            txtName.TabStop = false;
            // 
            // lblReciept
            // 
            lblReciept.AutoSize = true;
            lblReciept.Font = new Font("Showcard Gothic", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReciept.Location = new Point(231, 29);
            lblReciept.Margin = new Padding(4, 0, 4, 0);
            lblReciept.Name = "lblReciept";
            lblReciept.Size = new Size(271, 79);
            lblReciept.TabIndex = 12;
            lblReciept.Text = "Recept";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(789, 528);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(130, 57);
            buttonClose.TabIndex = 13;
            buttonClose.Text = "Stäng";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FrmGuest_ShowRecept
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 616);
            Controls.Add(buttonClose);
            Controls.Add(lblReciept);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblTypeOfRecept);
            Controls.Add(txtTypeOfRecept);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Name = "FrmGuest_ShowRecept";
            Text = "Visa recept";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblTypeOfRecept;
        private TextBox txtTypeOfRecept;
        private Label lblName;
        private TextBox txtName;
        private Label lblReciept;
        private Button buttonClose;
    }
}