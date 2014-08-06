﻿using System.Linq;
using NUnit.Framework;

namespace uLearn.Courses.Linq.Slides
{
	[Slide("Группировка с помощью GroupBy", "{421B0115-80E0-42B6-BE2D-79BD3661A2AD}")]
	[TestFixture]
	public class Grouping
	{
		/*

		`LINQ` содержит несколько методов группировки элементов последовательности в группы по некоторому признаку.
		Основной способ группировки — это метод `GroupBy`. Вот его полная сигнатура:

		`IEnumerable<IGrouping<TKey, TItem>> GroupBy(Func<TItem, TKey> keySelector)`

		`keySelector` по каждому элементу последовательности получает значение ключа. 
		Все элементы последовательности с одинаковым значением ключа образуют группу.

		Пример ниже показывает как можно разбить список имен в группы по первой букве имени:
		*/

		[Test]
		[ShowBodyOnSlide]
		public void Test()
		{
			string[] names = {"Pavel", "Peter", "Andrew", "Anna", "Alice", "John"};
			IGrouping<char, string>[] groups = names
				.GroupBy(name => name[0])
				.OrderBy(group => group.Key)
				.ToArray();
			// Каждая группа IGrouping реализует интерфейс IEnumerable:
			string[] firstGroup = groups[0].OrderBy(name => name).ToArray();
			Assert.That(firstGroup, Is.EqualTo(new[] {"Alice", "Andrew", "Anna"}).AsCollection);

			// Кроме того у группы есть поле Key, в котором хранится общий для этой группы ключ группировки
			char firstKey = groups[0].Key;
			Assert.That(firstKey, Is.EqualTo('A'));
		}

		/*
		В некотором смысле `GroupBy` — это метод противоположный по действию методу `SelectMany`.
		`GroupBy` создает группы, а `SelectMany` из списка групп делает плоский список.

		`SelectMany` после `GroupBy` не поменяют состав последовательности, но могут изменить порядок следования элементов:
		*/

		[ShowBodyOnSlide]
		[Test]
		public void SelectManyGroupBy()
		{
			string[] names = {"Pavel", "Peter", "Andrew", "Anna", "Alice", "John"};
			var names2 = names
				.GroupBy(name => name[0])
				.SelectMany(group => group);

			// Is.Equivalent игнорирует порядок элементов при сравнении коллекций:
			Assert.That(names2, Is.EquivalentTo(names));
		}
	}
}