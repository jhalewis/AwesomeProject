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


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=rub-mtsql.database.windows.net;Initial Catalog=E2GDB;User ID=rubmtsql;Password=Rubix2016");
        

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display_data();
            FillCombo();
            FillCombo2();
            //PolicyNumber();
            label15.Hide();
            label16.Show();
            label17.Show();
            label18.Show();
        }
        void FillCombo()
        {

            //DataTable table = new DataTable();
            //create our SQL SELECT statement
            string sql = "Select description from LIF_LJS_T_ContractTypeDescription";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            try
                {
                //comboBox1.Items.Clear();
                con.Open();
                //then we execute the SQL statement against the Connection using OleDBDataAdapter
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select description from LIF_LJS_T_ContractTypeDescription";
                cmd.ExecuteNonQuery();
                //we fill the result to dt which declared above as datatable                    
                da.Fill(table);

                foreach (DataRow dr in table.Rows)
                {
                    //we add new entry to our datatable manually 
                    //becuase Select Course is not Available in the Database
                    comboBox1.Items.Add(dr["Description"].ToString());
                 
                }
                }
                catch (SqlException ex)
                {
                    //this will display some error message if something 
                    //went wrong to our code above during execution
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            

        }
        void FillCombo2()
        {

            //DataTable table = new DataTable();
            //create our SQL SELECT statement
            string sql = "Select name from usr_mms_t_user";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable table2 = new DataTable();
            try
            {
                //comboBox2.Items.Clear();
                con.Open();
                //then we execute the SQL statement against the Connection using OleDBDataAdapter
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select name from usr_mms_t_user";
                cmd.ExecuteNonQuery();
                //we fill the result to dt which declared above as datatable                    
                da.Fill(table2);

                foreach (DataRow dr in table2.Rows)
                {
                    //we add new entry to our datatable manually 
                    //becuase Select Course is not Available in the Database
                    comboBox2.Items.Add(dr["name"].ToString());

                }
            }
            catch (SqlException ex)
            {
                //this will display some error message if something 
                //went wrong to our code above during execution
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public void PolicyNumber()
        {
            SqlCommand comando = new SqlCommand();
            string myConnectionString = @"Data Source=" + textBox5.Text + ";Initial Catalog=" + textBox7.Text + ";User ID = " + textBox6.Text + "; Password=" + textBox8.Text;
            SqlConnection conn = new SqlConnection(myConnectionString);
            comando.Connection = conn;
            comando.CommandText = "select (max(refno)+1) from lif_mgm_t_policy";
            conn.Open();
            textBox4.Text = comando.ExecuteScalar().ToString();
            conn.Close();            
        }


        ////DataTable table = new DataTable();
        ////create our SQL SELECT statement
        //string sql = "select isnull(max(refno),1) from lif_mgm_t_policy";
        //SqlCommand cmd = new SqlCommand(sql, con);
        //SqlDataReader Reader;
        //SqlDataAdapter da = new SqlDataAdapter(sql, con);
        //cmd.CommandText = "select isnull(max(refno),1) from lif_mgm_t_policy";
        //cmd.CommandType = CommandType.Text;
        //cmd.Connection = con;
        //con.Open();
        //Reader = cmd.ExecuteReader();
        //da.Fill(da);
        //con.Close();

        //try
        //    {
        //        //comboBox2.Items.Clear();
        //        con.Open();
        //        //then we execute the SQL statement against the Connection using OleDBDataAdapter
        //        cmd = con.CreateCommand();
        //        cmd.CommandText = "select isnull(max(refno),1) from lif_mgm_t_policy";
        //        cmd.CommandType = CommandType.Text;
        //        cmd.ExecuteNonQuery();
        //        Reader = cmd.ExecuteReader();
        //        //we fill the result to dt which declared above as datatable                    

        //        foreach (DataRow dr in table3.Rows)
        //        {
        //        //we add new entry to our datatable manually 
        //        //becuase Select Course is not Available in the Database
        //        listBox1.Items.Add(dr["refno"].ToString());

        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        //this will display some error message if something 
        //        //went wrong to our code above during execution
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }   

        public void display_data()       
        {       
                 
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [dbo].[Auto_MGM_T_TestData]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close(); 
                       
        }                         
              

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }       

        void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [dbo].[Auto_MGM_T_TestData]  values('" + textBox4.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox7.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "UPDATE [dbo].[Auto_MGM_T_TestData_Claims] SET PolicyID = " + textBox4.Text;
            cmd2.ExecuteNonQuery();
            con.Close();
            con.Open();
            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "UPDATE [dbo].[Auto_MGM_T_TestData_Claims] SET ClaimIncidentDate = " + textBox9.Text;
            cmd3.ExecuteNonQuery();
            con.Close();
            con.Open();
            SqlCommand cmd4 = con.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "UPDATE [dbo].[Auto_MGM_T_TestData_Web] SET PolicyID = " + textBox4.Text;
            cmd4.ExecuteNonQuery();
            con.Close();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            display_data();
            MessageBox.Show("Data Prepared. Now Create Your Ordered Test");
            label15.Show();
            label16.Hide();
            label17.Hide();
            label18.Hide();

        }

    private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from [dbo].[Auto_MGM_T_TestData]";
            cmd.ExecuteNonQuery();
            con.Close();
            display_data();
            MessageBox.Show("Cleared and Ready for Next Scenario");
            label15.Hide();
        }        

        public DataTable ExecuteQuery(string pstrSQL)
        {
            return new DataTable();
        }

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {            
            FillCombo2();
            PolicyNumber();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }    
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                test form2 = new test();
                form2.Show();

                this.Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd10 = con.CreateCommand();
            cmd10.CommandType = CommandType.Text;
            cmd10.CommandText = "UPDATE Auto_MGM_T_TestData SET Server = Null";
            cmd10.CommandText = "UPDATE [dbo].[Auto_MGM_T_TestData] SET Server = ('" + textBox5.Text + "')";
            cmd10.ExecuteNonQuery();
            con.Close();
            con.Open();
            SqlCommand cmd11 = con.CreateCommand();
            cmd11.CommandType = CommandType.Text;
            cmd11.CommandText = "UPDATE Auto_MGM_T_TestData SET SQLUser = Null";
            cmd11.CommandText = "UPDATE [dbo].[Auto_MGM_T_TestData] SET SQLUser = ('" + textBox6.Text + "')";
            cmd11.ExecuteNonQuery();
            con.Close();
            con.Open();
            SqlCommand cmd12 = con.CreateCommand();
            cmd12.CommandType = CommandType.Text;
            cmd12.CommandText = "UPDATE Auto_MGM_T_TestData SET Database = Null";
            cmd12.CommandText = "UPDATE [dbo].[Auto_MGM_T_TestData] SET [Database] = ('" + textBox7.Text + "')";
            cmd12.ExecuteNonQuery();
            con.Close();
            con.Open();
            SqlCommand cmd13 = con.CreateCommand();
            cmd13.CommandType = CommandType.Text;
            cmd13.CommandText = "UPDATE Auto_MGM_T_TestData SET SQLPassword = Null";
            cmd13.CommandText = "UPDATE [dbo].[Auto_MGM_T_TestData] SET SQLPassword = ('" + textBox8.Text + "')";
            cmd13.ExecuteNonQuery();
            con.Close();
            display_data();
            MessageBox.Show("Your test scenario is now ready to run on a different database");

        }
    }
}
