namespace ChalangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void When_User_Collect_Plus_OR_Minus_Point_should_Return_Correct_Result()
        {
            //arrange
            var user = new Employee("pawel", "d23r", 32);
            user.AddPoint(10);
            user.AddPoint(1);
            user.RemovePoint(1);

            //act

            var Result = user.Result;

            //assert
            Assert.AreEqual(10, Result);



            //  Assert.Pass();
        }


        [Test]
        public void When_User_Collect_Plus_OR_Minus_Point_should_Return_Correct_Result_1()
        {
            //arrange
            var user = new Employee("pawel", "d23r", 32);
            user.AddPoint(10);
            user.AddPoint(1);
            user.RemovePoint(1);

            //act

            var Result = user.ResultRemovePoint;

            //assert
            Assert.AreEqual(1, Result);



            //  Assert.Pass();
        }

    }
}