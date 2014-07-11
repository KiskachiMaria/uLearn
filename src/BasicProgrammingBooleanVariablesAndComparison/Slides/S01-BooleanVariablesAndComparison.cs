﻿using System;

namespace uLearn.Courses.BasicProgrammingIfWhileFor.Slides
{
	internal class S01_BooleanVariablesAndComparison
	{
		/*
		##Задача: Логические выражения и мечты.
		К сожалению, вы попали не в хогвартс. Но и в мире информатики полно магии.
		Например, некоторые программисты, как например Вася, пишут магические функции. А потом не могут сделать так, чтобы они давали нужный результат.
		Вам же осталось лишь подобрать переменные a, b, c, d с помощью нереализованных функций так, чтобы магическия функция Magic выдавала желаемый результат.
		*/
		[ShowOnSlide]
		[Hint("переменная типа bool, приведенная к строке, начинается с заглавной буквы")]
		[ExpectedOutput("False\r\nTrue\r\nFalse")]
		public static void Main()
		{
			var a = FirstNumber();
			var b = SecondNumber();
			var c = MagicString();
			var d = MagicBoolean();
			Magic(a, b, c, d);
		}

		private static string MagicString()
		{
			return "true";
			/*uncomment
			return ...
			*/
		}

		private static int SecondNumber()
		{
			return 4;
			/*uncomment
			return ...
			*/
		}

		private static bool MagicBoolean()
		{
			return false;
			/*uncomment
			return ...
			*/
		}

		private static int FirstNumber()
		{
			return 2;
			/*uncomment
			return ...
			*/
		}

		[ShowOnSlide]
		public static void Magic(int a, int b, string c, bool d)
		{
			var abrakadabra = a > b;
			var patronus = d.ToString() == "False";
			var avadaKedavra = (c == "true") == d;
			Console.WriteLine(abrakadabra == patronus);
			Console.WriteLine(avadaKedavra == abrakadabra);
			Console.WriteLine(avadaKedavra == patronus);
		}

	}
}