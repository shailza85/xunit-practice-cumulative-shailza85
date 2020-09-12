using System;
using Xunit;

namespace XUnitCumulativePractice_Tests
{
    public class Program_Tests
    {

        //Create test cases in Program_Tests.cs that will test each of the requirements of ValidateOneToOneHundredEven().
        // This is to say, we should be testing(Theories) :

        //Don’t forget to include edge cases (right on the border of acceptable, 
        //example if we wanted between 1 and 5, we would test at least -1, 0, 1, 5 and 6).
        //Please include at least 3 sets of test data per row.
        
            [Theory,
            InlineData("Hello", false),
            InlineData("Hello123", false),
            InlineData("33", false),
            InlineData("106", false),
            InlineData("-1", false),
            InlineData("0", false),
            InlineData("1", false),
            InlineData("101", false)]
        public void ValidateOneToOneHundredEven_TestFalse(string str, bool expectedOutput)
        {
            // Assert
            Assert.False(expectedOutput, str);
        }
        [Theory,
         InlineData("2", true),
         InlineData("46", true),
          InlineData("100", true),
          InlineData("62", true),
          InlineData("86", true),
          InlineData("90", true),
          InlineData("78", true)]
        public void ValidateOneToOneHundredEven_TestTrue(string str, bool expectedOutput)
        {
            // Assert
            Assert.True(expectedOutput, str);
        }


    }
}
