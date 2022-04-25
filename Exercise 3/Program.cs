Console.Write("Введите числа через запятую: ");
string _numbers = Console.ReadLine();
_numbers = _numbers.Replace(" ", "");
string[] _arrayNumbers = _numbers.Split(new char[] {','});

for(int i = 0; i < _arrayNumbers.Length; i++){
    Console.Write($"{_arrayNumbers[i]} ");
}
