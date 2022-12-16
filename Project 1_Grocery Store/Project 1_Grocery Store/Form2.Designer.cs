namespace Project_1_Grocery_Store
{
    partial class Form2
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
            this.AddProductL = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Unit = new System.Windows.Forms.Label();
            this.ProductNametxt = new System.Windows.Forms.TextBox();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.Unittxt = new System.Windows.Forms.ComboBox();
            this.AutoID = new System.Windows.Forms.CheckBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProductL
            // 
            this.AddProductL.AutoSize = true;
            this.AddProductL.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductL.Location = new System.Drawing.Point(31, 34);
            this.AddProductL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProductL.Name = "AddProductL";
            this.AddProductL.Size = new System.Drawing.Size(334, 64);
            this.AddProductL.TabIndex = 1;
            this.AddProductL.Text = "Add Product";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(36, 153);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(209, 32);
            this.ProductName.TabIndex = 2;
            this.ProductName.Text = "Product Name: ";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(36, 216);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(49, 32);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID:";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(36, 288);
            this.Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(87, 32);
            this.Price.TabIndex = 4;
            this.Price.Text = "Price:";
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit.Location = new System.Drawing.Point(36, 365);
            this.Unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(73, 32);
            this.Unit.TabIndex = 5;
            this.Unit.Text = "Unit:";
            // 
            // ProductNametxt
            // 
            this.ProductNametxt.Location = new System.Drawing.Point(292, 159);
            this.ProductNametxt.Margin = new System.Windows.Forms.Padding(2);
            this.ProductNametxt.Name = "ProductNametxt";
            this.ProductNametxt.Size = new System.Drawing.Size(212, 26);
            this.ProductNametxt.TabIndex = 7;
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(292, 216);
            this.IDtxt.Margin = new System.Windows.Forms.Padding(2);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(212, 26);
            this.IDtxt.TabIndex = 8;
            // 
            // Pricetxt
            // 
            this.Pricetxt.Location = new System.Drawing.Point(292, 288);
            this.Pricetxt.Margin = new System.Windows.Forms.Padding(2);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(212, 26);
            this.Pricetxt.TabIndex = 9;
            // 
            // Unittxt
            // 
            this.Unittxt.FormattingEnabled = true;
            this.Unittxt.Items.AddRange(new object[] {
            "Piece",
            "g",
            "Kg",
            "L",
            "Lbs",
            "Oz"});
            this.Unittxt.Location = new System.Drawing.Point(292, 365);
            this.Unittxt.Margin = new System.Windows.Forms.Padding(2);
            this.Unittxt.Name = "Unittxt";
            this.Unittxt.Size = new System.Drawing.Size(212, 28);
            this.Unittxt.TabIndex = 10;
            // 
            // AutoID
            // 
            this.AutoID.AutoSize = true;
            this.AutoID.Location = new System.Drawing.Point(571, 216);
            this.AutoID.Margin = new System.Windows.Forms.Padding(2);
            this.AutoID.Name = "AutoID";
            this.AutoID.Size = new System.Drawing.Size(90, 24);
            this.AutoID.TabIndex = 11;
            this.AutoID.Text = "Auto ID";
            this.AutoID.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.Yellow;
            this.AddProduct.Location = new System.Drawing.Point(75, 428);
            this.AddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(255, 59);
            this.AddProduct.TabIndex = 12;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Yellow;
            this.Exit.Location = new System.Drawing.Point(431, 428);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(255, 59);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.AutoID);
            this.Controls.Add(this.Unittxt);
            this.Controls.Add(this.Pricetxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.ProductNametxt);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.AddProductL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProductL;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.TextBox ProductNametxt;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.ComboBox Unittxt;
        private System.Windows.Forms.CheckBox AutoID;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button Exit;
    }
}