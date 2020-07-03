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

namespace exercise3
{
    public partial class Form1 : Form
    {

        int a, b, result, results;

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\visual basics practical\exercise3\exercise3\Database1.mdf;Integrated Security=True");
            a = Convert.ToInt32(comboBox1.SelectedItem);
            result = (a * 100);
            textBox1.Text = result.ToString();
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into bill values('" + comboBox1.SelectedItem + "', '" + comboBox2.SelectedItem + "', '" + textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();

            listBox1.Items.Add(label2.Text + ":" + comboBox1.SelectedItem.ToString() + "-" + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\visual basics practical\exercise3\exercise3\Database1.mdf;Integrated Security=True");

            b = Convert.ToInt32(comboBox2.SelectedItem);
            results = (b * 80);
          
            textBox1.Text =(result + results).ToString();
            con.Open();
            
            SqlCommand cmd = new SqlCommand("insert into bill values('" + comboBox1.SelectedItem.ToString() + "', '" + comboBox2.SelectedItem.ToString() + "', '" + textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            listBox1.Items.Add(label3.Text + ":" + comboBox2.SelectedItem.ToString() + "-" + textBox1.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\visual basics practical\exercise3\exercise3\Database1.mdf;Integrated Security=True");
            con.Open();
            string sqlTrunc = "TRUNCATE TABLE  bill";
            SqlCommand cmd = new SqlCommand(sqlTrunc, con);
            cmd.ExecuteNonQuery();
            con.Close();



        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public static void main(string[] args)
        {

            Application.Run(new Form1());


        }
    }
}