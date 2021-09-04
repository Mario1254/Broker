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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        public
        SqlConnection con = new SqlConnection("Data Source=MEHRIBAN-PC\\SQLEXPRESS;Initial Catalog=makler;Integrated Security=True");
        SqlCommand com;
        SqlDataAdapter da;
        DataSet ds;

        public string KL, PN;

        public void perenum(string w) //dla pn
        {   
            con.Open();
            da=new SqlDataAdapter ("select* from "+w,con);
            DataSet ds= new DataSet();
            da.Fill(ds);
            con.Close();

            for(int l=0;l<ds.Tables[0].Rows.Count;l++)
            {
                string KL1 = ds.Tables[0].Rows[l].ItemArray[0].ToString(); MessageBox.Show(KL1);
            con.Open();
                MessageBox.Show("update "+w+" set PN ="+(l+1).ToString() +" where kl like '"+KL1+"'");
            com = new SqlCommand("update "+w+" set PN ="+(l+1).ToString() +" where kl like '"+KL1+"'", con);
            com.ExecuteNonQuery();
            con.Close();
            }
        }

        void otrazit(string w,int P)
        {
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(w, con);
            da.Fill(ds);
            con.Close();
           if(P==1) dataGridView1.DataSource = ds.Tables[0];
            if(P==2) dataGridView2.DataSource = ds.Tables[0];
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maklerDataSet11.remont' table. You can move, or remove it, as needed.
            this.remontTableAdapter.Fill(this.maklerDataSet11.remont);
            // TODO: This line of code loads data into the 'maklerDataSet10.tip' table. You can move, or remove it, as needed.
            this.tipTableAdapter.Fill(this.maklerDataSet10.tip);
            // TODO: This line of code loads data into the 'maklerDataSet9.rayoni' table. You can move, or remove it, as needed.
            this.rayoniTableAdapter.Fill(this.maklerDataSet9.rayoni);
            // TODO: This line of code loads data into the 'maklerDataSet2.telefon' table. You can move, or remove it, as needed.
            this.telefonTableAdapter.Fill(this.maklerDataSet2.telefon);
            // TODO: This line of code loads data into the 'maklerDataSet1.t1' table. You can move, or remove it, as needed.
            this.t1TableAdapter.Fill(this.maklerDataSet1.t1);
            // TODO: This line of code loads data into the 'maklerDataSet.prodaja' table. You can move, or remove it, as needed.
            this.prodajaTableAdapter.Fill(this.maklerDataSet.prodaja);


            dataGridView1.Top = this.Height - dataGridView1.Height - 50;
            dataGridView1.Left = 8;
            dataGridView1.Width = this.Width - 250;    
            otrazit("select* from prodaja",1);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand("insert into t1(nk,fio,vesiqe,address)values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')",con);
            com.ExecuteNonQuery();
            con.Close();
            dataGridView2.Visible = true;
            otrazit("select* from t1",2);

            groupBox3.Visible = true;
            dataGridView3.Visible = true;
            otrazit("select* from telefon where NK like '"+textBox1.Text+"'", 3);

            groupBox4.Visible = true;            
            otrazit("select* from prodaja where kl like '" + textBox1.Text + "'", 1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand("insert into telefon(address,nomer,pr,nk)values('"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox1.Text+"')",con);
            com.ExecuteNonQuery();
            con.Close();
            otrazit("select* from telefon", 3);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string PN1 = Kol("select* from prodaja").ToString();
            textBox13.Text = PN1;
            con.Open();           
            com = new SqlCommand("insert into prodaja(kl,pn,rayon,tip,remont,rooms,ploshad,cena)values('"+textBox1.Text+"','"+textBox13.Text+"','"+comboBox5.Text+"','"+comboBox10.Text+"','"+comboBox11.Text+"','"+textBox10.Text+"','"+textBox11.Text+"','"+textBox12.Text+"')",con);
            com.ExecuteNonQuery();
            con.Close();
            otrazit("select* from prodaja",1);
        }

        private void kuplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
           
        }

        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f1 = "", f2 = "", f3 = "", f4 = "", f5 = "", f6= "";
            string f = "where ";

            if (checkBox1.Checked) f1 = "rayon like '" + comboBox1.Text + "'";
            if (checkBox2.Checked) f2 = "tip like '" + comboBox2.Text + "'";
            if (checkBox3.Checked) f3 = "remont like '" + comboBox3.Text + "'";
            if (checkBox4.Checked) f4 = "rooms like '" + comboBox4.Text + "'";
            if (checkBox5.Checked) f5 = "ploshad >=" + textBox7.Text +" and ploshad <=" + textBox14.Text + "";
            if (checkBox6.Checked) f6 = "cena >=" + textBox15.Text + " and cena <" + textBox16.Text + "";

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
                if (f == "where ") f = f + f5;  else f = f + " and " + f5;
            }
            if (f6 != "")
            {
                if (f == "where ") f = f + f6; else f = f + " and " + f6;
            }
            
            //MessageBox.Show(f);

            if (f == "where ") otrazit("select* from prodaja", 1);
            else otrazit("select* from prodaja " + f, 1);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sdatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
        }

        private void changeOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();   

        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            textBox5.Clear();
            textBox6.Clear();

           // comboBox10.Items.Clear();
           // comboBox11.Items.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
           // comboBox5.Items.Clear();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand("delete from prodaja where KL like'" + textBox18.Text+ "'", con);
            com.ExecuteNonQuery();
            con.Close();
            perenum("prodaja");

            otrazit("select* from prodaja", 1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KL = dataGridView1[0, e.RowIndex].Value.ToString();
            PN = dataGridView1[1, e.RowIndex].Value.ToString();
            con.Open();
            com = new SqlCommand("delete from prodaja where KL like'" + KL + "' and PN like '" + PN + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            otrazit("select* from prodaja",1);

        }

        private void snatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
