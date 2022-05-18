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
			this.WarningNotificationsLabel = new System.Windows.Forms.Label();
			this.NotificationsLabel = new System.Windows.Forms.Label();
			this.WarningNotificationsTextBox = new System.Windows.Forms.TextBox();
			this.NotificationsTextBox = new System.Windows.Forms.TextBox();
			this.StockControlGroupBox = new System.Windows.Forms.GroupBox();
			this.ProductsRegistryGroupBox = new System.Windows.Forms.GroupBox();
			this.Add2StockButton = new System.Windows.Forms.Button();
			this.RemoveFromStockButton = new System.Windows.Forms.Button();
			this.SearchProductButton = new System.Windows.Forms.Button();
			this.VisualizeStockButton = new System.Windows.Forms.Button();
			this.VisualizeRegButton = new System.Windows.Forms.Button();
			this.RemoveProductButton = new System.Windows.Forms.Button();
			this.EditProductButton = new System.Windows.Forms.Button();
			this.RegisterProductButton = new System.Windows.Forms.Button();
			this.VisualizeNotificationsButton = new System.Windows.Forms.Button();
			this.CleanNotificationsButton = new System.Windows.Forms.Button();
			this.StockGroupBox.SuspendLayout();
			this.StockProductsGroupBox.SuspendLayout();
			this.OutStockProductsGroupBox.SuspendLayout();
			this.NotificationsGroupBox.SuspendLayout();
			this.StockControlGroupBox.SuspendLayout();
			this.ProductsRegistryGroupBox.SuspendLayout();
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
			this.StockProductsGroupBox.Size = new System.Drawing.Size(256, 78);
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
			this.NotificationsGroupBox.Controls.Add(this.CleanNotificationsButton);
			this.NotificationsGroupBox.Controls.Add(this.VisualizeNotificationsButton);
			this.NotificationsGroupBox.Controls.Add(this.NotificationsTextBox);
			this.NotificationsGroupBox.Controls.Add(this.WarningNotificationsTextBox);
			this.NotificationsGroupBox.Controls.Add(this.NotificationsLabel);
			this.NotificationsGroupBox.Controls.Add(this.WarningNotificationsLabel);
			this.NotificationsGroupBox.Location = new System.Drawing.Point(338, 12);
			this.NotificationsGroupBox.Name = "NotificationsGroupBox";
			this.NotificationsGroupBox.Size = new System.Drawing.Size(254, 106);
			this.NotificationsGroupBox.TabIndex = 1;
			this.NotificationsGroupBox.TabStop = false;
			this.NotificationsGroupBox.Text = "Notificações";
			// 
			// WarningNotificationsLabel
			// 
			this.WarningNotificationsLabel.AutoSize = true;
			this.WarningNotificationsLabel.Location = new System.Drawing.Point(6, 19);
			this.WarningNotificationsLabel.Name = "WarningNotificationsLabel";
			this.WarningNotificationsLabel.Size = new System.Drawing.Size(44, 15);
			this.WarningNotificationsLabel.TabIndex = 0;
			this.WarningNotificationsLabel.Text = "Avisos:";
			// 
			// NotificationsLabel
			// 
			this.NotificationsLabel.AutoSize = true;
			this.NotificationsLabel.Location = new System.Drawing.Point(6, 41);
			this.NotificationsLabel.Name = "NotificationsLabel";
			this.NotificationsLabel.Size = new System.Drawing.Size(76, 15);
			this.NotificationsLabel.TabIndex = 1;
			this.NotificationsLabel.Text = "Notificações:";
			// 
			// WarningNotificationsTextBox
			// 
			this.WarningNotificationsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.WarningNotificationsTextBox.Location = new System.Drawing.Point(121, 19);
			this.WarningNotificationsTextBox.Name = "WarningNotificationsTextBox";
			this.WarningNotificationsTextBox.PlaceholderText = "No data available";
			this.WarningNotificationsTextBox.ReadOnly = true;
			this.WarningNotificationsTextBox.Size = new System.Drawing.Size(127, 16);
			this.WarningNotificationsTextBox.TabIndex = 3;
			this.WarningNotificationsTextBox.TabStop = false;
			this.WarningNotificationsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.WarningNotificationsTextBox.WordWrap = false;
			// 
			// NotificationsTextBox
			// 
			this.NotificationsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NotificationsTextBox.Location = new System.Drawing.Point(121, 41);
			this.NotificationsTextBox.Name = "NotificationsTextBox";
			this.NotificationsTextBox.PlaceholderText = "No data available";
			this.NotificationsTextBox.ReadOnly = true;
			this.NotificationsTextBox.Size = new System.Drawing.Size(127, 16);
			this.NotificationsTextBox.TabIndex = 4;
			this.NotificationsTextBox.TabStop = false;
			this.NotificationsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NotificationsTextBox.WordWrap = false;
			// 
			// StockControlGroupBox
			// 
			this.StockControlGroupBox.Controls.Add(this.VisualizeStockButton);
			this.StockControlGroupBox.Controls.Add(this.SearchProductButton);
			this.StockControlGroupBox.Controls.Add(this.RemoveFromStockButton);
			this.StockControlGroupBox.Controls.Add(this.Add2StockButton);
			this.StockControlGroupBox.Location = new System.Drawing.Point(12, 221);
			this.StockControlGroupBox.Name = "StockControlGroupBox";
			this.StockControlGroupBox.Size = new System.Drawing.Size(272, 100);
			this.StockControlGroupBox.TabIndex = 2;
			this.StockControlGroupBox.TabStop = false;
			this.StockControlGroupBox.Text = "Controle do Estoque";
			// 
			// ProductsRegistryGroupBox
			// 
			this.ProductsRegistryGroupBox.Controls.Add(this.VisualizeRegButton);
			this.ProductsRegistryGroupBox.Controls.Add(this.RegisterProductButton);
			this.ProductsRegistryGroupBox.Controls.Add(this.RemoveProductButton);
			this.ProductsRegistryGroupBox.Controls.Add(this.EditProductButton);
			this.ProductsRegistryGroupBox.Location = new System.Drawing.Point(338, 221);
			this.ProductsRegistryGroupBox.Name = "ProductsRegistryGroupBox";
			this.ProductsRegistryGroupBox.Size = new System.Drawing.Size(255, 100);
			this.ProductsRegistryGroupBox.TabIndex = 3;
			this.ProductsRegistryGroupBox.TabStop = false;
			this.ProductsRegistryGroupBox.Text = "Registro de Produtos";
			// 
			// Add2StockButton
			// 
			this.Add2StockButton.Location = new System.Drawing.Point(6, 22);
			this.Add2StockButton.Name = "Add2StockButton";
			this.Add2StockButton.Size = new System.Drawing.Size(75, 42);
			this.Add2StockButton.TabIndex = 0;
			this.Add2StockButton.Text = "Adicionar ao Estoque";
			this.Add2StockButton.UseVisualStyleBackColor = true;
			// 
			// RemoveFromStockButton
			// 
			this.RemoveFromStockButton.Location = new System.Drawing.Point(87, 22);
			this.RemoveFromStockButton.Name = "RemoveFromStockButton";
			this.RemoveFromStockButton.Size = new System.Drawing.Size(75, 42);
			this.RemoveFromStockButton.TabIndex = 1;
			this.RemoveFromStockButton.Text = "Retirar do Estoque";
			this.RemoveFromStockButton.UseVisualStyleBackColor = true;
			// 
			// SearchProductButton
			// 
			this.SearchProductButton.Location = new System.Drawing.Point(168, 22);
			this.SearchProductButton.Name = "SearchProductButton";
			this.SearchProductButton.Size = new System.Drawing.Size(75, 42);
			this.SearchProductButton.TabIndex = 4;
			this.SearchProductButton.Text = "Pesquisar Produto";
			this.SearchProductButton.UseVisualStyleBackColor = true;
			// 
			// VisualizeStockButton
			// 
			this.VisualizeStockButton.Location = new System.Drawing.Point(6, 70);
			this.VisualizeStockButton.Name = "VisualizeStockButton";
			this.VisualizeStockButton.Size = new System.Drawing.Size(237, 23);
			this.VisualizeStockButton.TabIndex = 4;
			this.VisualizeStockButton.Text = "Visualizar Estoque";
			this.VisualizeStockButton.UseVisualStyleBackColor = true;
			// 
			// VisualizeRegButton
			// 
			this.VisualizeRegButton.Location = new System.Drawing.Point(7, 70);
			this.VisualizeRegButton.Name = "VisualizeRegButton";
			this.VisualizeRegButton.Size = new System.Drawing.Size(237, 23);
			this.VisualizeRegButton.TabIndex = 7;
			this.VisualizeRegButton.Text = "Visualizar Registro";
			this.VisualizeRegButton.UseVisualStyleBackColor = true;
			// 
			// RemoveProductButton
			// 
			this.RemoveProductButton.Location = new System.Drawing.Point(169, 22);
			this.RemoveProductButton.Name = "RemoveProductButton";
			this.RemoveProductButton.Size = new System.Drawing.Size(75, 42);
			this.RemoveProductButton.TabIndex = 8;
			this.RemoveProductButton.Text = "Remover Produto";
			this.RemoveProductButton.UseVisualStyleBackColor = true;
			// 
			// EditProductButton
			// 
			this.EditProductButton.Location = new System.Drawing.Point(88, 22);
			this.EditProductButton.Name = "EditProductButton";
			this.EditProductButton.Size = new System.Drawing.Size(75, 42);
			this.EditProductButton.TabIndex = 6;
			this.EditProductButton.Text = "Editar Produto";
			this.EditProductButton.UseVisualStyleBackColor = true;
			// 
			// RegisterProductButton
			// 
			this.RegisterProductButton.Location = new System.Drawing.Point(7, 22);
			this.RegisterProductButton.Name = "RegisterProductButton";
			this.RegisterProductButton.Size = new System.Drawing.Size(75, 42);
			this.RegisterProductButton.TabIndex = 5;
			this.RegisterProductButton.Text = "Registrar Produto";
			this.RegisterProductButton.UseVisualStyleBackColor = true;
			// 
			// VisualizeNotificationsButton
			// 
			this.VisualizeNotificationsButton.Location = new System.Drawing.Point(6, 77);
			this.VisualizeNotificationsButton.Name = "VisualizeNotificationsButton";
			this.VisualizeNotificationsButton.Size = new System.Drawing.Size(75, 23);
			this.VisualizeNotificationsButton.TabIndex = 5;
			this.VisualizeNotificationsButton.Text = "Visualizar";
			this.VisualizeNotificationsButton.UseVisualStyleBackColor = true;
			// 
			// CleanNotificationsButton
			// 
			this.CleanNotificationsButton.Location = new System.Drawing.Point(173, 77);
			this.CleanNotificationsButton.Name = "CleanNotificationsButton";
			this.CleanNotificationsButton.Size = new System.Drawing.Size(75, 23);
			this.CleanNotificationsButton.TabIndex = 6;
			this.CleanNotificationsButton.Text = "Limpar";
			this.CleanNotificationsButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 333);
			this.Controls.Add(this.ProductsRegistryGroupBox);
			this.Controls.Add(this.StockControlGroupBox);
			this.Controls.Add(this.NotificationsGroupBox);
			this.Controls.Add(this.StockGroupBox);
			this.Name = "MainForm";
			this.Text = "Micro Stock Control";
			this.StockGroupBox.ResumeLayout(false);
			this.StockProductsGroupBox.ResumeLayout(false);
			this.StockProductsGroupBox.PerformLayout();
			this.OutStockProductsGroupBox.ResumeLayout(false);
			this.OutStockProductsGroupBox.PerformLayout();
			this.NotificationsGroupBox.ResumeLayout(false);
			this.NotificationsGroupBox.PerformLayout();
			this.StockControlGroupBox.ResumeLayout(false);
			this.ProductsRegistryGroupBox.ResumeLayout(false);
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
		private TextBox NotificationsTextBox;
		private TextBox WarningNotificationsTextBox;
		private Label NotificationsLabel;
		private Label WarningNotificationsLabel;
		private GroupBox StockControlGroupBox;
		private Button VisualizeStockButton;
		private Button SearchProductButton;
		private Button RemoveFromStockButton;
		private Button Add2StockButton;
		private GroupBox ProductsRegistryGroupBox;
		private Button VisualizeRegButton;
		private Button RegisterProductButton;
		private Button RemoveProductButton;
		private Button EditProductButton;
		private Button CleanNotificationsButton;
		private Button VisualizeNotificationsButton;
	}
}