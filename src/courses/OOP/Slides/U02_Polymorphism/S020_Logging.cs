﻿using uLearn;

namespace OOP.Slides.U02_Polymorphism
{
	[Slide("Задача: Логгирование *", "341AFC46-1100-4FD8-9C67-E2F427E8A9B9")]
	public class S020_Logging
	{
		/*
		Эта задача необязательная. Она предполагает самостоятельное изучение библиотеки NLog. Вы можете пропустить эту задачу, если она кажется вам сложной и непонятной.

		Для отладки алгоритмов подобных навигатору часто используют два инструмента: ведение журнала операций (логгирование) и визуализацию.

		### Логгирование

		В некоторых ключевых точках работы вашего алгоритма можно писать информационные сообщения, позволяющие программисту понять, что происходит без использования отладки.
		
		Например, в данной задаче можно было бы логгировать каждую команду, которую вернул навигатор.
		Кроме того, стоит записать текущее положение цели относительно робота, расстояние до нее, а также прошедшее время (по часам симулятора).

		Выводить эту информацию на консоль нельзя — на консоли должна быть финальная таблица с результатами тестирования. Кроме того, после закрытия окна консоли все логи теряются.
		По этим причинам часто логи пишут не на консоль, а в файл.

		В некоторых случаях важна возможность легко отключать логгирование при необходимости и включать его обратно.
		Эту возможность, а также множество других, дают специальные библиотеки логгирования. 
		
		Одна из наиболее популярных таких библиотек для платформы .NET — это NLog. 
		В этой задаче вам предлагается самостоятельно разобраться с этой библиотекой и использовать ее для логгирования перечисленной выше информации в файл.

		Используйте логгирование в других местах программы, если чувствуете в этом необходимость и пользу.

		### Ссылки для самостоятельного изучения

		* [Tutorial по настройке и использованию NLog](https://github.com/nlog/nlog/wiki/Tutorial)
		* [Пример конфигурирования логгирования](https://github.com/nlog/NLog/wiki/Configuration-API)
		* [Официальный сайт NLog](http://nlog-project.org/)
		* [Статья на русском про логгирование в .NET](http://habrahabr.ru/post/98638/)

		### Примечание

		Подобные библиотеки для логгирования есть для многих других языков, а в некоторых (например, Java и Python) они просто являются частью стандартной библиотеки типов.

		*/
	}
}