using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamplexUnitDemo.Services;
using Xunit;

namespace SamplexUnitDemo.Tests
{
    public class RectangleServiceTest
    {
        [Fact]
        public void AreaTest()
        {
            //Arrange
            RectangleService rectangleService = new RectangleService();

            //Act
            var area = rectangleService.Area(2, 3.5);

            //Assert
            Assert.Equal(7.0, area);
        }

        [Fact]
        public void PerimeterTest()
        {
            //Arrange
            RectangleService rectangleService = new RectangleService();

            //Act
            var perimeter = rectangleService.Perimeter(2, 3.5);

            //Assert
            Assert.Equal(11, perimeter);
        }
    }

   
}
