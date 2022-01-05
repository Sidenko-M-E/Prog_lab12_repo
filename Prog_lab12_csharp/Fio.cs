using System;

namespace Prog_lab12
{
	public class Fio
	{
		//Attributes
		private string surname;
		private string name;
		private string patronymic;


		//Properties
		public string Surname
		{
			get
			{
				string outputString = new string(surname.ToCharArray());
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
						surname = new string(value.ToCharArray());
				}
			}
		}
		public string Name
		{
			get
			{
				string outputString = new string(name.ToCharArray());
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
						name = new string(value.ToCharArray());
				}
			}
		}
		public string Patronymic
		{
			get
			{
				string outputString = new string(patronymic.ToCharArray());
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
						patronymic = new string(value.ToCharArray());
				}
			}
		}

		//Constructors
		public Fio()
		{
			surname = "unstated";
			name = "unstated";
			patronymic = "unstated";
		}
		public Fio(string bufSurname)
		{
			surname = "unstated";
			name = "unstated";
			patronymic = "unstated";

			SetSurname(bufSurname);
		}
		public Fio(string bufSurname, string bufName, string bufPatronymic)
		{
			Fio check = new Fio();

			if (check.SetSurname(bufSurname) || check.SetName(bufName) || check.SetPatronymic(bufPatronymic))
			{
				surname = "unstated";
				name = "unstated";
				patronymic = "unstated";
			}
			else
			{
				SetSurname(bufSurname);
				SetName(bufName);
				SetPatronymic(bufPatronymic);
			}
		}

		//Methods
		public bool SetAll(string bufSurname, string bufName, string bufPatronymic)
		{
			Fio check = new Fio();

			if (check.SetSurname(bufSurname) || check.SetName(bufName) || check.SetPatronymic(bufPatronymic))
				return (true);
			else
			{
				this.SetSurname(bufSurname);
				this.SetName(bufName);
				this.SetPatronymic(bufPatronymic);
				return (false);
			}
		}
		public bool SetSurname(string bufString)
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

			surname = new string(bufString.ToCharArray());
			return (false);
		}
		public bool SetName(string bufString)
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

			name = new string(bufString.ToCharArray());
			return (false);
		}
		public bool SetPatronymic(string bufString)
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

			patronymic = new string(bufString.ToCharArray());
			return (false);
		}

		public void HardSetSurname(string bufString)
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

			surname = new string(bufString.ToCharArray());
		}
		public void HardSetName(string bufString)
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

			name = new string(bufString.ToCharArray());
		}
		public void HardSetPatronymic(string bufString)
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

			patronymic = new string(bufString.ToCharArray());
		}

		public string GetSurname()
		{
			string outputString = new string(surname.ToCharArray());
			return (outputString);
		}
		public string GetName()
		{
			string outputString = new string(name.ToCharArray());
			return (outputString);
		}
		public string GetPatronymic()
		{
			string outputString = new string(patronymic.ToCharArray());
			return (outputString);
		}

		public void Read()
		{
			Fio check = new Fio();
			bool readFlag = true;
			while (readFlag) 
			{
				Console.Write("Enter surname:\n");
				try
				{
					check.HardSetSurname(Console.ReadLine());
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
				Console.Write("Enter name:\n");
				try
				{
					check.HardSetName(Console.ReadLine());
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
				Console.Write("Enter patronymic:\n");
				try
				{
					check.HardSetPatronymic(Console.ReadLine());
					readFlag = false;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			SetSurname(check.GetSurname());
			SetName(check.GetName());
			SetPatronymic(check.GetPatronymic());
		}

        public override string ToString()
        {
			string returnValue = "";
			returnValue += "FIO: " + surname + " " + name + " " + patronymic;
			return (returnValue);
        }

        public void Display()
		{
			Console.Write("FIO: {0} {1} {2}\n", surname, name, patronymic);
		}
	}
}

