

namespace DeveloperSample.Container
{
    public class Container
    {
        private Dictionary<Type, Type> ct   = new Dictionary<Type, Type>();
        public void Bind(Type interfaceType, Type implementationType)
        {
            ct[interfaceType] = implementationType;
        }
        public T Get<T>() 
        {
            if (ct[typeof(T)]!=null)
            {
                return (T)Activator.CreateInstance(ct[typeof(T)]);
            }
            else
                throw new NotImplementedException();
        }
    }
   
}
