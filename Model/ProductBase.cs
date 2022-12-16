using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class ProductBase
    {
        public Guid Id { get; internal set; }
        public string Name { get; set; }
        public List<EdditionAndPrintDate> edditionAndPrintDates1 { get; set; }
        public List<string> AuthersNames { get; set; }
        public ProductBase(string name,DateTime printDate ,List<string>authersNames , EdditionAndPrintDate edditionAndPrintDate)
        {
            Id = new Guid();
            Name = name;
            AuthersNames = authersNames;
            edditionAndPrintDates1 = new List<EdditionAndPrintDate>();
            edditionAndPrintDates1.Add(edditionAndPrintDate);
        }

    }
}
