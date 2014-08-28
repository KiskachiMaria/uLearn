﻿using System;
using uLearn.CSharp;

namespace uLearn.Courses.BasicProgramming.Slides
{
	[Slide("Ошибки преобразования типов", "{04D61C06-8A32-41A6-A47E-2AE2D095DEF3}")]
	public class S031_Conversion
	{
		/*
		Исправьте все ошибки преобразования типов.
		*/

		[Exercise]
		[ExpectedOutput("31415\n31416")]
		[Hint("Вспомните о том, что в С# есть приведение типов ")]
		[Hint("Округление можно найти в библиотеке Math")]
		public static void Main()
		{
			double pi = Math.PI;
			int tenThousend = (int)10000L;
			float floatPi = (float) pi;
			float tenThousendPi = floatPi*tenThousend;
			int roundedTenThousendPi = (int)Math.Round(tenThousendPi);
			int integerPartOfTenThousednPi = (int)tenThousendPi;
			Console.WriteLine(integerPartOfTenThousednPi);
			Console.WriteLine(roundedTenThousendPi);
			/*uncomment
			double pi = Math.PI;
			int tenThousend = 10000L;
			float floatPi = pi;
			float tenThousendPi = floatPi*tenThousend;
			int roundedTenThousendPi = tenThousendPi;
			int integerPartOfTenThousednPi = tenThousendPi;
			Console.WriteLine(integerPartOfTenThousednPi);
			Console.WriteLine(roundedTenThousendPi);
			*/
		}
	}
}