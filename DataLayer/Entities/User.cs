using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class User
    {
        public User()
        {
            
        }

          [Key] 
        public int UserId { get; set; } 

        public int ParentId { get; set; }




        [Display(Name = "نام کاربری")]
        [Required]
        public string UserName { get; set; }




        [Display(Name = "ایمیل")]
        [Required]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        public string Email { get; set; }




        [Display(Name = "نام و نام خانوادگی")]      
        public string FullName { get; set; }





        #region Relations

        [ForeignKey("ParentId")]
        public virtual Parent Parent { get; set; }


        #endregion
    }
}
