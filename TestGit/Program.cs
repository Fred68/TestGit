using System;
using System.Text;

namespace TestGit
	{
	class Program
		{
		static void Main(string[] args)
			{
			Console.WriteLine("Hello World!");
			string s = Console.ReadLine();
			Console.WriteLine(Dati(s));
			Console.ReadKey();
			}

		public static string Dati(string x)
			{
			StringBuilder strb = new StringBuilder();
			strb.Append("Messaggio: ");
			strb.Append(x);
			strb.Append("!");
			return strb.ToString();
			}

		}


	
	}


