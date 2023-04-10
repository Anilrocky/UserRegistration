using UserRegistration;

namespace UserRegistrationTest
{
    public class Tests
    {
        User user = new User();
        [Test]
        public void EnteredFirstName_WhenAnalyze_ShouldReturn_Valid()
        {
            string firstName = "Anil";
            string result = user.ValidateName(firstName);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void EnteredLastName_WhenAnalyze_ShouldReturn_Valid()
        {
            string lastName = "Kumar";
            string result = user.ValidateName(lastName);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void EnteredEMail_WhenAnalyze_ShouldReturn_Valid()
        {
            string eMail = "anil.ac@techies.co.in";
            string result = user.ValidateEmail(eMail);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void EnteredMobileNumber_WhenAnalyze_ShouldReturn_Valid()
        {
            string number = "91 6789054321";
            string result = user.ValidateMobileNumber(number);
            Assert.AreEqual(result, "Valid");
        }
        [Test]
        public void EnteredPassword_WhenAnalyze_ShouldReturn_Valid()
        {
            string passwd = "Asdkf@1234";
            string result = user.ValidatePassword(passwd);
            Assert.AreEqual(result, "Valid");
        }
    }
}