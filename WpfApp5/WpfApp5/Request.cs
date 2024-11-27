using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class Request
    {
        public int id {  get; set; }
        public DateTime DateAdd { get; set; }
        public string Equpment { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Client {  get; set; }
        public string Status { get; set; }
        public string ResponsiblePerson { get; set; }
        public List<string> Comments { get; set; } = new List<string>();
    }
}
