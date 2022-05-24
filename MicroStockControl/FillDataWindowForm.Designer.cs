namespace MicroStockControl
{
	partial class FillDataWindowForm
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
			this.ProductLabel = new System.Windows.Forms.Label();
			this.ManufacturerLabel = new System.Windows.Forms.Label();
			this.LotLabel = new System.Windows.Forms.Label();
			this.ManufacturingDateLabel = new System.Windows.Forms.Label();
			this.ExpirationDateLabel = new System.Windows.Forms.Label();
			this.UnitLabel = new System.Windows.Forms.Label();
			this.UnitPriceLabel = new System.Windows.Forms.Label();
			this.QuantityStockLabel = new System.Windows.Forms.Label();
			this.IdCodeLabel = new System.Windows.Forms.Label();
			this.BrandLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ProductLabel
			// 
			this.ProductLabel.AutoSize = true;
			this.ProductLabel.Location = new System.Drawing.Point(12, 9);
			this.ProductLabel.Name = "ProductLabel";
			this.ProductLabel.Size = new System.Drawing.Size(53, 15);
			this.ProductLabel.TabIndex = 0;
			this.ProductLabel.Text = "Produto:";
			// 
			// ManufacturerLabel
			// 
			this.ManufacturerLabel.AutoSize = true;
			this.ManufacturerLabel.Location = new System.Drawing.Point(12, 39);
			this.ManufacturerLabel.Name = "ManufacturerLabel";
			this.ManufacturerLabel.Size = new System.Drawing.Size(65, 15);
			this.ManufacturerLabel.TabIndex = 1;
			this.ManufacturerLabel.Text = "Fabricante:";
			// 
			// LotLabel
			// 
			this.LotLabel.AutoSize = true;
			this.LotLabel.Location = new System.Drawing.Point(12, 54);
			this.LotLabel.Name = "LotLabel";
			this.LotLabel.Size = new System.Drawing.Size(33, 15);
			this.LotLabel.TabIndex = 2;
			this.LotLabel.Text = "Lote:";
			// 
			// ManufacturingDateLabel
			// 
			this.ManufacturingDateLabel.AutoSize = true;
			this.ManufacturingDateLabel.Location = new System.Drawing.Point(12, 69);
			this.ManufacturingDateLabel.Name = "ManufacturingDateLabel";
			this.ManufacturingDateLabel.Size = new System.Drawing.Size(110, 15);
			this.ManufacturingDateLabel.TabIndex = 3;
			this.ManufacturingDateLabel.Text = "Data de Fabricação:";
			// 
			// ExpirationDateLabel
			// 
			this.ExpirationDateLabel.AutoSize = true;
			this.ExpirationDateLabel.Location = new System.Drawing.Point(12, 84);
			this.ExpirationDateLabel.Name = "ExpirationDateLabel";
			this.ExpirationDateLabel.Size = new System.Drawing.Size(97, 15);
			this.ExpirationDateLabel.TabIndex = 4;
			this.ExpirationDateLabel.Text = "Data de Validade:";
			// 
			// UnitLabel
			// 
			this.UnitLabel.AutoSize = true;
			this.UnitLabel.Location = new System.Drawing.Point(12, 99);
			this.UnitLabel.Name = "UnitLabel";
			this.UnitLabel.Size = new System.Drawing.Size(54, 15);
			this.UnitLabel.TabIndex = 5;
			this.UnitLabel.Text = "Unidade:";
			// 
			// UnitPriceLabel
			// 
			this.UnitPriceLabel.AutoSize = true;
			this.UnitPriceLabel.Location = new System.Drawing.Point(12, 114);
			this.UnitPriceLabel.Name = "UnitPriceLabel";
			this.UnitPriceLabel.Size = new System.Drawing.Size(85, 15);
			this.UnitPriceLabel.TabIndex = 6;
			this.UnitPriceLabel.Text = "Preço Unitário:";
			// 
			// QuantityStockLabel
			// 
			this.QuantityStockLabel.AutoSize = true;
			this.QuantityStockLabel.Location = new System.Drawing.Point(12, 129);
			this.QuantityStockLabel.Name = "QuantityStockLabel";
			this.QuantityStockLabel.Size = new System.Drawing.Size(137, 15);
			this.QuantityStockLabel.TabIndex = 7;
			this.QuantityStockLabel.Text = "Quantidade em Estoque:";
			// 
			// IdCodeLabel
			// 
			this.IdCodeLabel.AutoSize = true;
			this.IdCodeLabel.Location = new System.Drawing.Point(12, 144);
			this.IdCodeLabel.Name = "IdCodeLabel";
			this.IdCodeLabel.Size = new System.Drawing.Size(148, 15);
			this.IdCodeLabel.TabIndex = 8;
			this.IdCodeLabel.Text = "Código de Barras/Registro:";
			// 
			// BrandLabel
			// 
			this.BrandLabel.AutoSize = true;
			this.BrandLabel.Location = new System.Drawing.Point(12, 24);
			this.BrandLabel.Name = "BrandLabel";
			this.BrandLabel.Size = new System.Drawing.Size(43, 15);
			this.BrandLabel.TabIndex = 9;
			this.BrandLabel.Text = "Marca:";
			// 
			// FillDataWindowForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BrandLabel);
			this.Controls.Add(this.IdCodeLabel);
			this.Controls.Add(this.QuantityStockLabel);
			this.Controls.Add(this.UnitPriceLabel);
			this.Controls.Add(this.UnitLabel);
			this.Controls.Add(this.ExpirationDateLabel);
			this.Controls.Add(this.ManufacturingDateLabel);
			this.Controls.Add(this.LotLabel);
			this.Controls.Add(this.ManufacturerLabel);
			this.Controls.Add(this.ProductLabel);
			this.Name = "FillDataWindowForm";
			this.Text = "Fill Data";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label ProductLabel;
		private Label ManufacturerLabel;
		private Label LotLabel;
		private Label ManufacturingDateLabel;
		private Label ExpirationDateLabel;
		private Label UnitLabel;
		private Label UnitPriceLabel;
		private Label QuantityStockLabel;
		private Label IdCodeLabel;
		private Label BrandLabel;
	}
}