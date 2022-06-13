namespace MicroStockControl
{
	partial class SelectSearchTypeForm
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
			this.SelectDescriptionLabel = new System.Windows.Forms.Label();
			this.SelectSearchTypeComboBox = new System.Windows.Forms.ComboBox();
			this.SearchTextBox = new System.Windows.Forms.TextBox();
			this.SearchTextDescriptionLabel = new System.Windows.Forms.Label();
			this.MakeSearchButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SelectDescriptionLabel
			// 
			this.SelectDescriptionLabel.AutoSize = true;
			this.SelectDescriptionLabel.Location = new System.Drawing.Point(12, 9);
			this.SelectDescriptionLabel.Name = "SelectDescriptionLabel";
			this.SelectDescriptionLabel.Size = new System.Drawing.Size(252, 15);
			this.SelectDescriptionLabel.TabIndex = 0;
			this.SelectDescriptionLabel.Text = "Selecione o tipo de dado que deseja pesquisar:";
			// 
			// SelectSearchTypeComboBox
			// 
			this.SelectSearchTypeComboBox.FormattingEnabled = true;
			this.SelectSearchTypeComboBox.Location = new System.Drawing.Point(12, 27);
			this.SelectSearchTypeComboBox.Name = "SelectSearchTypeComboBox";
			this.SelectSearchTypeComboBox.Size = new System.Drawing.Size(252, 23);
			this.SelectSearchTypeComboBox.TabIndex = 1;
			// 
			// SearchTextBox
			// 
			this.SearchTextBox.Location = new System.Drawing.Point(12, 82);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new System.Drawing.Size(252, 23);
			this.SearchTextBox.TabIndex = 2;
			// 
			// SearchTextDescriptionLabel
			// 
			this.SearchTextDescriptionLabel.AutoSize = true;
			this.SearchTextDescriptionLabel.Location = new System.Drawing.Point(12, 64);
			this.SearchTextDescriptionLabel.Name = "SearchTextDescriptionLabel";
			this.SearchTextDescriptionLabel.Size = new System.Drawing.Size(201, 15);
			this.SearchTextDescriptionLabel.TabIndex = 3;
			this.SearchTextDescriptionLabel.Text = "Entre com o dado que deseja buscar:";
			// 
			// MakeSearchButton
			// 
			this.MakeSearchButton.Location = new System.Drawing.Point(189, 111);
			this.MakeSearchButton.Name = "MakeSearchButton";
			this.MakeSearchButton.Size = new System.Drawing.Size(75, 23);
			this.MakeSearchButton.TabIndex = 4;
			this.MakeSearchButton.Text = "Pesquisar";
			this.MakeSearchButton.UseVisualStyleBackColor = true;
			// 
			// SelectSearchTypeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 146);
			this.Controls.Add(this.MakeSearchButton);
			this.Controls.Add(this.SearchTextDescriptionLabel);
			this.Controls.Add(this.SearchTextBox);
			this.Controls.Add(this.SelectSearchTypeComboBox);
			this.Controls.Add(this.SelectDescriptionLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelectSearchTypeForm";
			this.Text = "SelectSearchTypeForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label SelectDescriptionLabel;
		private ComboBox SelectSearchTypeComboBox;
		private TextBox SearchTextBox;
		private Label SearchTextDescriptionLabel;
		private Button MakeSearchButton;
	}
}