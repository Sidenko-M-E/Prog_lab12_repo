using System;

namespace Prog_lab12
{
	public class Teacher
	{
		//Static fields and methods
		private static double baseSalary = 23456.78;
		static public double GetSalaryOf(Teacher bufTeacher)
		{
			double result = 0;
			int bufWorkExp = bufTeacher.GetWorkExp();
			if (bufWorkExp >= 0 && bufWorkExp <= 3)
				result = baseSalary;

			if (bufWorkExp >= 4 && bufWorkExp <= 7)
				result = baseSalary * 1.3;

			if (bufWorkExp >= 8 && bufWorkExp <= 14)
				result = baseSalary * 1.6;

			if (bufWorkExp >= 15 && bufWorkExp <= 24)
				result = baseSalary * 2.2;

			if (bufWorkExp >= 25)
				result = baseSalary * 3.1;

			result = Math.Round(result, 2, MidpointRounding.AwayFromZero);
			return (result);
		}

		//Attributes
		private int workExp;
		private string degree;
		private string facultyName;
		public Human humanField;

		//Properties
		public int WorkExp
		{
			get
			{
				return workExp;
			}
			set
			{
				if ((value >= 0) && (value <= 60))
					workExp = value;
			}
		}
		public string Degree 
		{
			get
			{
				string outputString = new string(degree.ToCharArray());
				return (outputString);
			}
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					string invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~`";
					char[] invalidSymbols = invalidSymbStr.ToCharArray();

					bool checkFlag = false;

					foreach (char symb in invalidSymbols)
					{
						if (value.IndexOf(symb) != (-1))
							checkFlag = true;
					}

					if (!checkFlag)
						degree = new string(value.ToCharArray());
				}
			}
		}
		public string FacultyName
		{
			get
			{
				string outputString = new string(facultyName.ToCharArray());
				return (outputString);
			}
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					string invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
					char[] invalidSymbols = invalidSymbStr.ToCharArray();

					bool checkFlag = false;

					foreach (char symb in invalidSymbols)
					{
						if (value.IndexOf(symb) != (-1))
							checkFlag = true;
					}

					if (!checkFlag)
						facultyName = new string(value.ToCharArray());
				}
			}
		}
		public Human HumanField 
		{
			get
			{
				return (humanField);
			}
			set
			{
				humanField = value;
			}
		}

		//Constructors
		public Teacher()
		{
			workExp = 0;
			degree = "unstated";
			facultyName = "unstated";
			humanField = new Human();
		}
		public Teacher(Human bufHuman)
		{
			workExp = 0;
			degree = "unstated";
			facultyName = "unstated";
			humanField = new Human(bufHuman.GetId(), bufHuman.GetAge(),
				bufHuman.GetHeight(), bufHuman.GetWeight(),
				bufHuman.GetGender(), bufHuman.fioField);
		}
		public Teacher(int bufWorkExp, string bufDegree, string bufFacultyName, Human bufHuman)
		{
			Teacher check = new Teacher();

			if (check.SetWorkExp(bufWorkExp) || check.SetDegree(bufDegree) || check.SetFacultyName(bufFacultyName))
			{
				workExp = 0;
				degree = "unstated";
				facultyName = "unstated";
				humanField = new Human();
			}
			else
			{
				SetWorkExp(bufWorkExp);
				SetDegree(bufDegree);
				SetFacultyName(bufFacultyName);
				humanField = new Human(bufHuman.GetId(), bufHuman.GetAge(),
				bufHuman.GetHeight(), bufHuman.GetWeight(), bufHuman.GetGender(), bufHuman.fioField);
			}
		}

		//Methods with Exceptions
		public void HardSetWorkExp(int buf)
		{
			if (buf < 0 || buf > 60)
				throw new Exception("Invalid range of number.");
			else
				workExp = buf;
		}
		public void HardSetDegree(string bufString)
		{
			if (string.IsNullOrEmpty(bufString))
				throw new FormatException("Input string is zero");

			string invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~`";
			char[] invalidSymbols = invalidSymbStr.ToCharArray();
			foreach (char symb in invalidSymbols)
			{
				if (bufString.IndexOf(symb) != (-1))
					throw new FormatException("Input string contains invalid symbols");
			}

			degree = new string(bufString.ToCharArray());
		}
		public void HardSetFacultyName(string bufString)
		{
			if (string.IsNullOrEmpty(bufString))
				throw new FormatException("Input string is zero");

			string invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
			char[] invalidSymbols = invalidSymbStr.ToCharArray();
			foreach (char symb in invalidSymbols)
			{
				if (bufString.IndexOf(symb) != (-1))
					throw new FormatException("Input string contains invalid symbols");
			}

			facultyName = new string(bufString.ToCharArray());
		}

