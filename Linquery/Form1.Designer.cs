namespace Linquery
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
			this.dgvProducts = new System.Windows.Forms.DataGridView();
			this.btnWhere = new System.Windows.Forms.Button();
			this.btnOrderBy = new System.Windows.Forms.Button();
			this.btnCategoryName = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProducts
			// 
			this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Location = new System.Drawing.Point(60, 38);
			this.dgvProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.Size = new System.Drawing.Size(950, 366);
			this.dgvProducts.TabIndex = 0;
			// 
			// btnWhere
			// 
			this.btnWhere.Location = new System.Drawing.Point(60, 522);
			this.btnWhere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnWhere.Name = "btnWhere";
			this.btnWhere.Size = new System.Drawing.Size(208, 95);
			this.btnWhere.TabIndex = 1;
			this.btnWhere.Text = "Where";
			this.btnWhere.UseVisualStyleBackColor = true;
			this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
			// 
			// btnOrderBy
			// 
			this.btnOrderBy.Location = new System.Drawing.Point(326, 522);
			this.btnOrderBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnOrderBy.Name = "btnOrderBy";
			this.btnOrderBy.Size = new System.Drawing.Size(182, 95);
			this.btnOrderBy.TabIndex = 2;
			this.btnOrderBy.Text = "OrderBy";
			this.btnOrderBy.UseVisualStyleBackColor = true;
			this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
			// 
			// btnCategoryName
			// 
			this.btnCategoryName.Location = new System.Drawing.Point(571, 522);
			this.btnCategoryName.Name = "btnCategoryName";
			this.btnCategoryName.Size = new System.Drawing.Size(149, 95);
			this.btnCategoryName.TabIndex = 4;
			this.btnCategoryName.Text = "CategoryName";
			this.btnCategoryName.UseVisualStyleBackColor = true;
			this.btnCategoryName.Click += new System.EventHandler(this.btnCategoryName_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1436, 857);
			this.Controls.Add(this.btnCategoryName);
			this.Controls.Add(this.btnOrderBy);
			this.Controls.Add(this.btnWhere);
			this.Controls.Add(this.dgvProducts);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnOrderBy;
		private System.Windows.Forms.Button btnCategoryName;
	}
}

