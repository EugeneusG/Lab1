using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
	class Program
	{
		/*		static void Main(string[] args)
				{
					Console.Write("Введите номер задания: ");
					int caseSwitch = int.Parse(Console.ReadLine());
					int a = 0, b = 0, c = 0;
					double d = 0, e = 0, f = 0;
					switch (caseSwitch)
					{
						case 1:
							Console.WriteLine("Введите значения переменных a и b: ");
							Console.Write("a = ");
							a = int.Parse(Console.ReadLine());
							Console.Write("b = ");
							b = int.Parse(Console.ReadLine());
							Console.WriteLine($"{a} + {b} = {a + b}");
							break;
						case 2:
							Console.WriteLine("Введите значения переменных a, b и c: ");
							Console.Write("a = ");
							a = int.Parse(Console.ReadLine());
							Console.Write("b = ");
							b = int.Parse(Console.ReadLine());
							Console.Write("c = ");
							c = int.Parse(Console.ReadLine());
							Console.WriteLine($"{a} + {b} + {c} = {c} + {b} + {a}");
							break;
						case 3:
							Console.WriteLine("Введите значения переменных a, b и c: ");
							Console.Write("a = ");
							a = int.Parse(Console.ReadLine());
							Console.Write("b = ");
							b = int.Parse(Console.ReadLine());
							Console.Write("c = ");
							c = int.Parse(Console.ReadLine());
							Console.WriteLine($"{a} + {b} + {c} = {a + b + c}");
							break;
						case 4:
							Console.WriteLine("Введите значения переменных d и e: ");
							Console.Write("d = ");
							d = double.Parse(Console.ReadLine());
							Console.Write("e = ");
							e = double.Parse(Console.ReadLine());
							Console.WriteLine($"{d} * {e} = {d * e}");
							break;
						case 5:
							Console.WriteLine("Введите значения переменных d и e: ");
							Console.Write("d = ");
							d = double.Parse(Console.ReadLine());
							Console.Write("e = ");
							e = double.Parse(Console.ReadLine());
							f = d / e;
							Console.Write($"{d} / {e} = ");
							Console.WriteLine("{0:##.###}", f);
							break;
						case 6:
							Console.WriteLine("Введите значения переменных d, e и f: ");
							Console.Write("d = ");
							d = double.Parse(Console.ReadLine());
							Console.Write("e = ");
							e = double.Parse(Console.ReadLine());
							Console.Write("f = ");
							f = double.Parse(Console.ReadLine());
							Console.WriteLine($"({d} + {e}) + {f} = {d} + ({e} + {f})");
							Console.WriteLine("N Format:({0,5:N} + {1,5:N}) + {2,5:N} = {0,5:N} + ({1,5:N} + {2,5:N})", d, e, f);
							break;
					}

				}*/
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			string count = "";
			int timer = 0;
			while(number > 0)
			{
				int i = number % 2;
				count += i.ToString();
				number /= 2;
			}
			string output = "";
			for (int i = count.Length - 1; i >= 0; i--)
			{
				output += count[i];
				if (count[i] == '1') timer++;
			}
			Console.WriteLine("Двоичное число: " + output);
			Console.WriteLine("Единиц в двоичном числе: " + timer);
			//Console.WriteLine("Количество единиц = " + count);
			Console.Read();
		}
	}
}