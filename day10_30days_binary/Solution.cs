using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given a base 10- integer, n , 
//    convert it to binary(base 2).
//Then find and print the base-10 integer 
//    denoting the maximum number of consecutive 1's in n's binary representation.

    //n is positive

namespace day10_30days_binary
{
    class Solution
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            string binNumber = ConvertToBinary(num);
            Console.WriteLine("" + num + " in binary is: " + binNumber);
            int result = CountConsectutiveOnes(binNumber);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        

        static string ConvertToBinary(int num)
        {

            int toBase = 2;
            string binary = Convert.ToString(num ,toBase);
            //binary = binary.PadLeft(8, '0');
            return binary;

            //Console.WriteLine(binary);

        }

        static int CountConsectutiveOnes(string binaryNum)
        {
            int currMax = 0;
            int countOne = 0;
            //convert string to cahr array
            char[] binNum = binaryNum.ToCharArray();
            char prev = '1';

            for (int i = 0; i < binNum.Length; i++)
            {
                //if it's one then
                if(binNum[i] == '1')
                {
                    //check if previous num was one
                    if(prev == '1')
                    {
                        //add one to count
                        countOne++;
                        //if count is greater than current maximum of 1's, replace it
                        if(countOne > currMax)
                        {
                            currMax = countOne;
                        }
                        
                    }
                    else if(prev == '0')
                    {
                        //reset countOnes
                        countOne = 1;

                    }
                    //set previous to one
                    prev = '1';   
                }

                //if it's zero just set prev to zero
                else if(binNum[i] == '0')
                {
                    //reset our one counter to zero
                    countOne = 0;
                    prev = '0';
                    
                }
                else
                {
                    Console.WriteLine("This is not a valid number");
                }


            }


            return currMax;
        }
    }
}
