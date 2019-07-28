using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterWay.Models
{
    public class Part
    {
        public int Id { get; set; }
        public string Partnumber { get; set; }
        public int CaseId { get; set; }
        public string OrderDate { get; set; }
        public int Delivered { get; set; }
        public string PartInfo
        {
            get
            {
                return CaseId + " - P/N: " + Partnumber + " Order date: " + OrderDate;
            }
        }
    }
}
