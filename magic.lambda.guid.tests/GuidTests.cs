/*
 * Magic, Copyright(c) Thomas Hansen 2019 - 2021, thomas@servergardens.com, all rights reserved.
 * See the enclosed LICENSE file for details.
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
