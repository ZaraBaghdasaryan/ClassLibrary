using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestProject
{
    public class TranslationProgramUnitTests
    {
        [Fact]
        public void CanCreateDictionaryInstance()
        {
            //Arrange
            var dictionary = new Dictionary<char, string>();
            //Act
            // Act section is empty because no member needs to be used to check that the instance can be created.

            //Assert
            Assert.IsNotNull(dictionary);

        }
        [Fact]
        public void CanReturnTranslatedValue()
        {
            //Arrange
            var program = new TranslationProgram();
             var result = program.Translate("");

            //Act


            //Assert
            Assert.IsNotNull(result);
        }


    }
}

/*
 * 1. Arrange - declare the variables and the objects you are going to test.
 * 2. Act - invoke methods on the objects to perform an action, such as, computing a value.
 * 3. Assert - assert something about the actual result you gained in the Act section.
 */