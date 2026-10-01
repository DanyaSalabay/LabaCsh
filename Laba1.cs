using System;

class Laba1
{
    public void Task1()
    {
        int number;
        while (true)
        {
            Console.Write("Введите число "
                + "(минимум двузначное): ");
            string inputText = Console.ReadLine();
            if (!int.TryParse(inputText, out number))
            {
                Console.WriteLine(
                    "Ошибка: введите целое число.");
                continue;
            }
            if ((number >= 10) || (number <= -10))
                break;
            Console.WriteLine("Ошибка: число "
                + "должно быть минимум двузначным.");
        }
        Console.WriteLine("Результат: "
            + sumLastNums(number));
    }

    public int sumLastNums(int x)
    {
        int lastDigit = x % 10;
        int secondLastDigit = (x / 10) % 10;
        return lastDigit + secondLastDigit;
    }

    public void Task2()
    {
        int number;
        while (true)
        {
            Console.Write("Введите число: ");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText, out number))
                break;
            Console.WriteLine(
                "Ошибка: введите целое число.");
        }
        Console.WriteLine("Результат: "
            + isPositive(number));
    }

    public bool isPositive(int x)
    {
        return x > 0;
    }

    public void Task3()
    {
        char symbol;
        while (true)
        {
            Console.Write("Введите символ: ");
            string inputText = Console.ReadLine();
            if (inputText.Length == 1)
            {
                symbol = inputText[0];
                break;
            }
            Console.WriteLine("Ошибка: введите "
                + "ровно один символ.");
        }
        Console.WriteLine("Результат: "
            + isUpperCase(symbol));
    }

    public bool isUpperCase(char x)
    {
        return x >= 'A' && x <= 'Z';
    }

    public void Task4()
    {
        int firstNumber, secondNumber;
        while (true)
        {
            Console.Write("Введите первое число: ");
            string inputText = Console.ReadLine();
            if (!int.TryParse(inputText,
                out firstNumber))
            {
                Console.WriteLine(
                    "Ошибка: введите целое число.");
                continue;
            }
            if (firstNumber == 0)
            {
                Console.WriteLine("Ошибка: число "
                    + "не должно быть нулём.");
                continue;
            }
            break;
        }
        while (true)
        {
            Console.Write("Введите второе число: ");
            string inputText = Console.ReadLine();
            if (!int.TryParse(inputText,
                out secondNumber))
            {
                Console.WriteLine(
                    "Ошибка: введите целое число.");
                continue;
            }
            if (secondNumber == 0)
            {
                Console.WriteLine("Ошибка: число "
                    + "не должно быть нулём.");
                continue;
            }
            break;
        }
        Console.WriteLine("Результат: "
            + isDivisor(firstNumber, secondNumber));
    }

    public bool isDivisor(int a, int b)
    {
        return a % b == 0 || b % a == 0;
    }

    public void Task5()
    {
        int runningSum;
        while (true)
        {
            Console.Write("Введите число 1: ");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText,
                out runningSum))
                break;
            Console.WriteLine(
                "Ошибка: введите целое число.");
        }

        for (int i = 2; i <= 5; i++)
        {
            int number;
            while (true)
            {
                Console.Write("Введите число "
                    + i + ": ");
                string inputText = Console.ReadLine();
                if (int.TryParse(inputText,
                    out number))
                    break;
                Console.WriteLine(
                    "Ошибка: введите целое число.");
            }
            runningSum = lastNumSum(runningSum,
                number);
        }

        Console.WriteLine("Итог: " + runningSum);
    }

    public int lastNumSum(int a, int b)
    {
        return (a % 10) + (b % 10);
    }

    public void Task6()
    {
        int dividend, divisor;
        while (true)
        {
            Console.Write("Введите делимое: ");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText,
                out dividend))
                break;
            Console.WriteLine(
                "Ошибка: введите целое число.");
        }
        while (true)
        {
            Console.Write("Введите делитель: ");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText, out divisor))
                break;
            Console.WriteLine(
                "Ошибка: введите целое число.");
        }
        Console.WriteLine("Результат: "
            + safeDiv(dividend, divisor));
    }

    public double safeDiv(int x, int y)
    {
        if (y == 0) return 0;
        return (double) x / y;
    }

    public void Task7()
    {
        int firstNumber, secondNumber;
        while (true)
        {
            Console.Write("Введите первое число: ");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText,
                out firstNumber))
                break;
            Console.WriteLine(
                "Ошибка: введите целое число.");
        }
        while (true)
        {
            Console.Write("Введите второе число: ");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText,
                out secondNumber))
                break;
            Console.WriteLine(
                "Ошибка: введите целое число.");
        }
        Console.WriteLine("Результат: "
            + makeDecision(firstNumber,
                secondNumber));
    }

    public string makeDecision(int x, int y)
    {
        if (x > y) return x + " > " + y;
        if (x < y) return x + " < " + y;
        return x + " == " + y;
    }

    public void Task8()
    {
        int firstNumber, secondNumber, thirdNumber;
        while (true)
        {
            Console.Write("Введите первое число: ");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText,
                out firstNumber))
                break;
            Console.WriteLine(
                "Ошибка: введите целое число.");
        }
        while (true)
        {
            Console.Write("Введите второе число: ");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText,
                out secondNumber))
                break;
            Console.WriteLine(
                "Ошибка: введите целое число.");
        }
        while (true)
        {
            Console.Write("Введите третье число: ");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText,
                out thirdNumber))
                break;
            Console.WriteLine(
                "Ошибка: введите целое число.");
        }
        Console.WriteLine("Результат: "
            + sum3(firstNumber, secondNumber,
                thirdNumber));
    }

    public bool sum3(int x, int y, int z)
    {
        return x + y == z || x + z == y
            || y + z == x;
    }

    public void Task9()
    {
        int ageValue;
        while (true)
        {
            Console.Write("Введите возраст: ");
            string inputText = Console.ReadLine();
            if (!int.TryParse(inputText,
                out ageValue))
            {
                Console.WriteLine(
                    "Ошибка: введите целое число.");
                continue;
            }
            if (ageValue < 0)
            {
                Console.WriteLine("Ошибка: "
                    + "возраст не может быть "
                    + "отрицательным.");
                continue;
            }
            break;
        }
        Console.WriteLine("Результат: "
            + age(ageValue));
    }

    public string age(int x)
    {
        int lastTwoDigits = x % 100;
        int lastDigit = x % 10;

        if ((lastTwoDigits >= 11)
            && (lastTwoDigits <= 14))
        {
            return x + " лет";
        }
        else if (lastDigit == 1)
        {
            return x + " год";
        }
        else if ((lastDigit == 2) || (lastDigit == 3)
            || (lastDigit == 4))
        {
            return x + " года";
        }
        else
        {
            return x + " лет";
        }
    }

    public void Task10()
    {
        Console.Write("Введите день недели: ");
        string dayName = Console.ReadLine();
        printDays(dayName.ToLower());
    }

    public void printDays(string x)
    {
        switch (x)
        {
            case "понедельник":
                Console.WriteLine("понедельник");
                goto case "вторник";
            case "вторник":
                Console.WriteLine("вторник");
                goto case "среда";
            case "среда":
                Console.WriteLine("среда");
                goto case "четверг";
            case "четверг":
                Console.WriteLine("четверг");
                goto case "пятница";
            case "пятница":
                Console.WriteLine("пятница");
                goto case "суббота";
            case "суббота":
                Console.WriteLine("суббота");
                goto case "воскресенье";
            case "воскресенье":
                Console.WriteLine("воскресенье");
                break;
            default:
                Console.WriteLine(
                    "это не день недели");
                break;
        }
    }

    public void Task11()
    {
        int number;
        while (true)
        {
            Console.Write("Введите число: ");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText, out number))
                break;
            Console.WriteLine(
                "Ошибка: введите целое число.");
        }
        Console.WriteLine("Результат: "
            + reverseListNums(number));
    }

    public string reverseListNums(int x)
    {
        string result = "";
        if (x >= 0)
        {
            for (int i = x; i >= 0; i--)
            {
                result += i;
                if (i > 0) result += " ";
            }
        }
        else
        {
            for (int i = x; i <= 0; i++)
            {
                result += i;
                if (i < 0) result += " ";
            }
        }
        return result;
    }

    public void Task12()
    {
        int baseNumber, exponent;
        while (true)
        {
            Console.Write("Введите основание: ");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText,
                out baseNumber))
                break;
            Console.WriteLine(
                "Ошибка: введите целое число.");
        }
        while (true)
        {
            Console.Write("Введите степень "
                + "(неотрицательную): ");
            string inputText = Console.ReadLine();
            if (!int.TryParse(inputText,
                out exponent))
            {
                Console.WriteLine(
                    "Ошибка: введите целое число.");
                continue;
            }
            if (exponent < 0)
            {
                Console.WriteLine("Ошибка: "
                    + "степень должна быть >= 0.");
                continue;
            }
            break;
        }
        Console.WriteLine("Результат: "
            + pow(baseNumber, exponent));
    }

    public int pow(int x, int y)
    {
        int result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }

    public void Task13()
    {
        int number;
        while (true)
        {
            Console.Write("Введите число: ");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText, out number))
                break;
            Console.WriteLine(
                "Ошибка: введите целое число.");
        }
        Console.WriteLine("Результат: "
            + equalNum(number));
    }

    public bool equalNum(int x)
    {
        if (x < 0) x = -x;

        int firstDigit = x % 10;
        x = x / 10;

        while (x > 0)
        {
            if (x % 10 != firstDigit) return false;
            x = x / 10;
        }
        return true;
    }

    public void Task14()
    {
        int height;
        while (true)
        {
            Console.Write("Введите высоту "
                + "треугольника: ");
            string inputText = Console.ReadLine();
            if (!int.TryParse(inputText,
                out height))
            {
                Console.WriteLine(
                    "Ошибка: введите целое число.");
                continue;
            }
            if (height <= 0)
            {
                Console.WriteLine("Ошибка: "
                    + "число должно быть больше 0.");
                continue;
            }
            break;
        }
        leftTriangle(height);
    }

    public void leftTriangle(int x)
    {
        string line = "";
        for (int i = 0; i < x; i++)
        {
            line += "*";
            Console.WriteLine(line);
        }
    }

    public void Task15()
    {
        guessGame();
    }

    public void guessGame()
    {
        Random random = new Random();
        int secretNumber = random.Next(0, 10);
        int attempts = 0;

        while (true)
        {
            int guess;
            while (true)
            {
                Console.Write("Введите число "
                    + "от 0 до 9: ");
                string inputText = Console.ReadLine();
                if (!int.TryParse(inputText,
                    out guess))
                {
                    Console.WriteLine(
                        "Ошибка: введите "
                        + "целое число.");
                    continue;
                }
                if ((guess < 0) || (guess > 9))
                {
                    Console.WriteLine(
                        "Ошибка: число должно "
                        + "быть от 0 до 9.");
                    continue;
                }
                break;
            }

            attempts++;

            if (guess == secretNumber)
            {
                Console.WriteLine("Вы угадали!");
                break;
            }
            else
            {
                Console.WriteLine("Вы не "
                    + "угадали, введите число "
                    + "от 0 до 9:");
            }
        }

        if (attempts > 4)
            Console.WriteLine("Вы отгадали "
                + "число за " + attempts
                + " попыток");
        else if (attempts == 1)
        {
            Console.WriteLine("Вы отгадали "
                + "число за " + attempts
                + " попытку");
        }
        else
        {
            Console.WriteLine("Вы отгадали "
                + "число за " + attempts
                + " попытки");
        }
    }

    public void Task16()
    {
        int size;
        while (true)
        {
            Console.Write("Введите размер массива: ");
            string inputText = Console.ReadLine();
            if (!int.TryParse(inputText, out size))
            {
                Console.WriteLine(
                    "Ошибка: введите целое число.");
                continue;
            }
            if (size <= 0)
            {
                Console.WriteLine("Ошибка: "
                    + "размер должен быть больше 0.");
                continue;
            }
            break;
        }

        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            while (true)
            {
                Console.Write("Введите элемент "
                    + i + ": ");
                string inputText = Console.ReadLine();
                if (int.TryParse(inputText,
                    out numbers[i])) break;
                Console.WriteLine(
                    "Ошибка: введите целое число.");
            }
        }

        int searchValue;
        while (true)
        {
            Console.Write("Введите число "
                + "для поиска: ");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText,
                out searchValue))
                break;
            Console.WriteLine(
                "Ошибка: введите целое число.");
        }

        Console.WriteLine("Результат: "
            + findLast(numbers, searchValue));
    }

    public int findLast(int[] arr, int x)
    {
        int lastIndex = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                lastIndex = i;
            }
        }
        return lastIndex;
    }

    public void Task17()
    {
        int size;
        while (true)
        {
            Console.Write("Введите размер массива: ");
            string inputText = Console.ReadLine();
            if (!int.TryParse(inputText, out size))
            {
                Console.WriteLine(
                    "Ошибка: введите целое число.");
                continue;
            }
            if (size <= 0)
            {
                Console.WriteLine("Ошибка: "
                    + "размер должен быть больше 0.");
                continue;
            }
            break;
        }

        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            while (true)
            {
                Console.Write("Введите элемент "
                    + i + ": ");
                string inputText = Console.ReadLine();
                if (int.TryParse(inputText,
                    out numbers[i])) break;
                Console.WriteLine(
                    "Ошибка: введите целое число.");
            }
        }

        int valueToInsert;
        while (true)
        {
            Console.Write("Введите число "
                + "для вставки: ");
            string inputText = Console.ReadLine();
            if (int.TryParse(inputText,
                out valueToInsert)) break;
            Console.WriteLine(
                "Ошибка: введите целое число.");
        }

        int position;
        while (true)
        {
            Console.Write("Введите позицию "
                + "(от 0 до " + size + "): ");
            string inputText = Console.ReadLine();
            if (!int.TryParse(inputText,
                out position))
            {
                Console.WriteLine(
                    "Ошибка: введите целое число.");
                continue;
            }
            if ((position < 0) || (position > size))
            {
                Console.WriteLine(
                    "Ошибка: позиция вне диапазона.");
                continue;
            }
            break;
        }

        int[] resultArray = add(numbers,
            valueToInsert, position);

        Console.Write("Результат: [");
        for (int i = 0; i < resultArray.Length; i++)
        {
            Console.Write(resultArray[i]);
            if (i < resultArray.Length - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine("]");
    }

    public int[] add(int[] arr, int x, int pos)
    {
        int[] resultArray = new int[arr.Length + 1];
        int sourceIndex = 0;

        for (int i = 0; i < resultArray.Length; i++)
        {
            if (i == pos)
            {
                resultArray[i] = x;
            }
            else
            {
                resultArray[i] = arr[sourceIndex];
                sourceIndex++;
            }
        }

        return resultArray;
    }

    public void Task18()
    {
        int size;
        while (true)
        {
            Console.Write("Введите размер массива: ");
            string inputText = Console.ReadLine();
            if (!int.TryParse(inputText, out size))
            {
                Console.WriteLine(
                    "Ошибка: введите целое число.");
                continue;
            }
            if (size <= 0)
            {
                Console.WriteLine("Ошибка: "
                    + "размер должен быть больше 0.");
                continue;
            }
            break;
        }

        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            while (true)
            {
                Console.Write("Введите элемент "
                    + i + ": ");
                string inputText = Console.ReadLine();
                if (int.TryParse(inputText,
                    out numbers[i])) break;
                Console.WriteLine(
                    "Ошибка: введите целое число.");
            }
        }

        reverse(numbers);

        Console.Write("Результат: [");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i < numbers.Length - 1)
                Console.Write(" ");
        }
        Console.WriteLine("]");
    }

    public void reverse(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temporary = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temporary;
        }
    }

    public void Task19()
    {
        int firstSize;
        while (true)
        {
            Console.Write("Введите размер "
                + "первого массива: ");
            string inputText = Console.ReadLine();
            if (!int.TryParse(inputText,
                out firstSize))
            {
                Console.WriteLine(
                    "Ошибка: введите целое число.");
                continue;
            }
            if (firstSize <= 0)
            {
                Console.WriteLine("Ошибка: "
                    + "размер должен быть больше 0.");
                continue;
            }
            break;
        }

        int[] firstArray = new int[firstSize];
        for (int i = 0; i < firstSize; i++)
        {
            while (true)
            {
                Console.Write("arr1[" + i + "]: ");
                string inputText = Console.ReadLine();
                if (int.TryParse(inputText,
                    out firstArray[i])) break;
                Console.WriteLine(
                    "Ошибка: введите целое число.");
            }
        }

        int secondSize;
        while (true)
        {
            Console.Write("Введите размер "
                + "второго массива: ");
            string inputText = Console.ReadLine();
            if (!int.TryParse(inputText,
                out secondSize))
            {
                Console.WriteLine(
                    "Ошибка: введите целое число.");
                continue;
            }
            if (secondSize <= 0)
            {
                Console.WriteLine("Ошибка: "
                    + "размер должен быть больше 0.");
                continue;
            }
            break;
        }

        int[] secondArray = new int[secondSize];
        for (int i = 0; i < secondSize; i++)
        {
            while (true)
            {
                Console.Write("arr2[" + i + "]: ");
                string inputText = Console.ReadLine();
                if (int.TryParse(inputText,
                    out secondArray[i])) break;
                Console.WriteLine(
                    "Ошибка: введите целое число.");
            }
        }

        int[] combinedArray = concat(firstArray,
            secondArray);

        Console.Write("Результат: [");
        for (int i = 0; i < combinedArray.Length; i++)
        {
            Console.Write(combinedArray[i]);
            if (i < combinedArray.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] combinedArray = new int[
            arr1.Length + arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            combinedArray[i] = arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            combinedArray[arr1.Length + i] = arr2[i];
        }

        return combinedArray;
    }

    public void Task20()
    {
        int size;
        while (true)
        {
            Console.Write("Введите размер массива: ");
            string inputText = Console.ReadLine();
            if (!int.TryParse(inputText, out size))
            {
                Console.WriteLine(
                    "Ошибка: введите целое число.");
                continue;
            }
            if (size <= 0)
            {
                Console.WriteLine("Ошибка: "
                    + "размер должен быть больше 0.");
                continue;
            }
            break;
        }

        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            while (true)
            {
                Console.Write("Введите элемент "
                    + i + ": ");
                string inputText = Console.ReadLine();
                if (int.TryParse(inputText,
                    out numbers[i])) break;
                Console.WriteLine(
                    "Ошибка: введите целое число.");
            }
        }

        int[] positiveNumbers =
            deleteNegative(numbers);

        Console.Write("Результат: [");
        for (int i = 0;
            i < positiveNumbers.Length; i++)
        {
            Console.Write(positiveNumbers[i]);
            if (i < positiveNumbers.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    public int[] deleteNegative(int[] arr)
    {
        int positiveCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0) positiveCount++;
        }

        int[] positiveNumbers =
            new int[positiveCount];
        int resultIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                positiveNumbers[resultIndex] =
                    arr[i];
                resultIndex++;
            }
        }

        return positiveNumbers;
    }
}
