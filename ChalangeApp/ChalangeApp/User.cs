

namespace ChalangeApp
{
   public class Employee
    {

        private List<int> point = new List<int>();

        public Employee(string name, string lastname, int age)
        {

            this.Name = name;
            this.Lastname = lastname;
            this.age = age;

        }

        public string Name {  get;  private set; }
        public string Lastname { get; private set; }
        public int age { get; private set; }
       
        public int Result
        {
            get
            {
                return this.point.Sum();
            }
        }

        public void ADDPOINT(int x)
        {
            this.point.Add(x);

        }
      


    }
}
