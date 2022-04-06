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
    public partial class Form1 : Form
    {
        private QLSV qlsv = new QLSV();
        public Form1()
        {
            InitializeComponent();
            cbb_lopsinhhoat.Items.Add("all");
            foreach (string i in qlsv.get_all_lsh().Distinct())
            {
                cbb_lopsinhhoat.Items.Add(i);

            }

        }
        public void reload(string lsh)
        {
            dataGridView1.DataSource = qlsv.get_sv_by_lsh(lsh);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_show_Click(object sender, EventArgs e)
        {
            if (cbb_lopsinhhoat.SelectedIndex >= 0)
            {
                string lsh = cbb_lopsinhhoat.SelectedItem.ToString();
                dataGridView1.DataSource = qlsv.get_sv_by_lsh(lsh);
            }
            else
            {
                MessageBox.Show("ban chua chon lop sinh hoat");
                cbb_lopsinhhoat.Text = "all";

            }

        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2("");
            f.del = new Form2.mydel(reload);
            f.Show();


        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string mssv = dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString();
                Form2 f = new Form2(mssv);
                f.del = new Form2.mydel(reload);
                f.Show();
            }
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<string> del = new List<string>();
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    del.Add(i.Cells["MSSV"].Value.ToString());
                }

                qlsv.del_sv(del);

                cbb_lopsinhhoat.SelectedIndex = 0;
                reload(cbb_lopsinhhoat.SelectedItem.ToString());
            }
        }

        private void bt_sort_Click(object sender, EventArgs e)
        {
            List<string> now = new List<string>();
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                now.Add(i.Cells["MSSV"].Value.ToString());
            }
            dataGridView1.DataSource = qlsv.sort1(qlsv.getAllSV());
        }
        DataGridView d = new DataGridView();
        private void bt_search_Click(object sender, EventArgs e)
        {

            string key = txt_search.Text;
            dataGridView1.DataSource = qlsv.finds(key);
        }
        }
    }

