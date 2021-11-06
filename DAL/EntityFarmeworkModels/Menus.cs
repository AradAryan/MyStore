using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.EntityFarmeworkModels.BaseModel;

namespace Domain.EntityFarmeworkModels
{
    public class Menus : BaseEntity
    {
        [MaxLength(100)]
        public string Link { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }
    }
}
