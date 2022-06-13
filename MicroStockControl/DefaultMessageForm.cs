using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroStockControl
{
	public partial class DefaultMessageForm : Form
	{
		public DefaultMessageForm(string Title, string[] Message)
		{
			InitializeComponent();

			this.Text = Title;

			string TmpMessage = "";

			if (Message.Length > 1)
			{
				for(int i = 0; i < Message.Length; i++)
				{
					TmpMessage += Message[i];

					if(i < Message.Length - 1)
					{
						TmpMessage += "\n";
					}
				}
			}
			else
			{
				TmpMessage += Message[0];
			}

			this.MessageTextBox.Text = TmpMessage;
		}
	}
}
