using System;

namespace Prog_lab12
{
	public class Faculty 
	{
		//Attributes
		private string facultyName;
		private int quantityOfStudents;
		private int quantityOfBachelors;
		private int quantityOfMasters;
		private int quantityOfTeachers;
		private int quantityOfCandidates;
		private int quantityOfDoctors;
		private int quantityOfDisciplines;

		//Properties
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
		public int QuantityOfStudents
		{
			get
			{
				return quantityOfStudents;
			}
			set
			{
				if ((value >= 0) && (value <= 1000))
					quantityOfStudents = value;
			}
		}
		public int QuantityOfBachelors
		{
			get
			{
				return quantityOfBachelors;
			}
			set
			{
				if ((value >= 0) && (value <= 1000))
					quantityOfBachelors = value;
			}
		}
		public int QuantityOfMasters
		{
			get
			{
				return quantityOfMasters;
			}
			set
			{
				if ((value >= 0) && (value <= 1000))
					quantityOfMasters = value;
			}
		}
		public int QuantityOfTeachers
		{
			get
			{
				return quantityOfTeachers;
			}
			set
			{
				if ((value >= 0) && (value <= 100))
					quantityOfTeachers = value;
			}
		}
		public int QuantityOfCandidates
		{
			get
			{
				return quantityOfCandidates;
			}
			set
			{
				if ((value >= 0) && (value <= 100))
					quantityOfCandidates = value;
			}
		}
		public int QuantityOfDoctors
		{
			get
			{
				return quantityOfDoctors;
			}
			set
			{
				if ((value >= 0) && (value <= 100))
					quantityOfDoctors = value;
			}
		}
		public int QuantityOfDisciplines
		{
			get
			{
				return quantityOfDisciplines;
			}
			set
			{
				if ((value >= 0) && (value <= 100))
					quantityOfDisciplines = value;
			}
		}

		//Constructors
		public Faculty()
		{
			facultyName = "unstated";
			quantityOfStudents = 0;
			quantityOfBachelors = 0;
			quantityOfMasters = 0;
			quantityOfTeachers = 0;
			quantityOfCandidates = 0;
			quantityOfDoctors = 0;
			quantityOfDisciplines = 0;
		}
		public Faculty(string bufFacultyName)
		{
			facultyName = "unstated";
			quantityOfStudents = 0;
			quantityOfBachelors = 0;
			quantityOfMasters = 0;
			quantityOfTeachers = 0;
			quantityOfCandidates = 0;
			quantityOfDoctors = 0;
			quantityOfDisciplines = 0;

			SetFacultyName(bufFacultyName);
		}
		public Faculty(string bufFacultyName, int studentsQuantity, int bachelorsQuantity, int mastersQuantity,
	int teachersQuantity, int candidatesQuantity, int doctorsQuantity, int disciplinesQuantity)
		{
			Faculty check = new Faculty();

			if (check.SetFacultyName(bufFacultyName) || check.SetQuantityOfStudents(studentsQuantity) ||
				check.SetQuantityOfBachelors(bachelorsQuantity) || check.SetQuantityOfMasters(mastersQuantity) ||
				check.SetQuantityOfTeachers(teachersQuantity) || check.SetQuantityOfCandidates(candidatesQuantity) ||
				check.SetQuantityOfDoctors(doctorsQuantity) || check.SetQuantityOfDisciplines(disciplinesQuantity))
			{
				facultyName = "unstated";
				quantityOfStudents = 0;
				quantityOfBachelors = 0;
				quantityOfMasters = 0;
				quantityOfTeachers = 0;
				quantityOfCandidates = 0;
				quantityOfDoctors = 0;
				quantityOfDisciplines = 0;
			}
			else
			{
				SetFacultyName(bufFacultyName);
				quantityOfStudents = studentsQuantity;
				quantityOfBachelors = bachelorsQuantity;
				quantityOfMasters = mastersQuantity;
				quantityOfTeachers = teachersQuantity;
				quantityOfCandidates = candidatesQuantity;
				quantityOfDoctors = doctorsQuantity;
				quantityOfDisciplines = disciplinesQuantity;
			}
		}


