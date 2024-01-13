using System.ComponentModel;

namespace ProjektSzg.Models
{
    public class Employees
    {
        public int id { get; set; }
        [DisplayName("Employee name")]
        public string employeeName { get; set; }

        public int employeeSurname { get; set; }   

        public int telNumber { get; set; }

    }
}
