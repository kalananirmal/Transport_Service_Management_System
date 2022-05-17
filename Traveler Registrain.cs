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
	public partial class Traveler_Registrain : Form
	{
		public Traveler_Registrain()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			form1 obj = new form1();
			obj.Show();
			this.Hide();
		}

		private void but_trsave_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Kalana Nirmal\source\repos\Transport Service Management System\Transport Service Management System\DatabaseVr.mdf; Integrated Security = True");
			
			try
			{

				con.Open();

				//traveler information
				String trname = text_trname.Text;
				String trprovice = comboBox_trp.Text;
				int trlice = int.Parse(text_trleno.Text);
				var trliceNo = Convert.ToInt32(text_trleno.Text);
				String tr_vetype = radioBut_trcar.Text;
				int trconumber = int.Parse(text_trcon.Text);
				//connect to the data base

				

				var sql = "insert into TrsvelerTable values ('" + trname + "','" + trprovice + "','" + trlice + "','" + tr_vetype + "','" + trconumber + "')";

				SqlCommand cmd = new SqlCommand(sql, con);
				cmd.ExecuteNonQuery();
				
				MessageBox.Show("data added ok");

			}
			catch (Exception ex1)
			{
				MessageBox.Show(ex1.Message);
			}
			finally
			{
				con.Close();

			}

			//try
			//{
			//	SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Kalana Nirmal\source\repos\Transport Service Management System\Transport Service Management System\DatabaseVr.mdf; Integrated Security = True");
			//	con.Open();
			//	if (con.State == ConnectionState.Open)
			//		MessageBox.Show("Connect");
			//	else
			//		MessageBox.Show("NO Connection");
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(ex.Message);
			//}

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void groupBox_ower_Enter(object sender, EventArgs e)
		{

		}

		private void radioBut_trvan_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioBut_trcar_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button12_Click(object sender, EventArgs e)
		{

		}

		private void button10_Click(object sender, EventArgs e)
		{

		}

		private void but_trback_Click(object sender, EventArgs e)
		{
			form1 obj = new form1();
			obj.Show();
			this.Hide();
		}

		private void pan_up_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Kalana Nirmal\source\repos\Transport Service Management System\Transport Service Management System\DatabaseVr.mdf; Integrated Security = True");

			try
			{
				con.Open();

				SqlCommand cmd = new SqlCommand("Select * From TrsvelerTable where travelarid = '" + text_sename.Text + "'", con);
				SqlDataReader r = cmd.ExecuteReader();

				if (r.Read())
				{
					text_trname.Text = r[1].ToString();
					comboBox_trp.Text = r[2].ToString();
					text_trleno.Text = r[3].ToString();
					radioBut_trcar.Text = r[4].ToString();
					text_trcon.Text = r[5].ToString();
					
				}
				else
				{
					MessageBox.Show("No Match Details on Table CMS");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				con.Close();
			}


			//}
			//catch (Exception ex)
			//{
			//MessageBox.Show(ex.ToString());
			//}
			//finally
			//{

			//}
		}

		private void but_trupdate_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Kalana Nirmal\source\repos\Transport Service Management System\Transport Service Management System\DatabaseVr.mdf; Integrated Security = True");

			con.Open();
			try
			{
				string trname = text_trname.Text;
				string trprovice = comboBox_trp.Text;
				string trlicence = text_trleno.Text;
				string trvechile;
				if (radioBut_trcar.Checked == true)
				{
					trvechile = "car";
				}
				string trcontac = text_trcon.Text;

				SqlCommand cmd = new SqlCommand("UPDATE TrsvelerTable SET trname= '" + text_trname.Text + "', trprovice= '" + comboBox_trp.Text + "', trlicence= '" + text_trleno.Text + "', trvechile= '" + radioBut_trcar.Text + "', trcontac = '" + text_trcon.Text + "' where travelarID = '"+ text_sename.Text +"'", con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Update Data Succefully");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				con.Close();
			}
		}

		private void but_delect_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Kalana Nirmal\source\repos\Transport Service Management System\Transport Service Management System\DatabaseVr.mdf; Integrated Security = True");

			con.Open();
			try
			{
				SqlCommand cmd = new SqlCommand("DELETE TrsvelerTable where travelarID = '" + text_sename.Text + "'", con);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Delete Data Succefully");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				con.Close();
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		//private void but_trupdate_Click(object sender, EventArgs e)
		//{

	}
	}

