﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChalangeApp
{
    public class UserEployeeInFile : UserEmployeeBase
    {
        private const string fileName = "Points.txt";
        public override event PointAddedDelegate PointAdded;

        public UserEployeeInFile(string name, string lastname, int age)
            : base(name, lastname, age)
        {
        }


        public override void AddPoint(float xPoint)
        {
            if (xPoint >= 0 && xPoint <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(xPoint);
                }
                if (PointAdded != null)
                {
                    PointAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid point value");
            }

        }

        public override void AddPoint(string stringPoint)
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

        public override void AddPoint(ulong longPoint)
        {
            float floatPoint = (float)longPoint;
            AddPoint(floatPoint);
        }

        public override void AddPoint(char charLetterPoint)
        {

            switch (charLetterPoint)
            {
                case 'A':
                case 'a':
                    AddPoint(100);
                    break;
                case 'B':
                case 'b':
                    AddPoint(80);
                    break;
                case 'C':
                case 'c':
                    AddPoint(60);
                    break;
                case 'D':
                case 'd':
                    AddPoint(40);
                    break;
                case 'E':
                case 'e':
                    AddPoint(20);
                    break;
                default:
                    {
                        var stringResult = char.ToString(charLetterPoint);
                        AddPoint(stringResult);
                        break;
                    }
            }
        }

        public override void AddPoint(double doublePoint)
        {
            var floatPointTemp = Math.Round(doublePoint, 2);
            float floatPoint = (float)floatPointTemp;
            AddPoint(floatPoint);
        }

        public override Statistics GetStat()
        {
            var result = new Statistics();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        result.AddPoints(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return result;
        }

        public override void RemovePoint(float x)
        {
            throw new NotImplementedException();
        }
    }
}
