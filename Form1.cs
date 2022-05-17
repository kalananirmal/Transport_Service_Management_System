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
	public partial class form1: Form
	{
		public form1()
		{
			InitializeComponent();
		}
		private void manuwal()
		{
			panl_rent.Visible = false;
		}
		private void show()
		{
			panl_rent.Visible = true;
		}
		private void hide()
		{
			panl_rent.Visible = false;
		}
		private Form activateForm = null;

		private void openChildForm(Form childForm)
		{
			if (activateForm != null)
			{
				activateForm.Close();
			}

			activateForm = childForm;
			childForm.TopLevel = false;
			childForm.Dock = DockStyle.Fill;
			panel_main.Controls.Add(childForm);
			panel_main.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void form1_Load(object sender, EventArgs e)
		{
			manuwal();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			openChildForm(new home());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			openChildForm(new Vehicle_Registation());
		}

		private void button4_Click_1(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{

		}

		private void button9_Click(object sender, EventArgs e)
		{

		}

		private void button12_Click(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{
			show();
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button9_Click_1(object sender, EventArgs e)
		{

		}

		private void button10_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click_2(object sender, EventArgs e)
		{
			openChildForm(new car());
		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			openChildForm(new van());
		}

		private void button7_Click_1(object sender, EventArgs e)
		{
			openChildForm(new bus());
		}

		private void button13_Click(object sender, EventArgs e)
		{

		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}

		private void but_tr_Click(object sender, EventArgs e)
		{
			openChildForm(new Traveler_Registrain());
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void panel5_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
