

namespace ChalangeApp
{
    public abstract class UserEmployeeBase : IEmployee
    {
        public UserEmployeeBase(string name, string lastname,int age)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Lastname { get; private set; }
        public int Age {get; private set; }

        // zaimplementowanie  metody  wirtualnej gdzie może byc nadpisywana lub uzupełniana  w klasie UserEmployeeInMemory
        //public virtual void SayHello()
        //{
        //    Console.WriteLine($"jestem{ Name}{ Lastname}");
        //}

        public abstract void AddPoint(float x);
        public abstract void AddPoint(string x);
        public abstract void AddPoint(ulong x);
        public abstract void AddPoint(char x);
        public abstract void AddPoint(double x);

        public abstract Statistics GetStat();
        
        public abstract void RemovePoint(float x);
    }
}
