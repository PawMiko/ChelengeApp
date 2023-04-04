namespace ChalangeApp.Tests
{
    public class EmployerTests
    {

        [Test]
        public void Check_And_Compare_Input_Data_Whit_The_Output_Result ()
        {
            //arrange
            var user = new UserEmployee("pawel", "d23r", 32);
            var user1 = new UserEmployee("pawel", "d23r", 32);
            var user2 = new UserEmployee("pawel", "d23r", 32);
            var user3 = new UserEmployee("asa", "sas", 44);
            user.AddPoint('a');
            user1.AddPoint(88);
            user2.AddPoint(93);
            user3.AddPoint('B');

            //act
            var Result  = user.GetStat();
            var Result1 = user1.GetStat();
            var Result2 = user2.GetStat();
            var Result3 = user3.GetStat();
            //assert
            Assert.AreEqual(100,Result.Max);
            Assert.AreEqual(88,Result1.Max);
            Assert.AreEqual('A', Result2.AverageLetter);
            Assert.AreEqual('A', Result3.AverageLetter);
        }
       

       
    }
}