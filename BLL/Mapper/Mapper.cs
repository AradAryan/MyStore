using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Mapper : IMapper
    {
        internal TDestination Map<TSource, TDestination>(TSource source, TDestination destination) where TSource : class, new() where TDestination : class, new()
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

        public TDestination Map<TDestination>(object source) where TDestination : class, new()
        {
            var destination = Activator.CreateInstance<TDestination>();
            Map(source, destination);

            return destination;
        }

        public IEnumerable<TDestination> MapList<TDestination>(IEnumerable<object> sources) where TDestination : class, new()
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

