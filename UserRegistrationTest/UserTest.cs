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
    }
}