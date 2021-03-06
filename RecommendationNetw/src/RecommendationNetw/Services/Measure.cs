﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecommendationNetw.Services
{
    public class PearsonMeasure : ISimilarityMeasure
    {
        public double SimilarityLimit { get; }

        public PearsonMeasure(double similarityLimit = 0.5)
        {
            SimilarityLimit = similarityLimit;
        }

        public double Calculate(IDictionary<string, int> sourceDict, IDictionary<string, int> otherDict)
        {
            var sourceList = new List<int>();
            var otherList = new List<int>();
            
            foreach (var item in sourceDict)
            {
                if (otherDict.ContainsKey(item.Key))
                {
                    sourceList.Add(item.Value);
                    otherList.Add(otherDict[item.Key]);
                }
            }

            if (sourceList.Distinct().Count() == 1 || otherList.Distinct().Count() == 1)
                return GetTanimotoCoef(sourceList, otherList);

            return GetPearsonCoef(sourceList, otherList);
        }

        private double GetPearsonCoef(IList<int> x, IList<int> y)
        {
            double _x = x.Average();
            double _y = y.Average();
            double count = x.Count();

            double xy = 0;

            for (int i = 0; i < count; i++)
            {
                xy += (x[i] - _x) * (y[i] - _y);
            }

            var disp1 = Dispercy(x, _x);
            var disp2 = Dispercy(y, _y);

            var result = (xy) / (count * Math.Sqrt(disp1) * Math.Sqrt(disp2));

            return Math.Round(result, 4);
        }
        private double GetTanimotoCoef(IList<int> x, IList<int> y)
        {
            int a = x.Count();
            int b = y.Count();
            int c = 0;
            for (int i = 0; i < a; i++)
            {
                if (TanimotoCompare(x[i],y[i]))
                    c++;
            }
            return (double)c / (a + b - c);
        }
        private double Dispercy(IList<int> list, double normalize)
        {
            double result = 0;
            foreach (var num in list)
            {
                result += Math.Pow(num, 2);
            }
            return (result / list.Count()) - Math.Pow(normalize, 2);
        }
        private bool TanimotoCompare(double a, double b)
        {
            if (a >= (b - 2) && a <= (b + 2))
                return true;
            return false;
        }
    }    
}
