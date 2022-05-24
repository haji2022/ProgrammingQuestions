

//Function/Method (1)
//1: Function
using ProgrammingQuestions;

void Greeting()
{
    Console.WriteLine("Hello World");
}

//2: Second function
void userData(string firstName,string lastName, int age)
{
    Console.WriteLine($"Firstname: {firstName}  lastname: {lastName} age: {age}");
}
//3: third function

void changeColorOfTheConsole()
{

    string color = Console.ForegroundColor.ToString();
    if(color == "Gray")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
    }
 
}
//4: fourth function

void PrintCurrentDate()
{
    var currentDate = DateTime.Now;
    Console.WriteLine(currentDate);
}
//5: fifth function

void PrintOutTheHighestValueOfTwoNumbers(int value1, int value2)
{
    if(value1 > value2)
    {
        Console.WriteLine($"{value1} is greater than {value2}");
    }

    else if (value1 == value2)
    {
        Console.WriteLine($"{value1} is equal to {value2}");
    }
    else
    {
        Console.WriteLine($"{value2} is greater than {value1}");
    }
}

//Start of question 6

int RandomNumberGenerator()
{
    Random rnd = new Random();
    int rndNumber = rnd.Next(1, 101); //1 - 100  --> 6
    return rndNumber;
}
//End of question 6

void GuessingGame()
{
    int theNumber = RandomNumberGenerator();
    bool game = true;
    int amountOfTimeTryed = 0;
    Console.WriteLine(theNumber);
    while (game)
    {
        Console.WriteLine("Guess the right number!");
        int userInput = int.Parse(Console.ReadLine());

        if (theNumber == userInput)
        {
            amountOfTimeTryed++;
            Console.WriteLine($"Woho You Guessed Right");
            Console.WriteLine($"Amount of time it took you to guess correct is: {amountOfTimeTryed} ");
            game = false;
        }

        else if (userInput > theNumber)
        {
            amountOfTimeTryed++;
            Console.WriteLine("You guessed Wrong!");
            Console.WriteLine("The value that you guessed is greater than TheGameNumber");
        }

        else if (userInput < theNumber)
        {
            amountOfTimeTryed++;
            Console.WriteLine("You guessed Wrong!");
            Console.WriteLine("The value that you guessed is less than TheGameNumber");
        }


    }
}

//Funktion där användaren skriver in en textrad, som sedan sparas i en fil på hårddisken

//Start of Question 7
string userText()
{
    Console.WriteLine("Hello user write some beautiful Text!");
    string userText = Console.ReadLine();
    return userText;
}
//End of Question 7
void CreateFileBasedOnUserText(string userText)
{
    string path = @"C:\Users\Abdirahman\OneDrive\Desktop\ProgrammingQuestions\userstory.txt";
    if (userText != null)
    {
        if(File.Exists(path))
        {
            File.AppendAllText(path, ". " + userText);
        } 
        else
        {
           File.WriteAllText(path, userText);
        }

        //string readText = File.ReadAllText("userstory.txt");
    }
}
// Question 8 
void ReadFileFromDisk()
{
    string path = @"C:\Users\Abdirahman\OneDrive\Desktop\ProgrammingQuestions\userstory.txt";
    var savedTextFromFile = File.ReadAllText(path);
    Console.WriteLine(savedTextFromFile);


}
//Start Of Question 9
List<double>GetSquareRootAndRaisedToTwoAndRaisedToTen(double  num)
{
    var sqrtNum = Math.Sqrt(num);
    var RaisedToTwo = num * num;
    var RaisedToTen = num * num * num * num * num * num * num * num * num * num * num;
    return new List<double> {sqrtNum, RaisedToTwo, RaisedToTen };

}

//End Of Question 9
void printOut(List<double> SquareRootAndRaisedToTwoAndRaisedToTen)
{
    var numbers = SquareRootAndRaisedToTwoAndRaisedToTen;
    Console.WriteLine($"Square root: {numbers[0]}");
    Console.WriteLine($"Raised to Two: {numbers[1]}");
    Console.WriteLine($"Raised to Ten: {numbers[2]}");
}

//Question 10

//Funktion där programmet skriver ut en multiplikationstabell från 1 till 10. En ”tabb” ska
//läggas in efter varje nummer. Försöka att ställa upp det så det blir relativt läsbart.

void MultiplicationTableOneToTen()
{

    //i = 10;
    //j = 10
    for(int i = 1; i <= 10; i++ )
    {
        for(int j = 1; j <= 10; j++)
        { 
           Console.WriteLine($"{i}*{j} ={i*j}");
        }
    }
 }

