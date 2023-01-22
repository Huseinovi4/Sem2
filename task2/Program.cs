Console.WriteLine("Введите первое число:");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int secondNumber = int.Parse(Console.ReadLine()!);
if(firstNumber==secondNumber*secondNumber){
  Console.WriteLine("первое число является квадратом второго!");
}
if(firstNumber*firstNumber==secondNumber){
  Console.WriteLine("второе число является квадратом первого!");
}
else{}
