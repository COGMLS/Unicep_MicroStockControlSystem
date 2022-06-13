using System.Data;

namespace MicroStockControl
{
	partial class StockViewForm
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
			this.StockDataGridView = new System.Windows.Forms.DataGridView();
			this.RefreshDataGridViewButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// StockDataGridView
			// 
			this.StockDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.StockDataGridView.Location = new System.Drawing.Point(12, 12);
			this.StockDataGridView.Name = "StockDataGridView";
			this.StockDataGridView.ReadOnly = true;
			this.StockDataGridView.RowTemplate.Height = 25;
			this.StockDataGridView.Size = new System.Drawing.Size(776, 385);
			this.StockDataGridView.TabIndex = 0;
			// 
			// RefreshDataGridViewButton
			// 
			this.RefreshDataGridViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RefreshDataGridViewButton.Location = new System.Drawing.Point(12, 415);
			this.RefreshDataGridViewButton.Name = "RefreshDataGridViewButton";
			this.RefreshDataGridViewButton.Size = new System.Drawing.Size(75, 23);
			this.RefreshDataGridViewButton.TabIndex = 1;
			this.RefreshDataGridViewButton.Text = "Atualizar";
			this.RefreshDataGridViewButton.UseVisualStyleBackColor = true;
			this.RefreshDataGridViewButton.Click += new System.EventHandler(this.RefreshDataGridViewButton_Click);
			// 
			// StockViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.RefreshDataGridViewButton);
			this.Controls.Add(this.StockDataGridView);
			this.Name = "StockViewForm";
			this.Text = "StockViewForm";
			((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView StockDataGridView;
		private Button RefreshDataGridViewButton;

		// Stock Local DataTable visualization:
		private DataTable StockDataTable;
	}
}