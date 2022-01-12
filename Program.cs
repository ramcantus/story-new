 // Console
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Title = "The Eating Game";
 // Code
Console.WriteLine("Welcome to my game!!\n");
Console.WriteLine("---------------------\n");
Console.WriteLine("Insert 1 and then enter :)");
int num1 = 0;
num1 =  Convert.ToInt32(Console.ReadLine());
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("----------------------\n");
Console.WriteLine("Instructions\n");
Console.WriteLine("1. To play this game you'll need to type 1, 2 or 3\n");
Console.WriteLine("2. I'm just bored tbh\n");
Console.WriteLine("3. Have fun!\n");
Console.WriteLine("----------------------\n");
Console.WriteLine("Press 'enter' to continue");
Console.WriteLine("-----------------------\n");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Blue;
Console.ReadLine();
Console.WriteLine("Which of these 3 foods is your favorite?\n");
Console.WriteLine("1. Pizza");
Console.WriteLine("2. Tacos");
Console.WriteLine("3. HotDogs\n");
Console.Write("Your option: \n");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
switch (Console.ReadLine())
{
case "1":
Console.WriteLine("\nGood Choice! Next question.\n");
break;
case "2":
Console.WriteLine("\nGood Choice! Next question.\n");
break;
case "3":
Console.WriteLine("\nReally??! bruh. Next question.\n");
break;   
}
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("What's your favorite drink in these 3?\n");
Console.WriteLine("1. Water");
Console.WriteLine("2. Soda");
Console.WriteLine("3. Coffee\n");
Console.Write("Your option: \n");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
switch (Console.ReadLine())
{
case "1":
Console.WriteLine("\nGood choice, saty healthy! Next question.\n");
break;
case "2":
Console.WriteLine("\nGood choice, but but not as healthy as water, Next question.\n");
break;
case "3":
Console.WriteLine("\nYou a pussy for choosing coffee lmao but next question.\n");
break;
}
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("LAST QUESTION\n");
Console.WriteLine("In what age range are you?\n");
Console.WriteLine("1. 10-15");
Console.WriteLine("2. 15-20");
Console.WriteLine("3. 20-30\n");
Console.Write("Your option: \n");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
switch (Console.ReadLine())
{
case "1":
Console.WriteLine("\nWow! You're in the same age range as me!\n");
break;
case "2":
Console.WriteLine("\nWow you are a bit older than I am.\n");
break;
case "3":
Console.WriteLine("\nYou are a grandpa what are you doing with your life :v:v:v.\n");
break;
}
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("THE END\n");
Console.WriteLine("Thanks for playing :3\n");
Console.WriteLine("-----------------------\n");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Press 'enter to exit");
Console.ReadKey();
 // Finish