
namespace ChalangeApp
{
    public class Employee
    {

        private List<int> Point = new List<int>();
        private List<int> PointRemove = new List<int>();


        public Employee(string name, string lastName, int age)
        {

            this.Name = name;
            this.Lastname = lastName;
            this.age = age;

        }

        public string Name { get; private set; }
        public string Lastname { get; private set; }
        public int age { get; private set; }

        public int Result
        {
            get
            {

                var resultAddPoint2 = this.Point.Sum()-this.PointRemove.Sum();
                return resultAddPoint2;

            }
        }
        public int ResultRemovePoint
        {
            get
            {
                return this.PointRemove.Sum();
            }
        }

        public void AddPoint(int x)
        {
            this.Point.Add(x);
            //this.point.Add(-1);

        }
        public void RemovePoint(int x) 
        {
            this.PointRemove.Add(x);
            //this.point.Add(x);

        }



    }
}