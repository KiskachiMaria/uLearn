﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OpenQA.Selenium;
using Selenium.UlearnDriverComponents.PageObjects;
using uLearn;
using uLearn.Web.DataContexts;

namespace Selenium.UlearnDriverComponents.Pages
{
	class ExerciseSlidePage : SlidePage
	{
		private IWebElement runSolutionButton;
		private IWebElement resetButton;
		private IWebElement hintsButton;
		private List<Hint> hints;
		private static readonly ULearnDb ulearnDb = new ULearnDb();
		private static readonly CourseManager courseManager = new CourseManager(new DirectoryInfo(@"C:\Users\213\Desktop\GitHub\uLearn\src\uLearn.Web"));
			
		public ExerciseSlidePage(IWebDriver driver, IObserver parent)
			: base(driver, parent)
		{
			Configure();
		}

		private new void Configure()
		{
			base.Configure();
			runSolutionButton = driver.FindElement(ElementsClasses.RunSolutionButton);
			resetButton = driver.FindElement(ElementsClasses.ResetButton);
			hintsButton = driver.FindElement(ElementsClasses.GetHintsButton);
			hints = GetHints();
			CheckExerciseSlide();
		}

		private List<Hint> GetHints()
		{
			const string hintXpath = "hyml/body/div[1]/div/div/div/div[9]/div/div";
			var allHints = UlearnDriverComponents.UlearnDriver.FindElementsSafely(driver, By.XPath(hintXpath));// driver.FindElement(By.Id("hint-place")).FindElements();
			var localHints = new List<Hint>(allHints.Count);
			for (var i = 0; i < allHints.Count; i++)
			{
				var likeButton = allHints[i].FindElement(By.Id(String.Format("{0}likeHint", i)));
				var hint = allHints[i].FindElement(By.XPath(hintXpath + "/p"));
				localHints[i] = new Hint(new LikeButton(likeButton), hint);
			}
			return localHints;
		}

		public string GetHintButtonText()
		{
			return hintsButton.Text;
		}

		public List<Hint> Hints()
		{
			return new List<Hint>(hints);
		}

		public bool HasMoreHints()
		{
			return hintsButton.Enabled;
		}

		public UlearnDriverComponents.UlearnDriver ClickRunButton()
		{
			runSolutionButton.Click();
			return new UlearnDriverComponents.UlearnDriver(driver);
		}

		public UlearnDriverComponents.UlearnDriver ClickResetButton()
		{
			resetButton.Click();
			return new UlearnDriverComponents.UlearnDriver(driver);
		}

		public UlearnDriverComponents.UlearnDriver ClickHintsButton()
		{
			hintsButton.Click();
			return new UlearnDriverComponents.UlearnDriver(driver);
		}

		public string GetTextFromSecretCode()
		{
			return driver.FindElement(ElementsId.SecreteCode).Text;
		}

		public string GetUserCodeText()
		{
			return driver.FindElement(ElementsClasses.CodeExercise).Text;
		}

		public ResultType GetRunResult()
		{
			return ResultType.Success;
		}

		private void CheckExerciseSlide()
		{
			CheckCodeMirror();
			CheckButtons();
			CheckHints();
		}

		private void CheckHints()//experiment
		{
			var userId = ulearnDb.Users.First(x => x.UserName == "admin").Id;
			var slideId = courseManager.GetCourse("courseId").Slides.First(x => x.Title == "Title").Id;
			var reallyHints = ulearnDb.Hints.Where(x => x.UserId == userId && x.SlideId == slideId).ToList();
			//var slide = courseManager.GetCourse("courseId").GetSlideById(slideId).Blocks.Where();
		}

		private void CheckButtons()
		{
			if (runSolutionButton == null)
				throw new NotFoundException("run-solution-button отсутствует на странице");
			if (resetButton == null)
				throw new NotFoundException("reset-button отсутствует на странице");
			if (hintsButton == null)
				throw new NotFoundException("get-hints-button отсутствует на странице");
		}

		private void CheckCodeMirror()
		{
			var secretCodeText = driver.FindElement(ElementsId.SecreteCode);
			if (secretCodeText == null)
				throw new NotFoundException("не найдена секретная область кода");
			var codeExerciseField = driver.FindElement(ElementsClasses.CodeExercise);
			if (codeExerciseField == null)
				throw new NotFoundException("не найдена область для кода");
			var codeMirrorObject = driver.FindElement(ElementsClasses.CodeMirror);
			if (codeMirrorObject == null)
				throw new NotFoundException("не найден codemirror");
		}

		public new void Update()
		{
			Configure();
		}
	}
}