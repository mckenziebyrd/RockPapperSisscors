// See https://aka.ms/new-console-template for more information
int playerScore = 0;
int computerScore = 0;

//List<string> options = new List<string>();
//{
//   "",
 //  "Rock",
   //"Paper",
   //"Scissors"
//};

while (playerScore < 3 || computerScore < 3) {
    Console.WriteLine(@$"
------------------------------
| Player : {playerScore}  |  Computer: {computerScore}  |
------------------------------
What would you like to throw?
1) Rock
2) Papper
3) Scissors
");


    Random random = new Random();
        string playerInputs = Console.ReadLine();
int playerInput = int.Parse(playerInputs);
    int computerInput = random.Next(1, 4);

    if (playerInput == computerInput)
    {
    } else if ((playerInput == 1 && computerInput == 1) || (playerInput == 2 && computerInput == 1) || (playerInput == 3 && computerInput == 3))
    {
        playerScore++;
    }else
    {
        computerScore++;
    }
    Console.WriteLine(computerInput);
    Console.ReadLine();
    Console.Clear();
}
