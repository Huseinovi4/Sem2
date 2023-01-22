Console.WriteLine("Введите номер дня недели:");
int number = int.Parse(Console.ReadLine()!);
if(number == 6|number == 7){
  Console.WriteLine("этот день недели является выходным!");
}
else{
  Console.WriteLine("этот день рабочичй,идите на работу!");
}