using Xunit;
using Xunit.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace Calculations.Test
{
    public class TestCollectionOrderer : ITestCollectionOrderer
    {
        public IEnumerable<ITestCollection> OrderTestCollections(
            IEnumerable<ITestCollection> testCollections)
        {
            return testCollections.OrderBy(x => x.DisplayName);
        }
    }
}