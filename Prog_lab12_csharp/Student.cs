using System;

namespace Prog_lab12
{
	public class Student
	{
		//Attributes
		protected int course;
		protected string eduProg;
		protected string group;
		protected string facultyName;
		public Human humanField;

		//Properties
		public int Course 
		{
			get
			{
				return course;
			}
			set
			{
				if ((value >= 0) && (value <= 6))
					course = value;
			}
		}
		public string EduProg 
		{
			get
			{
				string outputString = new string(eduProg.ToCharArray());
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
						eduProg = new string(value.ToCharArray());
				}
			}
		}
		public string Group 
		{
			get
			{
				string outputString = new string(group.ToCharArray());
				return (outputString);
			}
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					string invalidSymbStr = "!@#$%^&*()_+=\";:?*,./'][{}<>~` ";
					char[] invalidSymbols = invalidSymbStr.ToCharArray();

					bool checkFlag = false;

					foreach (char symb in invalidSymbols)
					{
						if (value.IndexOf(symb) != (-1))
							checkFlag = true;
					}

					if (!checkFlag)
						group = new string(value.ToCharArray());
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
		public Student()
		{
			course = 0;
			eduProg = "unstated";
			group = "unstated";
			facultyName = "unstated";
			humanField = new Human();
		}
		public Student(Human bufHuman)
		{
			course = 0;
			eduProg = "unstated";
			group = "unstated";
			facultyName = "unstated";
			humanField = new Human(bufHuman.GetId(), bufHuman.GetAge(), 
				bufHuman.GetHeight(), bufHuman.GetWeight(), 
				bufHuman.GetGender(), bufHuman.fioField);
		}
		public Student(int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman)
		{
			Student check = new Student();

			if (check.SetCourse(bufCourse) || check.SetEduProg(bufEduProg) || check.SetGroup(bufGroup) ||
				check.SetFacultyName(bufFacultyName))
			{
				course = 0;
				eduProg = "unstated";
				group = "unstated";
				facultyName = "unstated";
				humanField = new Human();
			}
			else
			{
				SetCourse(bufCourse);
				SetEduProg(bufEduProg);
				SetGroup(bufGroup);
				SetFacultyName(bufFacultyName);
				humanField = new Human(bufHuman.GetId(), bufHuman.GetAge(),
				bufHuman.GetHeight(), bufHuman.GetWeight(), 
				bufHuman.GetGender(), bufHuman.fioField);
			}
		}

		//Methods with Exceptions
		public void HardSetCourse(int buf)
		{
			if (buf < 0 || buf > 6)
				throw new Exception("Invalid range of number.");
			else
				course = buf;

		}
		public void HardSetEduProg(string bufString)
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

			eduProg = new string(bufString.ToCharArray());
		}
		public void HardSetGroup(string bufString)
		{
			if (string.IsNullOrEmpty(bufString))
				throw new FormatException("Input string is zero");

			string invalidSymbStr = "!@#$%^&*()_+=\";:?*,./'][{}<>~` ";
			char[] invalidSymbols = invalidSymbStr.ToCharArray();
			foreach (char symb in invalidSymbols)
			{
				if (bufString.IndexOf(symb) != (-1))
					throw new FormatException("Input string contains invalid symbols");
			}

			group = new string(bufString.ToCharArray());
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
		public bool SetCourse(int buf)
		{
			if (buf < 0 || buf > 6)
				return (true);
			else
			{
				course = buf;
				return (false);
			}
		}
		public bool SetEduProg(string bufString)
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

			eduProg = new string (bufString.ToCharArray());
			return (false);
		}
		public bool SetGroup(string bufString)
		{
			if (string.IsNullOrEmpty(bufString))
				return (true);

			string invalidSymbStr = "!@#$%^&*()_+=\";:?*,./'][{}<>~` ";
			char[] invalidSymbols = invalidSymbStr.ToCharArray();
			foreach (char symb in invalidSymbols)
			{
				if (bufString.IndexOf(symb) != (-1))
					return (true);
			}

			group = new string (bufString.ToCharArray());
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
		public bool SetAll(int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman)
		{
			Student check = new Student();

			if (check.SetCourse(bufCourse) || check.SetEduProg(bufEduProg) || check.SetGroup(bufGroup) ||
				check.SetFacultyName(bufFacultyName))
				return (true);
			else
			{
				SetCourse(bufCourse);
				SetEduProg(bufEduProg);
				SetGroup(bufGroup);
				SetFacultyName(bufFacultyName);
				humanField.SetAll(bufHuman.GetId(), bufHuman.GetAge(),
				bufHuman.GetHeight(), bufHuman.GetWeight(), bufHuman.GetGender(), bufHuman.fioField);
				return (false);
			}
		}

		public int GetCourse()
		{ return (course); }
		public string GetEduProg()
		{
			string outputString = new string(eduProg.ToCharArray());
			return (outputString);
		}
		public string GetGroup()
		{
			string outputString = new string (group.ToCharArray());
			return (outputString);
		}
		public string GetFacultyName()
		{
			string outputString = new string (facultyName.ToCharArray());
			return (outputString);
		}

		public void Read()
		{
			Student check = new Student();
			int bufInt;
			bool readFlag = true;
			while (readFlag)
			{
				Console.Write("Enter course:\n");
				try
				{
					bufInt = int.Parse(Console.ReadLine());
					check.HardSetCourse(bufInt);
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
				Console.Write("Enter education programm:\n");
				try
				{
					check.HardSetEduProg(Console.ReadLine());
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
				Console.Write("Enter group:\n");
				try
				{
					check.HardSetGroup(Console.ReadLine());
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

			SetAll(check.GetCourse(), check.GetEduProg(), check.GetGroup(),
			check.GetFacultyName(), check.humanField);
		}

        public override string ToString()
        {
			string returnValue = "";
			returnValue += "course: " + course.ToString() + 
				"\ndirection of preparation: " + eduProg + 
				"\ngroup: " + group + 
				"\nfaculty name: " + facultyName + 
				"\n" + humanField.ToString();
			return (returnValue);
        }
    }
}

