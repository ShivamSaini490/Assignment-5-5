using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        try
        {
            int[] numbers = { 1, 2, 3 };
            int value = numbers[10];
            Console.WriteLine("This line will not be executed if an exception occurs.");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("This block will always be executed.");
        }

        Console.WriteLine("Program continues...");
    }
}
