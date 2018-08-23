using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BuildNumGenCL
{
	class Program
	{
		static string buildNum;
		static string yearsSinceProjectStart;
		static string releaseNum;
		static string outputFile;

		static void Main(string[] args)
		{
			try
			{
				yearsSinceProjectStart = args[0];
				releaseNum = args[1];
				outputFile = args[2];

				buildNum = GenerateBuildNumber();
				File.WriteAllText(outputFile, buildNum);

				Environment.Exit(0);
			}
			catch (IndexOutOfRangeException ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				Environment.Exit(1);
			}
		}

		static string GenerateBuildNumber()
		{
			DateTime date = DateTime.Now;
			string month = date.Month.ToString("00");
			string day = date.Day.ToString("00");

			if (yearsSinceProjectStart == "0")
			{
				yearsSinceProjectStart = "";
			}

			buildNum = yearsSinceProjectStart + month + day + "/" + releaseNum;

			return buildNum;
		}
	}
}
