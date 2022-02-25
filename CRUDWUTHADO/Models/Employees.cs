using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWUTHADO.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Mobil { get; set; }
        public string Gender { get; set; }
        public int Dept_Id { get; set; }
        public string DName { get; set; }
    }
}
