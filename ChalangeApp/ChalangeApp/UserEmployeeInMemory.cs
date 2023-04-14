

namespace ChalangeApp
{
    public class UserEmployeeInMemory : UserEmployeeBase 
    {

        
       
        List<float> Points = new List<float>();
        List<float>PointsRemove = new List<float>();

        public override event PointAddedDelegate PointAdded;

        public UserEmployeeInMemory(string name, string lastname, int age) :
            base(name, lastname, age)
        {
        }
        
       

        // wywołanie i dopisanielub nadpisanie metody wirualnej zaimplementowanej w  klasie bazowej UserEmployeeBase
        //public override void SayHello()
        //{
        //    Console.WriteLine("jakże");
        //    base.SayHello();
        //}

        public override void AddPoint(float xPoint)
        {
            if (xPoint >= 0 && xPoint <= 100)
            {
                this.Points.Add(xPoint);
                if(PointAdded!=null)
                {
                    PointAdded(this, new EventArgs());

                }
               
            }
            else
            {
                throw new Exception("Invalid point value");

            }
        }

        public override void AddPoint(string stringPoint)
        {
            if (float.TryParse(stringPoint, out float floatResult))
            {
                this.AddPoint(floatResult);
            }
            else
            {
                throw new Exception("string is not float or wrong letter");
            }
        }

        public override void AddPoint(ulong longPoint)
        {
            float floatPoint = (float)longPoint;
            AddPoint(floatPoint);
        }

        public override void AddPoint(char charLetterPoint)
        {
            switch (charLetterPoint)
            {
                case 'A':
                case 'a':
                    this.Points.Add(100);
                    
                    break;
                case 'B':
                case 'b':
                    this.Points.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.Points.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.Points.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.Points.Add(20);
                    break;
                default:
                    {
                        var stringResult = char.ToString(charLetterPoint);
                        AddPoint(stringResult);
                        break;
                    }

            }
        }

        public override void AddPoint(double doublePoint)
        {
            var floatPointTemp = Math.Round(doublePoint, 2);
            float floatPoint = (float)floatPointTemp;
            AddPoint(floatPoint);
        }

        public override Statistics GetStat()
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
            switch (stat.Average)
            {
                case var average when average >= 80:
                    stat.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    stat.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    stat.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    stat.AverageLetter = 'D';
                    break;
                default:
                    stat.AverageLetter = 'E';
                    break;
            }
            return stat;
        }

        public override void RemovePoint(float minus)
        {

            if (minus > 0 && minus <= 100)
            {
                minus = minus * (-1);
                this.PointsRemove.Add(minus);
            }
            else
            {
                this.PointsRemove.Add(minus);
            }
            this.Points.Add(minus);
        }
    }
}
