using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LutetiumProblemSolving
{
    class ProblemSolvingClass
    {



        public string ReverseString(string strToReverse)
        {
            string reversedStr = "";

            //int i = strToReverse.Length - 1;
            //while(i >= 0)
            //{
            //    reversedStr += strToReverse[i];
            //    i++;
            //}
            for (int j = strToReverse.Length - 1; j >= 0; j--)
            {
                reversedStr += strToReverse[j];
            }

            return reversedStr;
        }
        public bool Palindrome(string strToCheck)
        {
            string reversedStr = ReverseString(strToCheck);
            if (strToCheck == reversedStr)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //"aaabbcccc"
        //"3a2b4c"
        public void CompressStr(string strToCompress)
        {
            string compressedStr = "";
            int counter = 1;
            for(int i = 0; i < strToCompress.Length; i++)
            {
                if(i == strToCompress.Length - 1)
                {
                    compressedStr += counter + strToCompress[i].ToString();
                }
                else if(strToCompress[i] != strToCompress[i + 1])
                {
                    compressedStr += counter + strToCompress[i].ToString();
                    counter = 1;
                }
                else
                {
                    counter++;
                }
            }

            Console.WriteLine(compressedStr);
            Console.ReadLine();
        }
    }
}
