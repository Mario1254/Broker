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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        public
       SqlConnection con = new SqlConnection("Data Source=MEHRIBAN-PC\\SQLEXPRESS;Initial Catalog=makler;Integrated Security=True");
        SqlCommand com;
        SqlDataAdapter da;
        DataSet ds;

        public string KL, PN;


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

            ds = new DataSet();
            con.Open();
            da = new SqlDataAdapter(w, con);
            da.Fill(ds);
            con.Close();

            return (ds.Tables[0].Rows.Count + 1);
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maklerDataSet19.arenda' table. You can move, or remove it, as needed.
            this.arendaTableAdapter.Fill(this.maklerDataSet19.arenda);
            // TODO: This line of code loads data into the 'maklerDataSet18.prodaja' table. You can move, or remove it, as needed.
            this.prodajaTableAdapter.Fill(this.maklerDataSet18.prodaja);
            // TODO: This line of code loads data into the 'maklerDataSet17.t1' table. You can move, or remove it, as needed.
            this.t1TableAdapter.Fill(this.maklerDataSet17.t1);


            otrazit("select* from t1",1);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //vibor nujnoy stroki
            con.Open();
            da = new SqlDataAdapter("select* from prodaja where KL like '" + KL + "' and PN like '" + PN + "'", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            string[] mas = new string[8];
            for (int i = 0; i <= 7; i++)
                mas[i] = ds.Tables[0].Rows[0].ItemArray[i].ToString();

            dataGridView2.Visible = true;
            dataGridView3.Visible = true;

            //soxr v arendu
            con.Open();
            com = new SqlCommand("Insert into arenda(Kl,PN,Rayon,Tip,Remont,Rooms,Ploshad,Cena,Srok,D1,D2,ID)values('" + mas[0] + "','" + mas[1] + "','" + mas[2] + "','" + mas[3] + "','" + mas[4] + "','" + mas[5] + "','" + mas[6] + "','" + mas[7] + "','" + comboBox1.SelectedIndex + "','" + " " + "','" + "  " + "','" + "0" + "')", con);
            com.ExecuteNonQuery();
            con.Close();
            otrazit("select* from arenda",3);

            //udaleniye iz prodaji
            con.Open();
            com = new SqlCommand("delete from prodaja where KL like'" + KL + "' and PN like '" + PN + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            otrazit("select* from prodaja",2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //vibor nujnoy stroki
            con.Open();
            da = new SqlDataAdapter("select* from prodaja where KL like '" + KL + "' and PN like '" + PN + "'", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                string[] mas = new string[8];
                for (int i = 0; i <= 7; i++)
                {
                    mas[i] = ds.Tables[0].Rows[0].ItemArray[i].ToString();
                    MessageBox.Show(mas[i]);
                }
                dataGridView2.Visible = true;
                dataGridView3.Visible = true;

                //soxr v arendu
                con.Open();
                com = new SqlCommand("Insert into arenda(Kl,PN,Rayon,Tip,Remont,Rooms,Ploshad,Cena,Srok,D1,D2,ID)values('" + mas[0] + "','" + mas[1] + "','" + mas[2] + "','" + mas[3] + "','" + mas[4] + "','" + mas[5] + "','" + mas[6] + "','" + mas[7] + "','" + comboBox1.SelectedIndex + "','" + " " + "','" + "  " + "','" + "0" + "')", con);
                com.ExecuteNonQuery();
                con.Close();
                otrazit("select* from arenda", 3);
                otrazit("select*from prodaja", 2);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //vibor nujnoy stroki
           // string K = Convert.ToString(Kol("select* from arenda"));
            con.Open();
            da = new SqlDataAdapter("select* from arenda where KL like '" + textBox1.Text + "'", con); //and PN like '" + PN + "'", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            int k1 = ds.Tables[0].Columns.Count;
            if(ds.Tables[0].Rows.Count>0)
            {
            string[] mas = new string[k1+1];
            for (int i = 0; i <= ds.Tables[0].Columns.Count; i++)
                mas[i] = ds.Tables[0].Rows[0].ItemArray[i].ToString();

            dataGridView2.Visible = true;
            dataGridView3.Visible = true;

            //soxr v prodaju
            con.Open();
            com = new SqlCommand("Insert into arenda(Kl,PN,Rayon,Tip,Remont,Rooms,Ploshad,Cena)values('" + mas[0] + "','" + mas[1] + "','" + mas[2] + "','" + mas[3] + "','" + mas[4] + "','" + mas[5] + "','" + mas[6] + "','" + mas[7] +"')", con);
            com.ExecuteNonQuery();
            con.Close();
            otrazit("select* from prodaja", 2);

            //udaleniye iz arendi
            con.Open();
            com = new SqlCommand("delete from arenda where KL like'" + textBox1.Text + "'",con); // and PN like '" + PN + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            otrazit("select* from arenda", 3);
        }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //vibor nujnoy stroki
            //string K = Convert.ToString(Kol("select* from arenda"));
            //int k1 = Convert.ToInt16(K);
            //MessageBox.Show("select* from arenda where KL like '" + textBox1.Text + "'",con);// and PN like '" + K + "'");
            con.Open();
            da = new SqlDataAdapter("select* from arenda where KL like '" + textBox1.Text + "'",con); //and PN like '" + K + "'", con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            int k1 = ds.Tables[0].Columns.Count;
            if (ds.Tables[0].Rows.Count > 0)
            {
                string[] mas = new string[k1+1];
                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                    mas[i] = ds.Tables[0].Rows[0].ItemArray[i].ToString();

                dataGridView2.Visible = true;
                dataGridView3.Visible = true;

                //soxr v prodaju
                con.Open();
                com = new SqlCommand("Insert into prodaja(Kl,PN,Rayon,Tip,Remont,Rooms,Ploshad,Cena)values('" + mas[0] + "','" + mas[1] + "','" + mas[2] + "','" + mas[3] + "','" + mas[4] + "','" + mas[5] + "','" + mas[6] + "','" + mas[7] + "')", con);
                com.ExecuteNonQuery();
                con.Close();
                otrazit("select* from prodaja", 2);
                otrazit("select* from arenda", 3);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            otrazit("Select* from t1 where NK like '" + textBox1.Text + "'", 1);
            otrazit("Select* from arenda where KL like '" + textBox1.Text + "'", 3);
            otrazit("Select* from prodaja where KL like '" + textBox1.Text + "'", 2);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KL = dataGridView2[0, e.RowIndex].Value.ToString();
            PN = dataGridView2[1, e.RowIndex].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KL = dataGridView3[0, e.RowIndex].Value.ToString();
            // PN = dataGridView2[1, e.RowIndex].Value.ToString();
        }
    }
}
