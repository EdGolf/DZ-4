Console.Write("Напишите число: ");
string _strNumber = Console.ReadLine();

int _sum = 0;
for(int i = 0; i < _strNumber.Length; i++){
    _sum += Convert.ToInt32(_strNumber[i].ToString());
}

Console.WriteLine("Сумма цифр: " + _sum);

