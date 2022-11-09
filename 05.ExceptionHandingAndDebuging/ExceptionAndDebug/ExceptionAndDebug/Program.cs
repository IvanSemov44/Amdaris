
using ExceptionAndDebug;

Console.WriteLine("If you want exit, just write exit");
Console.WriteLine("Now, give some number and if it is even i will throw error message and if it is odd i will didn't.");

try
{
    while (true)
    {
        string? input = Console.ReadLine();

        //if (input == "exit")
        //    Environment.Exit(0);

        try
        {

            int number = int.Parse(input);
            if (number == 0)
            {

            }
            else if (number % 2 == 0)
            {
                throw new DemoException("The Number is Even");
            }
            else
            {
                Console.WriteLine("The Number is odd");
            }
        }
        catch (FormatException ex)
        {
            if (input.ToLower() == "exit")
                throw new Exception("Bye bye");

            Console.WriteLine("Maybe is better to try with Number");
        }
        catch (DemoException ex)
        {

            Console.WriteLine(ex.Message);
        }
        catch (ZeroException)
        {
            Console.WriteLine("This is a 0");
        }
        finally
        {
            Console.WriteLine("");
        }

        Console.WriteLine("Try again");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    Environment.Exit(0);
}