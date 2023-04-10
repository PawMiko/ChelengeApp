

namespace ChalangeApp
{
    public abstract class  Person : System.Object
    {
      
        public Person(string name)
            :this(name,"no lastname",00,'u')
        {
            this.Name = name;   
        }
        public Person(string name,string lastName)
            :this(name,lastName,000,'g')
        {
            this.Name = name;
            this.Lastname = lastName;
        }
        public Person(string name, string lastName,int age)
            :this(name, lastName, age, 'h')
        {
            this.Name = name;
            this.Lastname = lastName;
            this.Age = age; 
        }
        public Person(string name, string lastName, int age,char sex)
        {
            this.Name = name;
            this.Lastname = lastName;
            this.Age = age; 
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Lastname { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set; }
    }
}
