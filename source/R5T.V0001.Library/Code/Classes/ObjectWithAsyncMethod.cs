using System;
using System.Threading.Tasks;


namespace R5T.V0001.Library
{
    public class ObjectWithAsyncMethod
    {
#pragma warning disable CA1822 // Mark members as static
        public Task AsyncMethod()
#pragma warning restore CA1822 // Mark members as static
        {
            return Task.CompletedTask;
        }
    }
}
