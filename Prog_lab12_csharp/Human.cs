using System;

namespace Prog_lab12
{
    public class Human : ICloneable
    {
		//Attributes
		private int id;
		private int age;
		private int height;
		private double weight;
		private char gender;
		public Fio fioField;

		//Properties
		public int Id
		{
			get
			{
				return id;
			}
			set
			{
				if ((value >= 0) && (value <= 9999))
					id = value;
			}
		}
		public int Age 
		{
			get
			{
				return age;
			}
			set
			{
				if ((value >= 0) && (value <= 200))
					age = value;
			}
		}
		public int Height
		{
			get
			{
				return height;
			}
			set
			{
				if ((value >= 40) && (value <= 300))
					height = value;
			}
		}
		public double Weight
		{
			get
			{
				return weight;
			}
			set
			{
				value = Math.Round(value, 1, MidpointRounding.AwayFromZero);
				if ((value >= 0) && (value <= 650))
					weight = value;
			}
		}
		public char Gender
        {
			get
			{
				return gender;
			}
			set
			{
				if (value == 'M' || value == 'F')
					gender = value;
			}
		}
		public Fio FioField 
		{
			get
			{
				return (fioField);
			}
			set
			{
				fioField = new Fio(value.GetSurname(), value.GetName(), value.GetPatronymic());
			}
		}

		//Constructors
		public Human()
		{
			id = 0;
			age = 0;
			height = 40;
			weight = 0;
			gender = 'M';
			fioField = new Fio();
		}
		public Human(int bufId)
		{
			id = 0;
			age = 0;
			height = 40;
			weight = 0;
			gender = 'M';
			fioField = new Fio();

			SetId(bufId);
		}
		public Human(int bufId, int bufAge, int bufHeight, double bufWeight, char bufGender, Fio bufFio)
		{
			Human check = new Human();

			if (check.SetId(bufId) || check.SetAge(bufAge) || check.SetHeight(bufHeight) ||
				check.SetWeight(bufWeight) || check.SetGender(bufGender))
			{
				id = 0;
				age = 0;
				height = 40;
				weight = 0;
				gender = 'M';
				fioField = new Fio();
			}
			else
			{
				SetId(bufId);
				SetAge(bufAge);
				SetHeight(bufHeight);
				SetWeight(bufWeight);
				SetGender(bufGender);
				fioField = new Fio(bufFio.GetSurname(), bufFio.GetName(), bufFio.GetPatronymic());
			}
		}

		//Methods with Exceptions
		public void HardSetId(int buf)
		{
			if (buf < 0 || buf > 9999)
				throw new Exception("Invalid range of number.");
			else
				id = buf;
		}
		public void HardSetAge(int buf)
		{
			if (buf < 0 || buf > 200)
				throw new Exception("Invalid range of number.");
			else
				age = buf;
		}
		public void HardSetHeight(int buf)
		{
			if (buf < 40 || buf > 300)
				throw new Exception("Invalid range of number.");
			else
				height = buf;
		}
		public void HardSetWeight(double buf)
		{
			//round *.* format to *.00 format 
			buf = Math.Round(buf, 2, MidpointRounding.AwayFromZero);
			if (buf < 0 || buf > 650)
				throw new Exception("Invalid range of number.");
			else
				weight = buf;
		}
		public void HardSetGender(char buf)
		{
			if (buf == 'M' || buf == 'F')
			{
				gender = buf;
			}
			else
				throw new Exception("Invalid symbol.");
		}

		//Methods
		public bool SetId(int buf)
		{
			if (buf < 0 || buf > 9999)
				return (true);
			else
			{
				id = buf;
				return (false);
			}
		}
		public bool SetAge(int buf)
		{
			if (buf < 0 || buf > 200)
				return (true);
			else
			{
				age = buf;
				return (false);
			}
		}
		public bool SetHeight(int buf)
		{
			if (buf < 40 || buf > 300)
				return (true);
			else
			{
				height = buf;
				return (false);
			}
		}
		public bool SetWeight(double buf)
		{
			//round *.* format to *.1 format 
			buf = Math.Round(buf, 1, MidpointRounding.AwayFromZero);
			if (buf < 0 || buf > 650)
				return (true);
			else
			{
				weight = buf;
				return (false);
			}
		}
		public bool SetGender(char buf)
		{
			if (buf == 'M' || buf == 'F')
			{
				gender = buf;
				return (false);
			}
			else
				return (true);
		}
		public bool SetAll(int bufId, int bufAge, int bufHeight, double bufWeight, char bufGender, Fio bufFio)
		{
			Human check = new Human();

			if (check.SetId(bufId) || check.SetAge(bufAge) || check.SetHeight(bufHeight) ||
				check.SetWeight(bufWeight) || check.SetGender(bufGender))
				return (true);
			else
			{
				SetId(check.GetId());
				SetAge(check.GetAge());
				SetHeight(check.GetHeight());
				SetWeight(check.GetWeight());
				SetGender(check.GetGender());
				fioField.SetAll(bufFio.GetSurname(), bufFio.GetName(), bufFio.GetPatronymic());
				return (false);
			}
		}

		public int GetId()
		{ return (id); }
		public int GetAge()
		{ return (age); }
		public int GetHeight()
		{ return (height); }
		public double GetWeight()
		{ return (weight); }
		public char GetGender()
		{ return (gender); }

		public void Read()
		{
			Human check = new Human();
			int bufInt;
			double bufDouble;
			char bufChar;

			bool readFlag = true;
			while (readFlag)
			{
				Console.Write("Enter id:\n");
                try
                {
					bufInt = int.Parse(Console.ReadLine());
					check.HardSetId(bufInt);
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
				Console.Write("Enter age:\n");
				try
				{
					bufInt = int.Parse(Console.ReadLine());
					check.HardSetAge(bufInt);
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
				Console.Write("Enter height:\n");
				try
				{
					bufInt = int.Parse(Console.ReadLine());
					check.HardSetHeight(bufInt);
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
				Console.Write("Enter weight:\n");
				try
				{
					bufDouble = double.Parse(Console.ReadLine());
					check.HardSetWeight(bufDouble);
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
				Console.Write("Enter gender:\n");
				try
				{
					bufChar = char.Parse(Console.ReadLine());
					check.HardSetGender(bufChar);
					readFlag = false;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			check.fioField.Read();

			SetAll(check.GetId(), check.GetAge(), 
				check.GetHeight(), check.GetWeight(), 
				check.GetGender(), check.fioField);
		}
        public override string ToString()
        {
			string returnValue = "";
			returnValue += "id: " + id.ToString() + 
				"\nage: " + age.ToString() + 
				"\nheight: " + height.ToString() + 
				"\nweigth: " + weight.ToString() + 
				"\ngender: " + gender + 
				"\n" + fioField.ToString();
			return (returnValue);
        }
		public object Clone()
		{
			return new Human(id, age, height, weight, gender, fioField);
		}
	}
}
