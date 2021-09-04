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

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

         SqlConnection con = new SqlConnection("Data Source=MEHRIBAN-PC\\SQLEXPRESS;Initial Catalog=makler;Integrated Security=True");
        SqlCommand com;
        SqlDataAdapter da;
        DataSet ds;
        public string KL;

        void otrazit(string w)
        {
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(w, con);
            da.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maklerDataSet16.remont' table. You can move, or remove it, as needed.
            this.remontTableAdapter.Fill(this.maklerDataSet16.remont);
            // TODO: This line of code loads data into the 'maklerDataSet15.tip' table. You can move, or remove it, as needed.
            this.tipTableAdapter.Fill(this.maklerDataSet15.tip);
            // TODO: This line of code loads data into the 'maklerDataSet14.rayoni' table. You can move, or remove it, as needed.
            this.rayoniTableAdapter.Fill(this.maklerDataSet14.rayoni);
            // TODO: This line of code loads data into the 'maklerDataSet6.arenda' table. You can move, or remove it, as needed.
            this.arendaTableAdapter.Fill(this.maklerDataSet6.arenda);

            dataGridView1.Top = this.Height - dataGridView1.Height - 50;
            dataGridView1.Left = 8;
            dataGridView1.Width = this.Width - 250;
            otrazit("select* from arenda");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f1 = "", f2 = "", f3 = "", f4 = "", f5 = "", f6 = "", f7= "";
            string f = "where ";

            if (checkBox1.Checked) f1 = "rayon like '" + comboBox1.Text + "'";
            if (checkBox2.Checked) f2 = "tip like '" + comboBox2.Text + "'";
            if (checkBox3.Checked) f3 = "remont like '" + comboBox5.Text + "'";
            if (checkBox4.Checked) f4 = "rooms like '" + comboBox3.Text + "'";
            if (checkBox5.Checked) f5 = "ploshad >=" + textBox1.Text + " and ploshad <=" + textBox2.Text + "";
            if (checkBox6.Checked) f6 = "cena >=" + textBox3.Text + " and cena <=" + textBox4.Text + "";
            if (checkBox7.Checked) f1 = "srok like '" + comboBox4.Text + "'";

            if (f1 != "")
            {
                if (f == "where ") f = f + f1; else f = f + " and " + f1;
            }

            if (f2 != "")
            {
                if (f == "where ") f = f + f2; else f = f + " and " + f2;
            }
            if (f3 != "")
            {
                if (f == "where ") f = f + f3; else f = f + " and " + f3;
            }
            if (f4 != "")
            {
                if (f == "where ") f = f + f4; else f = f + " and " + f4;
            }
            if (f5 != "")
            {
                if (f == "where ") f = f + f5; else f = f + " and " + f5;
            }
            if (f6 != "")
            {
                if (f == "where ") f = f + f6; else f = f + " and " + f6;
            }
            if (f7 != "")
            {
                if (f == "where ") f = f + f7; else f = f + " and " + f7;
            }

            //MessageBox.Show(f);

            if (f == "where ") otrazit("select* from arenda where id like  0");
            else otrazit("select* from arenda " + f+" and id like '"+"0"+"'");
            }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
           
            con.Open();
            com = new SqlCommand("update arenda set D1='" + dateTimePicker1.Value.ToShortDateString() + "', D2='" + dateTimePicker2.Value.ToShortDateString() + "', ID='"+1+"' where  KL like  '" + textBox5.Text + "'", con);           
            com.ExecuteNonQuery();
            con.Close();
            otrazit("select* from arenda");
             
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KL = dataGridView1[0, e.RowIndex].Value.ToString();
            con.Open();
            com = new SqlCommand("update arenda set D1='" + dateTimePicker1.Value.ToShortDateString() + "', D2='" + dateTimePicker2.Value.ToShortDateString() + "', ID='" + 1 + "' where  KL like  '" + KL + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            otrazit("select* from arenda");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         
    }
}
