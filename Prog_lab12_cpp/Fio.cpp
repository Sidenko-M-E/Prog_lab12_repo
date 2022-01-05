#include "Fio.h"
#include <iostream>


void Fio::HardSetSurname(string bufString)
{
	if (bufString.empty())
		throw logic_error("Input string is empty.");

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"¹;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			throw invalid_argument("Input string contains invalid symbols.");
	}

	surname = bufString;
}

void Fio::HardSetName(string bufString)
{
	if (bufString.empty())
		throw logic_error("Input string is empty.");

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"¹;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			throw invalid_argument("Input string contains invalid symbols.");
	}

	name = bufString;
}

void Fio::HardSetPatronymic(string bufString)
{
	if (bufString.empty())
		throw logic_error("Input string is empty.");

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"¹;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			throw invalid_argument("Input string contains invalid symbols.");
	}

	patronymic = bufString;
}

bool Fio::SetSurname(string bufString)
{ 
	if (bufString.empty())
		return (true);

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"¹;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			return (true);
	}
	
	surname = bufString;
	return (false);
}

bool Fio::SetName(string bufString) 
{
	if (bufString.empty())
		return (true);

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"¹;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			return (true);
	}

	name = bufString;
	return (false);
}

bool Fio::SetPatronymic(string bufString) 
{
	if (bufString.empty())
		return (true);

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"¹;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			return (true);
	}

	patronymic = bufString;
	return (false);
}

string Fio::GetSurname()
{
	return (surname);
}

string Fio::GetName() 
{ 
	return (name);
}

string Fio::GetPatronymic() 
{ 
	return (patronymic);
}

Fio::Fio()
{
	surname = "unstated";
	name = "unstated";
	patronymic = "unstated";
}

Fio::Fio(string bufSurname)
{
	surname = "unstated";
	name = "unstated";
	patronymic = "unstated";

	SetSurname(bufSurname);
}

Fio::Fio(string bufSurname, string bufName, string bufPatronymic)
{
	Fio check;

	if (check.SetSurname(bufSurname) || check.SetName(bufName) || check.SetPatronymic(bufPatronymic))
	{
		surname = "unstated";
		name = "unstated";
		patronymic = "unstated";
	}
	else
	{
		surname = bufSurname;
		name = bufName;
		patronymic = bufPatronymic;
	}
}

void Fio::Read()
{
	Fio check;
	string bufString;

	bool readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter surname:" << endl;
			getline(cin, bufString);
			check.HardSetSurname(bufString);
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}

	readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter name:" << endl;
			getline(cin, bufString);
			check.HardSetName(bufString);
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}
	
	readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter patronymic:" << endl;
			getline(cin, bufString);
			check.HardSetPatronymic(bufString);
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}

	surname = check.GetSurname();
	name = check.GetName();
	patronymic = check.GetPatronymic();
}

void operator<<(ostream& smth, Fio operandFio)
{
	cout << "FIO:" + operandFio.surname + " " + operandFio.name + " " + operandFio.patronymic << endl;
}
