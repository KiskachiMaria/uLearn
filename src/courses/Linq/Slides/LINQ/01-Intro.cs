﻿using System.Collections.Generic;
using System.Linq;

namespace uLearn.Courses.Linq.Slides
{
	[Slide("Введение", "{3446FAB2-15DF-4045-AB40-ABC1F3DC87C8}")]
	public class Intro
	{
		private readonly Letter[] letters = new Letter[0];
		/*
		Linq — это встроенный в язык C# механизм для лаконичной и компактной записи алгоритмов манипуляции коллекциями элементов.

		Большинство алгоритмов, которые на менее развитых языках принято писать с помощью циклов и условных операторов, 
		более компактно, красиво и понятно выражаются с помощью примитивов Linq.

		Продемонстрируем эти слова примером:
		*/

		[ShowOnSlide]
		public int[] GetNewLettersIds_ClassicWay()
		{
			var res = new List<int>();
			for(int i=0; i<letters.Length; i++)
			{
				if (letters[i].IsNew)
					res.Add(letters[i].Id);
			}
			return res.ToArray();
		}

		/*
		Этот код ищет идентификаторы новых писем. Похожий код каждому программисту приходится приходится писать крайне часто. 
		
		А вот версия решения той же задачи с помощью Linq:
		*/

		[ShowOnSlide]
		public int[] GetNewLettersIds_LinqWay()
		{
			return letters.Where(l => l.IsNew).Select(l => l.Id).ToArray();
		}

		public class Letter
		{
			public bool IsNew { get; set; }
			public int Id { get; set; }
		}

		/*
		Всего одна строчка! Короткая и понятная!

		Основные возможности Linq вы узнаете из лекционных слайдов.
		Однако главная ценность этого курса — хорошо подобранный набор упражнений.
		Они максимально близки к реальным задачам, встречающимся на практике, и хорошо демонстрирую выразительные возможности Linq.
		
		Если вы уже имеете представление о Linq, можете пропускать лекционные слайды, но прорешать упражнения. 
		Некоторые из них могут открыть вам новый взгляд на давно знакомые задачи.
		*/
	}
}