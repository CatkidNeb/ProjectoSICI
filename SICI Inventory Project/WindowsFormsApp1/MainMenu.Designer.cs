namespace WindowsFormsApp1
{
    partial class WelcomeMenu
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
            this.WelcomeTextLabel = new System.Windows.Forms.Label();
            this.MenuQuestionLabel = new System.Windows.Forms.Label();
            this.NewListingMenuButton = new System.Windows.Forms.Button();
            this.NewCategoryMenuButton = new System.Windows.Forms.Button();
            this.EditListingMenuButton = new System.Windows.Forms.Button();
            this.EditCategoryMenuButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.CreateMenuLabel = new System.Windows.Forms.Label();
            this.EditMenuLabel = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeTextLabel
            // 
            this.WelcomeTextLabel.AutoSize = true;
            this.WelcomeTextLabel.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeTextLabel.Location = new System.Drawing.Point(212, 43);
            this.WelcomeTextLabel.Name = "WelcomeTextLabel";
            this.WelcomeTextLabel.Size = new System.Drawing.Size(483, 32);
            this.WelcomeTextLabel.TabIndex = 0;
            this.WelcomeTextLabel.Text = "Welcome <INSERTNAMEHERE>>!";
            this.WelcomeTextLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuQuestionLabel
            // 
            this.MenuQuestionLabel.AutoSize = true;
            this.MenuQuestionLabel.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuQuestionLabel.Location = new System.Drawing.Point(174, 104);
            this.MenuQuestionLabel.Name = "MenuQuestionLabel";
            this.MenuQuestionLabel.Size = new System.Drawing.Size(324, 27);
            this.MenuQuestionLabel.TabIndex = 1;
            this.MenuQuestionLabel.Text = "What would you like to do?";
            // 
            // NewListingMenuButton
            // 
            this.NewListingMenuButton.Location = new System.Drawing.Point(141, 224);
            this.NewListingMenuButton.Name = "NewListingMenuButton";
            this.NewListingMenuButton.Size = new System.Drawing.Size(127, 65);
            this.NewListingMenuButton.TabIndex = 2;
            this.NewListingMenuButton.Text = "New Listing";
            this.NewListingMenuButton.UseVisualStyleBackColor = true;
            // 
            // NewCategoryMenuButton
            // 
            this.NewCategoryMenuButton.Location = new System.Drawing.Point(141, 317);
            this.NewCategoryMenuButton.Name = "NewCategoryMenuButton";
            this.NewCategoryMenuButton.Size = new System.Drawing.Size(127, 65);
            this.NewCategoryMenuButton.TabIndex = 3;
            this.NewCategoryMenuButton.Text = "New Category";
            this.NewCategoryMenuButton.UseVisualStyleBackColor = true;
            // 
            // EditListingMenuButton
            // 
            this.EditListingMenuButton.Location = new System.Drawing.Point(410, 224);
            this.EditListingMenuButton.Name = "EditListingMenuButton";
            this.EditListingMenuButton.Size = new System.Drawing.Size(127, 65);
            this.EditListingMenuButton.TabIndex = 4;
            this.EditListingMenuButton.Text = "Edit Listing";
            this.EditListingMenuButton.UseVisualStyleBackColor = true;
            // 
            // EditCategoryMenuButton
            // 
            this.EditCategoryMenuButton.Location = new System.Drawing.Point(410, 317);
            this.EditCategoryMenuButton.Name = "EditCategoryMenuButton";
            this.EditCategoryMenuButton.Size = new System.Drawing.Size(127, 65);
            this.EditCategoryMenuButton.TabIndex = 5;
            this.EditCategoryMenuButton.Text = "Edit Category";
            this.EditCategoryMenuButton.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(304, 347);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // CreateMenuLabel
            // 
            this.CreateMenuLabel.AutoSize = true;
            this.CreateMenuLabel.Location = new System.Drawing.Point(176, 188);
            this.CreateMenuLabel.Name = "CreateMenuLabel";
            this.CreateMenuLabel.Size = new System.Drawing.Size(53, 17);
            this.CreateMenuLabel.TabIndex = 7;
            this.CreateMenuLabel.Text = "Create!";
            // 
            // EditMenuLabel
            // 
            this.EditMenuLabel.AutoSize = true;
            this.EditMenuLabel.Location = new System.Drawing.Point(452, 188);
            this.EditMenuLabel.Name = "EditMenuLabel";
            this.EditMenuLabel.Size = new System.Drawing.Size(35, 17);
            this.EditMenuLabel.TabIndex = 8;
            this.EditMenuLabel.Text = "Edit!";
            this.EditMenuLabel.Click += new System.EventHandler(this.EditMenuLabel_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(304, 294);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // WelcomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 454);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.EditMenuLabel);
            this.Controls.Add(this.CreateMenuLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.EditCategoryMenuButton);
            this.Controls.Add(this.EditListingMenuButton);
            this.Controls.Add(this.NewCategoryMenuButton);
            this.Controls.Add(this.NewListingMenuButton);
            this.Controls.Add(this.MenuQuestionLabel);
            this.Controls.Add(this.WelcomeTextLabel);
            this.Name = "WelcomeMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.WelcomeMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeTextLabel;
        private System.Windows.Forms.Label MenuQuestionLabel;
        private System.Windows.Forms.Button NewListingMenuButton;
        private System.Windows.Forms.Button NewCategoryMenuButton;
        private System.Windows.Forms.Button EditListingMenuButton;
        private System.Windows.Forms.Button EditCategoryMenuButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label CreateMenuLabel;
        private System.Windows.Forms.Label EditMenuLabel;
        private System.Windows.Forms.Button button6;
    }
}