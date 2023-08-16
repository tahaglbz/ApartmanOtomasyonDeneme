using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyonDeneme
{
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }
        SqlHelperr helper = new SqlHelperr();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int daireno = Convert.ToInt32(comboBox1.Text);

            int para = (int)numericUpDown1.Value;
            DateTime yeni = dateTimePicker1.Value;

            SqlParameter p1 = new SqlParameter("DaireNO",daireno);
            SqlParameter p2 = new SqlParameter("Para",para);
            SqlParameter p3 = new SqlParameter("Tarih", yeni);

            helper.ExecuteProc("odeme_al",p1,p2,p3);
        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            DataTable dtr = helper.GetTable("select * from aidatOdemesi");

            foreach (DataRow item in dtr.Rows)
            {
                listBox1.Items.Add(item["DaireNO"]).ToString();
                listBox2.Items.Add(item["Para"]).ToString();
                listBox3.Items.Add(item["Tarih"]).ToString();
            }
        }
    }
}
