#include "Docent.h"
#include <iostream>

Docent::Docent()
{
}

Docent::Docent(int bufWorkExp, int bufNumberOfPubl, Fio bufFio) :StaffMember(bufWorkExp, bufNumberOfPubl, bufFio)
{
}

int Docent::CalculateSalary()
{
	int salaryForExp = 0;
	if (workExp >= 0 && workExp <= 3)
		salaryForExp = 14000;

	if (workExp >= 4 && workExp <= 7)
		salaryForExp = 18000;

	if (workExp >= 8 && workExp <= 14)
		salaryForExp = 25000;

	if (workExp >= 15 && workExp <= 24)
		salaryForExp = 40000;

	if (workExp >= 25)
		salaryForExp = 50000;

	return (salaryForExp + numberOfPubl * 1400);
}

void operator<<(ostream& smth, Docent operandDocent)
{
	cout << "working experience: " << operandDocent.workExp << endl;
	cout << "number of publications: " << operandDocent.numberOfPubl << endl;
	cout << operandDocent.fioField;
}
