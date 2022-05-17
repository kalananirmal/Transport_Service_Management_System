using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Transport_Service_Management_System
{
	public partial class Vehicle_Registation : Form
	{
		public Vehicle_Registation()
		{
			InitializeComponent();
		}

		SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C: \Users\Kalana Nirmal\source\repos\Transport Service Management System\Transport Service Management System\DatabaseVr.mdf;Integrated Security = True");
		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void but_vrsave_Click(object sender, EventArgs e)
		{

			try
			{
				//ower information
				String owername = text_owern.Text;
				String provice = comboBox_op.Text;
				String gender;
				if(radioBut_owermale.Checked==true)
				{

					gender = "Male";
				}
				else
				{
					gender = "Female";
				}
				int id = int.Parse(text_owerid.Text);
				int rent = int.Parse(comboBox_rent.Text);
				int conumber = int.Parse(text_owercon.Text);

				//vechile information
				int vechileno = int.Parse(text_vno.Text);
				String vechiletype;
				if (radioBut_car.Checked == true)
				{
					vechiletype = "Car";
				}
				else if (radioBut_van.Checked == true)
				{
					vechiletype = "Van";
				}
				else
				{
					vechiletype = "Bus";
				}
				String model = text_vm.Text;
				int eno = int.Parse(text_eno.Text);
				String country = comboBox_co.Text;
				String year = comboBox_ym.Text;
				//connect to the data basse
				SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Kalana Nirmal\source\repos\Transport Service Management System\Transport Service Management System\DatabaseVr.mdf; Integrated Security = True");
				con.Open();
				SqlCommand cmd = new SqlCommand("insert into VechileTable values ('"+owername+"','"+provice+"','"+ gender+"','"+id +"','"+rent+"','"+conumber+"','"+vechileno+"','"+vechiletype+"','"+model+"','"+eno+"','"+country+"','"+ year+"')", con);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Your Data have been Save");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{

			}
		}

		

		private void text_owern_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void pan_up_Paint(object sender, PaintEventArgs e)
		{

		}

		private void but_vrback_Click(object sender, EventArgs e)
		{
			form1 obj = new form1();
			obj.Show();
			this.Hide();
		}

		private void label18_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			form1 obj = new form1();
			obj.Show();
			this.Hide();
		}

		private void button10_Click(object sender, EventArgs e)
		{

		}

		private void but_vrupdate_Click(object sender, EventArgs e)
		{
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}

		private void text_vm_TextChanged(object sender, EventArgs e)
		{

		}

		private void label13_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter_1(object sender, EventArgs e)
		{

		}

		private void comboBox_op_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
