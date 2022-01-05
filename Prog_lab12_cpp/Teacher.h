#pragma once
#include "Human.h"


class Teacher {
private:
	int workExp;
	string degree;
	string facultyName;
	static double baseSalary;

public:
	Human humanField;

	void HardSetWorkExp(int buf);
	void HardSetDegree(string bufString);
	void HardSetFacultyName(string bufString);

	bool SetWorkExp(int buf);
	bool SetDegree(string bufString);
	bool SetFacultyName(string bufString);

	int GetWorkExp();
	string GetDegree();
	string GetFacultyName();

	Teacher operator+ (int operatorWorkExp);//Teacher+int=Teacher
	friend int operator+ (int operatorWorkExp, Teacher operatorTeacher); //int+Teacher=int
	Teacher& operator++();//prefix
	Teacher operator++(int unused);//postfix
	static double GetSalaryOf(Teacher& bufTeacher);

	Teacher();
	Teacher(Human bufHuman);
	Teacher(int bufWorkExp, string bufDegree, string bufFacultyName, Human bufHuman);

	void Read();
	friend void operator<<(ostream& smth, Teacher operandTeacher);
};