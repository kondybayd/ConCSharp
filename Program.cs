namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            //Main
            Hello();
            Hello();
            Hello();
            Hello(3);
            Hello(4);

            //TasksFunctions




            //Functions
            /*Greetings();
            AgeOfUSer(20);

            static void Greetings()
            {
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.WriteLine($"Heeloo {name}");
            }

            static void AgeOfUSer(int age)
            {
                Console.WriteLine($"Your age - {age}");
            }*/



            //Task1
            /*Console.Write("Login:");
            string login = Console.ReadLine();
            bool isItOk = false;
            for (int i = 0; i < login.Length; i++)
            {
                if (login != null)
                {
                    if (login.Length >= 4 && login.Length <= 12)
                    {
                        if (char.IsLetter(login[0]))
                            if (char.IsLetterOrDigit(login[i]))
                            {
                                isItOk = true;

                            }
                    }
                }
                else Console.WriteLine("Errror");
            
            }
            if (isItOk) Console.WriteLine("Логин принят");
            else Console.WriteLine("Ошибка: логин должен начинаться с буквы и содержать только буквы и цифры");*/

            //Task4
            /*Console.Write("Password:");
            bool PassIsDigit = false;
            string userPasswd = Console.ReadLine();
            for (int i = 0; i < userPasswd.Length; i++) {

                if (char.IsDigit(userPasswd[i])) 
                {
                    
                    PassIsDigit = true;
                    Console.WriteLine("Pass is OK");
                    break;
                }
                else Console.WriteLine("Error passwd");
            }*/
            //Task3
            /*Console.Write("Name:");
            string userName = Console.ReadLine();
            userName = userName.ToUpper();
            Console.WriteLine(userName);*/


            //Task2
            /*Console.Write("Email:");
            string userEmail = Console.ReadLine();
            if (userEmail.Contains("@") && userEmail.Contains(".") && userEmail.Length >= 6)
            {
                Console.WriteLine("Everything is OK");
            }
            else Console.WriteLine("Invalid Email");*/

            //Task1
            /* Console.Write("String:");
             string userStr = Console.ReadLine();
             int LenghtOfUserStr = userStr.Length;
             Console.WriteLine($"Length of ***{userStr}*** - {LenghtOfUserStr}");*/



            //Task3
            /*Console.Write("Какой месяц(1-12):");
            int numOfMonth = Convert.ToInt32(Console.ReadLine());
            if (numOfMonth == 1 && numOfMonth == 2 && numOfMonth == 12) Console.WriteLine("Сейчас Зима");
            else if (numOfMonth == 3 && numOfMonth == 4 && numOfMonth == 5) Console.WriteLine("Сейчас весна");
            else if (numOfMonth == 6 && numOfMonth == 7 && numOfMonth == 8) Console.WriteLine("Сейчас лето");
            else Console.WriteLine("Сейчас осень");*/

            /*Task2
             * int balans = 1000; // Вынесли баланс из цикла!

            while (true)
            {
                Console.WriteLine("What do you want?");
                Console.WriteLine("1 - показать баланс");
                Console.WriteLine("2 - пополнить");
                Console.WriteLine("3 - снять");
                Console.WriteLine("4 - выход");

                int oper = Convert.ToInt32(Console.ReadLine());

                switch (oper)
                {
                    case 1:
                        Console.WriteLine($"Ваш баланс: {balans}");
                        break;

                    case 2:
                        Console.Write("Пополнить счет на: ");
                        int popolnit = Convert.ToInt32(Console.ReadLine());

                        balans = balans + popolnit; // <-- главное изменение

                        Console.WriteLine($"Вы пополнили на: {popolnit}");
                        Console.WriteLine($"Баланс: {balans}");
                        break;

                    case 3:
                        Console.Write("Снять: ");
                        int snyat = Convert.ToInt32(Console.ReadLine());

                        if (snyat > balans)
                        {
                            Console.WriteLine("Недостаточно средств!");
                        }
                        else
                        {
                            balans = balans - snyat; // <-- главное изменение
                            Console.WriteLine($"Вы сняли: {snyat}");
                            Console.WriteLine($"Баланс: {balans}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Вы вышли.");
                        return;  // завершить программу

                    default:
                        Console.WriteLine("Неправильная команда!");
                        break;
                }
            }*/

            /*Task1
            string login = "duman";
            string passwd = "passwd111";

            int num = 0;
            int tries = 3;
            while (true)
            {
                if (num < tries)
                {
                    Console.Write("Login:");
                    string log = Console.ReadLine();
                    Console.Write("Password:");
                    string pass = Console.ReadLine();
                    if (log == login && pass == passwd)
                    {
                        Console.WriteLine("Добро пожаловать");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неправильный логин или пароль");
                    }
                    num++;
                }
                else
                {
                    Console.WriteLine("Доступ заблокирован");
                    break;
                }
            }*/



            /*while (true)
            {
                string mail = "duman@gmail.com";
                string password = "pass12345";

                Console.Write("Mail:");
                string mailCheck = Console.ReadLine();

                Console.Write("Pass:");
                string passCheck = Console.ReadLine();
                if (mailCheck == mail)
                {
                    if (passCheck == password) Console.WriteLine("Welcome!");
                    else Console.WriteLine("Wrong mail or password");
                }
                else Console.WriteLine("Wrong mail");
            }*/

            /*while(true) {
            Console.Write("Num1:");
            double userNum1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Num2:");
            double userNum2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("What to do(+,-,*,/) - ");
            string oper = Console.ReadLine();
            char operate = oper[0];
                switch (operate)
                {
                    case '+':
                        Console.WriteLine($"{userNum1 + " " + userNum2} = {userNum1 + userNum2}");
                        break;
                    case '-':
                        double minus = userNum1 - userNum2;
                        Console.WriteLine($"{userNum1} - {userNum2} = {minus}");
                        break;
                    case '*':
                        double kobeitu = userNum1 * userNum2;
                        Console.WriteLine($"{userNum1} * {userNum2} = {kobeitu}");
                        break;
                    case '/':
                        double bolu = userNum1 / userNum2;
                        Console.WriteLine($"{userNum1} / {userNum2} = {bolu}");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }*/


            /*Console.Write("Num1:");
            int userNMax = Convert.ToInt32(Console.ReadLine());
            Console.Write("Num2:");
            int userNMax2 = Convert.ToInt32(Console.ReadLine());
            if (userNMax > userNMax2) Console.WriteLine($"{userNMax} is Bigger");
            else if (userNMax < userNMax2) Console.WriteLine($"{userNMax2} is Bigger");
            else Console.WriteLine("Numbers equal!");*/

            /*Console.Write("num:");
            int oddCheck = Convert.ToInt32(Console.ReadLine());
            if (oddCheck % 2 == 0) Console.WriteLine($"{oddCheck} is Odd!");
            else Console.WriteLine($"{oddCheck} is Even!");*/

            /*Console.Write("Age:");
            int userAge = Convert.ToInt32(Console.ReadLine());
            int nextYear = userAge + 1;
            Console.WriteLine($"Next year you will be {nextYear} years old!");*/

            /*Console.Write("name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");*/


            /* Task2
             Console.Write("a = ");
             double a = Convert.ToDouble(Console.ReadLine());
             Console.Write("b = ");
             double b = Convert.ToDouble(Console.ReadLine());
             double c = a * b;
             Console.WriteLine($"Площадь прямоугольника - {c}");*/

            /*Task1
            Console.Write("Num1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("num2:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 + num2;
            double def = num1 - num2;
            double kobeitu = num1 * num2;
            double bolu = num1 / num2;
            Console.WriteLine($"{num1} + {num2} = {sum}");
            Console.WriteLine($"{num1} - {num2} = {def}");
            Console.WriteLine($"{num1} * {num2} = {kobeitu}");
            Console.WriteLine($"{num1} / {num2} = {bolu}");*/



        }

        static void Hello()
        {
            Console.WriteLine("Hello");
        }

        static void Hello(int repeat)
        {
            for (int i = 0; i <= repeat; i++)
            {
                Console.WriteLine("Hello");
            }
        } }
    }
