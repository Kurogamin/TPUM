using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Data
{
    public class SampleTest
    {
        [Fact]
        public void ExampleTest()
        {
            int firstNummber = 727;
            int secondNumber = firstNummber + 1;

            Assert.True(firstNummber < secondNumber);
        }
    }
}
