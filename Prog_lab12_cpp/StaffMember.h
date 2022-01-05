#pragma once
#include "Fio.h"

class StaffMember
{
protected:
	int workExp;
	int numberOfPubl;
public:
	Fio fioField;

	StaffMember();
	StaffMember(int bufWorkExp, int bufNumberOfPubl, Fio bufFio);

	bool SetWorkExp(int bufWorkExp);
	bool SetNumberOfPubl(int bufNumberOfPubl);

	int GetWorkExp();
	int GetNumberOfPubl();

	int virtual CalculateSalary() = 0;
};