namespace MicroStockControl
{
	partial class SelectStockItemForm
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
			this.UidDescriptionLabel = new System.Windows.Forms.Label();
			this.StockItemUIDTextBox = new System.Windows.Forms.TextBox();
			this.ConfirmStockUIDButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UidDescriptionLabel
			// 
			this.UidDescriptionLabel.AutoSize = true;
			this.UidDescriptionLabel.Location = new System.Drawing.Point(12, 9);
			this.UidDescriptionLabel.Name = "UidDescriptionLabel";
			this.UidDescriptionLabel.Size = new System.Drawing.Size(202, 15);
			this.UidDescriptionLabel.TabIndex = 0;
			this.UidDescriptionLabel.Text = "Entre com o UID do item do estoque:";
			// 
			// StockItemUIDTextBox
			// 
			this.StockItemUIDTextBox.Location = new System.Drawing.Point(12, 27);
			this.StockItemUIDTextBox.Name = "StockItemUIDTextBox";
			this.StockItemUIDTextBox.Size = new System.Drawing.Size(202, 23);
			this.StockItemUIDTextBox.TabIndex = 1;
			// 
			// ConfirmStockUIDButton
			// 
			this.ConfirmStockUIDButton.Location = new System.Drawing.Point(139, 56);
			this.ConfirmStockUIDButton.Name = "ConfirmStockUIDButton";
			this.ConfirmStockUIDButton.Size = new System.Drawing.Size(75, 23);
			this.ConfirmStockUIDButton.TabIndex = 2;
			this.ConfirmStockUIDButton.Text = "Confirmar";
			this.ConfirmStockUIDButton.UseVisualStyleBackColor = true;
			// 
			// SelectStockItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 88);
			this.Controls.Add(this.ConfirmStockUIDButton);
			this.Controls.Add(this.StockItemUIDTextBox);
			this.Controls.Add(this.UidDescriptionLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelectStockItemForm";
			this.Text = "SelectStockItemForm";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label UidDescriptionLabel;
		private TextBox StockItemUIDTextBox;
		private Button ConfirmStockUIDButton;
	}
}