namespace ListAndAdd
{
    partial class Form1
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
			this.lstProducts = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.txtUnitPrice = new System.Windows.Forms.TextBox();
			this.cmbCatagories = new System.Windows.Forms.ComboBox();
			this.btnAddProducts = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstProducts
			// 
			this.lstProducts.FormattingEnabled = true;
			this.lstProducts.ItemHeight = 20;
			this.lstProducts.Location = new System.Drawing.Point(885, 62);
			this.lstProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lstProducts.Name = "lstProducts";
			this.lstProducts.Size = new System.Drawing.Size(262, 544);
			this.lstProducts.TabIndex = 0;
			this.lstProducts.Click += new System.EventHandler(this.lstProducts_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(170, 88);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "ProductName";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(170, 252);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "ProductsPreice";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(170, 462);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Catagories";
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(174, 148);
			this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(148, 26);
			this.txtProductName.TabIndex = 4;
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.Location = new System.Drawing.Point(174, 340);
			this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtUnitPrice.Name = "txtUnitPrice";
			this.txtUnitPrice.Size = new System.Drawing.Size(148, 26);
			this.txtUnitPrice.TabIndex = 5;
			// 
			// cmbCatagories
			// 
			this.cmbCatagories.FormattingEnabled = true;
			this.cmbCatagories.Location = new System.Drawing.Point(174, 575);
			this.cmbCatagories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmbCatagories.Name = "cmbCatagories";
			this.cmbCatagories.Size = new System.Drawing.Size(180, 28);
			this.cmbCatagories.TabIndex = 6;
			// 
			// btnAddProducts
			// 
			this.btnAddProducts.Location = new System.Drawing.Point(174, 688);
			this.btnAddProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAddProducts.Name = "btnAddProducts";
			this.btnAddProducts.Size = new System.Drawing.Size(177, 69);
			this.btnAddProducts.TabIndex = 7;
			this.btnAddProducts.Text = "AddProducts";
			this.btnAddProducts.UseVisualStyleBackColor = true;
			this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(466, 688);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(154, 69);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "DeleteProduct";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(794, 688);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(144, 69);
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "UpdateProduct";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1163, 811);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAddProducts);
			this.Controls.Add(this.cmbCatagories);
			this.Controls.Add(this.txtUnitPrice);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstProducts);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.ComboBox cmbCatagories;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

