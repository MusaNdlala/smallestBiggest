using System;

namespace smallestBiggest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]; 

            int iterator = 0;
            while (iterator < arr.Length)
            {
                Console.WriteLine("Please enter number {0} of 10",iterator);
                arr[iterator] = Convert.ToInt32(Console.ReadLine());
                iterator++;
            }

            int[] ans = smallestOrBigest(arr);
            Console.WriteLine("smallest number {0}",ans[1]);
            Console.WriteLine("biggest number {0}", ans[0]);
            Console.ReadLine();
        }
        static int[] smallestOrBigest(int[] rr)
        {
            int []ans = new int[2];
            int smal = rr[0];
            int bigs = rr[0];
            
            //Console.WriteLine(rr.Length);
            
            for (int i = 0; i < rr.Length; i++)
            {               
                if (bigs  < rr[i] ){//check if the number in array is 
                    //bigger than bigs
                    bigs = rr[i];//we asign the bigs to the number in array
                }
                if (smal  > rr[i] ){//check if the number in array is 
                    //smaller than smal
                    smal = rr[i];//we asign the smal to the number in array
                }                 
            }
            ans[1] = smal;
            ans[0] = bigs;
            return (ans);
        }
    }
}
