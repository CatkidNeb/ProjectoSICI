namespace WindowsFormsApp1
{
    partial class CreateListingMenu
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
            this.NewListingNameBox = new System.Windows.Forms.TextBox();
            this.NewListingDescriptionBox = new System.Windows.Forms.TextBox();
            this.ListingNameLabel = new System.Windows.Forms.Label();
            this.ListingDescriptionLabel = new System.Windows.Forms.Label();
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.FinishNewListingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewListingNameBox
            // 
            this.NewListingNameBox.Location = new System.Drawing.Point(61, 62);
            this.NewListingNameBox.Name = "NewListingNameBox";
            this.NewListingNameBox.Size = new System.Drawing.Size(175, 22);
            this.NewListingNameBox.TabIndex = 0;
            this.NewListingNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NewListingDescriptionBox
            // 
            this.NewListingDescriptionBox.Location = new System.Drawing.Point(61, 132);
            this.NewListingDescriptionBox.Multiline = true;
            this.NewListingDescriptionBox.Name = "NewListingDescriptionBox";
            this.NewListingDescriptionBox.Size = new System.Drawing.Size(419, 119);
            this.NewListingDescriptionBox.TabIndex = 1;
            // 
            // ListingNameLabel
            // 
            this.ListingNameLabel.AutoSize = true;
            this.ListingNameLabel.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListingNameLabel.Location = new System.Drawing.Point(57, 37);
            this.ListingNameLabel.Name = "ListingNameLabel";
            this.ListingNameLabel.Size = new System.Drawing.Size(142, 22);
            this.ListingNameLabel.TabIndex = 2;
            this.ListingNameLabel.Text = "Listing Name";
            this.ListingNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListingDescriptionLabel
            // 
            this.ListingDescriptionLabel.AutoSize = true;
            this.ListingDescriptionLabel.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListingDescriptionLabel.Location = new System.Drawing.Point(57, 107);
            this.ListingDescriptionLabel.Name = "ListingDescriptionLabel";
            this.ListingDescriptionLabel.Size = new System.Drawing.Size(349, 22);
            this.ListingDescriptionLabel.TabIndex = 3;
            this.ListingDescriptionLabel.Text = "Write a description for the listing.";
            this.ListingDescriptionLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ReturnToMenuButton
            // 
            this.ReturnToMenuButton.Location = new System.Drawing.Point(87, 270);
            this.ReturnToMenuButton.Name = "ReturnToMenuButton";
            this.ReturnToMenuButton.Size = new System.Drawing.Size(121, 41);
            this.ReturnToMenuButton.TabIndex = 4;
            this.ReturnToMenuButton.Text = "Back to Menu\r\n";
            this.ReturnToMenuButton.UseVisualStyleBackColor = true;
            this.ReturnToMenuButton.Click += new System.EventHandler(this.ReturnToMenuButton_Click);
            // 
            // FinishNewListingButton
            // 
            this.FinishNewListingButton.Location = new System.Drawing.Point(323, 270);
            this.FinishNewListingButton.Name = "FinishNewListingButton";
            this.FinishNewListingButton.Size = new System.Drawing.Size(121, 41);
            this.FinishNewListingButton.TabIndex = 5;
            this.FinishNewListingButton.Text = "Finish";
            this.FinishNewListingButton.UseVisualStyleBackColor = true;
            this.FinishNewListingButton.Click += new System.EventHandler(this.ContinueNewListingButton_Click);
            // 
            // CreateListingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 346);
            this.Controls.Add(this.FinishNewListingButton);
            this.Controls.Add(this.ReturnToMenuButton);
            this.Controls.Add(this.ListingDescriptionLabel);
            this.Controls.Add(this.ListingNameLabel);
            this.Controls.Add(this.NewListingDescriptionBox);
            this.Controls.Add(this.NewListingNameBox);
            this.Name = "CreateListingMenu";
            this.Text = "Create a New Listing";
            this.Load += new System.EventHandler(this.CreateListingMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewListingNameBox;
        private System.Windows.Forms.TextBox NewListingDescriptionBox;
        private System.Windows.Forms.Label ListingNameLabel;
        private System.Windows.Forms.Label ListingDescriptionLabel;
        private System.Windows.Forms.Button ReturnToMenuButton;
        private System.Windows.Forms.Button FinishNewListingButton;
    }
}