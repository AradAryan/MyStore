using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Mapper<TDestination> : IMapper<TDestination> where TDestination : class, new()
    {
        internal TDestination Map<TSource>(TSource source, TDestination destination) where TSource : class, new()
        {
            if (source != null && destination != null)
            {
                List<PropertyInfo> sourceProperties = source.GetType().GetProperties().ToList<PropertyInfo>();
                List<PropertyInfo> destinationProperties = destination.GetType().GetProperties().ToList<PropertyInfo>();

                foreach (PropertyInfo sourceProperty in sourceProperties)
                {
                    PropertyInfo destinationProperty = destinationProperties.Find(item => item.Name == sourceProperty.Name);//AddEdit

                    if (destinationProperty != null)
                    {
                        try
                        {
                            destinationProperty.SetValue(destination, sourceProperty.GetValue(source, null), null);//Set to DC
                        }
                        catch
                        {

                        }
                    }
                }
                return destination;

            }
            return null;
        }

        public TDestination Map(object source)
        {
            var destination = Activator.CreateInstance<TDestination>();
            Map(source, destination);

            return destination;
        }

        public IEnumerable<TDestination> MapList(IEnumerable<object> sources)
        {
            _ = (List<TDestination>)Activator.CreateInstance(typeof(List<TDestination>));

            foreach (var source in sources)
            {
                var destination = Map(source, new TDestination());
                yield return destination;
            }
        }

    }

}

