using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class Ksiazka
	{
		public string[] ksiazkaZamknieta;
		public string[] ksiazkaOtwarta;

		public void pokazKsiazke()
		{
			int line = 0;
			for (int i = 0; i < ksiazkaZamknieta.Length; i++)
			{
				Console.WriteLine(ksiazkaZamknieta[line]);
				line++;
			}
		}
		public void otworzKsiazke()
		{
			int line = 0;
			for (int i = 0; i < ksiazkaOtwarta.Length; i++)
			{
				Console.WriteLine(ksiazkaOtwarta[line]);
				line++;
			}
		}
	}
}
