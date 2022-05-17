using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport_Service_Management_System
{
	public partial class home : Form
	{
		public home()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
				try
				{
					VisitLink();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Unable to open link that was clicked.");
				}
			}

			private void VisitLink()
			{
				// Change the color of the link text by setting LinkVisited
				// to true.
				linkLabel1.LinkVisited = true;
				//Call the Process.Start method to open the default browser
				//with a URL:
				System.Diagnostics.Process.Start("https://www.facebook.com/");
			}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
	}


