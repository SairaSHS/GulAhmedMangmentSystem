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

namespace Project_GulAhmed
{
    public partial class product : Form
    {
        public SqlConnection sqlcon = new SqlConnection("Data Source=ALI-PC;Initial Catalog=Gul_Ahmed;Integrated Security=True");
        SqlCommand cmd;     
        public product()
        {
            InitializeComponent();
        }

        private void product_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;

            comboBox1.Items.Clear();
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT P_Name FROM Product";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["P_Name"].ToString());

            }
            sqlcon.Close();
            

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee em = new Employee();
            em.Show();

        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            product p = new product();
            p.Show();
        }

        private void billingInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Billing_Invoice bi = new Billing_Invoice();
            bi.Show();

        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction t = new Transaction();
            t.Show();


        }

        private void saleMangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 sm = new Form2();
            sm.Show();

        }

        private void inventoryStrockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory_Stock IS = new Inventory_Stock();
            IS.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Product where P_name='"+comboBox1.Text+"'",sqlcon);
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader Dr;
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                this.textBox1.Text = Dr["P_Code"].ToString();
                this.textBox2.Text = Dr["P_Price"].ToString();
            }
            sqlcon.Close();
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(comboBox1.Text, textBox1.Text, textBox2.Text);
        }
    }
}
   
