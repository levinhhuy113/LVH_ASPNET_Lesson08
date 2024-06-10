using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LvhLesson08CF.Models
{
    public class LvhCategory
    {

        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        //thuộc tính quan hệ
        public virtual ICollection<LvhBook> LvhBooks { get; set; }

    }
}