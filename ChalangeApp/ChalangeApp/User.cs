
namespace ChalangeApp
{
    public class Employee
    {

        private List<int> point = new List<int>();
        private List<int> point_remove = new List<int>();


        public Employee(string name, string lastname, int age)
        {

            this.Name = name;
            this.Lastname = lastname;
            this.age = age;

        }

        public string Name { get; private set; }
        public string Lastname { get; private set; }
        public int age { get; private set; }

        public int Result
        {
            get
            {

                var result_add_Point2 = this.point.Sum()-this.point_remove.Sum();
                return result_add_Point2;

            }
        }
        public int Result_Remove_POINT
        {
            get
            {
                return this.point_remove.Sum();
            }
        }

        public void ADDPOINT(int x)
        {
            this.point.Add(x);
            //this.point.Add(-1);

        }
        public void REMOVEPOINT(int x) 
        {
            this.point_remove.Add(x);
            //this.point.Add(x);

        }



    }
}