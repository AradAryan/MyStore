using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.EntityFarmeworkModels.BaseModel
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
