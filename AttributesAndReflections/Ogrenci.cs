using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesAndReflections
{
    [Table("Ogrenci")]
    public class Ogrenci
    {
        [Column("Id",typeof(int),true)]
        public int Id { get; set; }

        [Column("Name", typeof(string), false)]
        public string Name { get; set; }   
    }
}
