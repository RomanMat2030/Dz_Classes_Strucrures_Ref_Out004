Console.WriteLine("Enter number 0-9: ");
string number = Console.ReadLine();
    try
    {
        int number2 = int.Parse(number);
        Console.WriteLine("Result: ");
        Console.WriteLine(number2 + 200);
    }
    catch(OverflowException ex)
    { Console.WriteLine(ex.Message); }
    catch (FormatException Fex)
    { Console.WriteLine(Fex.Message); }
    catch(Exception e)
    { Console.WriteLine(e.Message); }