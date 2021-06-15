using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQLOrderSystem
{
    public partial class Form1 : Form
    {
        private string SQL_ConnectStr = "server=127.0.0.1;port=3306;User=root;password=Cx010928;Database=ordersystemdatabase";
        public MySqlConnection myConnection;
        MySqlDataAdapter mySqlDataAdapter,mySqlDataAdapter1;
        DataSet dataset,dataset1;
        DataTable dt;
        string mySql;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBase_Connection();
            DataBase_SelectAll(myConnection);
        }

        public void DataBase_Connection()
        {
            try
            {
                myConnection = new MySqlConnection(SQL_ConnectStr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("数据库连接成功");
            }
        }

        public void DataBase_SelectAll(MySqlConnection myConnection)
        {
            try
            {
                if (myConnection != null)
                {
                    myConnection.Open();
                }
                Console.WriteLine("数据库查询端口已开启");
                string sqlselect = "SELECT * FROM ordersystem";
                MySqlCommand myCommand = new MySqlCommand(sqlselect, myConnection);
                mySqlDataAdapter = new MySqlDataAdapter(myCommand);
                dataset = new DataSet();
                mySqlDataAdapter.Fill(dataset, "ordersystem");
                dt = dataset.Tables["ordersystem"];
                dataGridView1.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                label1.Text = "数据库连接错误";
            }
           // finally
           // {
           //     myConnection.Close();
           // }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataset.Tables["ordersystem"].Clear();
            mySqlDataAdapter.Fill(dataset,"ordersystem");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable changeDt = dt.GetChanges();

            foreach(DataRow dr in changeDt.Rows)
            {
                if (dr.RowState == System.Data.DataRowState.Added)
                {

                   mySql = @"INSERT INTO `ordersystemdatabase`.`ordersystem` (`Order_id`,`Order_name`,`Order_cus`,`Order_price`)
                                  VALUES ('" + Convert.ToInt32(dr["Order_id"]) + "','" + dr["Order_name"].ToString() + "','" + dr["Order_cus"].ToString() + "','" + Convert.ToInt32(dr["Order_price"]) + "');";
                    MySqlCommand comm = new MySqlCommand(mySql, myConnection);
                    comm.ExecuteNonQuery();
                }
                else if (dr.RowState == System.Data.DataRowState.Modified)
                {
                    mySql = @"UPDATE `ordersystemdatabase`.`ordersystem`
                                     SET  `Order_name` = '" + dr["Order_name"].ToString() +"',`Order_cus` = '" + dr["Order_cus"].ToString() + "',`Order_price` = '" + Convert.ToInt32(dr["Order_price"]) + @"'
                                     WHERE (`Order_id` = '" + dr["Order_id"].ToString() + "');"; 
                    MySqlCommand comm = new MySqlCommand(mySql, myConnection);
                    comm.ExecuteNonQuery();
                }
                else if (dr.RowState == System.Data.DataRowState.Deleted)
                {
                    mySql = @"DELETE FORM [ordersystem]
                                   WHERE Order_id = '" + Convert.ToInt32(dr["Order_id", DataRowVersion.Original]) + @""; 
                    MySqlCommand comm = new MySqlCommand(mySql, myConnection);
                    comm.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myselect = "SELECT * FROM ordersystem WHERE Order_id = '" + textBox1.Text + "'";
                MySqlCommand myCommand = new MySqlCommand(myselect, myConnection);
                mySqlDataAdapter1 = new MySqlDataAdapter(myCommand);
                dataset1 = new DataSet();
                mySqlDataAdapter1.Fill(dataset1, "ordersystem");
                dataGridView2.DataSource = dataset1;
                dataGridView2.DataMember = "ordersystem";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                label1.Text = "查询出现了问题";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if(dataGridView1.Rows[index].HeaderCell.Value=="n"&& dataGridView1.Rows[index].HeaderCell.Value == textBox1.Text)
            {
                dataGridView1.Rows.RemoveAt(index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string myselect = "SELECT * FROM ordersystem WHERE Order_name LIKE '%" + textBox1.Text + "%'";
                MySqlCommand myCommand = new MySqlCommand(myselect, myConnection);
                mySqlDataAdapter1 = new MySqlDataAdapter(myCommand);
                dataset1 = new DataSet();
                mySqlDataAdapter1.Fill(dataset1, "ordersystem");
                dataGridView2.DataSource = dataset1;
                dataGridView2.DataMember = "ordersystem";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                label1.Text = "查询出现了问题";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string myselect = "SELECT * FROM ordersystem WHERE Order_cus LIKE '%" + textBox1.Text + "%'";
                MySqlCommand myCommand = new MySqlCommand(myselect, myConnection);
                mySqlDataAdapter1 = new MySqlDataAdapter(myCommand);
                dataset1 = new DataSet();
                mySqlDataAdapter1.Fill(dataset1, "ordersystem");
                dataGridView2.DataSource = dataset1;
                dataGridView2.DataMember = "ordersystem";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                label1.Text = "查询出现了问题";
            }
        }

    }
}
