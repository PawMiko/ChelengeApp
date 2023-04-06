
using System.Data;
using System.Drawing;

namespace ChalangeApp
{
    public class UserEmployee
    {
       // private const char sex = 'M';

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
                var resultAddPoint = this.Points.Sum();
                return resultAddPoint;

            }
        }

        public float ResultMinusPoint //propercja  zwracające sume punktów ujemnych na liscie POINT // nauka"
        {
            get
            {
                float resultAddMinusPoint = 0;
                for (int i = 0; i < this.Points.Count; i++)
                {
                    if (this.Points[i] < 0)
                        resultAddMinusPoint += this.Points[i];
                }
                return resultAddMinusPoint;

            }
        }

        public float ResultRemovePoint//propercja zwracająca sumę punktów "ujemnych"
        {
            get
            {
                return this.PointsRemove.Sum();
            }
        }

        public void AddPoint(float xPoint)//metoda ktora dodaje punkty z wykorzystaniem listy
        {
            if (xPoint >= 0 && xPoint <= 100)
            {
                this.Points.Add(xPoint);
            }
            else
            {
                throw new Exception("Invalid point value");
               
            }
        }
        public void AddPoint(ulong longPoint)//metoda konwerująca ulong na float w ramach walidacji
        {
            float floatPoint = (float)longPoint;
            AddPoint(floatPoint);
        }

        public void AddPoint(double doublePoint)//metoda konwerująca double na float w ramach walidacji
        {
            var floatPointTemp = Math.Round(doublePoint, 2);
            float floatPoint = (float)floatPointTemp;
            AddPoint(floatPoint);
        }

        public void AddPoint(char charLetterPoint)//metoda konwerująca char na string w ramach walidacji + case
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

        public void AddPoint(string stringPoint)//metoda konwerująca string na float w ramach walidacji
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

        public void RemovePoint(float minus) //metoda ktora konweruje liczby dodatnie na ujemne i dodaje ujemne  punkty z wykorzystaniem listy
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

        public Statistics GetStat() //metoda modelu danych
        {
            var stat = new Statistics();

            stat.max = float.MinValue;
            stat.min = float.MaxValue;
            stat.average = 0;

            foreach (var point in Points)
            {
                stat.max = Math.Max(stat.max, point);
                stat.min = Math.Min(stat.min, point);
                stat.average += point;
            }
            stat.average /= this.Points.Count;
            switch(stat.average)
            {
                case var average when average >= 80:
                    stat.averageLetter = 'A';
                    break;
                case var average when average >= 60:
                    stat.averageLetter = 'B';
                    break;
                case var average when average >= 40:
                    stat.averageLetter = 'C';
                    break;
                case var average when average >= 20:
                    stat.averageLetter = 'D';
                    break;
                default:
                    stat.averageLetter = 'E';
                    break;
            }

          return stat;
        }

            

        }


    
}