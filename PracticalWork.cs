//1.1
/*

        // Ввод чисел
        Console.Write("Enter the First number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Third number: ");
        double thirdNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Fourth number: ");
        double fourthNumber = Convert.ToDouble(Console.ReadLine());

        // Среднее значение
        double average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

        // Вывод результата
        Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber}, {fourthNumber} is: {average}");
*/



//1.2
/*

        // Ввод числа
        Console.Write("Введите первое число: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Введите второе число: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());
        
        // Показ введенных чисел
        Console.WriteLine($"\nВы ввели числа: {firstNumber} и {secondNumber}");
        
        // ПОказ возможнастей калькулятора
        Console.WriteLine("Какое действие выполнить?");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        Console.WriteLine("5. Нахождение остатка");
        Console.Write("Выберите номер действия: ");
        
        int choice = Convert.ToInt32(Console.ReadLine());
        double result;

        // Выполнение
        switch (choice)
        {
            case 1:
                result = firstNumber + secondNumber;
                Console.WriteLine($"\nРезультат: {firstNumber} + {secondNumber} = {result}");
                break;
            case 2:
                result = firstNumber - secondNumber;
                Console.WriteLine($"\nРезультат: {firstNumber} - {secondNumber} = {result}");
                break;
            case 3:
                result = firstNumber * secondNumber;
                Console.WriteLine($"\nРезультат: {firstNumber} * {secondNumber} = {result}");
                break;
            case 4:
                if (secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"\nРезультат: {firstNumber} / {secondNumber} = {result}");
                }
                else
                {
                    Console.WriteLine("\nОшибка: Деление на ноль невозможно.");
                }
                break;
            case 5:
                if (secondNumber != 0)
                {
                    result = firstNumber % secondNumber;
                    Console.WriteLine($"\nРезультат: {firstNumber} % {secondNumber} = {result}");
                }
                else
                {
                    Console.WriteLine("\nОшибка: Деление на ноль невозможно.");
                }
                break;
            default:
                Console.WriteLine("\nОшибка: Неправильный выбор действия.");
                break;
        }
*/


//1.3
/*
        // Выбор шкалы
        Console.WriteLine("Выберите шкалу вводимой температуры:");
        Console.WriteLine("1. Цельсий");
        Console.WriteLine("2. Кельвин");
        Console.WriteLine("3. Фаренгейт");
        Console.Write("Введите номер шкалы: ");

        int inputScale = Convert.ToInt32(Console.ReadLine());

        // Ввод температуры
        Console.Write("Введите показатель температуры: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        // Выбор шкалы для конвертации
        Console.WriteLine("\nВыберите тип шкалы для конвертации:");
        Console.WriteLine("1. Цельсий");
        Console.WriteLine("2. Кельвин");
        Console.WriteLine("3. Фаренгейт");
        Console.Write("Введите номер шкалы: ");

        int outputScale = Convert.ToInt32(Console.ReadLine());

        double convertedTemperature;

        // Конвертация температуры
        if (inputScale == 1 && outputScale == 2) // Цельсий -> Кельвин
        {
            convertedTemperature = temperature + 273.15;
            Console.WriteLine($"\nВы выбрали: Цельсий -> Кельвин");
        }
        else if (inputScale == 1 && outputScale == 3) // Цельсий -> Фаренгейт
        {
            convertedTemperature = (temperature * 9 / 5) + 32;
            Console.WriteLine($"\nВы выбрали: Цельсий -> Фаренгейт");
        }
        else if (inputScale == 2 && outputScale == 1) // Кельвин -> Цельсий
        {
            convertedTemperature = temperature - 273.15;
            Console.WriteLine($"\nВы выбрали: Кельвин -> Цельсий");
        }
        else if (inputScale == 2 && outputScale == 3) // Кельвин -> Фаренгейт
        {
            convertedTemperature = (temperature - 273.15) * 9 / 5 + 32;
            Console.WriteLine($"\nВы выбрали: Кельвин -> Фаренгейт");
        }
        else if (inputScale == 3 && outputScale == 1) // Фаренгейт -> Цельсий
        {
            convertedTemperature = (temperature - 32) * 5 / 9;
            Console.WriteLine($"\nВы выбрали: Фаренгейт -> Цельсий");
        }
        else if (inputScale == 3 && outputScale == 2) // Фаренгейт -> Кельвин
        {
            convertedTemperature = (temperature - 32) * 5 / 9 + 273.15;
            Console.WriteLine($"\nВы выбрали: Фаренгейт -> Кельвин");
        }
        else if (inputScale == outputScale)
        {
            convertedTemperature = temperature;
            Console.WriteLine($"\nВы выбрали одинаковые шкалы, температура остаётся той же.");
        }
        else
        {
            Console.WriteLine("\nОшибка: Неправильный выбор шкалы.");
            return;
        }

        // Вывод
        Console.WriteLine($"Результат конвертации: {convertedTemperature}");
*/



