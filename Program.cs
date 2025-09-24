using С__lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

internal class Program {

    static readonly Task1 _task1 = new Task1();
    static readonly Task2 _task2 = new Task2();
    static readonly Task3 _task3 = new Task3();
    static readonly Task4 _task4 = new Task4();
    static readonly CheckInput _check = new CheckInput();

    private static void Main(string[] args) {
        bool keepRunning = true;
        while (keepRunning) {
            //Вывод меню в консоль
            Console.Clear();
            Console.WriteLine("Выберите метод для тестирования:");
            Console.WriteLine("--- Задание 1 ---");
            Console.WriteLine("1.1. fraction(double x)");
            Console.WriteLine("1.3. charToNum(char x)");
            Console.WriteLine("1.5. is2Digits(int x)");
            Console.WriteLine("1.7. isInRange(int a, int b, int num)");
            Console.WriteLine("1.9. isEqual(int a, int b, int c)");
            Console.WriteLine("\n--- Задание 2 ---");
            Console.WriteLine("2.1. abs(int x)");
            Console.WriteLine("2.3. is35(int x)");
            Console.WriteLine("2.5. max3(int x, int y, int z)");
            Console.WriteLine("2.7. sum2(int x, int y)");
            Console.WriteLine("2.9. day(int x)");
            Console.WriteLine("\n--- Задание 3 ---");
            Console.WriteLine("3.1. listNums(int x)");
            Console.WriteLine("3.3. chet(int x)");
            Console.WriteLine("3.5. numLen(long x)");
            Console.WriteLine("3.7. square(int x)");
            Console.WriteLine("3.9. rightTriangle(int x)");
            Console.WriteLine("\n--- Задание 4 ---");
            Console.WriteLine("4.1. findFirst(int[] arr, int x)");
            Console.WriteLine("4.3. maxAbs(int[] arr)");
            Console.WriteLine("4.5. add(int[] arr, int[] ins, int pos)");
            Console.WriteLine("4.7. reverseBack(int[] arr)");
            Console.WriteLine("4.9. findAll(int[] arr, int x)");
            Console.WriteLine("\n0. Выход");
            Console.Write("\nВведите номер: ");

            string choice = Console.ReadLine();
            Console.Clear();

            // Вызов соответствующего теста
            switch (choice) {
                case "1.1": TestFraction(); break;
                case "1.3": TestCharToNum(); break;
                case "1.5": TestIs2Digits(); break;
                case "1.7": TestIsInRange(); break;
                case "1.9": TestIsEqual(); break;
                case "2.1": TestAbs(); break;
                case "2.3": TestIs35(); break;
                case "2.5": TestMax3(); break;
                case "2.7": TestSum2(); break;
                case "2.9": TestDay(); break;
                case "3.1": TestListNums(); break;
                case "3.3": TestChet(); break;
                case "3.5": TestNumLen(); break;
                case "3.7": TestSquare(); break;
                case "3.9": TestRightTriangle(); break;
                case "4.1": TestFindFirst(); break;
                case "4.3": TestMaxAbs(); break;
                case "4.5": TestAddArray(); break;
                case "4.7": TestReverseBack(); break;
                case "4.9": TestFindAll(); break;
                case "0":
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Неверный ввод. Пожалуйста, выберите номер из списка.");
                    break;
            }

            if (keepRunning) {
                Console.WriteLine("\nНажмите Enter, чтобы вернуться в меню...");
                Console.ReadLine();
            }
        }
        Console.WriteLine("Программа завершена.");
    }

   
    


    private static void TestFraction() {
        Console.WriteLine("--- Тест 1.1: fraction ---");
        double dNum = _check.ReadDouble("Введите дробное число: ");
        Console.WriteLine($"Дробная часть числа = {_task1.fraction(dNum)}");
    }

    private static void TestCharToNum() {
        Console.WriteLine("--- Тест 1.3: charToNum ---");
        char c = _check.ReadChar("Введите символ-цифру: ");
        Console.WriteLine($"Результат charToNum('{c}'): {_task1.charToNum(c)}");
    }

    private static void TestIs2Digits() {
        Console.WriteLine("--- Тест 1.5: is2Digits ---");
        int num = _check.ReadInt("Введите целое число: ");
        if (_task1.is2Digits(num))
            Console.WriteLine("Число двузначное");
        else
            Console.WriteLine("Число не двузначное");
    }

    private static void TestIsInRange() {
        Console.WriteLine("--- Тест 1.7: isInRange ---");
        int num1 = _check.ReadInt("Введите первую границу (целое число): ");
        int num2 = _check.ReadInt("Введите вторую границу (целое число): ");
        int num3 = _check.ReadInt("Введите целое число для проверки: ");
        if (_task1.isInRange(num1, num2, num3))
            Console.WriteLine("Число входит в заданный диапазон");
        else
            Console.WriteLine("Число не входит в диапазон");
    }

