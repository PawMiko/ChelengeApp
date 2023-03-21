

namespace ChalangeApp
{

  class FIRST_NUMBER
    {
        string stringer;
        public  string result;
        int VALUE;
        int temp=0 ;
        int remaider;
        int incTemp = 0;
        List<string> FIRS = new List<string>();
        private int liczba=0;
      public  FIRST_NUMBER()
        {
            Console.WriteLine("podaj liczbe ");
           
        }
        public void PRIME_CALKULATION_NUMBER(int X)
        {
             this.VALUE = X;
            this.temp = this.VALUE;
            
            for(this.VALUE=X;this.VALUE>=1;this.VALUE--)
            {
                for (this.temp = this.VALUE; this.temp >= 1; this.temp--)
                {
                    this.remaider = this.VALUE % this.temp;
                    if (this.remaider == 0)
                        this.incTemp++;
                    if (this.incTemp == 2 && this.temp == 1)
                    {
                        this.stringer = VALUE.ToString();
                        FIRS.Add(this.stringer +", " );
                    }
                    
                }
              this.incTemp = 0;
            }
             Console.WriteLine("liczby pierwsze to");
            this.result = string.Join("", FIRS);
           
        }

    }

}
