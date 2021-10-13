using System;

namespace Contact_App
{
    class Program 
    {
        static void Main(string[] args)
        {
            string nameInput;
            string phoneNumber;

            //Welcome user
            Console.WriteLine("Welcome to your Contact App!");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Let's Add a New Contact");

            //adding new contact
            
            Console.WriteLine("Please enter the Contacts Name: ");
            //assigns String and gathers Name input 
            nameInput = Console.ReadLine();
            
            //asks user for phone number of contact
            Console.WriteLine("Please enter the Contacts Number: ");
            //gathers phone number and converts to integer 
            phoneNumber = Convert.ToString(Console.ReadLine());
            //Create Person with correct info
            Contact person = new Contact(nameInput, phoneNumber);
            //thanks user and saves contact 
            Console.WriteLine("Rad! You have created a New Contact!!!");
            Console.WriteLine("--------------------------------------");
            Menu();
            //Have user choose option from 3 item list


            //function creates a Contact by taking in the users input 
            //figure out way to store multiple contacts in memory 
            void AddContact()
            {
                    
            Console.WriteLine("Please enter the Contacts Name: ");
            //assigns String and gathers Name input 
            string nameInput = Console.ReadLine();
            //asks user for phone number of contact
            Console.WriteLine("Please enter the Contacts Number: ");
            //gathers phone number and converts to integer 
            string phoneNumber = Convert.ToString(Console.ReadLine());
            //Create Person with correct info
            new Contact(nameInput, phoneNumber);
            //thanks user and saves contact 
            Console.WriteLine("Rad! You have created a New Contact!!!");
            Console.WriteLine("--------------------------------------");
            }


            //Menu Function 
            void Menu()
            {
                Console.WriteLine("Please choose from the following menu: ");
                Console.WriteLine("1) Add New Contact");
                Console.WriteLine("2) View All Contacts");
                Console.WriteLine("3) Search for Contact");
                //Gathers input and converts it to an integer
                int menuInput = Convert.ToInt32(Console.ReadLine());



                switch (menuInput)
                {
                    case 1:
                        Console.WriteLine("Let's add a new contact");
                        Console.WriteLine("Please enter the Contacts Name: ");
                        //assigns String and gathers Name input 
                        nameInput = Console.ReadLine();
                        //asks user for phone number of contact
                        Console.WriteLine("Please enter the Contacts Number: ");
                        //gathers phone number and converts to integer 
                        phoneNumber = Convert.ToString(Console.ReadLine());//figure out how to add a phonenumbers length of integers
                                                                          //Create Person with correct info
                        new Contact(nameInput, phoneNumber);
                        //thanks user and saves contact 
                        Console.WriteLine("Rad! You have created a New Contact!!!");
                        Menu();
                        break;

                    case 2: //VIEW ALL CONCACTS
                        bool confirm = false;
                        string Answer;

                        do
                        {
                            Console.WriteLine("View All Conacts?");
                            Console.WriteLine("Y or N?");
                            Answer = Console.ReadLine();
                            //Console.WriteLine("You entered, " + Answer + "!");

                            ConsoleKey response;
                            do
                            {
                                //show all contacts
                                Console.WriteLine("All Contacts? [Y/N]");
                                response = Console.ReadKey(false).Key;
                                if (response != ConsoleKey.Enter)
                                    Console.WriteLine();

                                //show all contacts here

                            } while (response != ConsoleKey.Y && response != ConsoleKey.N);

                            confirm = response == ConsoleKey.Y;


                        } while (!confirm);
                        ContactList(args);
                        //Console.WriteLine("These are your current Contacts: {0} {1} ", nameInput, phoneNumber);
                        Console.WriteLine("---------------------------------------------");
                        //throw menu option 
                        Menu();
                        Console.ReadKey();
                        break;
                        



                }


            }
            //prints Array of strings which are the Contacts 
            /*static void printArray(string[] arr)
            {
                Console.WriteLine("Here are your Contacts: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }*/
            //function that creates Array of Names of Contacts 
            void ContactList(string[] args)
            {
                string name = nameInput + phoneNumber;
                

                string[] names = new string[2];
                names[0] = name;
                names[1] = name;
                names[2] = name;

                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i].ToString());
                }



            }


           
        }
       
    }
}
