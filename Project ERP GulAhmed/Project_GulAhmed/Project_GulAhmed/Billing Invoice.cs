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
    public partial class Billing_Invoice : Form
    {
        public SqlConnection sqlcon = new SqlConnection("Data Source=ALI-PC;Initial Catalog=Gul_Ahmed;Integrated Security=True");
        SqlCommand cmd;
        public Billing_Invoice()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Billing_Invoice_Load(object sender, EventArgs e)
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee em = new Employee();
            em.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {

            this.dataGridView1.Rows.Add(this.comboBox1.Text, this.textBox2.Text, this.textBox4.Text, this.textBox3.Text, this.dateTimePicker2.Value.Date.ToString("d"), this.textBox1.Text);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Product where P_name='" + comboBox1.Text + "'", sqlcon);
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

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            if (this.textBox4.Text != "")
            {
                this.textBox3.Text = (Convert.ToInt64(this.textBox2.Text) * Convert.ToInt64(this.textBox4.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                sqlcon.Open();
                cmd = new SqlCommand("insert into billing_invoice(No_of_items,total_price,invoice_date,product_name,product_code,price)values('"+textBox4.Text+"','"+textBox3.Text+"','"+dateTimePicker2.Value.ToString("d")+"','"+comboBox1.Text+"','"+textBox1.Text+"','"+textBox2.Text+"')",sqlcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert Billing Invoice Table..!!!");
                sqlcon.Close();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
        

     

