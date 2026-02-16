using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MainCode;

namespace testsForDevOps.Tests
{
    public class CaculateUnitTests
    {
        [Fact]
        public void Caculate_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 1;
            int b = 2;

            // Act
            int result = MainCode.Program.Calculate(a, b);

            // Assert
            Assert.Equal(3, result);
        }
    }


}
