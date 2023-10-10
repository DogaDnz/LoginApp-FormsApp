using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		
		private void Form1_DoubleClick(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string ka = textBox1.Text;
			string pw = textBox2.Text;

			if(ka =="Doga")
			{
				if(pw == "123")
				{
					label1.Text = "Successful";
				}
				else {
					label1.Text = "Try again the password";
				}
			}
			else {
				label1.Text = "unSuccessful";
			}
		}
	}
}
