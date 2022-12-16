using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EdditionAndPrintDate
    {
        public DateTime PrintDate { get; set; }
        public int Eddition { get; set; }
        public EdditionAndPrintDate(DateTime printData,int eddition = 1)
        {
            Eddition = eddition;
        }
    }
}
