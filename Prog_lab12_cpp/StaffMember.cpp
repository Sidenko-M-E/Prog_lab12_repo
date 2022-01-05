#include "StaffMember.h"

StaffMember::StaffMember()
{
	workExp = 0;
	numberOfPubl = 0;
}

StaffMember::StaffMember(int bufWorkExp, int bufNumberOfPubl, Fio bufFio)
{
	workExp = 0;
	numberOfPubl = 0;
	SetWorkExp(bufWorkExp);
	SetNumberOfPubl(bufNumberOfPubl);
	fioField = bufFio;
}

bool StaffMember::SetWorkExp(int buf)
{
	if (buf < 0 || buf > 60)
		return (true);
	else
	{
		workExp = buf;
		return (false);
	}
}

bool StaffMember::SetNumberOfPubl(int buf)
{
	if (buf < 0 || buf > 100)
		return (true);
	else
	{
		numberOfPubl = buf;
		return (false);
	}
}

int StaffMember::GetWorkExp()
{
	return (workExp);
}

int StaffMember::GetNumberOfPubl()
{
	return(numberOfPubl);
}