		//Methods with Exceptions
		public void HardSetFacultyName(string bufString)
		{
			if (string.IsNullOrEmpty(bufString))
				throw new FormatException("Caught an Exception!!! Input string is zero");

			string invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
			char[] invalidSymbols = invalidSymbStr.ToCharArray();
			foreach (char symb in invalidSymbols)
			{
				if (bufString.IndexOf(symb) != (-1))
					throw new FormatException("Caught an Exception!!! Input string contains invalid symbols");
			}

			facultyName = new string(bufString.ToCharArray());
		}
		public void HardSetQuantityOfStudents(int buf)
		{
			if (buf < 0 || buf > 1000)
				throw new Exception("Invalid range of number.");
			else
				quantityOfStudents = buf;
		}
		public void HardSetQuantityOfBachelors(int buf)
		{
			if (buf < 0 || buf > 1000)
				throw new Exception("Invalid range of number.");
			else
				quantityOfBachelors = buf;
		}
		public void HardSetQuantityOfMasters(int buf)
		{
			if (buf < 0 || buf > 1000)
				throw new Exception("Invalid range of number.");
			else
				quantityOfMasters = buf;
		}
		public void HardSetQuantityOfTeachers(int buf)
		{
			if (buf < 0 || buf > 100)
				throw new Exception("Invalid range of number.");
			else
				quantityOfTeachers = buf;
		}
		public void HardSetQuantityOfCandidates(int buf)
		{
			if (buf < 0 || buf > 100)
				throw new Exception("Invalid range of number.");
			else
				quantityOfCandidates = buf;
		}
		public void HardSetQuantityOfDoctors(int buf)
		{
			if (buf < 0 || buf > 100)
				throw new Exception("Invalid range of number.");
			else
				quantityOfDoctors = buf;
		}
		public void HardSetQuantityOfDisciplines(int buf)
		{
			if (buf < 0 || buf > 100)
				throw new Exception("Invalid range of number.");
			else
				quantityOfDisciplines = buf;
		}

		//Methods
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
		public bool SetQuantityOfStudents(int buf)
		{
			if (buf < 0 || buf > 1000)
				return (true);
			else
			{
				quantityOfStudents = buf;
				return (false);
			}
		}
		public bool SetQuantityOfBachelors(int buf)
		{
			if (buf < 0 || buf > 1000)
				return (true);
			else
			{
				quantityOfBachelors = buf;
				return (false);
			}
		}
		public bool SetQuantityOfMasters(int buf)
		{
			if (buf < 0 || buf > 1000)
				return (true);
			else
			{
				quantityOfMasters = buf;
				return (false);
			}
		}
		public bool SetQuantityOfTeachers(int buf)
		{
			if (buf < 0 || buf > 100)
				return (true);
			else
			{
				quantityOfTeachers = buf;
				return (false);
			}
		}
		public bool SetQuantityOfCandidates(int buf)
		{
			if (buf < 0 || buf > 100)
				return (true);
			else
			{
				quantityOfCandidates = buf;
				return (false);
			}
		}
		public bool SetQuantityOfDoctors(int buf)
		{
			if (buf < 0 || buf > 100)
				return (true);
			else
			{
				quantityOfDoctors = buf;
				return (false);
			}
		}
		public bool SetQuantityOfDisciplines(int buf)
		{
			if (buf < 0 || buf > 100)
				return (true);
			else
			{
				quantityOfDisciplines = buf;
				return (false);
			}
		}

		public bool SetStudentsInfo(int allQuantity, int bachelorsQuantity, int mastersQuantity)
		{
			if (allQuantity < 0 || allQuantity > 1000 || bachelorsQuantity < 0 || bachelorsQuantity > 1000 || mastersQuantity < 0 || mastersQuantity > 1000)
				return (true);
			else
			{
				quantityOfStudents = allQuantity;
				quantityOfBachelors = bachelorsQuantity;
				quantityOfMasters = mastersQuantity;
				return (false);
			}
		}
		public bool SetTeachersInfo(int allQuantity, int candidatesQuantity, int doctorsQuantity)
		{
			if (allQuantity < 0 || allQuantity > 100 || candidatesQuantity < 0 || candidatesQuantity > 100 || doctorsQuantity < 0 || doctorsQuantity > 100)
				return (true);
			else
			{
				quantityOfTeachers = allQuantity;
				quantityOfCandidates = candidatesQuantity;
				quantityOfDoctors = doctorsQuantity;
				return (false);
			}
		}
		public bool SetAll(string bufFacultyName, int studentsQuantity, int bachelorsQuantity, int mastersQuantity, int teachersQuantity, int candidatesQuantity, int doctorsQuanity, int discpilinesQuantity)
		{
			Faculty check = new Faculty();

			if (check.SetFacultyName(bufFacultyName) || check.SetQuantityOfStudents(studentsQuantity) ||
				check.SetQuantityOfBachelors(bachelorsQuantity) || check.SetQuantityOfMasters(mastersQuantity) ||
				check.SetQuantityOfTeachers(teachersQuantity) || check.SetQuantityOfCandidates(candidatesQuantity) ||
				check.SetQuantityOfDoctors(doctorsQuanity) || check.SetQuantityOfDisciplines(discpilinesQuantity))
				return (true);
			else
			{
				HardSetFacultyName(bufFacultyName);
				SetStudentsInfo(studentsQuantity, bachelorsQuantity, mastersQuantity);
				SetTeachersInfo(teachersQuantity, candidatesQuantity, doctorsQuanity);
				SetQuantityOfDisciplines(discpilinesQuantity);
				return (false);
			}
		}

