package Prog_lab12_java;

import java.util.*;

public class Faculty
{
	//Attributes
	private String facultyName;
	private int quantityOfStudents;
	private int quantityOfBachelors;
	private int quantityOfMasters;
	private int quantityOfTeachers; 
	private int quantityOfCandidates;
	private int quantityOfDoctors;
	private int quantityOfDisciplines;

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

	public Faculty(String bufFacultyName)
	{
		facultyName = "unstated";
		quantityOfStudents = 0;
		quantityOfBachelors = 0;
		quantityOfMasters = 0;
		quantityOfTeachers = 0;
		quantityOfCandidates = 0;
		quantityOfDoctors = 0;
		quantityOfDisciplines = 0;

		setFacultyName(bufFacultyName);
	}
	public Faculty(String bufFacultyName, int studentsQuantity, int bachelorsQuantity, int mastersQuantity,
				   int teachersQuantity, int candidatesQuantity, int doctorsQuantity, int disciplinesQuantity)
	{
		Faculty check = new Faculty();

		if (check.setFacultyName(bufFacultyName) || check.setQuantityOfStudents(studentsQuantity) ||
				check.setQuantityOfBachelors(bachelorsQuantity) || check.setQuantityOfMasters(mastersQuantity) ||
				check.setQuantityOfTeachers(teachersQuantity) || check.setQuantityOfCandidates(candidatesQuantity) ||
				check.setQuantityOfDoctors(doctorsQuantity) || check.setQuantityOfDisciplines(disciplinesQuantity))
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
			setFacultyName(bufFacultyName);
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
	public void hardSetFacultyName(String bufString)
	{
		if (bufString.isEmpty()) {
			throw new IllegalStateException("Caught an Exception!!! Input string is empty!\n");
		}

		String invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
		char[] invalidSymbols = invalidSymbStr.toCharArray();
		for (char symb : invalidSymbols)
		{
			if(bufString.indexOf(symb) != (-1))
				throw new IllegalStateException("Caught an Exception!!! Input string contains invalid symbols!\n");
		}

		facultyName = facultyName.copyValueOf(bufString.toCharArray());
	}
	public void hardSetQuantityOfStudents(int buf)
	{
		if (buf < 0 || buf > 1000)
			throw new NumberFormatException("Caught an Exception!!! Invalid range of number!\n");
		else
			quantityOfStudents = buf;
	}
	public void hardSetQuantityOfBachelors(int buf)
	{
		if (buf < 0 || buf > 1000)
			throw new NumberFormatException("Caught an Exception!!! Invalid range of number!\n");
		else
			quantityOfBachelors = buf;
	}
	public void hardSetQuantityOfMasters(int buf)
	{
		if (buf < 0 || buf > 1000)
			throw new NumberFormatException("Caught an Exception!!! Invalid range of number!\n");
		else
			quantityOfMasters = buf;
	}
	public void hardSetQuantityOfTeachers(int buf)
	{
		if (buf < 0 || buf > 100)
			throw new NumberFormatException("Caught an Exception!!! Invalid range of number!\n");
		else
			quantityOfTeachers = buf;
	}
	public void hardSetQuantityOfCandidates(int buf)
	{
		if (buf < 0 || buf > 100)
			throw new NumberFormatException("Caught an Exception!!! Invalid range of number!\n");
		else
			quantityOfCandidates = buf;
	}
	public void hardSetQuantityOfDoctors(int buf)
	{
		if (buf < 0 || buf > 100)
			throw new NumberFormatException("Caught an Exception!!! Invalid range of number!\n");
		else
			quantityOfDoctors = buf;
	}
	public void hardSetQuantityOfDisciplines(int buf)
	{
		if (buf < 0 || buf > 100)
			throw new NumberFormatException("Caught an Exception!!! Invalid range of number!\n");
		else
			quantityOfDisciplines = buf;
	}


	//Methods
	public boolean setFacultyName(String bufString)
	{
		if (bufString.isEmpty()) {
			return (true);
		}

		String invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
		char[] invalidSymbols = invalidSymbStr.toCharArray();
		for (char symb : invalidSymbols) 
		{
			if(bufString.indexOf(symb) != (-1))
				return (true);
		}

		facultyName = facultyName.copyValueOf(bufString.toCharArray());
		return (false);
	}
	public boolean setQuantityOfStudents(int buf)
	{
		if (buf < 0 || buf > 1000)
			return (true);
		else
		{
			quantityOfStudents = buf;
			return (false);
		}
	}
	public boolean setQuantityOfBachelors(int buf)
	{
		if (buf < 0 || buf > 1000)
		return (true);
		else
		{
			quantityOfBachelors = buf;
			return (false);
		}
	}
	public boolean setQuantityOfMasters(int buf)
	{
		if (buf < 0 || buf > 1000)
		return (true);
		else
		{
			quantityOfMasters = buf;
			return (false);
		}
	}
	public boolean setQuantityOfTeachers(int buf)
	{
		if (buf < 0 || buf > 100)
		return (true);
		else
		{
			quantityOfTeachers = buf;
			return (false);
		}
	}
	public boolean setQuantityOfCandidates(int buf)
	{
		if (buf < 0 || buf > 100)
		return (true);
		else
		{
			quantityOfCandidates = buf;
			return (false);
		}
	}
	public boolean setQuantityOfDoctors(int buf)
	{
		if (buf < 0 || buf > 100)
		return (true);
		else
		{
			quantityOfDoctors = buf;
			return (false);
		}
	}
	public boolean setQuantityOfDisciplines(int buf)
	{
		if (buf < 0 || buf > 100)
		return (true);
		else
		{
			quantityOfDisciplines = buf;
			return (false);
		}
	}
	public boolean setStudentsInfo(int allQuantity, int bachelorsQuantity, int mastersQuantity)
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
	public boolean setTeachersInfo(int allQuantity, int candidatesQuantity, int doctorsQuantity)
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
	public boolean setAll(String bufFacultyName, int studentsQuantity, int bachelorsQuantity, int mastersQuantity, int teachersQuantity, int candidatesQuantity, int doctorsQuantity, int disciplinesQuantity)
	{
		Faculty check = new Faculty();

		if (check.setFacultyName(bufFacultyName) || check.setQuantityOfStudents(studentsQuantity) ||
				check.setQuantityOfBachelors(bachelorsQuantity) || check.setQuantityOfMasters(mastersQuantity) ||
				check.setQuantityOfTeachers(teachersQuantity) || check.setQuantityOfCandidates(candidatesQuantity) ||
				check.setQuantityOfDoctors(doctorsQuantity) || check.setQuantityOfDisciplines(disciplinesQuantity))
			return (true);
		else
		{
			this.setFacultyName(bufFacultyName);
			this.setStudentsInfo(studentsQuantity, bachelorsQuantity, mastersQuantity);
			this.setTeachersInfo(teachersQuantity, candidatesQuantity, doctorsQuantity);
			this.setQuantityOfDisciplines(disciplinesQuantity);
			return (false);
		}
	}


	public String getFacultyName()
	{
		return (String.copyValueOf(facultyName.toCharArray()));
	}
	public int getQuantityOfStudents()
	{
		return quantityOfStudents;
	}
	public int getQuantityOfBachelors()
	{
		return quantityOfBachelors;
	}
	public int getQuantityOfMasters()
	{
		return quantityOfMasters;
	}
	public int getQuantityOfTeachers()
	{
		return quantityOfTeachers;
	}
	public int getQuantityOfCandidates()
	{
		return quantityOfCandidates;
	}
	public int getQuantityOfDoctors()
	{
		return quantityOfDoctors;
	}
	public int getQuantityOfDisciplines()
	{
		return quantityOfDisciplines;
	}	


	//Processing methods
	public double getPercentOfMasters()
	{
		if (quantityOfStudents == 0)
			throw new IllegalStateException("Caught an Exception!!! Can't divide by QuantityOfStudents = 0!\n");
		return (((double) quantityOfMasters) / ((double) quantityOfStudents) * 100);
	}
	public double getPercentOfDoctors()
	{
		if (quantityOfTeachers == 0)
			throw new IllegalStateException("Caught an Exception!!! Can't divide by QuantityOfTeachers = 0!\n");
		return (((double) quantityOfDoctors) / ((double) quantityOfTeachers) * 100);
	}
	public double getStudToTeachRatio()
	{
		if (quantityOfStudents == 0)
			throw new IllegalStateException("Caught an Exception!!! Can't divide by QuantityOfStudents = 0!\n");
		return ((double) quantityOfStudents) / ((double) quantityOfTeachers);
	}
	public Faculty getWithMoreCandidates(Faculty buf)
	{
		if (this.getQuantityOfCandidates() >= buf.getQuantityOfCandidates())
			return (this);
		else
			return (buf);
	}
	public void read()
	{
		Faculty check = new Faculty();
		Scanner scanner = new Scanner(System.in);

	   	boolean readFlag = true;
		while(readFlag)
	   {
			System.out.print("Enter faculty name:\n");
			try
			{
				check.hardSetFacultyName(scanner.nextLine());
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex);
			}
		}

	   readFlag = true;
	   while(readFlag)
	   {
			System.out.print("Enter quantity of students:\n");
			try
			{
				check.hardSetQuantityOfStudents(Integer.parseInt(scanner.nextLine()));
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex);
			}
		}

