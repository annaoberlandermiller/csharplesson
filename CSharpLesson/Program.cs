using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson
{ struct gamer
{
	public string name;
	public int favnbr;
}

	class Program
	{
		static void Main(string[] args)
		{
			int a = (23 * 37);
			int b = a - 41;
			int c = b / 7;
			Console.WriteLine(c);

			//Use this one professionally.  This way you can change the variable without the changing the equation.
			int w = 23;
			int x = 17;
			int y = 41;
			int z = 7;
			int ans = ((w * x) - y) / z;
			//Remember, don't actually name variables with a letter, be descriptive.


			int DaysAYear = 365;
			int MyAge = 26;
			int DaysOld = (DaysAYear * MyAge);
			//Finish this tonight - try to figure out how anyone could enter info in and get their actual # of days alive


			string name = "Anna";
			int days = 6;
			string msg = "My name is " + name + ". " + "I've been in the .NET bootcamp for " + days + " days.";
			Console.WriteLine(msg);


			int[] frames = new int[10];
			frames[0] = 30;
			frames[1] = 17;
			frames[2] = 10;
			frames[3] = 15;
			frames[4] = 26;
			frames[5] = 7;
			frames[6] = 28;
			frames[7] = 20;
			frames[8] = 6;
			frames[9] = 4;
			int game = 0;
			//Console.WriteLine(game);

			foreach (int frm in frames) { game = game + frm; }
			Console.WriteLine(game);

			//string[] names = { "Greg," "Michael", "Dan", "Anna", "Marcus", "Foster", "Jermaine", "Mitchell", "Jonathan", "Larry", "William"; }
			//foreach(string aname in names) {
			//Console.WriteLine("Hi " + aname);}

			string[] info = { "Anna", "Miller", "Cincinnati, OH", "oberlanderannas@gmail.com" }; 
			foreach (string item in info) {
				Console.WriteLine(item);
			}

			
			
		gamer ken; 
		ken.name = "Ken";
		ken.favnbr = 10;
		gamer nick;
		nick.name = "Nick";
		nick.favnbr = 7;

		gamer[] gamers = { ken, nick };
		foreach(gamer gmr in gamers) { //type, variable, the command "in", collection
			Console.WriteLine("{0} fav nbr is {1}", gmr.name, gmr.favnbr);  //... Figure out what this means...
				}
		}
	}
}
