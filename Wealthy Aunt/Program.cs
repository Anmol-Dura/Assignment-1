// See https://aka.ms/new-console-template for more information

//Wealthy Aunt problem
Console.Write("How much did you receive money ($)? ");
Double money = Double.Parse(Console.ReadLine());
Console.Write("Items after Books and supplies: ");
Double numberOfItems = Double.Parse(Console.ReadLine());
Double booksAndSupplies = money * (3 / 4.0);
Console.WriteLine();
Console.WriteLine("Books and Supplies: {0} $",booksAndSupplies);
Console.WriteLine("You can then buy: ");
Double dividedMoney = (money - booksAndSupplies)/numberOfItems;
int forCofee = (int)dividedMoney/2;
int FlashComputerNumbers = (int)dividedMoney/4;
int subwayTickets = (int)dividedMoney/3;
Console.WriteLine("{0} Cofees",forCofee);
Console.WriteLine("{0} Flash Computer Numbers", FlashComputerNumbers);
Console.WriteLine("{0} subway Tickets", subwayTickets);
int momFlowers = (int)(money - booksAndSupplies-(forCofee*2 + FlashComputerNumbers* 4 + subwayTickets*3));
Console.WriteLine("and you will have {0} dollars for the white roses.",momFlowers);