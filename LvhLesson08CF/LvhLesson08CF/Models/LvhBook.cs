using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LvhLesson08CF.Models
{
    /// <summary>
    /// Tạo ra cấu trúc bảng Book
    /// </summary>
    public class LvhBook
    {
        [Key]
        public int LvhBookID { get; set; }
        public string LvhTitle { get; set; }
        public string LvhAuthor { get; set; }
        public int LvhYear { get; set; }
        public string LvhPublisher { get; set; }
        public string LvhPicture { get; set; }
        public int LvhCategoryId { get; set; }
        //Thuộc tính quan hệ
        public virtual LvhCategory LvhCategory { get; set; }



    }
}