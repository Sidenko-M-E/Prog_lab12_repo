using System;

namespace Prog_lab12
{
	public class Cadet : Student
	{
		//Attributes
		private int sessionRes;
		private string militaryRank;

		//Constructors
		public Cadet()
		{
			sessionRes = 0;
			militaryRank = "unstated";
		}
		public Cadet(Human bufHuman)
		{
			sessionRes = 0;
			militaryRank = "unstated";
		}
		public Cadet(int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman):base(bufCourse, bufEduProg, bufGroup, bufFacultyName, bufHuman)
		{
			sessionRes = 0;
			militaryRank = "unstated";
		}
		public Cadet(int bufSessionRes, string bufMilitaryRank, int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman)
		{
			Cadet check = new Cadet();

			if (check.SetSessionRes(bufSessionRes) || check.SetMilitaryRank(bufMilitaryRank) ||
				check.SetCourse(bufCourse) || check.SetEduProg(bufEduProg) ||
				check.SetGroup(bufGroup) || check.SetFacultyName(bufFacultyName))
			{
				sessionRes = 0;
				militaryRank = "unstated";
			}
			else
			{
				sessionRes = bufSessionRes;
				SetMilitaryRank(bufMilitaryRank);
				course = bufCourse;
				SetEduProg(bufEduProg);
				SetGroup(bufGroup);
				SetFacultyName(bufFacultyName);
				humanField = new Human(bufHuman.GetId(), bufHuman.GetAge(),
				bufHuman.GetHeight(), bufHuman.GetWeight(),
				bufHuman.GetGender(), bufHuman.fioField);
			}
		}

		//Methods
		public bool SetSessionRes(int buf)
		{
			if (buf < 0 || buf > 100)
				return (true);
			else
			{
				sessionRes = buf;
				return (false);
			}
		}
		public bool SetMilitaryRank(string bufString)
		{
			if (string.IsNullOrEmpty(bufString))
				return (true);

			string invalidSymbStr = "!@#$%^&*()_+1234567890-=\"№;:?*,./'][{}<>~` ";
			char[] invalidSymbols = invalidSymbStr.ToCharArray();
			foreach (char symb in invalidSymbols)
			{
				if (bufString.IndexOf(symb) != (-1))
					return (true);
			}

			militaryRank = new string(bufString.ToCharArray());
			return (false);
		}

		public bool SetAll(int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman)
		{
			Console.Write("Cadet SetAll has been called.\n");
			if (base.SetAll(bufCourse, bufEduProg, bufGroup, bufFacultyName, bufHuman))
				return (true);

			sessionRes = 0;
			militaryRank = "unstated";
			return (false);
		}
		public bool SetAll(int bufSessionRes, string bufMilitaryRank, int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman)
		{
			Console.Write("Cadet SetAll has been called.\n");
			Cadet check = new Cadet();

			if (check.SetSessionRes(bufSessionRes) || check.SetMilitaryRank(bufMilitaryRank) ||
				check.SetCourse(bufCourse) || check.SetEduProg(bufEduProg) ||
				check.SetGroup(bufGroup) || check.SetFacultyName(bufFacultyName))
				return (true);

			sessionRes = bufSessionRes;
			SetMilitaryRank(bufMilitaryRank);
			course = bufCourse;
			SetEduProg(bufEduProg);
			SetGroup(bufGroup);
			SetFacultyName(bufFacultyName);
			humanField = new Human(bufHuman.GetId(), bufHuman.GetAge(),
			bufHuman.GetHeight(), bufHuman.GetWeight(),
			bufHuman.GetGender(), bufHuman.fioField);
			return (false);
		}

		public int GetSessionRes()
		{
			return (sessionRes);
		}
		public string GetMilitaryRank()
		{
			string outputString = new string(militaryRank.ToCharArray());
			return (outputString);
		}

		public override string ToString()
		{
            string returnValue = "";
			returnValue += "session results: " + sessionRes.ToString() +
				"military rank: " + militaryRank +
				"\n" + base.ToString();
			return (returnValue);
        }
    }
}