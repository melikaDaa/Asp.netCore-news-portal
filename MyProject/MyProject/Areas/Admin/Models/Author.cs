using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Areas.Admin.Models
{
    
    public class Author
    {
        
        public int ID { get; set; }

        [DisplayName("نام ونام خانوادگی")]

        public string FullName { get; set; }
        [DisplayName("سن")]

        public string Age { get; set; }
        [DisplayName("تحصیلات")]

        public string Degree { get; set; }
        [DisplayName("آدرس")]

        public string Adreess { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
}
