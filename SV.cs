using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thi_giua_ky
{
    class SV : IComparable<SV>
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public string LopSH { get; set; }
        public bool Gender { get; set; }
        public DateTime NS { get; set; }
        public double DTB { get; set; }
        public bool Anh { get; set; }
        public bool HB { get; set; }
        public bool CCNN { get; set; }

        public int CompareTo(SV other)
        {
            return this.MSSV.CompareTo(other.MSSV);
        }
    }

}
