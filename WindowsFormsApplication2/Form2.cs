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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=MEHRIBAN-PC\\SQLEXPRESS;Initial Catalog=makler;Integrated Security=True");
        SqlCommand com;
        SqlDataAdapter da;
        DataSet ds;

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maklerDataSet13.tip' table. You can move, or remove it, as needed.
            this.tipTableAdapter.Fill(this.maklerDataSet13.tip);
            // TODO: This line of code loads data into the 'maklerDataSet12.rayoni' table. You can move, or remove it, as needed.
            this.rayoniTableAdapter1.Fill(this.maklerDataSet12.rayoni);
            // TODO: This line of code loads data into the 'maklerDataSet8.remont' table. You can move, or remove it, as needed.
            this.remontTableAdapter.Fill(this.maklerDataSet8.remont);
            // TODO: This line of code loads data into the 'maklerDataSet7.rayoni' table. You can move, or remove it, as needed.
         //   this.rayoniTableAdapter.Fill(this.maklerDataSet7.rayoni);
            // TODO: This line of code loads data into the 'maklerDataSet5.arenda' table. You can move, or remove it, as needed.
            this.arendaTableAdapter.Fill(this.maklerDataSet5.arenda);
            // TODO: This line of code loads data into the 'maklerDataSet4.telefon' table. You can move, or remove it, as needed.
            this.telefonTableAdapter.Fill(this.maklerDataSet4.telefon);
            // TODO: This line of code loads data into the 'maklerDataSet3.t1' table. You can move, or remove it, as needed.
            this.t1TableAdapter.Fill(this.maklerDataSet3.t1);

            dataGridView1.Top = this.Height - dataGridView1.Height - 50;
            dataGridView1.Left = 8;
            dataGridView1.Width = this.Width - 250;
            otrazit("select* from arenda", 3);

        }

        void otrazit(string w, int P)
        {
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(w, con);
            da.Fill(ds);
            con.Close();
            if (P == 1) dataGridView1.DataSource = ds.Tables[0];
            if (P == 2) dataGridView2.DataSource = ds.Tables[0];
            if (P == 3) dataGridView3.DataSource = ds.Tables[0];
        }


        public int Kol(string w)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(w, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return (ds.Tables[0].Rows.Count + 1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand("insert into t1(nk,fio,vesiqe,address)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
            //dataGridView1.Visible = true;
            otrazit("select* from t1", 1);

            groupBox2.Visible = true;
            dataGridView2.Visible = true;
            otrazit("select* from telefon where NK like '" + textBox1.Text + "'", 2);

            groupBox3.Visible = true;
            otrazit("select* from arenda where kl like '" + textBox1.Text + "'", 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand("insert into telefon(address,nomer,pr,nk)values('" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox1.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
            otrazit("select* from telefon", 2);
        }


        private void button3_Click(object sender, EventArgs e)
        {

            string PN1 = Kol("select* from arenda").ToString();
            con.Open();
            com = new SqlCommand("insert into arenda(kl,pn,rayon,tip,remont,rooms,ploshad,cena,srok)values('" + textBox1.Text + "','" + PN1 + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox4.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','"+comboBox3.SelectedIndex+"')",con);
            com.ExecuteNonQuery();
            con.Close();
            otrazit("select* from arenda", 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            textBox5.Clear();
            textBox6.Clear();

           // comboBox1.Items.Clear();
            //comboBox2.Items.Clear();
            //comboBox3.Items.Clear();
           // comboBox4.Items.Clear();        
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            
        }
    }
}
