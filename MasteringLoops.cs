using System;

namespace MasteringLoops
{
	internal class MasteringLoops
	{
		static void Main(string[] args)
		{
			Console.Write("Введите сообщение: ");
			string message = Console.ReadLine();
			Console.Write("Введите количество повторений: ");
			int numberRepitions = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < numberRepitions; ++i)
				Console.WriteLine(message);
		}
	}
}
