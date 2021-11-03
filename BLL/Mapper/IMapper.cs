using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IMapper
    {
        TDestination Map<TDestination>(object source) where TDestination : class, new();
        IEnumerable<TDestination> MapList<TDestination>(IEnumerable<object> sources) where TDestination : class, new();
    }
}
