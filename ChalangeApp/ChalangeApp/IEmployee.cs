
namespace ChalangeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Lastname { get; }

        Statistics GetStat();
        void AddPoint(string x);
        void AddPoint(ulong x);
        void AddPoint(char x);
        void AddPoint(double x);
        void RemovePoint(float x);

    }
}
