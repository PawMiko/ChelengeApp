namespace ChalangeApp.Tests
{
    public class EmployerTests
    {
        [Test]
        public void When_User_Collect_Plus_Or_Minus_Point_should_Be_Return_Correct_Statistic_Average_Result()
        {
            //arrange
            var user = new UserEmployee("pawel", "d23r", 32);
            
            user.AddPoint(12);
            user.AddPoint(1);
            user.RemovePoint(1);
            
            //act
             var Result = user.GetStat();

            //assert
            Assert.AreEqual(4, Result.Average);
            
        }


        [Test]
        public void When_User_Collect_Plus_Or_Minus_Point_should_Be_Return_Correct_Statistic_MIN_Result()
        {
            //arrange
            var user = new UserEmployee("pawel", "d23r", 32);
            user.AddPoint(10);
            user.AddPoint(1);
            user.RemovePoint(1);

            //act

            var Result = user.GetStat();

            //assert
            Assert.AreEqual(-1, Result.Min);

        }

        [Test]
        public void When_User_Collect_Plus_Or_Minus_Point_should_Be_Return_Correct_Statistic_MAX_Result()
        {
            //arrange
            var user = new UserEmployee("pawel", "d23r", 32);
            user.AddPoint(10);
            user.AddPoint(1);
            user.RemovePoint(1);

            //act

            var Result = user.GetStat();

            //assert
            Assert.AreEqual(10, Result.Max);

        }
    }
}