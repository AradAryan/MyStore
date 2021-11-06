using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.EntityFarmeworkModels.BaseModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.EntityFarmeworkModels
{
    public class Product : BaseEntity
    {
        [MaxLength(10)]
        public string Name { get; set; }

        public long Price { get; set; }

        [MaxLength(10)]
        public string CreationDate { get; set; }

        [MaxLength(10)]
        public string CreationTime { get; set; }

        public int ChildId { get; set; }

        public int ParentId { get; set; }


        [ForeignKey("ChildId")]
        public Child Children { get; set; }

        [ForeignKey("ParentId")]
        public Parent Parents { get; set; }
    }
}
