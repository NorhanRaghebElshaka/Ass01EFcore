using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01EFcore.Entites
{
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        public string DepName { get; set; }

        public string city { get; set; }

    }
}
