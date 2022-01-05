#include "Human.h"
#include <cmath>
#include <string>
#include <iostream>


void Human::HardSetId(int buf)
{
	if (buf < 0 || buf > 9999)
		throw invalid_argument("Invalid range of number.");
	else
		id = buf;
}

void Human::HardSetAge(int buf)
{
	if (buf < 0 || buf > 200)
		throw invalid_argument("Invalid range of number.");
	else
		age = buf;
}

void Human::HardSetHeight(int buf)
{
	if (buf < 40 || buf > 300)
		throw invalid_argument("Invalid range of number.");
	else
		height = buf;
}

void Human::HardSetWeight(double buf)
{
	buf = round(buf * 100) / 100;
	if (buf < 0 || buf > 650)
		throw invalid_argument("Invalid range of number.");
	else
		weight = buf;
}

void Human::HardSetGender(char buf)
{
	if (buf == 'M' || buf == 'F')
		gender = buf;
	else
		throw invalid_argument("Invalid range of number.");
}

bool Human::SetId(int buf)
{
	if (buf < 0 || buf > 9999)
		return (true);
	else
	{
		id = buf;
		return (false);
	}
}

bool Human::SetAge(int buf)
{
	if (buf < 0 || buf > 200)
		return (true);
	else
	{
		age = buf;
		return (false);
	}
}

bool Human::SetHeight(int buf)
{
	if (buf < 40 || buf > 300)
		return (true);
	else
	{
		height = buf;
		return (false);
	}
}

bool Human::SetWeight(double buf)
{
	buf = round(buf * 100) / 100;
	if (buf < 0 || buf > 650)
		return (true);
	else
	{
		weight = buf;
		return (false);
	}
}

bool Human::SetGender(char buf)
{
	if (buf == 'M' || buf == 'F')
	{
		gender = buf;
		return (false);
	}
	else
		return (true);
}

int Human::GetId()
{
	return (id);
}

int Human::GetAge()
{
	return (age);
}

int Human::GetHeight()
{
	return (height);
}

double Human::GetWeight()
{
	return (weight);
}

char Human::GetGender()
{
	return (gender);
}

Human::Human()
{	
	id = 0;
	age = 0;
	height = 40;
	weight = 0;
	gender = 'M';
}

Human::Human(int bufId)
{
	id = 0;
	age = 0;
	height = 40;
	weight = 0;
	gender = 'M';

	SetId(bufId);
}

Human::Human(int bufId, int bufAge, int bufHeight, double bufWeight, char bufGender, Fio bufFio)
{
	Human check;

	if (check.SetId(bufId) || check.SetAge(bufAge) || check.SetHeight(bufHeight) ||
		check.SetWeight(bufWeight) || check.SetGender(bufGender))
	{
		id = 0;
		age = 0;
		height = 40;
		weight = 0;
		gender = 'M';
	}
	else
	{
		id = bufId;
		age = bufAge;
		height = bufHeight;
		weight = bufWeight;
		gender = bufGender;
		fioField = bufFio;
	}
}


void Human::Read()
{
	Human check;
	string bufString;
	char bufChar;

	bool readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter id:" << endl;
			getline(cin, bufString);
			check.HardSetId(stoi(bufString));
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
			cout << "\nEnter age:" << endl;
			getline(cin, bufString);
			check.HardSetAge(stoi(bufString));
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
			cout << "\nEnter height:" << endl;
			getline(cin, bufString);
			check.HardSetHeight(stoi(bufString));
	
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
			cout << "\nEnter weight:" << endl;
			getline(cin, bufString);
			check.HardSetWeight(stod(bufString));
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
			cout << "\nEnter gender:" << endl;
			cin >> bufChar;
			cin.ignore();
			check.HardSetGender(bufChar);
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}

	check.fioField.Read();

	id = check.GetId();
	age = check.GetAge();
	height = check.GetHeight();
	weight = check.GetWeight();
	gender = check.GetGender();
	fioField = check.fioField;							
}

void operator<<(ostream& smth, Human operandHuman)
{
	cout << "id: " << operandHuman.id << endl;
	cout << "age: " << operandHuman.age << endl;
	cout << "height: " << operandHuman.height << endl;
	cout.setf(ios::fixed);
	cout.precision(2);
	cout << "weight: " << operandHuman.weight << endl;
	cout.unsetf(ios::fixed);
	cout << "gender: " << operandHuman.gender << endl;
	cout << operandHuman.fioField;
}
