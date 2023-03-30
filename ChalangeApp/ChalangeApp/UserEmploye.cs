
namespace ChalangeApp
{
    public class UserEmployee
    {

        private List<float> Points = new List<float>();
        private List<float> PointsRemove = new List<float>();


        public UserEmployee(string name)
        {

            this.LoginName = name;
          
        }

        public UserEmployee(string name, string lastName, int age)
        {

            this.LoginName = name;
            this.Lastname = lastName;
            this.age = age;

        }

        
        public string LoginName { get; private set; }
        public string Lastname { get; private set; }
        public int age { get; private set; }

        public float Result //propercja  zwracające sume punktów zdobytych jak i "ujemnych"
        {
            get
            {
                var resultAddPoint2 = this.Points.Sum();
                return resultAddPoint2;

            }
        }
        public float ResultRemovePoint//propercja zwracająca sumę punktów "ujemnych"
        {
            get
            {
                return this.PointsRemove.Sum();
            }
        }

        public void AddPoint(float x)
        {
            this.Points.Add(x);
            //metoda ktora dodaje punkty z wykorzystaniem listy

        }
        public void RemovePoint(float x) 
        {
            if(x>0)
            {
                x = x * (-1);
                this.PointsRemove.Add(x);
            }
            this.Points.Add(x);
            //metoda ktora dodaje "ujemne"  punkty z wykorzystaniem listy
            

        }
        public Statistics GetStat () //metoda modelu danych
        {
            var stat = new Statistics();

            stat.Max = float.MinValue;
            stat.Min = float.MaxValue;
            stat.Average = 0;

            foreach (var point in Points)
            {
                stat.Max = Math.Max(stat.Max, point);
                stat.Min = Math.Min(stat.Min, point);
                stat.Average += point;
            }
            stat.Average /= this.Points.Count;

            return stat;     
        }



    }
}