//Funktion som skapar två arrayer. Den första fylls med slumpmässiga tal. Den andra fylls med
//talen från den första i stigande ordning. Array.Sort() får EJ användas.
//Question 11
void CreateTwoArraysAndPrintOutItsAllValues()
{
    var firstList = new List<int>();
  
    var rndNumber = new Random();
    for(int i = 0; i < 10; i++)
    {
        //10;
        firstList.Add(rndNumber.Next(1, 101));
        Console.WriteLine(firstList[i]);
    }
    Console.WriteLine("---------------------------------");
    var res = (from number in 
              firstList orderby
              number ascending
              select number).ToList();

    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine(res[j]);
     
    }


}
//Question 12
bool ItsPalinDrome(string userInput)
{
    return userInput.SequenceEqual(userInput.Reverse());
}
//Question 13

void PrintOutAllNumbersBetweenTheTwoinputs(int x, int y)
{
   if(x < y)
    {
        //x= 1; y = 10; 2-3-4-5-6-7-8-9
        for (int i = x + 1; i < y; i++ )
        {
            Console.WriteLine(i);
        }
    }
   else
    {
        for (int i = y + 1; i < x; i++)
        {
            Console.WriteLine(i);
        }
    }
}


//Question 14
//14.Funktion där användaren skickar in ett antal värden (komma-separerade siffror) som sedan
//sorteras och skrivs ut efter udda och jämna värden. 

void PrintOutAfterOddAndEven(string numberInput)
{
    var Stringnumbers = numberInput.Split(',').ToList();

     for(int i = 0; i < Stringnumbers.Count; i++)
      {
        var num = int.Parse(Stringnumbers[i]);
        if(num % 2 == 0)
        {
            Console.Write(num + " ");
        }

      }
    Console.WriteLine("<--Even-----------------");

    for (int i = 0; i < Stringnumbers.Count; i++)
    {
        var num = int.Parse(Stringnumbers[i]);
        if (num % 2 != 0)
        {
            Console.Write(num + " ");
        }
    }
    Console.WriteLine("<--ODD-----------------");
}


//Question 15:
//. Funktion där användaren skriver in ett antal värden(komma-separerade siffor) som sedan
//adderas och skrivs ut

void AddAllNumbersAndPrintOut(string numberInput)
{
    var Stringnumbers = numberInput.Split(',').ToList();
    int val = 0;
    for (int i = 0; i < Stringnumbers.Count; i++)
    {
        var num = int.Parse(Stringnumbers[i]);
        val += num;
    }

    Console.WriteLine($"All the values Added Together Became: {val}");
}

   //Question 16:
List<Character> CreateCharacter(string characterName, string OpponentName)
{
   Random random = new Random();
    List<Character> Characters = new List<Character>();
    
    for (int i = 0; i < 2; i++)
    {
        if(i == 0)
        {
            var Health = random.Next(1, 101);
            var Strength = random.Next(1, 11);
            var Luck = random.Next(1, 11);
            Character Hero = new Character(characterName, Health, Strength, Luck);
            Characters.Add(Hero);

        }
        if (i == 1)
        {
            var Health = random.Next(1, 101);
            var Strength = random.Next(1, 11);
            var Luck = random.Next(1, 11);
            Character Monster = new Character(OpponentName, Health, Strength, Luck);
            Characters.Add(Monster);

        }

    }
    return Characters;

}
//Funktion där användaren ska ange namnet på sin karaktär och namnet på en motståndare.
//Funktionen skall sedan själv lägga till slumpmässiga värden för Hälsa, Styrka och Tur, som
//sparas i en instans av en klass.



