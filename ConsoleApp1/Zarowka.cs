using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
class Zarowka
	{
		public string[] zarowka1;
		public string[] zarowka2;

		public void kolorON()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
		}
		public void kolorOFF()
		{
			Console.ForegroundColor = ConsoleColor.White;
		}
		public void pokazZarowke()
		{
			int line = 0;
			for (int i = 0; i < zarowka1.Length; i++)
			{
				Console.WriteLine(zarowka1[line]);
				line++;
			}
		}
		public void zaswiecZarowke()
		{
			int line = 0;
			for (int i = 0; i < zarowka2.Length; i++)
			{
				Console.WriteLine(zarowka2[line]);
				line++;
			}
		}
	}
}
