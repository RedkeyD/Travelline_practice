int[] winValues = new int[ 3 ];
winValues[ 0 ] = 18;
winValues[ 1 ] = 19;
winValues[ 2 ] = 20;

Random random = new Random();

double currentSum = 10000;
double winSum = 0;
double multiplicator = 0.1;
int bet = 0;
int randomNum = random.Next( 1, 20 );

string betPrompt = "Введите вашу ставку: ";
Console.Write( betPrompt );


string betInput = Console.ReadLine();

if ( int.TryParse( betInput, out int parsedBet ) )
{
    bet = parsedBet;
}
else
{
    string inputError = "Ошибка. Попробуйте  еще раз ввести ваше значение";
    Console.WriteLine( inputError );
    
}
if ( currentSum > 0 && bet <= currentSum )
{
    string randomNumMessage = $"Вам выпало число {randomNum}";
    Console.WriteLine( randomNumMessage );

    if ( winValues.Contains( randomNum ) )
    {
        winSum = bet * 1 + ( multiplicator * randomNum ) % 17;

        currentSum += winSum;

        string winMessage = $"Поздравляем с победой вы выиграли сумму в размере {winSum}";
        Console.WriteLine( winMessage );
    }
    else
    {
        currentSum -= bet;

        string loseMessage = $"Вы проиграли вашу ставку в размере {bet}";
        Console.WriteLine( loseMessage );
        
    }
}
else
{
    string insufficientFundsMessage = $"Недостаточно средств на балансе {currentSum}";
    Console.WriteLine( insufficientFundsMessage );
}







