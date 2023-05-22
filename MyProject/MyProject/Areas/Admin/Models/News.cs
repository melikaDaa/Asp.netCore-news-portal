using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Areas.Admin.Models
{
    public class News

    {
        [Key]
        public int Id { get; set; }
        [DisplayName("تیتر خبر")]

        public string NewsName { get; set; }
        [DisplayName("متن خبر")]

        public string NewsDesc { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public int? CategoryIDCategory { get; set; }
        public int? AuthorID { get; set; }


        public virtual Category Category { get; set; }

        public virtual Author Author { get; set; }
    }
}
