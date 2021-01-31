
namespace MegaDesk_Carlson
{
    partial class AddQuote
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.deskWidth = new System.Windows.Forms.TextBox();
            this.deskDepth = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.ButtonSaveQuote = new System.Windows.Forms.Button();
            this.numDrawers = new System.Windows.Forms.TextBox();
            this.drawersLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.surfaceMaterials = new System.Windows.Forms.ComboBox();
            this.rushOrder = new System.Windows.Forms.ComboBox();
            this.rushLabel = new System.Windows.Forms.Label();
            this.quoteDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(35, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(161, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Customer Name:";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(47, 50);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(154, 20);
            this.customerName.TabIndex = 1;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.BackColor = System.Drawing.Color.Transparent;
            this.widthLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.ForeColor = System.Drawing.Color.White;
            this.widthLabel.Location = new System.Drawing.Point(35, 98);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(63, 20);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width";
            // 
            // deskWidth
            // 
            this.deskWidth.Location = new System.Drawing.Point(47, 121);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(154, 20);
            this.deskWidth.TabIndex = 2;
            this.deskWidth.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            // 
            // deskDepth
            // 
            this.deskDepth.Location = new System.Drawing.Point(47, 192);
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(154, 20);
            this.deskDepth.TabIndex = 3;
            this.deskDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Depth_KeyPress);
            this.deskDepth.Validating += new System.ComponentModel.CancelEventHandler(this.Depth_Validating);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.BackColor = System.Drawing.Color.Transparent;
            this.depthLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.ForeColor = System.Drawing.Color.White;
            this.depthLabel.Location = new System.Drawing.Point(35, 169);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(63, 20);
            this.depthLabel.TabIndex = 4;
            this.depthLabel.Text = "Depth";
            // 
            // ButtonSaveQuote
            // 
            this.ButtonSaveQuote.Location = new System.Drawing.Point(453, 374);
            this.ButtonSaveQuote.Name = "ButtonSaveQuote";
            this.ButtonSaveQuote.Size = new System.Drawing.Size(154, 55);
            this.ButtonSaveQuote.TabIndex = 7;
            this.ButtonSaveQuote.Text = "Save Quote";
            this.ButtonSaveQuote.UseVisualStyleBackColor = true;
            this.ButtonSaveQuote.Click += new System.EventHandler(this.ButtonSaveQuote_Click);
            // 
            // numDrawers
            // 
            this.numDrawers.Location = new System.Drawing.Point(47, 261);
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.Size = new System.Drawing.Size(154, 20);
            this.numDrawers.TabIndex = 4;
            this.numDrawers.Validating += new System.ComponentModel.CancelEventHandler(this.numDrawers_Validating);
            // 
            // drawersLabel
            // 
            this.drawersLabel.AutoSize = true;
            this.drawersLabel.BackColor = System.Drawing.Color.Transparent;
            this.drawersLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersLabel.ForeColor = System.Drawing.Color.White;
            this.drawersLabel.Location = new System.Drawing.Point(35, 238);
            this.drawersLabel.Name = "drawersLabel";
            this.drawersLabel.Size = new System.Drawing.Size(183, 20);
            this.drawersLabel.TabIndex = 8;
            this.drawersLabel.Text = "Number of Drawers";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.ForeColor = System.Drawing.Color.White;
            this.materialLabel.Location = new System.Drawing.Point(35, 306);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(164, 20);
            this.materialLabel.TabIndex = 10;
            this.materialLabel.Text = "Desktop Material";
            // 
            // surfaceMaterials
            // 
            this.surfaceMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfaceMaterials.FormattingEnabled = true;
            this.surfaceMaterials.Location = new System.Drawing.Point(47, 329);
            this.surfaceMaterials.Name = "surfaceMaterials";
            this.surfaceMaterials.Size = new System.Drawing.Size(154, 21);
            this.surfaceMaterials.TabIndex = 5;
            // 
            // rushOrder
            // 
            this.rushOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rushOrder.FormattingEnabled = true;
            this.rushOrder.Location = new System.Drawing.Point(47, 397);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(154, 21);
            this.rushOrder.TabIndex = 6;
            // 
            // rushLabel
            // 
            this.rushLabel.AutoSize = true;
            this.rushLabel.BackColor = System.Drawing.Color.Transparent;
            this.rushLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushLabel.ForeColor = System.Drawing.Color.White;
            this.rushLabel.Location = new System.Drawing.Point(35, 374);
            this.rushLabel.Name = "rushLabel";
            this.rushLabel.Size = new System.Drawing.Size(110, 20);
            this.rushLabel.TabIndex = 12;
            this.rushLabel.Text = "Rush Order";
            // 
            // quoteDate
            // 
            this.quoteDate.Location = new System.Drawing.Point(407, 27);
            this.quoteDate.Name = "quoteDate";
            this.quoteDate.Size = new System.Drawing.Size(200, 20);
            this.quoteDate.TabIndex = 14;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk_Carlson.Properties.Resources.pablo_2_;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.quoteDate);
            this.Controls.Add(this.rushOrder);
            this.Controls.Add(this.rushLabel);
            this.Controls.Add(this.surfaceMaterials);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.drawersLabel);
            this.Controls.Add(this.ButtonSaveQuote);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox deskWidth;
        private System.Windows.Forms.TextBox deskDepth;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Button ButtonSaveQuote;
        private System.Windows.Forms.TextBox numDrawers;
        private System.Windows.Forms.Label drawersLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.ComboBox surfaceMaterials;
        private System.Windows.Forms.ComboBox rushOrder;
        private System.Windows.Forms.Label rushLabel;
        private System.Windows.Forms.DateTimePicker quoteDate;
    }
}