using System;

public class PersonnummerValidator
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Skriv in ett svenskt personnummer (ÅÅMMDD-XXXX eller ÅÅÅÅMMDD-XXXX):");
            string personnummer = Console.ReadLine();

            if (IsValidPersonnummer(personnummer))
            {
                Console.WriteLine("Personnumret är korrekt.");
                break;
            }
            else
            {
                Console.WriteLine("Personnumret är ogiltigt.");
            }
        }
    }

    public static bool IsValidPersonnummer(string personnummer)
    {
        // Extract the year, month, and day from the personnummer for testing.
        int birthYear, birthMonth, birthDay;

        if (personnummer.Length == 11)
        {
            birthYear = int.Parse(personnummer.Substring(0, 2));
            birthMonth = int.Parse(personnummer.Substring(2, 2));
            birthDay = int.Parse(personnummer.Substring(4, 2));
        }
        else if (personnummer.Length == 13)
        {
            birthYear = int.Parse(personnummer.Substring(0, 4));
            birthMonth = int.Parse(personnummer.Substring(4, 2));
            birthDay = int.Parse(personnummer.Substring(6, 2));
        }
        else
        {
            return false; // Invalid length
        }

        // Validate the month
        if (birthMonth < 1 || birthMonth > 12)
        {
            return false; // Invalid month
        }

        // Validate the day
        if (birthDay < 1 || birthDay > DaysInMonth(birthYear, birthMonth))
        {
            return false; // Invalid day
        }

        return true;
    }

    public static int GetYearOffset(int yearLength)
    {
        return (yearLength == 2) ? 1900 : 0;
    }

    public static int DaysInMonth(int year, int month)
    {
        if (month == 2) // February
        {
            // Leap year: 29 days, Non-leap year: 28 days
            return IsLeapYear(year) ? 29 : 28;
        }
        else if (month >= 1 && month <= 7)
        {
            return month % 2 == 1 ? 31 : 30; // Odd months: 31 days, Even months: 30 days
        }
        else
        {
            return month % 2 == 0 ? 31 : 30; // Remaining even months: 31 days, odd months: 30 days
        }
    }

    public static bool IsLeapYear(int year)
    {
        // Leap year rules: divisible by 4, not divisible by 100 unless divisible by 400
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