void Meny()
{
    bool menu = true;
while(menu)
    {
       Console.WriteLine("0: For stopping the program");
       Console.WriteLine("1: For printing for Greeting");
       Console.WriteLine("2: For printing for creating a user and printing out the userInfo");
       Console.WriteLine("3: For changing the color of the console");
       Console.WriteLine("4: For Printing out current DATE");
       Console.WriteLine("5: For printing out the highest value of two numbers");
       Console.WriteLine("6: For playing the guessing game");
       Console.WriteLine("7: For Writing some Beautiful story");
       Console.WriteLine("8: For reading file from disk");
       Console.WriteLine("9: For sending in a number and getting back its square root, etc");
       Console.WriteLine("10: For getting the multiplication table of 1-10");
       Console.WriteLine("11: For creating Two Arrays And Print Out Its corresponding Values");
       Console.WriteLine("12: For checking if its palindrome");
       Console.WriteLine("13: For Printing out all the numbers between two given inputs");
       Console.WriteLine("14: For Printing Out Whether a numbers is in the odd category or even.");
       Console.WriteLine("15: For Printing Out All Numbers added togther.");
       Console.WriteLine("16: For Creating A Character And An Opponent.");

        //.Funktion som tar en input från användaren och kontrollerar ifall det är en palindrom(alltså
        //samma ord från båda håll, såsom Anna eller radar.

        string inputChoice = Console.ReadLine(); //The program will wait here.
        switch(inputChoice)
        {
            case "0":
                menu = false;
                break;

            case "1":
                Greeting();
                break;
            case "2":
                Console.WriteLine("Whats your firstname?");
                string firstname = Console.ReadLine();
                Console.WriteLine("Whats your lastname?");
                string lastname = Console.ReadLine();
                Console.WriteLine("Whats your age");
                int age = int.Parse(Console.ReadLine());
                userData(firstname,lastname,age);
                break;

            case "3":
                //inside here 
                changeColorOfTheConsole();
                break;

            case "4":
                PrintCurrentDate();
                break;

            case "5":
                Console.WriteLine("Write in the first number");
                int firstnumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Write in the second number");
                int secondnumber = int.Parse(Console.ReadLine());
                PrintOutTheHighestValueOfTwoNumbers(firstnumber, secondnumber);
                break;


            case "6":
                GuessingGame();
                break;

            case "7":
                string storyData = userText();
                CreateFileBasedOnUserText(storyData);
                break;

            case "8":
                ReadFileFromDisk();
                break;

            case "9":
                Console.WriteLine("Please type in a number");
                double number = double.Parse(Console.ReadLine());
               var result =  GetSquareRootAndRaisedToTwoAndRaisedToTen(number);
                   printOut(result);
                break;

            case "10":
                MultiplicationTableOneToTen();
                break;

            case "11":
                CreateTwoArraysAndPrintOutItsAllValues();
                break;

            case "12":
                Console.WriteLine("Write a name or a text");
                string userInput = Console.ReadLine();
                var palindrome = ItsPalinDrome(userInput);
                if (palindrome)
                {
                    Console.WriteLine("Its Palindrome! :)");
                }
                else
                {
                    Console.WriteLine("Its not Palindrome!");
                }


                break;

            case "13":
                Console.WriteLine("Kindly, Write in the first number");
                int firstNum = int.Parse(Console.ReadLine());
                Console.WriteLine("And also, Write in the second number");
                int secondNum = int.Parse(Console.ReadLine());
                PrintOutAllNumbersBetweenTheTwoinputs(firstNum, secondNum);
                break;

            case "14":
                Console.WriteLine("Kindy Write few numbers, to categorize if they are odd or even: ex: 1,2,3,4,5,6");
                Console.WriteLine("Obs Separate the numbers by comma!");
                string userNumberInput = Console.ReadLine();
                PrintOutAfterOddAndEven(userNumberInput);
                break;

            case "15":
                Console.WriteLine("Kindly, Write few numbers separated by comma: ex: 1,2,3,4,5,6. to get the sum value of all numbers added together");
                string userNumberInputAddition = Console.ReadLine();
                AddAllNumbersAndPrintOut(userNumberInputAddition);
                break;

            case "16":
                Console.WriteLine("Kindly, Write the name of your HERO character");
                string HeroName = Console.ReadLine();

                Console.WriteLine("Kindly, Write the name of your Opponent ");
                string OpponentName = Console.ReadLine();

                List<Character> Characters = CreateCharacter(HeroName, OpponentName);

                 Console.WriteLine("Over Stats of All Characters");
                 for(int i = 0; i < Characters.Count; i++) 
                  {
                    if(i == 0)
                    {
                        Console.WriteLine($"Your Characters Name: {Characters[i].Name}");
                        Console.WriteLine($"Your Characters Health: {Characters[i].Health}");
                        Console.WriteLine($"Your Characters Strength: {Characters[i].Strength}");
                        Console.WriteLine($"Your Characters Luck: {Characters[i].Luck}");
                    }
                    Console.WriteLine("----------------------------------------");
                    if (i == 1)
                    {
                        Console.WriteLine($"Opponents Characters Name: {Characters[i].Name}");
                        Console.WriteLine($"Opponents Characters Health: {Characters[i].Health}");
                        Console.WriteLine($"Opponents Characters Strength: {Characters[i].Strength}");
                        Console.WriteLine($"Opponents Characters Luck: {Characters[i].Luck}");
                    }

                }


                break;





        }


    }
   


}



Meny();