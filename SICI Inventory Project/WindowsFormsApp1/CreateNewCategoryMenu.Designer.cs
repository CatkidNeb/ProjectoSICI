namespace WindowsFormsApp1
{
    partial class CreateNewCategoryMenu
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
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.CategoryDescriptionLabel = new System.Windows.Forms.Label();
            this.NewCategoryNameBox = new System.Windows.Forms.TextBox();
            this.NewCategoryDescriptionBox = new System.Windows.Forms.TextBox();
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.FinishNewCategoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.AutoSize = true;
            this.CategoryNameLabel.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.CategoryNameLabel.Location = new System.Drawing.Point(57, 37);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(164, 22);
            this.CategoryNameLabel.TabIndex = 0;
            this.CategoryNameLabel.Text = "Category Name";
            // 
            // CategoryDescriptionLabel
            // 
            this.CategoryDescriptionLabel.AutoSize = true;
            this.CategoryDescriptionLabel.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.CategoryDescriptionLabel.Location = new System.Drawing.Point(57, 107);
            this.CategoryDescriptionLabel.Name = "CategoryDescriptionLabel";
            this.CategoryDescriptionLabel.Size = new System.Drawing.Size(372, 22);
            this.CategoryDescriptionLabel.TabIndex = 1;
            this.CategoryDescriptionLabel.Text = "Write a Category for the Description";
            this.CategoryDescriptionLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // NewCategoryNameBox
            // 
            this.NewCategoryNameBox.Location = new System.Drawing.Point(61, 62);
            this.NewCategoryNameBox.Name = "NewCategoryNameBox";
            this.NewCategoryNameBox.Size = new System.Drawing.Size(100, 22);
            this.NewCategoryNameBox.TabIndex = 2;
            // 
            // NewCategoryDescriptionBox
            // 
            this.NewCategoryDescriptionBox.Location = new System.Drawing.Point(61, 132);
            this.NewCategoryDescriptionBox.Multiline = true;
            this.NewCategoryDescriptionBox.Name = "NewCategoryDescriptionBox";
            this.NewCategoryDescriptionBox.Size = new System.Drawing.Size(419, 119);
            this.NewCategoryDescriptionBox.TabIndex = 3;
            // 
            // ReturnToMenuButton
            // 
            this.ReturnToMenuButton.Location = new System.Drawing.Point(87, 270);
            this.ReturnToMenuButton.Name = "ReturnToMenuButton";
            this.ReturnToMenuButton.Size = new System.Drawing.Size(121, 41);
            this.ReturnToMenuButton.TabIndex = 4;
            this.ReturnToMenuButton.Text = "Back to Menu";
            this.ReturnToMenuButton.UseVisualStyleBackColor = true;
            // 
            // FinishNewCategoryButton
            // 
            this.FinishNewCategoryButton.Location = new System.Drawing.Point(323, 270);
            this.FinishNewCategoryButton.Name = "FinishNewCategoryButton";
            this.FinishNewCategoryButton.Size = new System.Drawing.Size(121, 41);
            this.FinishNewCategoryButton.TabIndex = 5;
            this.FinishNewCategoryButton.Text = "Finish";
            this.FinishNewCategoryButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 346);
            this.Controls.Add(this.FinishNewCategoryButton);
            this.Controls.Add(this.ReturnToMenuButton);
            this.Controls.Add(this.NewCategoryDescriptionBox);
            this.Controls.Add(this.NewCategoryNameBox);
            this.Controls.Add(this.CategoryDescriptionLabel);
            this.Controls.Add(this.CategoryNameLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.Label CategoryDescriptionLabel;
        private System.Windows.Forms.TextBox NewCategoryNameBox;
        private System.Windows.Forms.TextBox NewCategoryDescriptionBox;
        private System.Windows.Forms.Button ReturnToMenuButton;
        private System.Windows.Forms.Button FinishNewCategoryButton;
    }
}