using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.NewRelation
{
    public class Role
    {
        public Role()
        {
                
        }

        [Key]
        public int RoleId { get; set; }

        public string Name { get; set; }



        #region Relations

        public virtual ICollection<RolePermission> RolePermission { get; set; }


        #endregion
    }
}
