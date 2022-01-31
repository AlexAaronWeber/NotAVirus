// See https://aka.ms/new-console-template for more information
//intro
Console.WriteLine("Welcome to your bank's credit score checker.");

//getting info
Console.WriteLine("Could you please enter your name!");
string name = Console.ReadLine();

//displaying info
//Console.WriteLine("Thank you for the info, " + name);

//steal mother's maiden name
Console.WriteLine("For security purposes, please provide your mother's maiden name!");
string momMaidenName = Console.ReadLine();

//fav food
Console.WriteLine("What is your favorite food?");
string favFood = Console.ReadLine();

//steal home address
Console.WriteLine("Please provide your home address");
string homeAddress = Console.ReadLine();

//steal SOC #
Console.WriteLine("Please provide your social security number!");
double socNum = double.Parse(Console.ReadLine());

//steal cc number
Console.WriteLine("Please provide your Credit card number");
double creditCardNum = double.Parse(Console.ReadLine());

//steal bank acct info
Console.WriteLine("Please provide your bank account number");
double bankAcctNum = double.Parse(Console.ReadLine());



//display
Console.WriteLine("Your stolen info is as follows:");
Console.WriteLine("Name: " + name);
Console.WriteLine("Mother's maiden name: " + momMaidenName);
Console.WriteLine("Favorite food: " + favFood);
Console.WriteLine("Address: " + homeAddress);
Console.WriteLine("Social Security Number: " + socNum);
Console.WriteLine("Credit card: " + creditCardNum);
Console.WriteLine("Bank account: " + bankAcctNum);

Console.WriteLine("Good luck stopping me! Mwahahahahahahaha");

