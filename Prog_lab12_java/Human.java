package Prog_lab12_java;

import java.util.*;

public class Human implements Cloneable
{
	//Attributes
	private int id;
	private int age;
	private int height;
	private double weight;
	private char gender;
	public Fio fioField;

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

		setId(bufId);
	}

	public Human(int bufId, int bufAge, int bufHeight, double bufWeight, char bufGender, Fio bufFio)
	{
		Human check = new Human();

		if (check.setId(bufId) || check.setAge(bufAge) || check.setHeight(bufHeight) ||
				check.setWeight(bufWeight) || check.setGender(bufGender))
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
			setId(bufId);
			setAge(bufAge);
			setHeight(bufHeight);
			setWeight(bufWeight);
			setGender(bufGender);
			fioField = new Fio(bufFio.getSurname(), bufFio.getName(), bufFio.getPatronymic());
		}
	}

	//Methods with Exceptions
	public void hardSetId(int buf)
	{
		if (buf < 0 || buf > 9999)
			throw new NumberFormatException("Invalid range of number.\n");
		else
			id = buf;
	}

	public void hardSetAge(int buf)
	{
		if (buf < 0 || buf > 200)
			throw new NumberFormatException("Invalid range of number.\n");
		else
			age = buf;
	}

	public void hardSetHeight(int buf)
	{
		if (buf < 40 || buf > 300)
			throw new NumberFormatException("Invalid range of number.\n");
		else
			height = buf;
	}

	public void hardSetWeight(double buf)
	{
		//round *.* format to *.00 format
		buf = (double)(Math.round(buf * 100)) / 100;
		if (buf < 0 || buf > 650)
			throw new NumberFormatException("Invalid range of number.\n");
		else
			weight = buf;
	}

	public void hardSetGender(char buf)
	{
		if (buf == 'M' || buf == 'F')
			gender = buf;
		else
			throw new IllegalStateException("Invalid symbol.\n");
	}


	//Methods
	public int getBodyMassIndex()
	{
		return (BodyMassIndex.calculate(height, weight));
	}

	public boolean setId(int buf)
	{
		if (buf < 0 || buf > 9999)
			return (true);
		else
		{
			id = buf;
			return (false);
		}
	}

	public boolean setAge(int buf)
	{
		if (buf < 0 || buf > 200)
			return (true);
		else
		{
			age = buf;
			return (false);
		}
	}

	public boolean setHeight(int buf)
	{
		if (buf < 40 || buf > 300)
			return (true);
		else
		{
			height = buf;
			return (false);
		}
	}

	public boolean setWeight(double buf)
	{
		//round *.* format to *.1 format 
		buf = (double)(Math.round(buf * 10)) / 10;
		if (buf < 0 || buf > 650)
			return (true);
		else
		{
			weight = buf;
			return (false);
		}
	}

	public boolean setGender(char buf)
	{
		if (buf == 'M' || buf == 'F')
		{
			gender = buf;
			return(false);
		}
		else
			return (true);
	}

	public boolean setAll(int bufId, int bufAge, int bufHeight, double bufWeight, char bufGender, Fio bufFio)
	{
		Human check = new Human();

		if (check.setId(bufId) || check.setAge(bufAge) || check.setHeight(bufHeight) ||
				check.setWeight(bufWeight) || check.setGender(bufGender))
			return (true);
		else
		{
			setId(check.getId());
			setAge(check.getAge());
			setHeight(check.getHeight());
			setWeight(check.getWeight());
			setGender(check.getGender());
			fioField.setAll(bufFio.getSurname(), bufFio.getName(), bufFio.getPatronymic());
			return (false);
		}
	}

	public int getId()
	{
		return (id);
	}

	public int getAge()
	{
		return (age);
	}

	public int getHeight()
	{
		return (height);
	}

	public double getWeight()
	{
		return (weight);
	}

	public char getGender()
	{
		return (gender);
	}

	public void read()
	{
		Human check = new Human();
		Scanner scanner = new Scanner(System.in);

		boolean readFlag = true;
		while(readFlag)
		{
			System.out.print("Enter id:\n");
			try
			{
				check.hardSetId(Integer.parseInt(scanner.nextLine()));
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
			System.out.print("Enter age:\n");
			try
			{
				check.hardSetAge(Integer.parseInt(scanner.nextLine()));
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
			System.out.print("Enter height:\n");
			try
			{
				check.hardSetHeight(Integer.parseInt(scanner.nextLine()));
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
			System.out.print("Enter weight:\n");
			try
			{
				check.hardSetWeight(Double.parseDouble(scanner.nextLine()));
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
			System.out.print("Enter gender:\n");
			try
			{
				check.hardSetGender(scanner.next(".").charAt(0));
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex);
			}
		}

		check.fioField.read();

		this.setAll(check.getId(), check.getAge(), check.getHeight(),
				check.getWeight(), check.getGender(), check.fioField);
	}

	public String toString()
	{
	String returnValue = "";
	returnValue += "id: " + id +
			"\nage: " + age +
			"\nheight: " + height +
			"\nweigth: " + weight +
			"\ngender: " + gender +
			"\n" + fioField.toString();
	return (returnValue);
	}

	public Object clone()
	{
		try
		{
			Human clone = (Human)super.clone();
			clone.fioField = (Fio)fioField.clone();
			return (clone);
		}
		catch(CloneNotSupportedException e)
		{

		}
		return this;
	}
}
