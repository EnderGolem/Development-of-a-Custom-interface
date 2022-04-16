/* Example:
Формат консольной строки
Название каталога    маска1   маска2 .... маскаN
Введенный каталог:
d:\Users\Григорий\Desktop\Лабараторные ПТ\CONSOLE\CONSOLE\bin\Debug
Size = 0 for mask: .cs
Size = 6144 for mask: .exe
*/

using System;
using System.Collections.Generic;
using System.Linq;

using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
	class Program
	{
		private static Regex makeRegex(string from)
		{
			Regex regex = new Regex(from.Replace("*", "[.]").Replace("?", ".").Replace("*", ".*").Replace("#", @"\d") + "$");
			return regex;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Формат консольной строки");
			Console.WriteLine("Название каталога    маска1   маска2 .... маскаN");
			if(args.Length == 0)
            {
				Console.WriteLine("Ничего не было введено");
				Console.WriteLine("Нажмите Enter для завершения программы");
				Console.ReadLine();
				return;
            }
			string s1 = args[0];
			string s2 = "";
			if (s1.Contains("dir"))
			{
				
				s1 = s1.Replace("dir", Directory.GetCurrentDirectory());
			}
			Console.WriteLine("Введенный каталог:");
			Console.WriteLine(s1);

			if (!Directory.Exists(s1))
			{
				Console.WriteLine("Такого каталога не существует");
				Console.WriteLine("Нажмите Enter для завершения программы");
				Console.ReadLine();
				return;
			}

			if (args.Length == 1)
				s2 = "*.*";
			else
				s2 = args[1];

			printFileMask(s1, s2);
			for (int i = 2; i < args.Length; i++)
			{
				printFileMask(s1, args[i]);
			}
			Console.ReadLine();
		}

		private static void printFileMask(string s1, string s2)
		{
			Regex regex = makeRegex(s2);
			Queue<string> sf = new Queue<string>();
			sf.Enqueue(s1);
			long size = 0;
			while (sf.Count > 0)
			{
				var now = sf.Dequeue();
				var gd = Directory.GetDirectories(now);
				var gf = Directory.GetFiles(now);
				foreach (var x in gd)
				{
					sf.Enqueue(x);
				}

				foreach (var x in gf)
				{
					if (regex.IsMatch(x))
					{
						size += new FileInfo(x).Length;
					}
				}
			}
			Console.WriteLine("Size = {0} for mask: {1}", size, s2);
		}
	}
}
