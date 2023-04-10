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
    }
}