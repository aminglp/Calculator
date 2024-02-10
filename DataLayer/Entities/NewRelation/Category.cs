using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities.NewRelation
{
    public class Category
    {
        public Category()
        {
                
        }

        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }


        #region Relations
         [ForeignKey("ParentId")]
        public ICollection<Category> Categories { get; set; }


        #endregion




    }
}