    private static void TestIsEqual() {
        Console.WriteLine("--- Тест 1.9: isEqual ---");
        int num1 = _check.ReadInt("Введите первое целое число: ");
        int num2 = _check.ReadInt("Введите второе целое число: ");
        int num3 = _check.ReadInt("Введите третье целое число: ");
        if (_task1.isEqual(num1, num2, num3))
            Console.WriteLine("Все числа равны");
        else
            Console.WriteLine("Не все числа равны");
    }


    private static void TestAbs() {
        Console.WriteLine("--- Тест 2.1: abs ---");
        int num = _check.ReadInt("Введите целое число: ");
        Console.WriteLine($"Модуль числа = {_task2.abs(num)}");
    }

    private static void TestIs35() {
        Console.WriteLine("--- Тест 2.3: is35 ---");
        int num = _check.ReadInt("Введите целое число: ");
        if (_task2.is35(num))
            Console.WriteLine("Число делится на 3 или на 5 (но не на оба одновременно)");
        else
            Console.WriteLine("Число не делится ни на 3, ни на 5, или делится на оба");
    }

    private static void TestMax3() {
        Console.WriteLine("--- Тест 2.5: max3 ---");
        int num1 = _check.ReadInt("Введите первое целое число: ");
        int num2 = _check.ReadInt("Введите второе целое число: ");
        int num3 = _check.ReadInt("Введите третье целое число: ");
        Console.WriteLine($"Максимальное из чисел = {_task2.max3(num1, num2, num3)}");
    }

    private static void TestSum2() {
        Console.WriteLine("--- Тест 2.7: sum2 ---");
        int num1 = _check.ReadInt("Введите первое целое число: ");
        int num2 = _check.ReadInt("Введите второе целое число: ");
        Console.WriteLine($"Результат = {_task2.sum2(num1, num2)}");
    }

    private static void TestDay() {
        Console.WriteLine("--- Тест 2.9: day ---");
        int num = _check.ReadInt("Введите номер дня недели (1-7): ");
        Console.WriteLine($"Результат: {_task2.day(num)}");
    }


    private static void TestListNums() {
        Console.WriteLine("--- Тест 3.1: listNums ---");
        int num = _check.ReadInt("Введите целое положительное число: ");
        Console.WriteLine($"Результат: {_task3.listNums(num)}");
    }

    private static void TestChet() {
        Console.WriteLine("--- Тест 3.3: chet ---");
        int num = _check.ReadInt("Введите целое положительное число: ");
        Console.WriteLine($"Результат: {_task3.chet(num)}");
    }

    private static void TestNumLen() {
        Console.WriteLine("--- Тест 3.5: numLen ---");
        long num = _check.ReadLong("Введите длинное целое число: ");
        Console.WriteLine($"Длина числа: {_task3.numLen(num)}");
    }

    private static void TestSquare() {
        Console.WriteLine("--- Тест 3.7: square ---");
        int size = _check.ReadInt("Введите размер квадрата: ");
        _task3.square(size);
    }

    private static void TestRightTriangle() {
        Console.WriteLine("--- Тест 3.9: rightTriangle ---");
        int height = _check.ReadInt("Введите высоту треугольника: ");
        _task3.rightTriangle(height);
    }


    private static void TestFindFirst() {
        Console.WriteLine("--- Тест 4.1: findFirst ---");
        int[] arr = _check.ReadArray("Создание массива.");
        int x = _check.ReadInt("Введите число для поиска: ");
        int index = _task4.findFirst(arr, x);
        if (index != -1)
            Console.WriteLine($"Первое вхождение числа {x} находится по индексу: {index}");
        else
            Console.WriteLine($"Число {x} не найдено в массиве.");
    }

    private static void TestMaxAbs() {
        Console.WriteLine("--- Тест 4.3: maxAbs ---");
        int[] arr = _check.ReadArray("Создание массива.");
        Console.WriteLine($"Максимальное по модулю значение: {_task4.maxAbs(arr)}");
    }

    private static void TestAddArray() {
        Console.WriteLine("--- Тест 4.5: add (массив в массив) ---");
        int[] arr = _check.ReadArray("Создание основного массива.");
        int[] ins = _check.ReadArray("Создание вставляемого массива.");
        int pos = _check.ReadInt($"Введите позицию для вставки (от 0 до {arr.Length}): ");
        int[] result = _task4.add(arr, ins, pos);
        Console.WriteLine($"Результат: [{string.Join(", ", result)}]");
    }

    private static void TestReverseBack() {
        Console.WriteLine("--- Тест 4.7: reverseBack ---");
        int[] arr = _check.ReadArray("Создание массива.");
        int[] reversed = _task4.reverseBack(arr);
        Console.WriteLine($"Перевернутый массив: [{string.Join(", ", reversed)}]");
    }

    private static void TestFindAll() {
        Console.WriteLine("--- Тест 4.9: findAll ---");
        int[] arr = _check.ReadArray("Создание массива.");
        int x = _check.ReadInt("Введите число для поиска всех вхождений: ");
        int[] result = _task4.findAll(arr, x);
        Console.WriteLine($"Результат (индексы числа {x}): [{string.Join(", ", result.Where(i => i != 0 || x == 0))}]");
    }
}
