// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text;
using System.Xml.Linq;
using PianoDataApp;

//string holding clinets.txt file
string fileName = "clients.txt";

// This getd the current working directory of the project
string startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

//Combines current working directory with file name to make complete path to the txt file.
string path = Path.Combine(startupPath, fileName);

//New List to hold strings to be inputed into client.txt
List<string> lines = new List<string>();
//Feature 3-List to hold each instance of Customer that is created
List<Customer> tuningCustomer = new List<Customer>();
lines = File.ReadAllLines(path).ToList(); // Converts array of string from clients.txt to List.

//loop through the lines list to split the words at each comma, and then place the string into the new instance of customer being created.
//add each customer into the tuningcustomer list.
foreach(string line in lines)
{
    string[] items = line.Split(',');
    Customer p = new Customer(items[0], items[1], items[2], items[3], items[4], items[5], items[6], items[7]);
    tuningCustomer.Add(p);
}

//This List was created to have output for the clients.csv file
List<string> outContents = new List<string>();

//string holding the inout from user to continue
string confirmContinue;

//Feature 1-master loop to run the options for user to interact with.
do
{
    displaymenu();
    Console.WriteLine("Enter your choice 1-3:");
    int choice = int.Parse(Console.ReadLine());
    Console.Clear();

    //Switch statement for executing user options
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

        case 2://Print List to console and outfile.txt
            foreach (Customer p in tuningCustomer)
            {
                Console.WriteLine(p);
                //retruns each customer property as a string and places into outContenets List to be written to txt file.
                outContents.Add(p.ToString());
            }
            //Feature 4-Write to txt file
            string outFile = "outFile.txt";
            string path2 = Path.Combine(startupPath, outFile);
            File.WriteAllLines(path2, outContents);
            break;

        case 3://take input for new user, and write to csv

            StringBuilder csvcontent = new StringBuilder();
            Console.WriteLine("Enter the first name of the client");
            var afirstName = Console.ReadLine();

            Console.WriteLine("Enter the last name of the client");
            var blastName = Console.ReadLine();

            Console.WriteLine("Enter the email of the client");
            var cemail = Console.ReadLine();

            Console.WriteLine("Enter the address of the client");
            var daddress = Console.ReadLine();

            Console.WriteLine("Enter the piano brand of the client");
            var epianoBrand = Console.ReadLine();

            Console.WriteLine("Enter the piano model of the client");
            var fpianoModel = Console.ReadLine();

            Console.WriteLine("Enter the piano age of the client");
            var gpianoAge = (Console.ReadLine());

            Console.WriteLine("Enter the piano serial number of the client");
            var hpianoSerialNumber = (Console.ReadLine());
            //Feature 4-Write to csv file
            csvcontent.AppendLine($"{afirstName},{blastName},{cemail},{daddress},{epianoBrand},{fpianoModel},{gpianoAge},{hpianoSerialNumber}");
            string csvPath = "clients.csv";
            string path3 = Path.Combine(startupPath, csvPath);
            File.AppendAllText(path3, csvcontent.ToString());
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




// Method for Menu to display options to user
static void displaymenu()
{

    Console.WriteLine("======================================================\n                        PIANO DATA APP MENU                         \n======================================================");
    Console.WriteLine(" 1.Add New Client");
    Console.WriteLine(" 2.View all Client List in Console and clients.txt");
    Console.WriteLine(" 3.Add new Client to csv file and view all Client List in CSV");
    Console.WriteLine("******************************************************\n");
}


