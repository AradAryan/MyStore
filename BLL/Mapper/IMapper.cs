using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IMapper<TDestination> where TDestination : class, new()
    {
        TDestination Map(object source);
        IEnumerable<TDestination> MapList(IEnumerable<object> sources);
    }
}
