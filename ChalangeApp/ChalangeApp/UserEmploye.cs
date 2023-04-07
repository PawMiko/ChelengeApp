
using System.Data;
using System.Drawing;

namespace ChalangeApp
{
    public class UserEmployee : Person
    {
        private List<float> Points = new List<float>();
        private List<float> PointsRemove = new List<float>();

        public UserEmployee()
           : this("no name","no surname",55)
        {   
        }

        public UserEmployee(string name)
            : base(name)
        { 
        }

        public UserEmployee(string name, string lastName, int age)
            :base(name,lastName,age) 
        { 
        }
        public UserEmployee(string name, string lastName, int age,char sex)
           : base(name,lastName,age,sex)
        {
        }




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
            switch(stat.Average)
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

            

        }


    
}