#pragma once
#include "Student.h"

class Cadet : public Student
{
private:
	int sessionRes;
	string militaryRank;

public:
	Cadet();
	Cadet(Human bufHuman);
	Cadet(int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman);
	Cadet(int bufSessionRes, string bufMilitaryRank, int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman);

	bool SetSessionRes(int buf);
	bool SetMilitaryRank(string bufString);
	bool SetAll(int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman);
	bool SetAll(int bufSessionRes, string bufMilitaryRank, int bufCourse, string bufEduProg, string bufGroup, string bufFacultyName, Human bufHuman);

	int GetSessionRes();
	string GetMilitaryRank();

	void operator=(Student operandStudent);
	friend void operator<<(ostream& smth, Cadet operandCadet);

	int ScholarshipÑalc();
};