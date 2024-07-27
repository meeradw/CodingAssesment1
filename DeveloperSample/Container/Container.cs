

namespace DeveloperSample.Container
{
    public class Container
    {
        private Dictionary<Type, Type> t   = new Dictionary<Type, Type>();
        public void Bind(Type interfaceType, Type implementationType)
        {
            t[interfaceType] = implementationType;
        }
        public T Get<T>() 
        {
            if (t[typeof(T)]!=null)
            {
                return (T)Activator.CreateInstance(t[typeof(T)]);
            }
            else
                throw new NotImplementedException();
        }
    }
   
}
