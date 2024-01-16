using System;

public class PersonnummerValidator
{
    public static void Main()
    {
        Console.WriteLine("Skriv in ett svenskt personnummer (ÅÅMMDD-XXXX):");
        string personnummerInput = Console.ReadLine();

        if (IsValidPersonnummer(personnummerInput))
        {
            Console.WriteLine("Personnumret är korrekt.");
        }
        else
        {
            Console.WriteLine("Personnumret är ogiltigt.");
        }

        Console.ReadLine();
    }

   public static bool IsValidPersonnummer(string personnummer)
    {
        // Kontrollera längden på personnumret
        if (personnummer.Length != 11)
        {
            return false;
        }

        // Kontrollera att de första nio tecknen är siffror
        for (int i = 0; i < 6; i++)
        {
            if (!char.IsDigit(personnummer[i]))
            {
                return false;
            }
        }

        // Kontrollera att tecken 10 är en bindestreck (-)
        if (personnummer[6] != '-')
        {
            return false;
        }

        // Kontrollera att korrekt formet ÅÅMMDD
        int year, month, day;
        if (!int.TryParse(personnummer.Substring(0, 2), out year) ||
            !int.TryParse(personnummer.Substring(2, 2), out month) ||
            !int.TryParse(personnummer.Substring(4, 2), out day))
        {
            return false;
        }
        //Kontrollera för giltigt år,månad, och dag

        if (year < 0 || month < 1 || month > 12 || day < 1 || day > 31)
        {
            return false;
        }



        // Kontrollera att tecken 8 till 11 är siffror
        if (!int.TryParse(personnummer.Substring(7, 4), out int idDigits))
        {
            return false;
        }

        // Check if the idDigits are valid
        if (idDigits < 0 || idDigits > 9999)
        {
            return false;
        }

        return true;
    }

}
