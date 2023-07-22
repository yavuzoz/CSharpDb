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
			this.btnTake = new System.Windows.Forms.Button();
			this.btnSkip = new System.Windows.Forms.Button();
			this.btnFind = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProducts
			// 
			this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Location = new System.Drawing.Point(60, 38);
			this.dgvProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.Size = new System.Drawing.Size(841, 420);
			this.dgvProducts.TabIndex = 0;
			// 
			// btnWhere
			// 
			this.btnWhere.Location = new System.Drawing.Point(51, 522);
			this.btnWhere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnWhere.Name = "btnWhere";
			this.btnWhere.Size = new System.Drawing.Size(158, 56);
			this.btnWhere.TabIndex = 1;
			this.btnWhere.Text = "Where";
			this.btnWhere.UseVisualStyleBackColor = true;
			this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
			// 
			// btnOrderBy
			// 
			this.btnOrderBy.Location = new System.Drawing.Point(229, 522);
			this.btnOrderBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnOrderBy.Name = "btnOrderBy";
			this.btnOrderBy.Size = new System.Drawing.Size(138, 56);
			this.btnOrderBy.TabIndex = 2;
			this.btnOrderBy.Text = "OrderBy";
			this.btnOrderBy.UseVisualStyleBackColor = true;
			this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
			// 
			// btnCategoryName
			// 
			this.btnCategoryName.Location = new System.Drawing.Point(387, 522);
			this.btnCategoryName.Name = "btnCategoryName";
			this.btnCategoryName.Size = new System.Drawing.Size(123, 56);
			this.btnCategoryName.TabIndex = 4;
			this.btnCategoryName.Text = "CategoryName";
			this.btnCategoryName.UseVisualStyleBackColor = true;
			this.btnCategoryName.Click += new System.EventHandler(this.btnCategoryName_Click);
			// 
			// btnTake
			// 
			this.btnTake.Location = new System.Drawing.Point(530, 522);
			this.btnTake.Name = "btnTake";
			this.btnTake.Size = new System.Drawing.Size(116, 56);
			this.btnTake.TabIndex = 5;
			this.btnTake.Text = "Take";
			this.btnTake.UseVisualStyleBackColor = true;
			this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
			// 
			// btnSkip
			// 
			this.btnSkip.Location = new System.Drawing.Point(662, 522);
			this.btnSkip.Name = "btnSkip";
			this.btnSkip.Size = new System.Drawing.Size(116, 56);
			this.btnSkip.TabIndex = 6;
			this.btnSkip.Text = "Skip";
			this.btnSkip.UseVisualStyleBackColor = true;
			this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(800, 522);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(116, 56);
			this.btnFind.TabIndex = 7;
			this.btnFind.Text = "Find";
			this.btnFind.UseVisualStyleBackColor = true;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1436, 857);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.btnSkip);
			this.Controls.Add(this.btnTake);
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
		private System.Windows.Forms.Button btnTake;
		private System.Windows.Forms.Button btnSkip;
		private System.Windows.Forms.Button btnFind;
	}
}

