namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Printer
            Printer printer = new Printer();
            printer.Print("Hello Students");
            printer.Print(100);
            printer.Print("Welcome", 3);

            Console.WriteLine("\n----------------------\n");

            // Nepali Teacher
            NepaliTeacher nepali = new NepaliTeacher();
            nepali.Name = "Mausam";
            Console.WriteLine("Nepali Teacher: " + nepali.Name);
            nepali.Teaching();
            nepali.SalaryInfo();

            Console.WriteLine();

            // English Teacher
            EnglishTeacher english = new EnglishTeacher();
            english.Name = "Raj";
            Console.WriteLine("English Teacher: " + english.Name);
            english.Teaching();
            english.SalaryInfo();
        }
    }
}