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

namespace studentreg
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//calling load method when form loads 
			Load();
		}


		 SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=gcbt; Integrated Security=True;");

		 SqlCommand cmd = new SqlCommand();
		 SqlDataReader read;
		 private SqlDataAdapter drr;
		 string id;
		bool Mode = true;
		 string sql;





		//Loading and showing datas in data grid 
		 public void Load()
		 {

			 try
			 {
				 sql = "select * from student";
				 cmd = new SqlCommand(sql, con);
				 con.Open();
				 
				 read = cmd.ExecuteReader();


				 dataGridView1.Rows.Clear();

				 while (read.Read())
				 {
					dataGridView1.Rows.Add(read[0], read[1], read[2], read[3]);

				 }
				 con.Close();
			 }
			 catch(Exception ex)
			 {

				 MessageBox.Show(ex.Message);
			 }
		 }

		 //Getting Id for edit 
		 public void getId(string id)
		 {
			 sql = "select * from student where id = '"+ id +"' ";
			 cmd = new SqlCommand(sql, con);
			 con.Open();
			 read = cmd.ExecuteReader();

			 while (read.Read())
			 {
				//Getting name which is index one 
				 txtStdName.Text = read[1].ToString();
				 txtCourse.Text = read[2].ToString();
				 txtFee.Text = read[3].ToString();

			 }

			 con.Close();
		 }



		private void btnSave_Click(object sender, EventArgs e)
		{
			string name = txtStdName.Text;
			string course = txtCourse.Text;
			string fee = txtFee.Text;




			if (Mode == true)
			{
				// saving the new student
				id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				sql = "insert into student(stname,course,fee) values(@stname,@course,@fee)";
				con.Open();
				cmd = new SqlCommand(sql, con);
				cmd.Parameters.AddWithValue("@stname", name);
				cmd.Parameters.AddWithValue("@course", course);
				cmd.Parameters.AddWithValue("@fee", fee);
				MessageBox.Show("Record Added Successfully");
			
				cmd.ExecuteNonQuery();
				
				txtStdName.Clear();
				txtCourse.Clear();
				txtFee.Clear();


			}
			else
			{
				// saveing the edited student
				sql = "update student set stname = @stname, course = @course, fee = @fee where id = @id";
				con.Open();
				cmd = new SqlCommand(sql, con);
				cmd.Parameters.AddWithValue("@stname", name);
				cmd.Parameters.AddWithValue("@course", course);
				cmd.Parameters.AddWithValue("@fee", fee);
				cmd.Parameters.AddWithValue("@id", id);
				MessageBox.Show("Record Updated Successfully");

				cmd.ExecuteNonQuery();

				txtStdName.Clear();
				txtCourse.Clear();
				txtFee.Clear();

				btnSave.Text = "Save";

				Mode = true;

		

			}

			con.Close();





		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// saying when user click edit button
			if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
			{
				// mode is false for changing the saving way for update
				Mode = false;
				//column 0 means the id
				id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				getId(id);
				btnSave.Text = "Edit";

			}
			else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
			{
				Mode = false;
				//column 0 means the id
				id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				sql= "delete from student where id = @id";
				con.Open();
				cmd = new SqlCommand(sql, con);
				cmd.Parameters.AddWithValue("@id", id);

				cmd.ExecuteNonQuery();
				MessageBox.Show("Record Deleted Successfully");
				con.Close();

			}
	
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			Load();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{

			txtStdName.Clear();
			txtCourse.Clear();
			txtFee.Clear();
			btnSave.Text = "Save";

			Mode = true;

		}
	}
}
