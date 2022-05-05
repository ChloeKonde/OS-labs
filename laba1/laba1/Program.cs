// вариант 4
using System;
using System.Diagnostics;

namespace laba1
{
	class Program
	{
		static void Main(string[] args)
		{
			if(args.Length > 0) 
			{
				Console.WriteLine(args[0]);
				// Console.WriteLine(args[1]);

			}

			Process myProcess = new Process();

			try
			{
				myProcess.StartInfo.UseShellExecute = false;

				myProcess.StartInfo.FileName = args[0];
				myProcess.StartInfo.Arguments = args[1];
				myProcess.Start();

				Console.WriteLine("Дочерний процесс запущен. Ждём его окончания...");

				myProcess.WaitForExit();

				Console.WriteLine("Дочерний процесс закончен.");

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
