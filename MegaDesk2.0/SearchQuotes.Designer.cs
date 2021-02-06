
namespace MegaDesk_Carlson
{
    partial class SearchQuotes
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
            this.surfaceMaterials = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialsView = new System.Windows.Forms.DataGridView();
            this.showAllQuotesBtn = new System.Windows.Forms.Button();
            this.MainMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.materialsView)).BeginInit();
            this.SuspendLayout();
            // 
            // surfaceMaterials
            // 
            this.surfaceMaterials.FormattingEnabled = true;
            this.surfaceMaterials.Location = new System.Drawing.Point(15, 73);
            this.surfaceMaterials.Name = "surfaceMaterials";
            this.surfaceMaterials.Size = new System.Drawing.Size(155, 21);
            this.surfaceMaterials.TabIndex = 0;
            this.surfaceMaterials.SelectedIndexChanged += new System.EventHandler(this.surfaceMaterials_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Material To Find A Quote";
            // 
            // materialsView
            // 
            this.materialsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsView.Location = new System.Drawing.Point(12, 166);
            this.materialsView.Name = "materialsView";
            this.materialsView.Size = new System.Drawing.Size(855, 272);
            this.materialsView.TabIndex = 2;
            // 
            // showAllQuotesBtn
            // 
            this.showAllQuotesBtn.Location = new System.Drawing.Point(712, 87);
            this.showAllQuotesBtn.Name = "showAllQuotesBtn";
            this.showAllQuotesBtn.Size = new System.Drawing.Size(155, 57);
            this.showAllQuotesBtn.TabIndex = 4;
            this.showAllQuotesBtn.Text = "Show All Quotes";
            this.showAllQuotesBtn.UseVisualStyleBackColor = true;
            this.showAllQuotesBtn.Click += new System.EventHandler(this.showAllQuotesBtn_Click);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(712, 12);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(155, 57);
            this.MainMenuButton.TabIndex = 17;
            this.MainMenuButton.Text = "Return to Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.showAllQuotesBtn);
            this.Controls.Add(this.materialsView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surfaceMaterials);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.materialsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox surfaceMaterials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView materialsView;
        private System.Windows.Forms.Button showAllQuotesBtn;
        private System.Windows.Forms.Button MainMenuButton;
    }
}