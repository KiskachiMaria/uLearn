﻿namespace uLearn.Courses.BasicProgramming.Slides.U14_Structures
{
	[Slide("Практика", "448C71091C394F6196742990DE2C0F44")]
	public class S099_Exercise
	{
		/*
		В этой задаче вам предлагается написать карточный пасьянс "Гармошка".
		
		Во всех созданных вами классах не должно быть публичных полей и свойств с сеттерами, а инициализация объектов должна происходить в конструкторе.

		## Карта и колода (1 балла)

		1. Создайте класс `Card` для представления карты. 
		2. Сделайте у него конструктор и переопределите метод `ToString`.
		3. Создайте класс `CardDeck` представляющий колоду. 
		4. Сделайте у него конструктор, с помощью которого можно задать тип колоды (с двоек, с шестерок или с семерок).
		5. Переопределите метод `ToString` — пусть он выводит содержимое колоды в одну строку.
		6. В методе Main создайте 3 разные колоды и выведите их на консоль.

		## Интерфейс колоды (1 балл)

		1. Добавьте колоде метод Shuffle, тасующий колоду, например, простейшим алгоритмом 
		[Фишера-Йетса](https://ru.wikipedia.org/wiki/%D0%A2%D0%B0%D1%81%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D0%B5_%D0%A4%D0%B8%D1%88%D0%B5%D1%80%D0%B0%E2%80%93%D0%99%D0%B5%D1%82%D1%81%D0%B0).
		2. Добавьте колоде метод `Card ExtractTop()`, снимающий с колоды очередную карту.
		3. Добавьте колоде геттер `CardsCount`, возвращающий количество оставшихся карт в колоде.
		4. В методе Main создайте 3 разные колоды, перетасуйте каждую из них и выведите их на консоль.

		## Пасьянс "Гармошка" (2 балла)

		![Пасьянс](solitaire.png)

		Правила этого пасьянса очень просты. Карты извлекаются из колоды по одной и выкладываются в линию слева направо.
		В любой момент каждую из уже выложенных карт можно попытаться положить на карту слева или через две карты налево.
		Это можно сделать, если у карт совпадают или масти или достоинства.

		На рисунке слева доступно два хода: 7♦ → 3♦ и 4♦ → 3♦.

		Цель игры — закончить с линией из одной или двух карт.

		Придумайте и введите в программу классы, которые необходимы для создания такой игры.

		Создайте консольную игру, которая в цикле выводит на консоль текущее состояние игрового поля, и запрашивает очредной ход у пользователя.
		Не забудте обрабатывать некорректный ввод пользователя.
		
		## Подсказка: масти на английском

		* ♠ Spades
		* ♣ Clubs 
		* ♥ Hearts 
		* ♦ Diamonds 
		
		Вы можете скопировать и вставить эти символы в свою программу. Они работают в консоли.
		*/

	}
}