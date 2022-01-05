#pragma once
#include "StaffMember.h"

class Assistant : public StaffMember
{
public:
	Assistant();
	Assistant(int bufWorkExp, int bufNumberOfPubl, Fio bufFio);

	int CalculateSalary();
	friend void operator<<(ostream& smth, Assistant operandAssistant);
};