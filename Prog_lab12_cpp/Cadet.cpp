#include "Cadet.h"
#include <iostream>

Cadet::Cadet()
{
	sessionRes = 0;
	militaryRank = "unstated";
}

Cadet::Cadet(Human bufHuman):Student(bufHuman)
{
	sessionRes = 0;
	militaryRank = "unstated";
}

Cadet::Cadet(int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman):Student(bufCourse, bufEduProg, bufGroup, bufFacultyName, bufHuman)
{
	sessionRes = 0;
	militaryRank = "unstated";
}

Cadet::Cadet(int bufSessionRes, string bufMilitaryRank, int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman)
{
	Cadet check;

	if (check.SetSessionRes(bufSessionRes) || check.SetMilitaryRank(bufMilitaryRank) ||
		check.SetCourse(bufCourse) || check.SetEduProg(bufEduProg) ||
		check.SetGroup(bufGroup) || check.SetFacultyName(bufFacultyName))
	{
		sessionRes = 0;
		militaryRank = "unstated";
	}
	else
	{
		sessionRes = bufSessionRes;
		militaryRank = bufMilitaryRank;
		course = bufCourse;
		eduProg = bufEduProg;
		group = bufGroup;
		facultyName = bufFacultyName;
		humanField = bufHuman;
	}
}

bool Cadet::SetSessionRes(int buf)
{
	if (buf < 0 || buf > 100)
		return (true);
	else
	{
		sessionRes = buf;
		return (false);
	}
}

bool Cadet::SetMilitaryRank(string bufString)
{
	if (bufString.empty())
		return (true);

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"¹;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			return (true);
	}

	militaryRank = bufString;
	return (false);
}

bool Cadet::SetAll(int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman)
{
	cout << "Cadet SetAll has been called.\n";
	if (Student::SetAll(bufCourse, bufEduProg, bufGroup, bufFacultyName, bufHuman))
		return (true);

	sessionRes = 0;
	militaryRank = "unstated";
	return(false);
}

bool Cadet::SetAll(int bufSessionRes, string bufMilitaryRank, int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman)
{
	cout << "Cadet SetAll has been called.\n";
	Cadet check;

	if (check.SetSessionRes(bufSessionRes) || check.SetMilitaryRank(bufMilitaryRank) ||
		check.SetCourse(bufCourse) || check.SetEduProg(bufEduProg) || 
		check.SetGroup(bufGroup) || check.SetFacultyName(bufFacultyName))
		return (true);

	sessionRes = bufSessionRes;
	militaryRank = bufMilitaryRank;

	course = bufCourse;
	eduProg = bufEduProg;
	group = bufGroup;
	facultyName = bufFacultyName;
	humanField = bufHuman;
	return(false);
}

int Cadet::GetSessionRes()
{
	return(sessionRes);
}

string Cadet::GetMilitaryRank()
{
	return(militaryRank);
}

void Cadet::operator=(Student operandStudent)
{
	sessionRes = 0;
	militaryRank = "unstated";
	course = operandStudent.GetCourse();
	eduProg = operandStudent.GetEduProg();
	group = operandStudent.GetGroup();
	facultyName = operandStudent.GetFacultyName();
	humanField = operandStudent.humanField;
}

int Cadet::ScholarshipÑalc()
{
	int bonusScolarship = 0;
	if (sessionRes <= 24)
		return(0);
	if ((sessionRes >= 50) && (sessionRes <= 74))
		bonusScolarship = 1000;
	if ((sessionRes >= 75) && (sessionRes <= 100))
		bonusScolarship = 2000;

	if (course == 0)
		return (0);

	if (course == 1)
		return (1500.25 + bonusScolarship);

	if (course == 2)
		return (1725.25 + bonusScolarship);

	if (course == 3)
		return (2000.50 + bonusScolarship);

	if (course == 4)
		return (2750.75 + bonusScolarship);

	if (course == 5)
		return (3400.15 + bonusScolarship);

	if (course == 6)
		return (4200.35 + bonusScolarship);
}

void operator<<(ostream& smth, Cadet operandCadet)
{
	cout << "session results: " << operandCadet.sessionRes << endl;
	cout << "military rank: " << operandCadet.militaryRank << endl;
	cout << "course: " << operandCadet.course << endl;
	cout << "direction of preparation: " << operandCadet.eduProg << endl;
	cout << "group: " << operandCadet.group << endl;
	cout << "faculty name: " << operandCadet.facultyName << endl;
	cout << operandCadet.humanField;
}
