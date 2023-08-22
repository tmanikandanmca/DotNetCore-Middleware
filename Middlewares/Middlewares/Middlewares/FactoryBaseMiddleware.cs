namespace Middlewares.Middlewares
{
    public class FactoryBaseMiddleware : IMiddlewareFactory
    {
        public IMiddleware? Create(Type middlewareType)
        {
            throw new NotImplementedException();
        }

        public void Release(IMiddleware middleware)
        {
            throw new NotImplementedException();
        }
    }
}
