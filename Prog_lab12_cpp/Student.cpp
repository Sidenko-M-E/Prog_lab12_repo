#include "Student.h"
#include <iostream>

void Student::HardSetCourse(int buf)
{
	if (buf < 0 || buf > 6)
		throw invalid_argument("Invalid range of number.");
	else
		course = buf;
}

void Student::HardSetEduProg(string bufString)
{
	if (bufString.empty())
		throw logic_error("Input string is empty.");

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"π;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			throw invalid_argument("Input string contains invalid symbols.");
	}

	eduProg = bufString;
}

void Student::HardSetGroup(string bufString)
{
	if (bufString.empty())
		throw logic_error("Input string is empty.");

	char invalidSymbols[] = "!@#$%^&*()_+=\"π;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			throw invalid_argument("Input string contains invalid symbols.");
	}

	group = bufString;
}

void Student::HardSetFacultyName(string bufString)
{
	if (bufString.empty())
		throw logic_error("Input string is empty.");

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"π;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			throw invalid_argument("Input string contains invalid symbols.");
	}

	facultyName = bufString;
}

bool Student::SetCourse(int buf)
{
	if (buf < 0 || buf > 6)
		return (true);
	else
	{
		course = buf;
		return (false);
	}
}

bool Student::SetEduProg(string bufString)
{
	if (bufString.empty())
		return (true);

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"π;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			return (true);
	}

	eduProg = bufString;
	return (false);
}

bool Student::SetGroup(string bufString)
{
	if (bufString.empty())
		return (true);

	char invalidSymbols[] = "!@#$%^&*()_+=\"π;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			return (true);
	}

	group = bufString;
	return (false);
}

bool Student::SetFacultyName(string bufString)
{
	if (bufString.empty())
		return (true);

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"π;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			return (true);
	}

	facultyName = bufString;
	return (false);
}

bool Student::SetAll(int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman)
{
	cout << "Student SetAll has been called.\n";
	Student check;

	if (check.SetCourse(bufCourse) || check.SetEduProg(bufEduProg) || check.SetGroup(bufGroup) ||
		check.SetFacultyName(bufFacultyName))
		return (true);
	
	course = bufCourse;
	eduProg = bufEduProg;
	group = bufGroup;
	facultyName = bufFacultyName;
	humanField = bufHuman;
	return(false);
}

int Student::GetCourse()
{
	return (course);
}

string Student::GetEduProg()
{
	return (eduProg);
}

string Student::GetGroup()
{
	return (group);
}

string Student::GetFacultyName()
{
	return (facultyName);
}


Student::Student()
{
	course = 0;
	eduProg = "unstated";
	group = "unstated";
	facultyName = "unstated";
}

Student::Student(Human bufHuman)
{
	cout << "Student constructor with parameters has been called." << endl;
	course = 0;
	eduProg = "unstated";
	group = "unstated";
	facultyName = "unstated";
	humanField = bufHuman;
}

Student::Student(int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman)
{
	cout << "Student constructor with parameters has been called." << endl;
	Student check;

	if (check.SetCourse(bufCourse) || check.SetEduProg(bufEduProg) || check.SetGroup(bufGroup) ||
		check.SetFacultyName(bufFacultyName))
	{
		course = 0;
		eduProg = "unstated";
		group = "unstated";
		facultyName = "unstated";
	}
	else
	{
		course = bufCourse;
		eduProg = bufEduProg;
		group = bufGroup;
		facultyName = bufFacultyName;
		humanField = bufHuman;
	}
}

bool Student::IsScolarshipHigh()
{
	if (Scholarship—alc() > 4000)
		return (true);
	else
		return (false);
}

int Student::Scholarship—alc()
{
	if (course == 0)
		return (0);

	if (course == 1)
		return (1500);

	if (course == 2)
		return (1725);

	if (course == 3)
		return (2000);

	if (course == 4)
		return (2750);

	if (course == 5)
		return (3400);

	if (course == 6)
		return (4200);
}

void Student::Read()
{
	Student check;
	string bufString;

	bool readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter course:" << endl;
			getline(cin, bufString);
			check.HardSetCourse(stoi(bufString));
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
			cout << "\nEnter education programme:" << endl;
			getline(cin, bufString);
			check.HardSetEduProg(bufString);
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
			cout << "\nEnter group:" << endl;
			getline(cin, bufString);
			check.HardSetGroup(bufString);
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
			cout << "\nEnter faculty name:" << endl;
			getline(cin, bufString);
			check.HardSetFacultyName(bufString);
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}
				

	check.humanField.Read();

	course = check.GetCourse();
	eduProg = check.GetEduProg();
	group = check.GetGroup();
	facultyName = check.GetFacultyName();
	humanField = check.humanField;
}

void operator<<(ostream& smth, Student operandStudent)
{
	cout << "course: " << operandStudent.course << endl;
	cout << "direction of preparation: " << operandStudent.eduProg << endl;
	cout << "group: " << operandStudent.group << endl;
	cout << "faculty name: " << operandStudent.facultyName << endl;
	cout << operandStudent.humanField;
}
