#pragma once
#include "StaffMember.h"

class Docent : public StaffMember
{
public:
	Docent();
	Docent(int bufWorkExp, int bufNumberOfPubl, Fio bufFio);

	int CalculateSalary();
	friend void operator<<(ostream& smth, Docent operandDocent);
};