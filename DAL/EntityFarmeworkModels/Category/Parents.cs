using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.EntityFarmeworkModels.BaseModel;

namespace Domain.EntityFarmeworkModels
{
    public class Parents : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }


        public IList<Children> Children { get; set; }
    }
}

