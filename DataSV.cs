using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace thi_giua_ky
{
    
    class DataSV
    {
        private  static DataSV _sv;
        public static DataSV sv
        {
            get
            {
                if(_sv == null)
                {
                    _sv = new DataSV();
                }
                return _sv;
            }
             private set { }
        
        }
        public DataTable DTSV { get; set; }
     private  DataSV()
        {
            DTSV = new DataTable();
            DTSV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName = "MSSV",DataType = typeof(string)},
                new DataColumn {ColumnName = "NameSV",DataType = typeof(string)},
                new DataColumn {ColumnName = "LopSH",DataType = typeof(string)},
                new DataColumn {ColumnName = "Gender",DataType = typeof(bool)},
                new DataColumn {ColumnName = "NS",DataType = typeof(DateTime)},
                new DataColumn {ColumnName = "DTB",DataType = typeof(double)},
                new DataColumn {ColumnName = "ANH",DataType = typeof(bool)},
                new DataColumn {ColumnName = "HB",DataType = typeof(bool)},
                new DataColumn {ColumnName = "CCNN",DataType = typeof(bool)},

            });
            DTSV.Rows.Add("102", "nguyen van a", "19T", true, DateTime.Now, 1.1, true, false, true);
            DTSV.Rows.Add("103", "nguyen van b", "18T", true, DateTime.Now, 2.1, false, false, true);
            DTSV.Rows.Add("104", "nguyen van c", "19T", true, DateTime.Now, 3.1, true, true, true);
        }

        public void Add(SV s)
        {
            DTSV.Rows.Add(s.MSSV, s.NameSV, s.LopSH, s.Gender, s.NS, s.DTB, s.Anh, s.HB, s.CCNN);
        }
        public void update_row(SV s)
        {
            foreach(DataRow i in DTSV.Rows)
            {
                if(i[0].Equals(s.MSSV))
                {
                    i[0] = s.MSSV;
                    i[1] = s.NameSV;
                    i[2] = s.LopSH;
                    i[3] = s.Gender;
                    i[4] = s.NS;
                    i[5] = s.DTB;
                    i[6] = s.Anh;
                    i[7] = s.HB;
                    i[8] = s.CCNN;
                }
                
            }
        }
        public void delrow(string mssv)
        {
            for (int i = DTSV.Rows.Count - 1; i >= 0; i--)
            {
                // sample removes all even foos
                if ((string)DTSV.Rows[i]["MSSV"]  == mssv)
                    DTSV.Rows.RemoveAt(i);
            }
        }
    }
   
    
}
