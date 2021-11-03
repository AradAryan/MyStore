using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Domain.EntityFarmeworkModels.BaseModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.EntityFarmeworkModels
{
    public class Products : BaseEntity
    {
        [MaxLength(10)]
        public string Name { get; set; }
        public long Price { get; set; }
    }
}
