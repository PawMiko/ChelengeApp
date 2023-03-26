namespace ChalangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void When_User_Collect_Plus_OR_Minus_Point_should_Return_Correct_Result()
        {
            //arrange
            var user = new Employee("pawel", "d23r", 32);
            user.ADDPOINT(10);
            user.ADDPOINT(1);
            user.REMOVEPOINT(1);

            //act

            var result = user.Result;

            //assert
            Assert.AreEqual(10, result);



            //  Assert.Pass();
        }


        [Test]
        public void When_User_Collect_Plus_OR_Minus_Point_should_Return_Correct_Result_1()
        {
            //arrange
            var user = new Employee("pawel", "d23r", 32);
            user.ADDPOINT(10);
            user.ADDPOINT(1);
            user.REMOVEPOINT(1);

            //act

            var result = user.Result_Remove_POINT;

            //assert
            Assert.AreEqual(1, result);



            //  Assert.Pass();
        }

    }
}