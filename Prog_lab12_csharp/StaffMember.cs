using System;

namespace Prog_lab12
{
	public abstract class StaffMember
	{
		//Attributes
		protected int workExp;
		protected int numberOfPubl;
		public Fio fioField;

		//Constructors
		public StaffMember()
		{
			workExp = 0;
			numberOfPubl = 0;
			fioField = new Fio();
		}
		public StaffMember(int bufWorkExp, int bufNumberOfPubl, Fio bufFio)
		{
			workExp = 0;
			numberOfPubl = 0;
			SetWorkExp(bufWorkExp);
			SetNumberOfPubl(bufNumberOfPubl);
			fioField = new Fio(bufFio.GetSurname(), bufFio.GetName(), bufFio.GetPatronymic());
		}

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
		public bool SetNumberOfPubl(int buf)
		{
			if (buf < 0 || buf > 100)
				return (true);
			else
			{
				numberOfPubl = buf;
				return (false);
			}
		}

		public int GetWorkExp()
		{
			return (workExp);
		}
		public int GetNumberOfPubl()
		{
			return (numberOfPubl);
		}

		public abstract int CalculateSalary();
        public override string ToString()
        {
			string returnValue = "";
			returnValue += "working experience: " + workExp.ToString() +
				"\nnumber of publications: " + numberOfPubl.ToString() +
				"\n" + fioField.ToString();
			return (returnValue);
		}
    }
}