#pragma once
#include "StaffMember.h"

class Assistant : public StaffMember
{
	Assistant();
	Assistant(int bufWorkExp, int bufNumberOfPubl, Fio bufFio);

	int CalculateSalary();
};