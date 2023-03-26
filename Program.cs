// See https://aka.ms/new-console-template for more information
using PianoDataApp;

displaymenu();
//bool userWantsToExit = false;
//while (!userWantsToExit)
//{
List<Customer> tuningCustomer = new List<Customer>();
string confirmContinue;

do
{
    Console.WriteLine("Enter your choice 1-6:");
    int choice = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (choice)
    {
        case 1:
            var newCustomer = new Customer();
            Console.WriteLine("Enter the first name of the client");
            newCustomer.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the last name of the client");
            newCustomer.LastName = Console.ReadLine();

            Console.WriteLine("Enter the email of the client");
            newCustomer.Email = Console.ReadLine();

            Console.WriteLine("Enter the address of the client");
            newCustomer.Address = Console.ReadLine();

            Console.WriteLine("Enter the piano brand of the client");
            newCustomer.PianoBrand = Console.ReadLine();

            Console.WriteLine("Enter the piano model of the client");
            newCustomer.PianoModel = Console.ReadLine();

            Console.WriteLine("Enter the piano age of the client");
            newCustomer.PianoAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the piano serial number of the client");
            newCustomer.PianoSerialNumber = int.Parse(Console.ReadLine());

            tuningCustomer.Add(newCustomer);
            break;

        case 2:
            foreach (var i in tuningCustomer)
            {
                Console.WriteLine(
                    $"{i.FirstName} " +
                    $"{i.LastName}" +
                    $"\r\n{i.Address}" +
                    $"\r\n{i.Email}" +
                    $"\r\n{i.PianoBrand}" +
                    $"\r\n{i.PianoModel}" +
                    $"\r\n{i.PianoSerialNumber}" +
                    $"\r\n{i.PianoAge}" +
                    "\r\n" +
                    "\r\n"
                    );
            }
            break;

        default:
        Console.WriteLine("Invalid Entry");
        break;
    }

    Console.Write("Press y or Y to continue:");
    confirmContinue = Console.ReadLine().ToString();
    Console.Clear();
} while (confirmContinue == "Y" || confirmContinue == "y");




static void displaymenu()
{

    Console.WriteLine("======================================================\n                        PIANO DATA APP MENU                         \n======================================================");
    Console.WriteLine(" 1.Add New Client");
    Console.WriteLine(" 2.Delete Clinet");
    Console.WriteLine(" 3.Update Client");
    Console.WriteLine(" 4.View all Client list");
    Console.WriteLine(" 5.Show who the TOP 5 STUDENTS");
    Console.WriteLine(" 6.Find a Client by ID");
    Console.WriteLine("******************************************************\n");
}


