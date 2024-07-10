using System;
using System.Runtime.CompilerServices;

class Ali
{
    public static void Main()
    {
        Console.WriteLine("This program prints details of a country by taking its code, name or capital city.");

        START1:
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

        Console.WriteLine("Enter Data of Country you want to find: ");
        string Choice = Console.ReadLine().ToUpper();

        Country C1 = new Country();
        C1.Name = "Pakistan";
        C1.Code = "PAK";
        C1.Capital = "Islamabad";

        Country C2 = new Country();
        C2.Name = "Australia";
        C2.Code = "AUS";
        C2.Capital = "Canberra";

        Country C3 = new Country();
        C3.Name = "United States of America";
        C3.Code = "USA";
        C3.Capital = "Washimgton D.C.";

        Country C4 = new Country();
        C4.Name = "United Kingdom";
        C4.Code = "GBR";
        C4.Capital = "London";

        Country C5 = new Country();
        C5.Name = "Canada";
        C5.Code = "CAN";
        C5.Capital = "Ottawa";

        List<Country> LC = new List<Country>();
        LC.Add(C1);
        LC.Add(C2);
        LC.Add(C3);
        LC.Add(C4);
        LC.Add(C5);

        Country foundCountry = LC.Find(country => country.Code.ToUpper() == Choice || country.Name.ToUpper() == Choice || country.Capital.ToUpper() == Choice);

        if (foundCountry != null)
        {
            Console.WriteLine("Country Found:");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Name: {0}", foundCountry.Name);
            Console.WriteLine("Code: {0}", foundCountry.Code);
            Console.WriteLine("Capital: {0}", foundCountry.Capital);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
        }
        else
        {
            Console.WriteLine("Country Details not Found in this List.");

            START2:
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Do you want to try again? (yes/no)");
            string redo = Console.ReadLine().ToLower();

            if (redo == "yes")
            {
                goto START1;
            }
            else if (redo == "no")
            {
                return;
            }
            else
            {
                Console.WriteLine("Wrong Input!");
                goto START2;
            }
        }
    }  
}

public class Country
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Capital { get; set; }
}