using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.NewRelation
{
    public class RolePermission
    {
        public RolePermission() 
        {

        }

        [Key]
        public int RolePermissionId { get; set; }


        public int RoleId { get; set; }


        public int PermissionId { get; set; }




        #region Relations


        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }


        [ForeignKey("PermissionId")]
        public virtual Permission Permission { get; set; }

        #endregion


    }
}
