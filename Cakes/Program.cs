using Cakes;
using System.Reflection.Metadata.Ecma335;

namespace cakes
{
    internal class Program
    {
        static string final_text;
        static int all_cost;
        static void Main(string[] args)
        {
            first_menu();
        }
        static void first_menu_text()
        {
            Console.WriteLine("Выберите параметры торта");
            Console.WriteLine("-------------------------");
            Console.WriteLine("  Форма");
            Console.WriteLine("  Размер");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Цена: ");
            Console.WriteLine("Ваш торт: ");
        }
        static int first_menu()
        {
            Console.CursorVisible = false;
            int position = 2;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position > 8)
                    {
                        position = 8;
                    }
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position < 2)
                    {
                        position = 2;
                    }
                }
                Console.Clear();
                first_menu_text();
                Console.SetCursorPosition(0, position);
                Console.Write("->");

                if (position == 8 & key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Спачибо за заказ! Чтобы сделать еще один нажите Esc");
                    Console.WriteLine("Цена вашего торта - " + all_cost);
                    Console.WriteLine("Ваш заказ - " + final_text);
                    File.AppendAllText("C:\\Users\\egork\\OneDrive\\Рабочий стол\\Заказ.txt", "\nЗаказ от: " + DateTime.Now + "\n");
                    File.AppendAllText("C:\\Users\\egork\\OneDrive\\Рабочий стол\\Заказ.txt", "Заказ: " + final_text + "\n");
                    File.AppendAllText("C:\\Users\\egork\\OneDrive\\Рабочий стол\\Заказ.txt", "Цена: " + all_cost + "\n");


                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        first_menu();
                    }
                }
                if (key.Key == ConsoleKey.Enter & position != 8)
                {
                    Console.Clear();
                    second_menu(position);
                }
                Console.SetCursorPosition(7, 10);
                Console.WriteLine(all_cost);
                Console.SetCursorPosition(10, 11);
                Console.WriteLine(final_text);
            }
            return position;
        }
        static void second_menu_text(int position)
        {
            foreach (parameters i in parameters())
            {
                if (i.pos == position)
                {
                    Console.Clear();
                    Console.WriteLine(i.one);
                    Console.WriteLine(i.two);
                    Console.WriteLine(i.three);
                }
            }
        }

        static void costs(int position, int position1)
        {
            foreach (Cost i in cost())
            {
                if (i.pos_cost == position)
                {
                    if (position1 == 0)
                        all_cost += i.one_cost;
                    else if (position1 == 1)
                        all_cost += i.two_cost;
                    else if (position1 == 2)
                        all_cost += i.three_cost;
                }
            }
        }
        static void final_name(int position, int position1)
        {
            foreach (parameters i in parameters())
            {
                if (i.pos == position)
                {
                    if (position1 == 0)
                        final_text += i.one;
                    else if (position1 == 1)
                        final_text += i.two;
                    else if (position1 == 2)
                        final_text += i.three;
                }
            }
        }

        static void second_menu(int position)
        {
 
            int position1 = 0;
            Console.CursorVisible = false;
            while (true)
            {
                ConsoleKeyInfo key1 = Console.ReadKey();
                if (key1.Key == ConsoleKey.UpArrow)
                {
                    position1--;
                    if (position1 < 0)
                    {
                        position1 = 0;
                    }
                }
                if (key1.Key == ConsoleKey.DownArrow)
                {
                    position1++;
                    if (position1 > 2)
                    {
                        position1 = 2;
                    }
                }
                second_menu_text(position);
                Console.SetCursorPosition(0, position1);
                Console.Write("->");
                if (key1.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    costs(position, position1);
                    final_name(position, position1);
                    first_menu();
                }
            }
        }


        static parameters[] parameters()
        {
            parameters form = new parameters("  Круглый - 1000", "  Квадратный - 1500", "  Овальный - 3000", 2);
            parameters size = new parameters("  Малкенький - 1000", "  Средний - 1500", "  Большой - 3000", 3);
            parameters taste = new parameters("  Малина - 1000", "  Клубника - 1500", "  Ваниль - 3000", 4);
            parameters amount = new parameters("  Три коржа - 1000", "  Четыре коржа - 1500", "  Пять коржей - 3000", 5);
            parameters glaze = new parameters("  Белая - 1000", "  Синяя - 1500", "  Желтая - 3000", 6);
            parameters decor = new parameters("  Орехи - 1000", "  Съедобная бумага - 1500", "  Посыпка - 3000", 7);
            parameters[] parameters = new parameters[6];
            parameters[0] = form;
            parameters[1] = size;
            parameters[2] = taste;
            parameters[3] = amount;
            parameters[4] = glaze;
            parameters[5] = decor;
            return parameters;
        }
        static Cost[] cost()
        {
            Cost form_one = new Cost(1000, 1500, 3000, 2);
            Cost size_one = new Cost(1000, 1500, 3000, 3);
            Cost taste_one = new Cost(1000, 1500, 3000, 4);
            Cost amount_one = new Cost(1000, 1500, 3000, 5);
            Cost glaze_one = new Cost(1000, 1500, 3000, 6);
            Cost decor_one = new Cost(1000, 1500, 3000, 7);
            Cost[] cost = new Cost[6];
            cost[0] = form_one;
            cost[1] = size_one;
            cost[2] = taste_one;
            cost[3] = amount_one;
            cost[4] = glaze_one;
            cost[5] = decor_one;

            return cost;
        }
    }
}


