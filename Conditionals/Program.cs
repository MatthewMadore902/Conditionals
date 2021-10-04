using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
	class Program
	{
		static int score = 0;
		static int Lives = 3;
		static bool oneUpGained = false;
		static void Main(string[] args)
		{
			ShowHUD();

			score = score + 1000000;

			ShowHUD();

			// if player did not gain a 1 up
			if (oneUpGained == false)
			{
				// check for 1mil points
				if (score >= 1000000)
				{
					Lives = Lives + 1; //one up rewarded 
					oneUpGained = true;
				}

			}




			ShowHUD();

			Console.ReadKey(true);
		}



		static void ShowHUD()
		{
			Console.WriteLine("Score: " + score);
			Console.WriteLine("Lives: " + Lives);
		}
	}
}
