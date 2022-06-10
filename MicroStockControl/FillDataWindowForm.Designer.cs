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
			this.ProductTextBox = new System.Windows.Forms.TextBox();
			this.BrandTextBox = new System.Windows.Forms.TextBox();
			this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
			this.LotTextBox = new System.Windows.Forms.TextBox();
			this.IdCodeTextBox = new System.Windows.Forms.TextBox();
			this.QuantityStockTextBox = new System.Windows.Forms.TextBox();
			this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
			this.UnitTextBox = new System.Windows.Forms.TextBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.SaveNextButton = new System.Windows.Forms.Button();
			this.CancelButtonForm = new System.Windows.Forms.Button();
			this.SaveOutStock_CheckBox = new System.Windows.Forms.CheckBox();
			this.ExpirationDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.ManufacturingDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.UseManufacturingTimeCheckBox = new System.Windows.Forms.CheckBox();
			this.UseExpirationTimeCheckBox = new System.Windows.Forms.CheckBox();
			this.ManufacturingTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.ExpirationTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// ProductLabel
			// 
			this.ProductLabel.AutoSize = true;
			this.ProductLabel.Location = new System.Drawing.Point(12, 15);
			this.ProductLabel.Name = "ProductLabel";
			this.ProductLabel.Size = new System.Drawing.Size(53, 15);
			this.ProductLabel.TabIndex = 0;
			this.ProductLabel.Text = "Produto:";
			// 
			// ManufacturerLabel
			// 
			this.ManufacturerLabel.AutoSize = true;
			this.ManufacturerLabel.Location = new System.Drawing.Point(12, 73);
			this.ManufacturerLabel.Name = "ManufacturerLabel";
			this.ManufacturerLabel.Size = new System.Drawing.Size(65, 15);
			this.ManufacturerLabel.TabIndex = 1;
			this.ManufacturerLabel.Text = "Fabricante:";
			// 
			// LotLabel
			// 
			this.LotLabel.AutoSize = true;
			this.LotLabel.Location = new System.Drawing.Point(12, 102);
			this.LotLabel.Name = "LotLabel";
			this.LotLabel.Size = new System.Drawing.Size(33, 15);
			this.LotLabel.TabIndex = 2;
			this.LotLabel.Text = "Lote:";
			// 
			// ManufacturingDateLabel
			// 
			this.ManufacturingDateLabel.AutoSize = true;
			this.ManufacturingDateLabel.Location = new System.Drawing.Point(12, 131);
			this.ManufacturingDateLabel.Name = "ManufacturingDateLabel";
			this.ManufacturingDateLabel.Size = new System.Drawing.Size(110, 15);
			this.ManufacturingDateLabel.TabIndex = 3;
			this.ManufacturingDateLabel.Text = "Data de Fabricação:";
			// 
			// ExpirationDateLabel
			// 
			this.ExpirationDateLabel.AutoSize = true;
			this.ExpirationDateLabel.Location = new System.Drawing.Point(12, 160);
			this.ExpirationDateLabel.Name = "ExpirationDateLabel";
			this.ExpirationDateLabel.Size = new System.Drawing.Size(97, 15);
			this.ExpirationDateLabel.TabIndex = 4;
			this.ExpirationDateLabel.Text = "Data de Validade:";
			// 
			// UnitLabel
			// 
			this.UnitLabel.AutoSize = true;
			this.UnitLabel.Location = new System.Drawing.Point(12, 189);
			this.UnitLabel.Name = "UnitLabel";
			this.UnitLabel.Size = new System.Drawing.Size(54, 15);
			this.UnitLabel.TabIndex = 5;
			this.UnitLabel.Text = "Unidade:";
			// 
			// UnitPriceLabel
			// 
			this.UnitPriceLabel.AutoSize = true;
			this.UnitPriceLabel.Location = new System.Drawing.Point(12, 218);
			this.UnitPriceLabel.Name = "UnitPriceLabel";
			this.UnitPriceLabel.Size = new System.Drawing.Size(85, 15);
			this.UnitPriceLabel.TabIndex = 6;
			this.UnitPriceLabel.Text = "Preço Unitário:";
			// 
			// QuantityStockLabel
			// 
			this.QuantityStockLabel.AutoSize = true;
			this.QuantityStockLabel.Location = new System.Drawing.Point(12, 247);
			this.QuantityStockLabel.Name = "QuantityStockLabel";
			this.QuantityStockLabel.Size = new System.Drawing.Size(137, 15);
			this.QuantityStockLabel.TabIndex = 7;
			this.QuantityStockLabel.Text = "Quantidade em Estoque:";
			// 
			// IdCodeLabel
			// 
			this.IdCodeLabel.AutoSize = true;
			this.IdCodeLabel.Location = new System.Drawing.Point(12, 276);
			this.IdCodeLabel.Name = "IdCodeLabel";
			this.IdCodeLabel.Size = new System.Drawing.Size(148, 15);
			this.IdCodeLabel.TabIndex = 8;
			this.IdCodeLabel.Text = "Código de Barras/Registro:";
			// 
			// BrandLabel
			// 
			this.BrandLabel.AutoSize = true;
			this.BrandLabel.Location = new System.Drawing.Point(12, 44);
			this.BrandLabel.Name = "BrandLabel";
			this.BrandLabel.Size = new System.Drawing.Size(43, 15);
			this.BrandLabel.TabIndex = 9;
			this.BrandLabel.Text = "Marca:";
			// 
			// ProductTextBox
			// 
			this.ProductTextBox.Location = new System.Drawing.Point(164, 12);
			this.ProductTextBox.Name = "ProductTextBox";
			this.ProductTextBox.Size = new System.Drawing.Size(624, 23);
			this.ProductTextBox.TabIndex = 19;
			// 
			// BrandTextBox
			// 
			this.BrandTextBox.Location = new System.Drawing.Point(164, 41);
			this.BrandTextBox.Name = "BrandTextBox";
			this.BrandTextBox.Size = new System.Drawing.Size(624, 23);
			this.BrandTextBox.TabIndex = 20;
			// 
			// ManufacturerTextBox
			// 
			this.ManufacturerTextBox.Location = new System.Drawing.Point(164, 70);
			this.ManufacturerTextBox.Name = "ManufacturerTextBox";
			this.ManufacturerTextBox.Size = new System.Drawing.Size(624, 23);
			this.ManufacturerTextBox.TabIndex = 21;
			// 
			// LotTextBox
			// 
			this.LotTextBox.Location = new System.Drawing.Point(164, 99);
			this.LotTextBox.Name = "LotTextBox";
			this.LotTextBox.Size = new System.Drawing.Size(624, 23);
			this.LotTextBox.TabIndex = 22;
			// 
			// IdCodeTextBox
			// 
			this.IdCodeTextBox.Location = new System.Drawing.Point(164, 273);
			this.IdCodeTextBox.Name = "IdCodeTextBox";
			this.IdCodeTextBox.Size = new System.Drawing.Size(624, 23);
			this.IdCodeTextBox.TabIndex = 28;
			// 
			// QuantityStockTextBox
			// 
			this.QuantityStockTextBox.Location = new System.Drawing.Point(164, 244);
			this.QuantityStockTextBox.Name = "QuantityStockTextBox";
			this.QuantityStockTextBox.Size = new System.Drawing.Size(624, 23);
			this.QuantityStockTextBox.TabIndex = 27;
			// 
			// UnitPriceTextBox
			// 
			this.UnitPriceTextBox.Location = new System.Drawing.Point(164, 215);
			this.UnitPriceTextBox.Name = "UnitPriceTextBox";
			this.UnitPriceTextBox.Size = new System.Drawing.Size(624, 23);
			this.UnitPriceTextBox.TabIndex = 26;
			// 
			// UnitTextBox
			// 
			this.UnitTextBox.Location = new System.Drawing.Point(164, 186);
			this.UnitTextBox.Name = "UnitTextBox";
			this.UnitTextBox.Size = new System.Drawing.Size(624, 23);
			this.UnitTextBox.TabIndex = 25;
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(12, 367);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 29;
			this.SaveButton.Text = "Salvar";
			this.SaveButton.UseVisualStyleBackColor = true;
			// 
			// SaveNextButton
			// 
			this.SaveNextButton.Location = new System.Drawing.Point(93, 367);
			this.SaveNextButton.Name = "SaveNextButton";
			this.SaveNextButton.Size = new System.Drawing.Size(115, 23);
			this.SaveNextButton.TabIndex = 30;
			this.SaveNextButton.Text = "Salvar e Próximo";
			this.SaveNextButton.UseVisualStyleBackColor = true;
			// 
			// CancelButtonForm
			// 
			this.CancelButtonForm.Location = new System.Drawing.Point(713, 367);
			this.CancelButtonForm.Name = "CancelButtonForm";
			this.CancelButtonForm.Size = new System.Drawing.Size(75, 23);
			this.CancelButtonForm.TabIndex = 31;
			this.CancelButtonForm.Text = "Cancelar";
			this.CancelButtonForm.UseVisualStyleBackColor = true;
			// 
			// SaveOutStock_CheckBox
			// 
			this.SaveOutStock_CheckBox.AutoSize = true;
			this.SaveOutStock_CheckBox.Location = new System.Drawing.Point(12, 313);
			this.SaveOutStock_CheckBox.Name = "SaveOutStock_CheckBox";
			this.SaveOutStock_CheckBox.Size = new System.Drawing.Size(152, 19);
			this.SaveOutStock_CheckBox.TabIndex = 32;
			this.SaveOutStock_CheckBox.Text = "Salvar FORA do estoque";
			this.SaveOutStock_CheckBox.UseVisualStyleBackColor = true;
			// 
			// ExpirationDateMaskedTextBox
			// 
			this.ExpirationDateMaskedTextBox.Culture = new System.Globalization.CultureInfo("pt-BR");
			this.ExpirationDateMaskedTextBox.Location = new System.Drawing.Point(164, 128);
			this.ExpirationDateMaskedTextBox.Mask = "00/00/0000";
			this.ExpirationDateMaskedTextBox.Name = "ExpirationDateMaskedTextBox";
			this.ExpirationDateMaskedTextBox.Size = new System.Drawing.Size(92, 23);
			this.ExpirationDateMaskedTextBox.TabIndex = 33;
			this.ExpirationDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
			// 
			// ManufacturingDateMaskedTextBox
			// 
			this.ManufacturingDateMaskedTextBox.Culture = new System.Globalization.CultureInfo("pt-BR");
			this.ManufacturingDateMaskedTextBox.Location = new System.Drawing.Point(164, 157);
			this.ManufacturingDateMaskedTextBox.Mask = "00/00/0000";
			this.ManufacturingDateMaskedTextBox.Name = "ManufacturingDateMaskedTextBox";
			this.ManufacturingDateMaskedTextBox.Size = new System.Drawing.Size(92, 23);
			this.ManufacturingDateMaskedTextBox.TabIndex = 34;
			this.ManufacturingDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
			// 
			// UseManufacturingTimeCheckBox
			// 
			this.UseManufacturingTimeCheckBox.AutoSize = true;
			this.UseManufacturingTimeCheckBox.Location = new System.Drawing.Point(291, 130);
			this.UseManufacturingTimeCheckBox.Name = "UseManufacturingTimeCheckBox";
			this.UseManufacturingTimeCheckBox.Size = new System.Drawing.Size(87, 19);
			this.UseManufacturingTimeCheckBox.TabIndex = 35;
			this.UseManufacturingTimeCheckBox.Text = "Usar tempo";
			this.UseManufacturingTimeCheckBox.UseVisualStyleBackColor = true;
			// 
			// UseExpirationTimeCheckBox
			// 
			this.UseExpirationTimeCheckBox.AutoSize = true;
			this.UseExpirationTimeCheckBox.Location = new System.Drawing.Point(291, 159);
			this.UseExpirationTimeCheckBox.Name = "UseExpirationTimeCheckBox";
			this.UseExpirationTimeCheckBox.Size = new System.Drawing.Size(87, 19);
			this.UseExpirationTimeCheckBox.TabIndex = 36;
			this.UseExpirationTimeCheckBox.Text = "Usar tempo";
			this.UseExpirationTimeCheckBox.UseVisualStyleBackColor = true;
			// 
			// ManufacturingTimeMaskedTextBox
			// 
			this.ManufacturingTimeMaskedTextBox.Location = new System.Drawing.Point(400, 128);
			this.ManufacturingTimeMaskedTextBox.Mask = "00:00";
			this.ManufacturingTimeMaskedTextBox.Name = "ManufacturingTimeMaskedTextBox";
			this.ManufacturingTimeMaskedTextBox.Size = new System.Drawing.Size(100, 23);
			this.ManufacturingTimeMaskedTextBox.TabIndex = 37;
			this.ManufacturingTimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
			// 
			// ExpirationTimeMaskedTextBox
			// 
			this.ExpirationTimeMaskedTextBox.Location = new System.Drawing.Point(400, 157);
			this.ExpirationTimeMaskedTextBox.Mask = "00:00";
			this.ExpirationTimeMaskedTextBox.Name = "ExpirationTimeMaskedTextBox";
			this.ExpirationTimeMaskedTextBox.Size = new System.Drawing.Size(100, 23);
			this.ExpirationTimeMaskedTextBox.TabIndex = 38;
			this.ExpirationTimeMaskedTextBox.ValidatingType = typeof(System.DateTime);
			// 
			// FillDataWindowForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 402);
			this.Controls.Add(this.ExpirationTimeMaskedTextBox);
			this.Controls.Add(this.ManufacturingTimeMaskedTextBox);
			this.Controls.Add(this.UseExpirationTimeCheckBox);
			this.Controls.Add(this.UseManufacturingTimeCheckBox);
			this.Controls.Add(this.ManufacturingDateMaskedTextBox);
			this.Controls.Add(this.ExpirationDateMaskedTextBox);
			this.Controls.Add(this.SaveOutStock_CheckBox);
			this.Controls.Add(this.CancelButtonForm);
			this.Controls.Add(this.SaveNextButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.IdCodeTextBox);
			this.Controls.Add(this.QuantityStockTextBox);
			this.Controls.Add(this.UnitPriceTextBox);
			this.Controls.Add(this.UnitTextBox);
			this.Controls.Add(this.LotTextBox);
			this.Controls.Add(this.ManufacturerTextBox);
			this.Controls.Add(this.BrandTextBox);
			this.Controls.Add(this.ProductTextBox);
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
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
		private TextBox ProductTextBox;
		private TextBox BrandTextBox;
		private TextBox ManufacturerTextBox;
		private TextBox LotTextBox;
		private TextBox IdCodeTextBox;
		private TextBox QuantityStockTextBox;
		private TextBox UnitPriceTextBox;
		private TextBox UnitTextBox;
		private Button SaveButton;
		private Button SaveNextButton;
		private Button CancelButtonForm;
		private CheckBox SaveOutStock_CheckBox;
		private MaskedTextBox ExpirationDateMaskedTextBox;
		private MaskedTextBox ManufacturingDateMaskedTextBox;
		private CheckBox UseManufacturingTimeCheckBox;
		private CheckBox UseExpirationTimeCheckBox;
		private MaskedTextBox ManufacturingTimeMaskedTextBox;
		private MaskedTextBox ExpirationTimeMaskedTextBox;
	}
}