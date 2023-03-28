// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using PianoDataApp;


string filePath = "/Users/xcastudent/Desktop/PianoDataApp/clients.txt";
List<string> lines = new List<string>();
List<Customer> tuningCustomer = new List<Customer>();

lines = File.ReadAllLines(filePath).ToList(); // Converts array to List
foreach(string line in lines)
{
    string[] items = line.Split(',');
    Customer p = new Customer(items[0], items[1], items[2], items[3], items[4], items[5], items[6], items[7]);
    tuningCustomer.Add(p);
}


List<string> outContents = new List<string>();


string confirmContinue;

do
{
    displaymenu();
    Console.WriteLine("Enter your choice 1-6:");
    int choice = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter the first name of the client");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter the last name of the client");
            var lastName = Console.ReadLine();

            Console.WriteLine("Enter the email of the client");
            var email = Console.ReadLine();

            Console.WriteLine("Enter the address of the client");
            var address = Console.ReadLine();

            Console.WriteLine("Enter the piano brand of the client");
            var pianoBrand = Console.ReadLine();

            Console.WriteLine("Enter the piano model of the client");
            var pianoModel = Console.ReadLine();

            Console.WriteLine("Enter the piano age of the client");
            var pianoAge = (Console.ReadLine());

            Console.WriteLine("Enter the piano serial number of the client");
            var pianoSerialNumber = (Console.ReadLine());

            var newCustomer = new Customer(firstName, lastName, email, address, pianoBrand, pianoModel, pianoSerialNumber, pianoAge);
            tuningCustomer.Add(newCustomer);
            break;

        case 2:
            foreach (Customer p in tuningCustomer)
            {
                Console.WriteLine(p);
                outContents.Add(p.ToString());
            }

            string outFile = "/Users/xcastudent/Desktop/PianoDataApp/outFile.txt";
            File.WriteAllLines(outFile, outContents);
            break;

        default:
            Console.WriteLine("Invalid Entry");
            break;
    }

    Console.Write("Press y to continue or n to Exit:");
    confirmContinue = Console.ReadLine().ToString();
    Console.Clear();
} while (confirmContinue == "Y" || confirmContinue == "y");

Console.WriteLine("Thank you for using the Piano Data App!");




static void displaymenu()
{

    Console.WriteLine("======================================================\n                        PIANO DATA APP MENU                         \n======================================================");
    Console.WriteLine(" 1.Add New Client");
    Console.WriteLine(" 2.View all Client List");
    Console.WriteLine(" 6.Find a Client by ID");
    Console.WriteLine("******************************************************\n");
}


