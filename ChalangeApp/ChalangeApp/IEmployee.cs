﻿
namespace ChalangeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Lastname { get; }
        int Age { get; } 

        Statistics GetStat();
        void AddPoint(string x);
        void AddPoint(ulong x);
        void AddPoint(char x);
        void AddPoint(double x);
        void AddPoint(float x);
        void RemovePoint(float x);

    }
}
