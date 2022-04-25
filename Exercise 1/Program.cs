Console.Write("Напишите число: ");
int _number = Convert.ToInt32(Console.ReadLine());
Console.Write("Возведем в степень: ");
int _numberPow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Получается " + Pow(_number, _numberPow));

int Pow(int number, int pow){
    int result = 1;
    for(int i = 0; i < pow; i++){
        result *= number;
    }
    return result;
}
