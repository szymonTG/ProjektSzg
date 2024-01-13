using System.ComponentModel;

namespace ProjektSzg.Models
{
    public class Employees
    {
        public int id { get; set; }
        [DisplayName("Employee name")]
        public string employeeName { get; set; }
        [DisplayName("Employee Surname")]
        public string employeeSurname { get; set; }
        [DisplayName("Employee telephone number")]
        public int telNumber { get; set; }

    }
}
