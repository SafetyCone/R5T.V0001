using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace R5T.V0001
{
    [TestClass]
    public class IEnumerableTests
    {
        [TestMethod]
        public void DefaultIsNullForIEnumerable()
        {
            // Uses string as generic type parameter, but could be any type.
            IEnumerable<string> expectedValue = null;

            IEnumerable<string> actualValue = default;

            Instances.Assertion.AreEqual(expectedValue, actualValue);
        }
    }
}