		//Methods
		public bool SetWorkExp(int buf)
		{
			if (buf < 0 || buf > 60)
				return (true);
			else
			{
				workExp = buf;
				return (false);
			}
		}
		public bool SetDegree(string bufString)
		{
			if (string.IsNullOrEmpty(bufString))
				return (true);

			string invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~`";
			char[] invalidSymbols = invalidSymbStr.ToCharArray();
			foreach (char symb in invalidSymbols)
			{
				if (bufString.IndexOf(symb) != (-1))
					return (true);
			}

			degree = new string (bufString.ToCharArray());
			return (false);
		}
		public bool SetFacultyName(string bufString)
		{
			if (string.IsNullOrEmpty(bufString))
				return (true);

			string invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
			char[] invalidSymbols = invalidSymbStr.ToCharArray();
			foreach (char symb in invalidSymbols)
			{
				if (bufString.IndexOf(symb) != (-1))
					return (true);
			}

			facultyName = new string (bufString.ToCharArray());
			return (false);
		}
		public bool SetAll(int bufWorkExp, string bufDegree, string bufFacultyName, Human bufHuman)
		{
			Teacher check = new Teacher();

			if (check.SetWorkExp(bufWorkExp) || check.SetDegree(bufDegree) || check.SetFacultyName(bufFacultyName))
				return (true);
			else
			{
				SetWorkExp(bufWorkExp);
				SetDegree(bufDegree);
				SetFacultyName(bufFacultyName);
				humanField.SetAll(bufHuman.GetId(), bufHuman.GetAge(),
				bufHuman.GetHeight(), bufHuman.GetWeight(), 
				bufHuman.GetGender(), bufHuman.fioField);
				return (false);
			}
		}

		public int GetWorkExp()
		{ return (workExp); }
		public string GetDegree()
		{
			string outputString = new string(degree.ToCharArray());
			return (outputString);
		}
		public string GetFacultyName()
		{
			string outputString = new string(facultyName.ToCharArray());
			return (outputString);
		}

		public static Teacher operator +(Teacher operatorTeacher, int operatorWorkExp)
		{
			return (new Teacher
			{
				WorkExp = operatorTeacher.WorkExp + operatorWorkExp,
				Degree = operatorTeacher.Degree,
				FacultyName = operatorTeacher.FacultyName,
				HumanField = operatorTeacher.HumanField
			});
		}
		public static int operator +(int operatorWorkExp, Teacher operatorTeacher)
		{
			return (operatorTeacher.workExp + operatorWorkExp);
		}
		public static Teacher operator ++(Teacher operatorTeacher)
		{
			++operatorTeacher.workExp;
			return (operatorTeacher);
		}

		public void Read()
		{
			Teacher check = new Teacher();
			int bufInt;
			bool readFlag = true;
			while (readFlag)
			{
				Console.Write("Enter working experience:\n");
				try
				{
					bufInt = int.Parse(Console.ReadLine());
					check.HardSetWorkExp(bufInt);
					readFlag = false;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			readFlag = true;
			while (readFlag)
			{
				Console.Write("Enter scientific degree:\n");
				try
				{
					check.HardSetDegree(Console.ReadLine());
					readFlag = false;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			readFlag = true;
			while (readFlag)
			{
				Console.Write("Enter faculty name:\n");
				try
				{
					check.HardSetFacultyName(Console.ReadLine());
					readFlag = false;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}

			}

			check.humanField.Read();

			SetAll(check.GetWorkExp(), check.GetDegree(),
			check.GetFacultyName(), check.humanField);
		}

        public override string ToString()
        {
			string returnValue = "";
			returnValue = "working experience: " + workExp.ToString() +
				"\nscientific degree: " + degree +
				"\nfaculty name: " + facultyName +
				humanField.ToString();
			return (returnValue);
        }
	}
}
