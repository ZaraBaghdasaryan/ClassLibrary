using ClassLibrary.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class AbstractFactoryTests
    {
        [Fact]
        public void CanGetFactory()
        {
            var factory = new Factory(); 

            var result = factory.GetFactory("Morse");

            Assert.NotNull(result);
        }

         [Fact] 
        public void CanCreateDictionary()
        {
            //Arrange
            var factory = new Factory(); 

            var dict = factory.GetFactory("Morse");

            //Act
            var result = dict.CreateDictionary();

            //Assert
            Assert.NotNull(result);

        }

    }
}