		readFlag = true;
		while(readFlag)
		{
			System.out.print("Enter quantity of bachelors:\n");
			try
			{
				check.hardSetQuantityOfBachelors(Integer.parseInt(scanner.nextLine()));
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex);
			}
		}

		readFlag = true;
		while(readFlag)
		{
			System.out.print("Enter quantity of masters:\n");
			try
			{
				check.hardSetQuantityOfMasters(Integer.parseInt(scanner.nextLine()));
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex);
			}
		}

		readFlag = true;
		while(readFlag)
		{
			System.out.print("Enter quantity of teachers:\n");
			try
			{
				check.hardSetQuantityOfTeachers(Integer.parseInt(scanner.nextLine()));
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex);
			}
		}

		readFlag = true;
		while(readFlag)
		{
			System.out.print("Enter quantity of candidates:\n");
			try
			{
				check.hardSetQuantityOfCandidates(Integer.parseInt(scanner.nextLine()));
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex);
			}
		}

		readFlag = true;
		while(readFlag)
		{
			System.out.print("Enter quantity of doctors:\n");
			try
			{
				check.hardSetQuantityOfDoctors(Integer.parseInt(scanner.nextLine()));
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex);
			}
		}

		readFlag = true;
		while(readFlag)
		{
			System.out.print("Enter quantity of disciplines:\n");
			try
			{
				check.hardSetQuantityOfDisciplines(Integer.parseInt(scanner.nextLine()));
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex);
			}
		}

		this.setAll(check.getFacultyName(), check.getQuantityOfStudents(), check.getQuantityOfBachelors(),
				check.getQuantityOfMasters(), check.getQuantityOfTeachers(), check.getQuantityOfTeachers(),
				check.getQuantityOfDoctors(), check.getQuantityOfDisciplines());
	}
	public void display()
	{
	System.out.printf("faculty name: %s\n", facultyName);
	System.out.printf("quantity of students: %d\n", quantityOfStudents);
	System.out.printf("quantity of bachelors: %d\n", quantityOfBachelors);
	System.out.printf("quantity of masters: %d\n\n", quantityOfMasters);

	System.out.printf("quantity of teachers: %d\n", quantityOfTeachers);
	System.out.printf("quantity of candidates: %d\n", quantityOfCandidates);
	System.out.printf("quantity of doctors: %d\n\n", quantityOfDoctors);

	System.out.printf("quantity of disciplines: %d\n\n", quantityOfDisciplines);
   }

	public String toString()
	{
		String returnValue = "";
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
