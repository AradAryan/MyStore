using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.EntityFarmeworkModels.BaseModel
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

    }
}
