namespace MicroStockControl
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.StockGroupBox = new System.Windows.Forms.GroupBox();
			this.StockProductsGroupBox = new System.Windows.Forms.GroupBox();
			this.OutStockProductsGroupBox = new System.Windows.Forms.GroupBox();
			this.InStockActiveProductsLabel = new System.Windows.Forms.Label();
			this.InStockInactiveProductsLabel = new System.Windows.Forms.Label();
			this.InStockActiveProductsTextBox = new System.Windows.Forms.TextBox();
			this.InStockInactiveProductsTextBox = new System.Windows.Forms.TextBox();
			this.OutStockActiveProdutcsTextBox = new System.Windows.Forms.TextBox();
			this.OutStockWaitingProductsTextBox = new System.Windows.Forms.TextBox();
			this.OutStockActiveProductsLabel = new System.Windows.Forms.Label();
			this.OutStockWaitingProductsLabel = new System.Windows.Forms.Label();
			this.NotificationsGroupBox = new System.Windows.Forms.GroupBox();
			this.StockGroupBox.SuspendLayout();
			this.StockProductsGroupBox.SuspendLayout();
			this.OutStockProductsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// StockGroupBox
			// 
			this.StockGroupBox.Controls.Add(this.OutStockProductsGroupBox);
			this.StockGroupBox.Controls.Add(this.StockProductsGroupBox);
			this.StockGroupBox.Location = new System.Drawing.Point(12, 12);
			this.StockGroupBox.Name = "StockGroupBox";
			this.StockGroupBox.Size = new System.Drawing.Size(272, 197);
			this.StockGroupBox.TabIndex = 0;
			this.StockGroupBox.TabStop = false;
			this.StockGroupBox.Text = "Estoque";
			// 
			// StockProductsGroupBox
			// 
			this.StockProductsGroupBox.Controls.Add(this.InStockInactiveProductsTextBox);
			this.StockProductsGroupBox.Controls.Add(this.InStockActiveProductsTextBox);
			this.StockProductsGroupBox.Controls.Add(this.InStockInactiveProductsLabel);
			this.StockProductsGroupBox.Controls.Add(this.InStockActiveProductsLabel);
			this.StockProductsGroupBox.Location = new System.Drawing.Point(6, 22);
			this.StockProductsGroupBox.Name = "StockProductsGroupBox";
			this.StockProductsGroupBox.Size = new System.Drawing.Size(256, 84);
			this.StockProductsGroupBox.TabIndex = 0;
			this.StockProductsGroupBox.TabStop = false;
			this.StockProductsGroupBox.Text = "Produtos no Estoque";
			// 
			// OutStockProductsGroupBox
			// 
			this.OutStockProductsGroupBox.Controls.Add(this.OutStockWaitingProductsLabel);
			this.OutStockProductsGroupBox.Controls.Add(this.OutStockActiveProductsLabel);
			this.OutStockProductsGroupBox.Controls.Add(this.OutStockWaitingProductsTextBox);
			this.OutStockProductsGroupBox.Controls.Add(this.OutStockActiveProdutcsTextBox);
			this.OutStockProductsGroupBox.Location = new System.Drawing.Point(6, 112);
			this.OutStockProductsGroupBox.Name = "OutStockProductsGroupBox";
			this.OutStockProductsGroupBox.Size = new System.Drawing.Size(256, 76);
			this.OutStockProductsGroupBox.TabIndex = 1;
			this.OutStockProductsGroupBox.TabStop = false;
			this.OutStockProductsGroupBox.Text = "Produtos Fora do Estoque";
			// 
			// InStockActiveProductsLabel
			// 
			this.InStockActiveProductsLabel.AutoSize = true;
			this.InStockActiveProductsLabel.Location = new System.Drawing.Point(6, 19);
			this.InStockActiveProductsLabel.Name = "InStockActiveProductsLabel";
			this.InStockActiveProductsLabel.Size = new System.Drawing.Size(43, 15);
			this.InStockActiveProductsLabel.TabIndex = 0;
			this.InStockActiveProductsLabel.Text = "Ativos:";
			// 
			// InStockInactiveProductsLabel
			// 
			this.InStockInactiveProductsLabel.AutoSize = true;
			this.InStockInactiveProductsLabel.Location = new System.Drawing.Point(6, 41);
			this.InStockInactiveProductsLabel.Name = "InStockInactiveProductsLabel";
			this.InStockInactiveProductsLabel.Size = new System.Drawing.Size(51, 15);
			this.InStockInactiveProductsLabel.TabIndex = 1;
			this.InStockInactiveProductsLabel.Text = "Inativos:";
			// 
			// InStockActiveProductsTextBox
			// 
			this.InStockActiveProductsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InStockActiveProductsTextBox.Location = new System.Drawing.Point(80, 19);
			this.InStockActiveProductsTextBox.Name = "InStockActiveProductsTextBox";
			this.InStockActiveProductsTextBox.PlaceholderText = "No data available";
			this.InStockActiveProductsTextBox.ReadOnly = true;
			this.InStockActiveProductsTextBox.Size = new System.Drawing.Size(170, 16);
			this.InStockActiveProductsTextBox.TabIndex = 2;
			this.InStockActiveProductsTextBox.TabStop = false;
			this.InStockActiveProductsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.InStockActiveProductsTextBox.WordWrap = false;
			// 
			// InStockInactiveProductsTextBox
			// 
			this.InStockInactiveProductsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InStockInactiveProductsTextBox.Location = new System.Drawing.Point(80, 41);
			this.InStockInactiveProductsTextBox.Name = "InStockInactiveProductsTextBox";
			this.InStockInactiveProductsTextBox.PlaceholderText = "No data available";
			this.InStockInactiveProductsTextBox.ReadOnly = true;
			this.InStockInactiveProductsTextBox.Size = new System.Drawing.Size(170, 16);
			this.InStockInactiveProductsTextBox.TabIndex = 3;
			this.InStockInactiveProductsTextBox.TabStop = false;
			this.InStockInactiveProductsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.InStockInactiveProductsTextBox.WordWrap = false;
			// 
			// OutStockActiveProdutcsTextBox
			// 
			this.OutStockActiveProdutcsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.OutStockActiveProdutcsTextBox.Location = new System.Drawing.Point(80, 19);
			this.OutStockActiveProdutcsTextBox.Name = "OutStockActiveProdutcsTextBox";
			this.OutStockActiveProdutcsTextBox.PlaceholderText = "No data available";
			this.OutStockActiveProdutcsTextBox.ReadOnly = true;
			this.OutStockActiveProdutcsTextBox.Size = new System.Drawing.Size(170, 16);
			this.OutStockActiveProdutcsTextBox.TabIndex = 3;
			this.OutStockActiveProdutcsTextBox.TabStop = false;
			this.OutStockActiveProdutcsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.OutStockActiveProdutcsTextBox.WordWrap = false;
			// 
			// OutStockWaitingProductsTextBox
			// 
			this.OutStockWaitingProductsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.OutStockWaitingProductsTextBox.Location = new System.Drawing.Point(80, 41);
			this.OutStockWaitingProductsTextBox.Name = "OutStockWaitingProductsTextBox";
			this.OutStockWaitingProductsTextBox.PlaceholderText = "No data available";
			this.OutStockWaitingProductsTextBox.ReadOnly = true;
			this.OutStockWaitingProductsTextBox.Size = new System.Drawing.Size(170, 16);
			this.OutStockWaitingProductsTextBox.TabIndex = 4;
			this.OutStockWaitingProductsTextBox.TabStop = false;
			this.OutStockWaitingProductsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.OutStockWaitingProductsTextBox.WordWrap = false;
			// 
			// OutStockActiveProductsLabel
			// 
			this.OutStockActiveProductsLabel.AutoSize = true;
			this.OutStockActiveProductsLabel.Location = new System.Drawing.Point(6, 19);
			this.OutStockActiveProductsLabel.Name = "OutStockActiveProductsLabel";
			this.OutStockActiveProductsLabel.Size = new System.Drawing.Size(43, 15);
			this.OutStockActiveProductsLabel.TabIndex = 5;
			this.OutStockActiveProductsLabel.Text = "Ativos:";
			// 
			// OutStockWaitingProductsLabel
			// 
			this.OutStockWaitingProductsLabel.AutoSize = true;
			this.OutStockWaitingProductsLabel.Location = new System.Drawing.Point(6, 41);
			this.OutStockWaitingProductsLabel.Name = "OutStockWaitingProductsLabel";
			this.OutStockWaitingProductsLabel.Size = new System.Drawing.Size(64, 15);
			this.OutStockWaitingProductsLabel.TabIndex = 6;
			this.OutStockWaitingProductsLabel.Text = "Em espera:";
			// 
			// NotificationsGroupBox
			// 
			this.NotificationsGroupBox.Location = new System.Drawing.Point(338, 12);
			this.NotificationsGroupBox.Name = "NotificationsGroupBox";
			this.NotificationsGroupBox.Size = new System.Drawing.Size(254, 106);
			this.NotificationsGroupBox.TabIndex = 1;
			this.NotificationsGroupBox.TabStop = false;
			this.NotificationsGroupBox.Text = "Notificações";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 333);
			this.Controls.Add(this.NotificationsGroupBox);
			this.Controls.Add(this.StockGroupBox);
			this.Name = "MainForm";
			this.Text = "Micro Stock Control";
			this.StockGroupBox.ResumeLayout(false);
			this.StockProductsGroupBox.ResumeLayout(false);
			this.StockProductsGroupBox.PerformLayout();
			this.OutStockProductsGroupBox.ResumeLayout(false);
			this.OutStockProductsGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox StockGroupBox;
		private GroupBox OutStockProductsGroupBox;
		private Label OutStockWaitingProductsLabel;
		private Label OutStockActiveProductsLabel;
		private TextBox OutStockWaitingProductsTextBox;
		private TextBox OutStockActiveProdutcsTextBox;
		private GroupBox StockProductsGroupBox;
		private TextBox InStockInactiveProductsTextBox;
		private TextBox InStockActiveProductsTextBox;
		private Label InStockInactiveProductsLabel;
		private Label InStockActiveProductsLabel;
		private GroupBox NotificationsGroupBox;
	}
}