		public string GetFacultyName()
		{
			string outputString = new string(facultyName.ToCharArray());
			return (outputString);
		}
		public int GetQuantityOfStudents()
		{return quantityOfStudents;}
		public int GetQuantityOfBachelors()
		{return quantityOfBachelors;}
		public int GetQuantityOfMasters()
		{return quantityOfMasters;}
		public int GetQuantityOfTeachers()
		{return quantityOfTeachers;}
		public int GetQuantityOfCandidates()
		{return quantityOfCandidates;}
		public int GetQuantityOfDoctors()
		{return quantityOfDoctors;}
		public int GetQuantityOfDisciplines()
		{return quantityOfDisciplines;}

		//Processing methods
		public double GetProcentOfMasters()
		{
			if (quantityOfStudents == 0)
				throw new DivideByZeroException("Caught an Exception!!! Can't divide by QuantityOfStudents = 0");
			return (((double)quantityOfMasters) / ((double)quantityOfStudents) * 100);
		}
		public double GetProcentOfDoctors()
		{
			if (quantityOfTeachers == 0)
				throw new DivideByZeroException("Caught an Exception!!! Can't divide by QuantityOfTeachers = 0");
			return (((double)quantityOfDoctors) / ((double)quantityOfTeachers) * 100);
		}
		public double GetStudToTeachRatio()
		{
			if (quantityOfTeachers == 0)
				throw new DivideByZeroException("Caught an Exception!!! Can't divide by QuantityOfTeachers = 0");
			return ((double)quantityOfStudents) / ((double)quantityOfTeachers);
		}
		public Faculty GetWithMoreCandidates(Faculty buf)
		{
			if (this.GetQuantityOfCandidates() >= buf.GetQuantityOfCandidates())
				return (this);
			else
				return (buf);
		}
		public void IsHavingMoreStudentsThen(out int comparisonValueAndResult)
		{
			comparisonValueAndResult = 15;
			if (this.GetQuantityOfTeachers() > comparisonValueAndResult)
				comparisonValueAndResult = 1;
			else
				comparisonValueAndResult = 0;
		}
		public void IsHavingMoreTeachersThen(ref int comparisonValueAndResult)
		{
			if (this.GetQuantityOfTeachers() > comparisonValueAndResult)
				comparisonValueAndResult = 1;
			else
				comparisonValueAndResult = 0;
		}

		public bool Read()
		{
			Faculty check = new Faculty();
			int bufInt;

			bool readFlag = true;
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

			readFlag = true;
			while (readFlag)
			{
				Console.Write("Enter quantity of students:\n");
				try
				{
					bufInt = int.Parse(Console.ReadLine());
					check.HardSetQuantityOfStudents(bufInt);
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
				Console.Write("Enter quantity of bachelors:\n");
				try
				{
					bufInt = int.Parse(Console.ReadLine());
					check.HardSetQuantityOfBachelors(bufInt);
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
				Console.Write("Enter quantity of masters:\n");
				try
				{
					bufInt = int.Parse(Console.ReadLine());
					check.HardSetQuantityOfMasters(bufInt);
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
				Console.Write("Enter quantity of teachers:\n");
				try
				{
					bufInt = int.Parse(Console.ReadLine());
					check.HardSetQuantityOfTeachers(bufInt);
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
				Console.Write("Enter quantity of candidates:\n");
				try
				{
					bufInt = int.Parse(Console.ReadLine());
					check.HardSetQuantityOfCandidates(bufInt);
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
				Console.Write("Enter quantity of doctors:\n");
				try
				{
					bufInt = int.Parse(Console.ReadLine());
					check.HardSetQuantityOfDoctors(bufInt);
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
				Console.Write("Enter quantity of disciplines:\n");
				try
				{
					bufInt = int.Parse(Console.ReadLine());
					check.HardSetQuantityOfDisciplines(bufInt);
					readFlag = false;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			SetAll(check.GetFacultyName(), check.GetQuantityOfStudents(), check.GetQuantityOfBachelors(),
				check.GetQuantityOfMasters(), check.GetQuantityOfTeachers(), check.GetQuantityOfTeachers(),
				check.GetQuantityOfDoctors(), check.GetQuantityOfDisciplines());
			return (false);
		}

        public override string ToString()
        {
			string returnValue = "";
			returnValue += "faculty name: " + facultyName +
				"\nquantity of students: " + quantityOfStudents +
				"\nquantity of bachelors: " + quantityOfBachelors +
				"\nquantity of masters: " + quantityOfMasters +
				"\nquantity of teachers: " + quantityOfTeachers +
				"\nquantity of candidates: " + quantityOfCandidates +
				"\nquantity of doctors: " + quantityOfDoctors +
				"\nquantity of disciplines: " + quantityOfDisciplines;
			return (returnValue);
        }
	}
}
