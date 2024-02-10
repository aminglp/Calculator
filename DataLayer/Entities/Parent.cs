using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Parent
    {
        public Parent()
        {
            
        }

        [Key]
        public int ParntId { get; set; }


        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Name { get; set; }

        #region Relations

        public virtual ICollection<User> Users { get; set; }

        #endregion

    }
}
