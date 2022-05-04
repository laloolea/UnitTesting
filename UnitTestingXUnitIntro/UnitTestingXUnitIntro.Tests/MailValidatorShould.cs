using Xunit;
namespace UnitTestingXUnitIntro.Tests
{
    public class MailValidatorShould
    {

        [Fact]
        public void ValidateValidEmail()
        {
            //Arrange
            string email = "eduardo@atos.com";
            var mailValidator = new MailValidator();
            //Act
            bool isValid = mailValidator.IsValidEmail(email);
            //Asserts
            Assert.True(isValid);
        }
        //This was represents the two test up
        [Theory]
        [InlineData("invalid@invalid.invalid", false)]
        [InlineData("thecodercave@gmail.com", true)]
        public void ValidateEmail(string emailAddress, bool expected)
        {
            //Arrange
            var mailValidator = new MailValidator();

            //Act
            bool isValid = mailValidator.IsValidEmail(emailAddress);

            //Asserts
            Assert.Equal(expected, isValid);
        }


        [Theory]
        [InlineData("spam@gmail.com", "INBOX")]
        [InlineData("spam@spam.com", "SPAM")]
        public void IdentifySpam(string emailAddress, string expected)
        {
            //Arrange
            var mailValidator = new MailValidator();

            //Act
            string result = mailValidator.IsSpam(emailAddress);

            //Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void RaiseErrorWhenEmailIsEmpty()
        {
            //Arrange
            var mailValidator = new MailValidator();
            //Act
            //In this case is empty everything in the next line

            //Assert
            //verify that this exception is throwed with the code inside 
            Assert.Throws<EmailNotProvidedException>(() => mailValidator.IsValidEmail(null));
        }
    }
}
