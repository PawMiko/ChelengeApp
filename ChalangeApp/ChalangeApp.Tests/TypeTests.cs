

namespace ChalangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST_REFERENCE()
        {
            //arrange
            var User1 = GetEployee("Adam");
            var User2 = GetEployee("Adam");

            //act
            //string jest immutable
            //assert
            Assert.AreNotEqual(User1, User2);

            //  Assert.Pass();
        }
        private UserEmployee GetEployee(string name)
        {
            return new UserEmployee(name);
        }

        [Test]
        public void TEST_VALUABLE()
        {
            //arrange
            int User1 =1;
            int User2 =2;
            float User3 = 0.34F;
            float User4 = 0.34F;
            double User5 = 0.78738d;
            double User6 = 0.093129d;

            //act

            //assert
            Assert.AreNotEqual(User1, User2);
            Assert.AreEqual(User3, User4);
            Assert.AreNotEqual(User5, User6);

            //  Assert.Pass();
        }
       

    }
}
