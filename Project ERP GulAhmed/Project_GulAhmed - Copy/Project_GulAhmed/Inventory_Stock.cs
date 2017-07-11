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
    public partial class Inventory_Stock : Form
    {
        public SqlConnection sqlcon = new SqlConnection("Data Source=ALI-PC;Initial Catalog=Gul_Ahmed;Integrated Security=True");
       SqlCommand cmd;
        public Inventory_Stock()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Inventory_Stock_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(comboBox1.Text,textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                sqlcon.Open();
                cmd = new SqlCommand("insert into inventory(P_Id,Quality)values('" + comboBox1.Text + "','"+textBox1.Text+"')", sqlcon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfull..!!!");
                sqlcon.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        }

    

        

      
    }

