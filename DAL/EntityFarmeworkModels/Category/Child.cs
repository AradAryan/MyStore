using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.EntityFarmeworkModels.BaseModel;

namespace Domain.EntityFarmeworkModels
{
    public class Child : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        public int ParentId { get; set; }


        [ForeignKey("ParentId")]
        public Parent Parents { get; set; }

        public Product Products { get; set; }
    }
}
