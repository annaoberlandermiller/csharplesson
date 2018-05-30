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

			//Variable/WriteLine exercise
			string name = "Anna";
			int days = 6;
			string msg = "My name is " + name + ". " + "I've been in the .NET bootcamp for " + days + " days.";
			Console.WriteLine(msg);

			//Bowling foreach loop exercise
			int[] frames = new int[10]; //there's 10 in the brackets because there's 10 sets of data
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
			foreach (int frm in frames) { game = game + frm; }
			//int is the data type, frm is a new variable, in is a command, frames 
			Console.WriteLine(game); // This calculates the score of a bowling game


			//Array name exercise
			//string[] names = { "Greg," "Michael", "Dan", "Anna", "Marcus", "Foster", "Jermaine", "Mitchell", "Jonathan", "Larry", "William"; }
			//foreach(string aname in names) {
			//Console.WriteLine("Hi " + aname);}


			string[] info = { "Anna", "Miller", "Cincinnati, OH", "oberlanderannas@gmail.com" };
			foreach (string item in info) {
				Console.WriteLine(item);
			}


			//structure/array exercise - see lines 8,10, and 11 for beginning of structure 
			gamer ken;
			ken.name = "Ken";
			ken.favnbr = 10;
			gamer nick;
			nick.name = "Nick";
			nick.favnbr = 7;

			gamer[] gamers = { ken, nick };
			foreach (gamer gmr in gamers) { //type, variable, the command "in", collection
				Console.WriteLine("{0} fav nbr is {1}", gmr.name, gmr.favnbr);
			}
			//Console.Write("Enter a number from 1 to 10:  ");
			//string response = Console.ReadLine();
			//Console.WriteLine(response);


			//Console.Write("Enter 100, 200, or 300:  ");
			//string ans2 = Console.ReadLine();
			//int x1 = int.Parse(ans2);  //this is saying assign the value the user entered for ans 2 to x1
			//string color = "red";
			//if (x1 == 100) {
			//Console.WriteLine("x is equal to 100");
			//	if (color == "red") {
			//		Console.WriteLine("Color is red");
			//	} else {
			//		if (color == "yellow") {
			//			Console.WriteLine("Color is yellow");
			//		} else {
			//			if (color == "green") {
			//				Console.WriteLine("Color is green");
			//			}
			//		}
			//	} else {
			//		if (x1 == 200) {
			//	Console.WriteLine("x is equal to 200");
			//	}
			//		else if {
			//			 (x1 == 300) {
			//			Console.WriteLine("x is equal to 300");
			//		} else {
			//				Console.WriteLine("x is not 100, 20, or 300");
			//		}

			//while()
			int idx = 0;
			while (idx < 50) {
				if (idx % 2 == 0) {
					Console.WriteLine("The index is {0}", idx); //{0} is a place holder for the changing value of idx
				}     
				if (idx % 3 == 0) {
					Console.WriteLine("The index is divisible by 3", idx);
				}
				if (idx % 7 == 0) {
					Console.WriteLine("The index is divisible by 7", idx);
				}
			idx++;  // this is equivelant to idx +=1 (and idx = idx + 1). this will ensure that that an infinite loop does not occur.  
			}   // remember, you can't use idx++ if you're incrementing more than 1

				
						}

				}

			}

		
	