package Prog_lab12_java;

import java.util.*;

public class Fio implements Cloneable
{
	//Attributes
	private String surname;
	private String name;
	private String patronymic;

	//Constructors
	public Fio()
	{
		surname = "unstated";
		name = "unstated";
		patronymic = "unstated";
	}

	public Fio(String bufSurname)
	{
		surname = "unstated";
		name = "unstated";
		patronymic = "unstated";

		setSurname(bufSurname);
	}

	public Fio(String bufSurname, String bufName, String bufPatronymic)
	{
		Fio check = new Fio();

		if (check.setSurname(bufSurname) || check.setName(bufName) || check.setPatronymic(bufPatronymic))
		{
			surname = "unstated";
			name = "unstated";
			patronymic = "unstated";
		}
		else
		{
			setSurname(bufSurname);
			setName(bufName);
			setPatronymic(bufPatronymic);
		}
	}

	//Methods with Exceptions
	public void hardSetSurname(String bufString)
	{
		if (bufString.isEmpty())
			throw new IllegalStateException("Caught an Exception!!! Input string is empty!\n");

		String invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
		char[] invalidSymbols = invalidSymbStr.toCharArray();
		for (char symb : invalidSymbols)
		{
			if(bufString.indexOf(symb) != (-1))
				throw new IllegalStateException("Caught an Exception!!! Input string contains invalid symbols!\n");
		}

		surname = surname.copyValueOf(bufString.toCharArray());
	}

	public void hardSetName(String bufString)
	{
		if (bufString.isEmpty())
			throw new IllegalStateException("Caught an Exception!!! Input string is empty!\n");

		String invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
		char[] invalidSymbols = invalidSymbStr.toCharArray();
		for (char symb : invalidSymbols)
		{
			if (bufString.indexOf(symb) != (-1))
				throw new IllegalStateException("Caught an Exception!!! Input string contains invalid symbols!\n");
		}

		name = name.copyValueOf(bufString.toCharArray());
	}

	public void hardSetPatronymic(String bufString)
	{
		if (bufString.isEmpty())
			throw new IllegalStateException("Caught an Exception!!! Input string is empty!\n");

		String invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
		char[] invalidSymbols = invalidSymbStr.toCharArray();
		for (char symb : invalidSymbols)
		{
			if (bufString.indexOf(symb) != (-1))
				throw new IllegalStateException("Caught an Exception!!! Input string contains invalid symbols!\n");
		}

		patronymic = patronymic.copyValueOf(bufString.toCharArray());
	}

	//Methods
	public boolean setSurname(String bufString)
	{
		if (bufString.isEmpty()) 
			return (true);
		
		String invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
		char[] invalidSymbols = invalidSymbStr.toCharArray();
		for (char symb : invalidSymbols) 
		{
			if(bufString.indexOf(symb) != (-1))
				return (true);
		}

		surname = surname.copyValueOf(bufString.toCharArray());
		return (false);
	}

	public boolean setName(String bufString)
	{
		if (bufString.isEmpty())
			return (true);
		
		String invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
		char[] invalidSymbols = invalidSymbStr.toCharArray();
		for (char symb : invalidSymbols)
		{
			if (bufString.indexOf(symb) != (-1))
				return (true);
		}

		name = name.copyValueOf(bufString.toCharArray());
		return (false);
	}

	public boolean setPatronymic(String bufString)
	{
		if (bufString.isEmpty())
			return (true);
			
		String invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
		char[] invalidSymbols = invalidSymbStr.toCharArray();
		for (char symb : invalidSymbols)
		{
			if (bufString.indexOf(symb) != (-1))
			return (true);
		}

		patronymic = patronymic.copyValueOf(bufString.toCharArray());
		return (false);
	}

	public boolean setAll(String bufSurname, String bufName, String bufPatronymic)
	{
		Fio check = new Fio();

		if (check.setSurname(bufSurname) || check.setName(bufName) || check.setPatronymic(bufPatronymic))
			return (true);
		else
		{
			this.setSurname(bufSurname);
			this.setName(bufName);
			this.setPatronymic(bufPatronymic);
			return (false);
		}
	}

	public String getSurname()
	{
		return (String.copyValueOf(surname.toCharArray()));
	}

	public String getName()
	{
		return (String.copyValueOf(name.toCharArray()));
	}

	public String getPatronymic()
	{
		return (String.copyValueOf(patronymic.toCharArray()));
	}

	public void read()
	{
		Fio check = new Fio();
		Scanner scanner = new Scanner(System.in);

		boolean readFlag = true;
		while(readFlag)
		{
			System.out.print("Enter surname:\n");
			try
			{
				check.hardSetSurname(scanner.nextLine());
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex.getMessage());
			}
		}

		readFlag = true;
		while(readFlag)
		{
			System.out.print("Enter name:\n");
			try
			{
				check.hardSetName(scanner.nextLine());
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex.getMessage());
			}
		}

		readFlag = true;
		while(readFlag)
		{
			System.out.print("Enter patronymic:\n");
			try
			{
				check.hardSetPatronymic(scanner.nextLine());
				readFlag = false;
			}
			catch (Exception ex)
			{
				System.out.print(ex.getMessage());
			}
		}

		this.setAll(check.getSurname(), check.getName(), check.getPatronymic());
	}

	public String toString()
	{
		String returnValue = "";
		returnValue += "FIO: " + surname + " " + name + " " + patronymic;
		return (returnValue);
	}

	public Object clone()
	{
		try
		{
			return ((Fio)super.clone());
		}
		catch(CloneNotSupportedException e)
		{

		}
		return this;
	}
}
