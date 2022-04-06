using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace thi_giua_ky
{
    class QLSV
    {
        public List<SV> getAllSV()
        {
            List<SV> data = new List<SV>(); // khởi tạo list rỗng để chứa sinh viên
            foreach(DataRow i in DataSV.sv.DTSV.Rows)
            {
                data.Add(transfer_datarow_for_SV(i));//loi do khong the add 1 row, phia viet ham chuyen tu row thanh string
            }


            return data;
        }
        public SV transfer_datarow_for_SV(DataRow i)// lấy 1 sv ra từ datatable
        {
            return new SV
            {
                MSSV = i[0].ToString(),
                NameSV = i["NameSv"].ToString(),
                LopSH = i["LopSH"].ToString(),
                Gender = Convert.ToBoolean(i["Gender"].ToString()),
                NS = Convert.ToDateTime(i["NS"].ToString()),
                DTB = Convert.ToDouble(i["DTB"].ToString()),
                Anh = Convert.ToBoolean(i["ANH"].ToString()),
                CCNN = Convert.ToBoolean(i["CCNN"].ToString()),
                HB = Convert.ToBoolean(i["HB"].ToString())
            };
        }
        public List<SV> get_sv_by_lsh(string lsh)
        {
            List<SV> data = new List<SV>();
            if(lsh == "all")
            {
                data = getAllSV();
            }
            else
            {
                foreach(SV i in getAllSV())
                {
                    if(i.LopSH == lsh)
                    {
                        data.Add(i);
                    }
                }
            }
            return data;            
        }
        public List<string> get_all_lsh()
        {
            List<string> data = new List<string>();
            foreach(SV i in getAllSV())
            {
                data.Add(i.LopSH);
            }
            return data;
        }
        public SV getSVbyMSSV(string mssv)
        {
            SV s = new SV();
            foreach(SV i in getAllSV())
            {
                if(i.MSSV == mssv)
                {
                    s = i;
                    break;
                }
            }
            return s;
        }
        public bool ADDUpdate(string mssv)
        {
            bool ADD = true;
            foreach(SV i in getAllSV())
            {
                if(i.MSSV == mssv)
                {
                    ADD = false;
                }
            }
            return ADD;
        }
        public void  ExecuteData(SV s)
        {
            if (ADDUpdate(s.MSSV))
            {
                DataSV.sv.Add(s);
            }
            else
            {
                DataSV.sv.update_row(s);
            }
        }
      public void del_sv (List<string> del)
        {
            foreach(string i in del)
            {
                DataSV.sv.delrow(i);
            }
        }
    public List<SV> getSvDtg(List<string> now){
            List<SV> data = new List<SV>();
            foreach(string i in now) { 
                foreach(SV j in getAllSV())
                {
                    if(i == j.MSSV)
                    {
                        data.Add(j);
                        break;
                    }
                }
            }
            return data;
        }
        public List<SV> sort1(List<SV> data)
        {
            data = getAllSV();
            data.Sort();
            return data;
        }
        public List<SV> finds(string data)
        {
            List<SV> data1 = new List<SV>();
           foreach(SV i in getAllSV())
            {
                if(i.NameSV == data)
                {
                    data1.Add(i);
                }
            }
            return data1;
        }

    }
}
