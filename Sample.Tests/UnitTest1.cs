using System;
using FluentAssertions;
using Xunit;

namespace Sample.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a = new Class1();
            a.SomeThing(1).Should().Be(1);
        }
    }
}
