using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructureAlgorithmProblems
{
    class BinarySearchString
    {
        public static void BinarySearchword(List<string> wordlist)
        {
            int mid, start = 0;
            int end = wordlist.Count-1;
            bool isFound=false;
            Console.WriteLine("Enter the word to be searched");
            string searchword=Console.ReadLine();
            while (start <= end)
            {
                mid=(start+end)/2;
                int result=searchword.CompareTo(wordlist[mid]);
                if (result == 0)
                {
                    isFound=true;
                    Console.WriteLine("word found in file");
                    break;
                }
                else if(result > 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end= mid - 1;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("word is not present in given file");
            }
        }
    }
}
