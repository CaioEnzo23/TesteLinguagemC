int soma = 7-5;
int subtracao = 7-5;
int produto = 7*5;
int quociente = 7/5;

Console.WriteLine("Soma:" + soma);
Console.WriteLine("Subtração:" + subtracao);
Console.WriteLine("Multiplicação:" + produto);
Console.WriteLine("Divisão:" + quociente);

Random dice = new Random();
int roll = dice.Next(1,7);
Console.WriteLine(roll);

Radom dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

dice.Next()

Radom dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3

Console.WriteLine($"Rolagem dos dados: {roll1} + {roll2} + {roll3} = {total}");

if (total > 14){
    Console.WriteLine("Você venceu!");
}

if (total < 15){
    Console.WriteLine("Que pena, você perdeu.")
}

