/*
 * Magic Cloud, copyright Aista, Ltd. See the attached LICENSE file for details.
 */

using System;
using System.Linq;
using Xunit;

namespace magic.lambda.guid.tests
{
    public class GuidTests
    {
        [Fact]
        public void Create()
        {
            var lambda = Common.Evaluate(@"guid.new");
            Assert.Equal(typeof(Guid), lambda.Children.First().Value.GetType());
        }
    }
}
