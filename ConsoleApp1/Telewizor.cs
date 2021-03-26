using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class Telewizor
	{
		public string[] telewizorKanal1;
		public string[] telewizorKanal2;

		public void odpalKanal1()
		{
			int line = 0;
			for (int i = 0; i < telewizorKanal1.Length; i++)
			{
				Console.WriteLine(telewizorKanal1[line]);
				line++;
			}
		}
		public void odpalKanal2()
		{
			int line = 0;
			for (int i = 0; i < telewizorKanal2.Length; i++)
			{
				Console.WriteLine(telewizorKanal2[line]);
				line++;
			}
		}
	}
}
