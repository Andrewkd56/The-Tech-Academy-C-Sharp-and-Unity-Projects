using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integerserror
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 22, 85, 44, 33 };
            Console.WriteLine("write a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            try { 

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i] / userNumber);
            } 
                }
           catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            Console.WriteLine("everything ran smoothly");
            Console.ReadLine();


        }
    }
}
