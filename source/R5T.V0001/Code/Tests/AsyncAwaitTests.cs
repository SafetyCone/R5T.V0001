using System;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.V0001.Library;


namespace R5T.V0001
{
    [TestClass]
    public class AsyncAwaitTests
    {
        [TestMethod]
        public async Task AwaitingNullConditionalOperatorThrows()
        {
            ObjectWithAsyncMethod objectWithAsyncMethod = null;

            await Instances.Assertion.ThrowsExceptionAsync(() =>
                objectWithAsyncMethod?.AsyncMethod());
        }
    }
}
