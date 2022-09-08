// See https://aka.ms/new-console-template for more information
using CustomsExceptions.CustomExceptions;

Console.WriteLine("Hello, World!");

try
{
    TestException(true);
}
catch (MyCustomException ex)
{
    Console.WriteLine("Custom exception: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Generic exception: " + ex.Message);
}


static void TestException(bool throwException)
{
    if (throwException)
        throw new MyCustomException();

    throw new IndexOutOfRangeException();
} 