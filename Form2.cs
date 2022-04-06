using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thi_giua_ky
{
    
    public partial class Form2 : Form
    {
        private QLSV qlsv = new QLSV();
        public delegate void mydel(string lsh);
        public mydel del { get; set; }
        public string mssv { get; set; }

        public Form2(string m)
        {
            InitializeComponent();
            mssv = m;
            foreach (string i in qlsv.get_all_lsh().Distinct())
            {
                cbb_lopsinhhoat.Items.Add(i);
            }
            gui();
        }
        private void bt_ok_Click(object sender, EventArgs e)
        {
            SV s = new SV
            {
                MSSV = tb_mssv.Text,
                NameSV = tb_name.Text,
                LopSH = cbb_lopsinhhoat.SelectedItem.ToString(),
                NS = Convert.ToDateTime(dateTimePicker1.Value.ToString()),
                Gender  = Convert.ToBoolean(rdb_female.Checked.ToString()),
                DTB =Convert.ToDouble(tb_dtb.Text.ToString()),
                Anh = Convert.ToBoolean(cb_anh.Checked.ToString()),
                HB = Convert.ToBoolean(cb_hocba.Checked.ToString()),
                CCNN = Convert.ToBoolean(cb_ngoaingu.Checked.ToString()),
            };
            qlsv.ExecuteData(s);
            del("all");
            this.Close();
        }
      

        private void Form2_Load(object sender, EventArgs e)
        {
        }


       public void gui()
        {
            if(mssv != "")
            {
                tb_mssv.Enabled = false;
                tb_mssv.Text = qlsv.getSVbyMSSV(mssv).MSSV;
                tb_name.Text = qlsv.getSVbyMSSV(mssv).NameSV;
                cbb_lopsinhhoat.SelectedItem = qlsv.getSVbyMSSV(mssv).LopSH;
                if (qlsv.getSVbyMSSV(mssv).Gender)
                {
                    rdb_male.Checked = true;
                }
                else
                {    rdb_female.Checked = true;
                 }
                dateTimePicker1.Value = qlsv.getSVbyMSSV(mssv).NS;
                tb_dtb.Text = qlsv.getSVbyMSSV(mssv).DTB.ToString();
                cb_anh.Checked = qlsv.getSVbyMSSV(mssv).Anh;
                cb_hocba.Checked = qlsv.getSVbyMSSV(mssv).HB;
                cb_ngoaingu.Checked = qlsv.getSVbyMSSV(mssv).CCNN;

            }

        }

     
    }
}