//1.4
/*
        Console.WriteLine("введите путь");
        string str = Console.ReadLine();
        string[] parts = str.Split('/');
        Console.WriteLine(parts[parts.Length - 1]);
*/



//1.5
/*
        // Ввод предложения
        Console.Write("Введите предложение: ");
        string sentence = Console.ReadLine();

        // Разделение предложения на слова
        string[] words = sentence.Split(' ');

        // Переменные для хранения самого длинного слова
        string longestWord = "";
        int maxLength = 0;

        // Цикл для перебора слов
        foreach (string word in words)
        {
            if (word.Length > maxLength)
            {
                longestWord = word;
                maxLength = word.Length;
            }
        }

        // Вывод самого длинного слова
        Console.WriteLine($"\nСамое длинное слово: {longestWord}");
*/



//1.6
/*
        // Первый массив
        Console.Write("Введите значения для первого массива через пробел: ");
        string[] firstArrayInput = Console.ReadLine().Split(' ');

        // Второй массив
        Console.Write("Введите значения для второго массива через пробел: ");
        string[] secondArrayInput = Console.ReadLine().Split(' ');

        // Преобразование строковых в числовые
        int length = firstArrayInput.Length;
        int[] firstArray = new int[length];
        int[] secondArray = new int[length];
        int[] resultArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            firstArray[i] = int.Parse(firstArrayInput[i]);
            secondArray[i] = int.Parse(secondArrayInput[i]);
        }

        // Перемножение массивов
        for (int i = 0; i < length; i++)
        {
            resultArray[i] = firstArray[i] * secondArray[i];
        }

        // Вывод результата
        Console.Write("Результат: ");
        foreach (int value in resultArray)
        {
            Console.Write(value + " ");
        }
*/


//1.7
/*
        // Ввод чисел
        Console.Write("Введите пять чисел через пробел: ");
        string[] input = Console.ReadLine().Split(' ');

        // Преобразование строкового в целочисленный
        int[] numbers = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        // Инициализация переменных для хранения минимального и максимального значений
        int maxNumber = numbers[0];
        int minNumber = numbers[0];

        // Поиск максимального и минимального чисел
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
            if (number < minNumber)
            {
                minNumber = number;
            }
        }

        // Вывод результата
        Console.WriteLine($"\nМаксимальное число: {maxNumber}");
        Console.WriteLine($"Минимальное число: {minNumber}");
*/



//1.8
/*
        // Запрос количества ступеней у пользователя
        Console.Write("Введите количество ступеней: ");
        int steps = int.Parse(Console.ReadLine());

        // Построение пирамиды
        for (int i = 1; i <= steps; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine(); // Переход на новую строку после каждого уровня
        }
*/



//2.1
/*
        // Цикл для строк таблицы (от 1 до 9)
        for (int i = 1; i <= 9; i++)
        {
            // Цикл для столбцов таблицы (от 1 до 9)
            for (int j = 1; j <= 9; j++)
            {
                // Вывод результата умножения с форматированием
                Console.Write($"{i} х {j} = {i * j}\t");
            }
            // Переход на новую строку после каждого ряда умножений
            Console.WriteLine();
        }
*/


//3.10
/*
        // Ввод чисел
        Console.Write("Введите пять чисел через пробел: ");
        string[] input = Console.ReadLine().Split(' ');

        // Преобразование строкового массива в целочисленный
        int[] numbers = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        // Инициализация переменных для хранения минимального и максимального значений
        int maxNumber = numbers[0];
        int minNumber = numbers[0];

        // Поиск максимального и минимального чисел
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
            if (number < minNumber)
            {
                minNumber = number;
            }
        }

        // Вывод результата
        Console.WriteLine($"\nМаксимальное число: {maxNumber}");
        Console.WriteLine($"Минимальное число: {minNumber}");
*/
