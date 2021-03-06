using System;
using System.Diagnostics;
using System.IO;
using CommandLine;

namespace uLearn.CourseTool
{
	abstract class AbstractOptions
	{
		protected AbstractOptions()
		{
			config = new Lazy<Config>(() => new FileInfo(ConfigFile).DeserializeXml<Config>());
		}

		private string dir;
		private string profile;
		protected const string SlideUrlFormat = "/Course/{0}/LtiSlide/{1}";
		protected const string SolutionsUrlFormat = "/Course/{0}/AcceptedAlert/{1}";

		[Option('d', "dir", HelpText = "Working directory for the project")]
		public string Dir
		{
			get { return dir ?? Directory.GetCurrentDirectory(); }
			set { dir = value; }
		}

		[Option('p', "profile", HelpText = "Profile used to work with Edx and uLearn")]
		public string Profile
		{
			get { return profile ?? "default"; }
			set { profile = value; }
		}

		public string ConfigFile { get { return Dir + "/config.xml"; } }

		public Config Config { get { return config.Value; } }
		private readonly Lazy<Config> config;

		public void InitializeDirectoryIfNotYet()
		{
			if (!Directory.Exists(Dir))
				Directory.CreateDirectory(Dir);
			var configTemplateFile = Path.Combine(Utils.GetRootDirectory(), "templates/config.xml");
			File.Copy(configTemplateFile, ConfigFile);
			Process.Start("notepad", ConfigFile);
			Console.WriteLine("Edit the config file {0} and run this option again.", ConfigFile);
		}

		public void Execute()
		{
			if (File.Exists(ConfigFile))
				DoExecute();
			else
				InitializeDirectoryIfNotYet();
		}

		public abstract void DoExecute();
	}
}