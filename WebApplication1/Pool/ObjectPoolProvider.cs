using Microsoft.Extensions.ObjectPool;

namespace WebApplication1.Pool
{
    public class CustomObjectPoolProvider : ObjectPoolProvider
    {
        public override ObjectPool<T> Create<T>(IPooledObjectPolicy<T> policy)
        {
            throw new NotImplementedException();
        }
    }
}
