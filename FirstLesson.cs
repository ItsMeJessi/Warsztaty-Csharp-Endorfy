//variables

int number;
number = 5;

int number1 = 6;

const int NUMBER_2 = 5;

double number3 = 7.32;
float number4 = 4.44f;

byte number5 = 234;

char letter = 'G';

string sentence = "This is the first lesson";
string sentence2 = "It's ok!";

Console.WriteLine(sentence);
sentence = "This is the second lesson";
Console.WriteLine(sentence);


string sentence3 = sentence + " " + sentence2;
Console.WriteLine(sentence3);

Console.WriteLine("What's your name?");

string playerName;

playerName = Console.ReadLine();
Console.WriteLine("Hello, " + playerName);

string welcomeMessage = $"Hello, {playerName}. Nice to see you";
Console.WriteLine(welcomeMessage);

Console.WriteLine("How old are you?");

int age = 0;

age = Convert.ToInt32(Console.ReadLine());

if(age >= 18)
{
    Console.WriteLine("Ok, welcome.");
    if(age > 30)
    {
        Console.WriteLine("But you're too old");
    }
}
else
{
    Console.WriteLine("Sorry, you're too young");
}




