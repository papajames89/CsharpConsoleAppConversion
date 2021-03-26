using System;
using System.IO;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Program stworzyl: Grzegorz Rzeszut";
			char znak;
			char znak2;
			Telewizor kanal1 = new Telewizor();
			Telewizor kanal2 = new Telewizor();
			kanal1.telewizorKanal1 = File.ReadAllLines(@"tv_kanal1.txt");
			kanal2.telewizorKanal2 = File.ReadAllLines(@"tv_kanal2.txt");

			Ksiazka ksiazka1 = new Ksiazka();
			Ksiazka ksiazka2 = new Ksiazka();
			ksiazka1.ksiazkaZamknieta = File.ReadAllLines(@"ksiazka1.txt");
			ksiazka2.ksiazkaOtwarta = File.ReadAllLines(@"ksiazka2.txt");

			Zarowka zarowka1 = new Zarowka();
			Zarowka zarowka2 = new Zarowka();
			zarowka1.zarowka1 = File.ReadAllLines(@"zarowka1.txt");
			zarowka2.zarowka2 = File.ReadAllLines(@"zarowka2.txt");


			int caseSwitch = 1;
			switch (caseSwitch)
			{
				case 1:
					Console.Clear();
					zarowka1.kolorOFF();
					Console.WriteLine("Wybierz przedmiot: ");
					Console.WriteLine();
					Console.WriteLine("1. Telewizor");
					Console.WriteLine("2. Ksiazka");
					Console.WriteLine("3. Zarowka");
					Console.WriteLine("4. Konwersja znaku");
					Console.WriteLine();
					znak = Console.ReadKey().KeyChar;
					if (znak == '1') { goto case 2; }
					else if (znak == '2') { goto case 4; }
					else if (znak == '3') { goto case 6; }
					else if (znak == '4') { goto case 8; }
					else
					{
						Console.Clear();
						Console.WriteLine("Bledny znak - wybierz 1, 2 lub 3");
						Console.WriteLine();
						System.Threading.Thread.Sleep(2000);
						goto case 1;
					}
					break;
				case 2:
					Console.Clear();
					kanal1.odpalKanal1();
					Console.WriteLine();
					Console.WriteLine("1. Zmien kanal");
					Console.WriteLine("2. Wroc do menu glownego");
					Console.WriteLine();
					znak = Console.ReadKey().KeyChar;
					if (znak == '1') { goto case 3; }
					else if (znak == '2') { goto case 1; }
					else
					{
						Console.Clear();
						Console.WriteLine("Bledny znak - wybierz 1 lub 2");
						Console.WriteLine();
						System.Threading.Thread.Sleep(2000);
						goto case 2;
					}
					break;
				case 3:
					Console.Clear();
					kanal2.odpalKanal2();
					Console.WriteLine();
					Console.WriteLine("1. Zmien kanal");
					Console.WriteLine("2. Wroc do menu glownego");
					Console.WriteLine();
					znak = Console.ReadKey().KeyChar;
					if (znak == '1') { goto case 2; }
					else if (znak == '2') { goto case 1; }
					else
					{
						Console.Clear();
						Console.WriteLine("Bledny znak - wybierz 1 lub 2");
						Console.WriteLine();
						System.Threading.Thread.Sleep(2000);
						goto case 3;
					}
					break;
				case 4:
					Console.Clear();
					ksiazka1.pokazKsiazke();
					Console.WriteLine();
					Console.WriteLine("1. Otworz Ksiazke");
					Console.WriteLine("2. Wroc do menu glownego");
					Console.WriteLine();
					znak = Console.ReadKey().KeyChar;
					if (znak == '1') { goto case 5; }
					else if (znak == '2') { goto case 1; }
					else
					{
						Console.Clear();
						Console.WriteLine("Bledny znak - wybierz 1 lub 2");
						Console.WriteLine();
						System.Threading.Thread.Sleep(2000);
						goto case 4;
					}
					break;
				case 5:
					Console.Clear();
					ksiazka2.otworzKsiazke();
					Console.WriteLine();
					Console.WriteLine("1. Zamknij ksiazke");
					Console.WriteLine("2. Wroc do menu glownego");
					Console.WriteLine();
					znak = Console.ReadKey().KeyChar;
					if (znak == '1') { goto case 4; }
					else if (znak == '2') { goto case 1; }
					else
					{
						Console.Clear();
						Console.WriteLine("Bledny znak - wybierz 1 lub 2");
						Console.WriteLine();
						System.Threading.Thread.Sleep(2000);
						goto case 5;
					}
					break;
				case 6:
					Console.Clear();
					zarowka1.kolorOFF();
					zarowka1.pokazZarowke();
					Console.WriteLine();
					Console.WriteLine("1. Zaswiec zarowke");
					Console.WriteLine("2. Wroc do menu glownego");
					Console.WriteLine();
					znak = Console.ReadKey().KeyChar;
					if (znak == '1') { goto case 7; }
					else if (znak == '2') { goto case 1; }
					else
					{
						Console.Clear();
						Console.WriteLine("Bledny znak - wybierz 1 lub 2");
						System.Threading.Thread.Sleep(2000);
						Console.WriteLine();
						goto case 6;
					}
					break;
				case 7:
					Console.Clear();
					zarowka1.kolorON();
					zarowka2.zaswiecZarowke();
					Console.WriteLine();
					Console.WriteLine("1. Zgas zarowke");
					Console.WriteLine("2. Wroc do menu glownego");
					Console.WriteLine();
					znak = Console.ReadKey().KeyChar;
					if (znak == '1') { goto case 6; }
					else if (znak == '2') { goto case 1; }
					else
					{
						Console.Clear();
						Console.WriteLine("Bledny znak - wybierz 1 lub 2");
						Console.WriteLine();
						System.Threading.Thread.Sleep(2000);
						goto case 7;
					}
					break;
				case 8:
					Console.Clear();
					Console.WriteLine("Wybierz przedmiot: ");
					Console.WriteLine();
					Console.WriteLine("1. Telewizor");
					Console.WriteLine("2. Ksiazka");
					Console.WriteLine("3. Zarowka");
					Console.WriteLine("4. Wroc do menu glownego");
					znak = Console.ReadKey().KeyChar;
					if (znak != '1' && znak != '2' && znak != '3' && znak != '4')
					{
						Console.Clear();
						Console.WriteLine("Bledny znak - wybierz 1,2,3 lub 4");
						Console.WriteLine();
						System.Threading.Thread.Sleep(2000);
						goto case 8;
					}
					else if (znak == '4')
					{
						goto case 1;
					}
					Console.WriteLine();
					Console.WriteLine("Wybierz znak");
					znak2 = Console.ReadKey().KeyChar;
					Console.WriteLine();
					if (znak == '1')
					{
						Console.Clear();
						string str = string.Join('X', kanal1.telewizorKanal1);
						string newstr = string.Empty;

						foreach (char item in str)
						{
							if (item != ' ' && item != 'X')
							{
								newstr = newstr + znak2;
							}
							else
							{
								newstr = newstr + item;
							}
						}
						string[] str1 = newstr.Split('X');
						int line = 0;
						for (int i = 0; i < str1.Length; i++)
						{
							Console.WriteLine(str1[line]);
							line++;
						}
						System.Threading.Thread.Sleep(2000);
						goto case 8;
					}
					else if (znak == '2')
					{
						Console.Clear();
						string str = string.Join('X', ksiazka1.ksiazkaZamknieta);
						string newstr = string.Empty;

						foreach (char item in str)
						{
							if (item != ' ' && item != 'X')
							{
								newstr = newstr + znak2;
							}
							else
							{
								newstr = newstr + item;
							}
						}
						string[] str1 = newstr.Split('X');
						int line = 0;
						for (int i = 0; i < str1.Length; i++)
						{
							Console.WriteLine(str1[line]);
							line++;
						}
						System.Threading.Thread.Sleep(2000);
						goto case 8;
					}
					else if (znak == '3')
					{
						Console.Clear();
						string str = string.Join('X', zarowka1.zarowka1);
						string newstr = string.Empty;

						foreach (char item in str)
						{
							if (item != ' ' && item != 'X')
							{
								newstr = newstr + znak2;
							}
							else
							{
								newstr = newstr + item;
							}
						}
						string[] str1 = newstr.Split('X');
						int line = 0;
						for (int i = 0; i < str1.Length; i++)
						{
							Console.WriteLine(str1[line]);
							line++;
						}
						System.Threading.Thread.Sleep(2000);
						goto case 8;
					}
					else
					{
						goto case 8;
					}
					break;
				default:
					break;
			}
		}	
	}
}
