﻿using System;
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
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        SqlHelperr a = new SqlHelperr();
        private void btn_eklee_Click(object sender, EventArgs e)
        {
            int para = (int)numericUpDown1.Value;
            DateTime yep = dateTimePicker1.Value;
            string giderler = "";
            foreach (Control item in groupBox1.Controls)
            {
                if(item is CheckBox && ((CheckBox)item).Checked)
                {
                    giderler +=","+ item.Text;
                }
            }
            giderler = giderler.Remove(0, 1);

            SqlParameter p1 = new SqlParameter("Gider",giderler);
            SqlParameter p2 = new SqlParameter("Para", para);
            SqlParameter p3 = new SqlParameter("Tarih",yep);

            a.ExecuteProc("giderlerm",p1,p2,p3);


        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            DataTable dt = a.GetTable("select * from GiderTablosu");

            foreach (DataRow dr in dt.Rows) 
            {
                listBox1.Items.Add(dr["Para"]).ToString();
                listBox2.Items.Add(dr["Tarih"]).ToString();
                listBox3.Items.Add(dr["Gider"]).ToString();
            }
        }
    }
}
