using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class StringtoDoubleArray
    {
        public  double[,] ToDoubleBidimensionalArray(string input)
        {
            var doubleRows = input.Split(';');
            int doubleColumns = input.Split(';')[0].Split(',').Count();

            for (int i = 0; i<doubleRows.Count(); i++)
            {
                doubleRows[i] = doubleRows[i].Replace('{',' ');
                doubleRows[i] = doubleRows[i].Replace('}', ' ');
            }

            var result = new double[doubleRows.Count(), doubleColumns];

            for (int i = 0; i < doubleRows.Count(); i++)
            {
                var temp = doubleRows[i].Split(',').ToArray();
                for (int j = 0; j < doubleColumns; j++)
                {
                    result[i, j] = double.Parse(temp[j]);
                }
            }

            return result;
        }
        
        //Usage 4 NOOBS
        //string parse = "{ 7, 2, 8, 4}; { 2, 3, 5, 6}; {1, 5, 7, 10}; { 4, 7, 10, -13}";
        //parse.ToDoubleBidimensionalArray(); //devuelve un double[,]
    }
}
