using System.Text;

namespace Practic_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;

            List<Parallelogram> figures = new List<Parallelogram>();
            Random rnd = new Random();

            int menu = 0;
            do
            {
                Console.WriteLine("1. Показати фігури");
                Console.WriteLine("2. Додати фігуру");
                Console.WriteLine("3. Розрахувати площу усіх фігур");
                Console.WriteLine("0. Вихід");

                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    if (figures.Count == 0)
                    {
                        Console.WriteLine("У масиві немає фігур!");
                    }
                    else
                    {
                        figures.ForEach(figure => { Console.WriteLine(figure.ToString()); });
                    }
                }
                else if (menu == 2)
                {
                    int type = rnd.Next(1, 3);
                    Parallelogram newFigure = null;

                    if (type == 1)
                    {
                        newFigure = new Rectangle(rnd.Next(1, 11), rnd.Next(1, 11));
                    }
                    else
                    {
                        newFigure = new Square(rnd.Next(1, 11));
                    }

                    figures.Add(newFigure);
                }
                else if (menu == 3)
                {
                    if (figures.Count == 0)
                    {
                        Console.WriteLine("У масиві немає фігур!");
                    }
                    else
                    {
                        foreach (Parallelogram figure in figures)
                        {
                            Console.WriteLine($"{figure.ToString()} \nПлоща: {figure.GetArea()}");
                        }
                    }
                }

            } while (menu != 0);
        }
    }
}
