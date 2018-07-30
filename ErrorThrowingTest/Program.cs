using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorThrowingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringArray = new string[3] { "a", "b", "c" };
            try
            {
                GetValueAtIndex(stringArray, 1);
            }
            catch (ArgumentNullException nullException)
            {
                Console.WriteLine(nullException.Message);
            }
            catch (ArgumentOutOfRangeException outOfRangeException)
            {
                Console.WriteLine(outOfRangeException.Message);
            }
            //var stringArray = new string[3] { "a", "b", "c" };
            //try
            //{
            //    string letter = GetValueAtIndex(stringArray, 2);

            //    if (letter == "b")
            //    {
            //        throw new Exception("Letter is b, created exception.");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("Index out of range");
            //}
            Console.ReadKey();
        }

        static string GetValueAtIndex(string[] values, int index)
        {
            try
            {
                Console.WriteLine("Entering GetValueAtIndex");

                if (values == null)
                {
                    throw new ArgumentNullException("Array is null");
                }
                if (index < 0 || index >= values.Length)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range.");
                }
                return values[index];
            }
            catch
            {
                Console.WriteLine("Error in GetValueAtIndex");
                throw;
            }
            finally
            {
                Console.WriteLine("Exiting GetValueAtIndex");
            }

            
        }
    }
}
