using System;

namespace UserNameDataTask
{
	class Program
	{
		static void Main(string[] args)
		{
			// Programm palub kastuajal sisestada eesnime;
			// Programm palun kastuajal sisestada number 1-3;
			// Kui kastuaja sisestab 1, siis kuvab kastuaja eesnime tagurpidi;
			// Kui kastuaja sisestab 2, siis kuvab kastuaja eesnime esimese tähe;
			// Kui kastuaja sisestab 3, siis kuvab kastuaja eesnime pikkuse;

			Console.WriteLine("Palun sisesta eesnimi:");
			string userName = Console.ReadLine();

			bool userLoop = true;

			while (userLoop)
			{
				Console.WriteLine("Palun sisesta arv 1-3:");
				int userNumber = Convert.ToInt32(Console.ReadLine());

				if (userNumber == 1)
				{
					GetUserNameReverse(userName);
					break;
				}
				else if (userNumber == 2)
				{
					GetUserNameFirst(userName);
					break;
				}
				else if (userNumber == 3)
				{
					GetUserNameLength(userName);
					break;
				}
				else
				{
					Console.WriteLine("Vale valik, Proovi uuesti!");
				}
			}

		}
		public static void GetUserNameReverse(string userInput)
		{
			for (int i = userInput.Length - 1; i >= 0; i--)
			{
				Console.Write(userInput[i]);
			}
		}

		public static void GetUserNameFirst(string userInput)
		{

			Console.WriteLine($"Sinu eesnimne esimene täht on {userInput[0]}");
		}

		public static void GetUserNameLength(string userInput)
		{
			Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk");
		}
	}

}	
