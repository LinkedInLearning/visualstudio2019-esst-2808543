using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotNameGenerator
{

    public class NameGenerator
    {
   
        private List<string> _primeNames;

        private List<string> _tagNames;
        private string[] _initials = new string[] { "A.", "B.", "C." };

        private Random _ran = new Random();

        public NameGenerator()
        {
            _tagNames = System.IO.File.ReadAllLines("RobotTagNames.txt").ToList<string>();
            _primeNames = System.IO.File.ReadAllLines("RobotPrimeNames.txt").ToList<string>();
           
        }

        public string GetRobotName()
        {
            var randomPrimeIndex = _ran.Next(1, _primeNames.Count);
            var randomTagIndex = _ran.Next(0, _tagNames.Count);
            return _primeNames[randomPrimeIndex] + " " + _tagNames[randomTagIndex];
        }
        public List<string> GetRobotNames(int maxCount)
        {

            var temp = new List<string>();
            //int currentMaxCount = (Math.Min (_primeNames.Count * _tagNames.Count) > maxCount ? maxCount :
            //                                                                (_primeNames.Count * _tagNames.Count);

            int currentMaxCount = (Math.Min(Math.Min(_primeNames.Count, maxCount), _tagNames.Count));
            var q1 = from name in _primeNames
                     orderby _ran.NextDouble()
                     select name;
            var q2 = from name in _tagNames
                     orderby _ran.NextDouble()
                     select name;
            var primeNameList = q1.ToList();
            var tagNameList = q2.ToList();
            for (int i = 0; i < currentMaxCount; i++)
            {
                temp.Add(primeNameList.ElementAt(i) + " " + tagNameList.ElementAt(i));
            }

            return temp;
        }

        

        
    }
}
