namespace UppercaseApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void UppercaseReturnUppercaseString()
        {

            string input = "hello world";
            string expected = "HELLO WORLD";

            string actual = StringUtility.ConvertToUpper(input);

            Assert.Equal(expected, actual);
        }
    }
}