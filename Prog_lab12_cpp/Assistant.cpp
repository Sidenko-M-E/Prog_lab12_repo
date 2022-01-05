#include "Assistant.h"
#include <iostream>

Assistant::Assistant()
{
}

Assistant::Assistant(int bufWorkExp, int bufNumberOfPubl, Fio bufFio):StaffMember(bufWorkExp, bufNumberOfPubl, bufFio)
{
}

int Assistant::CalculateSalary()
{
	int salaryForExp = 0;
	if (workExp >= 0 && workExp <= 3)
		salaryForExp = 4500;

	if (workExp >= 4 && workExp <= 7)
		salaryForExp = 6000;

	if (workExp >= 8 && workExp <= 14)
		salaryForExp = 10000;

	if (workExp >= 15 && workExp <= 24)
		salaryForExp = 14000;

	if (workExp >= 25)
		salaryForExp = 20000;

	return (salaryForExp + numberOfPubl * 750);
}

void operator<<(ostream& smth, Assistant operandAssistant)
{
	cout << "working experience: " << operandAssistant.workExp << endl;
	cout << "number of publications: " << operandAssistant.numberOfPubl << endl;
	cout << operandAssistant.fioField;
}
