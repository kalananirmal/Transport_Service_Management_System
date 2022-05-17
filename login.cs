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
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		private void text_trname_TextChanged(object sender, EventArgs e)
		{

		}

		private void but_login_Click(object sender, EventArgs e)
		{
			var user =text_urname.Text;
			var pass = text_pass.Text;
			if (user=="Admin" && pass=="123admin")
			{
				MessageBox.Show("You have been Successfully Login", "log in", MessageBoxButtons.OK, MessageBoxIcon.Information);
				form1 obj = new form1();
				obj.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Check Your Username OR Password", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void but_ex_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void login_Load(object sender, EventArgs e)
		{

		}

		private void text_pass_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
