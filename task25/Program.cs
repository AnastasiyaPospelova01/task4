//Задача 25: Напишите цикл, который принимает на вход два числа
//(A и B) и возводит число A в натуральную степень B.
//Еще раз зафиксируем: нужно написать именно ЦИКЛ, а не метод Math.Pow
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число, а затем степень: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int result = 1;

int i = 1;
while (i <= B) {
    result *= A;
    i ++;
}

Console.WriteLine(result);

