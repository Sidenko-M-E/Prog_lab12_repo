#include "Faculty.h"
#include <iostream>


void Faculty::HardSetFacultyName(string bufString)
{
	if (bufString.empty())
		throw logic_error("Input string is empty.");

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"¹;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			throw invalid_argument("Input string contains invalid symbols.");
	}

	if (facultyName)
		delete facultyName;
	facultyName = NULL;
	facultyName = new char[strlen(bufString.c_str()) + 1];
	strcpy(facultyName, bufString.c_str());
}

void Faculty::HardSetQuantityOfStudents(int buf)
{
	if (buf < 0 || buf > 1000)
		throw invalid_argument("Invalid range of number.");
	else
		quantityOfStudents = buf;
}

void Faculty::HardSetQuantityOfBachelors(int buf)
{
	if (buf < 0 || buf > 1000)
		throw invalid_argument("Invalid range of number.");
	else
		quantityOfBachelors = buf;
}

void Faculty::HardSetQuantityOfMasters(int buf)
{
	if (buf < 0 || buf > 1000)
		throw invalid_argument("Invalid range of number.");
	else
		quantityOfMasters = buf;
}

void Faculty::HardSetQuantityOfTeachers(int buf)
{
	if (buf < 0 || buf > 100)
		throw invalid_argument("Invalid range of number.");
	else
		quantityOfTeachers = buf;
}

void Faculty::HardSetQuantityOfCandidates(int buf)
{
	if (buf < 0 || buf > 100)
		throw invalid_argument("Invalid range of number.");
	else
		quantityOfDoctors = buf;
}

void Faculty::HardSetQuantityOfDoctors(int buf)
{
	if (buf < 0 || buf > 100)
		throw invalid_argument("Invalid range of number.");
	else
		quantityOfDoctors = buf;
}

void Faculty::HardSetQuantityOfDisciplines(int buf)
{
	if (buf < 0 || buf > 100)
		throw invalid_argument("Invalid range of number.");
	else
		quantityOfDisciplines = buf;
}


bool Faculty::SetFacultyName(string bufString)
{
	if (bufString.empty())
		return (true);

	char invalidSymbols[] = "!@#$%^&*()_+1234567890-=\"¹;:?*,./'][{}<>~` ";
	for (char symb : invalidSymbols)
	{
		if (bufString.find(symb) != (-1))
			return (true);
	}
	
	/*code was commented for shallow copy demonstation
	if (facultyName)
		delete facultyName;
	facultyName = NULL;
	facultyName = new char[strlen(bufString.c_str()) + 1];
	*/
	strcpy(facultyName, bufString.c_str());
	return (false);
}

bool Faculty::SetQuantityOfStudents(int buf)
{
	if (buf < 0 || buf > 1000)
		return (true);
	else
	{
		quantityOfStudents = buf;
		return (false);
	}
}

bool Faculty::SetQuantityOfBachelors(int buf)
{
	if (buf < 0 || buf > 1000)
		return (true);
	else
	{
		quantityOfBachelors = buf;
		return (false);
	}
}

bool Faculty::SetQuantityOfMasters(int buf)
{
	if (buf < 0 || buf > 1000)
		return (true);
	else
	{
		quantityOfMasters = buf;
		return (false);
	}
}

bool Faculty::SetQuantityOfTeachers(int buf)
{
	if (buf < 0 || buf > 100)
		return (true);
	else
	{
		quantityOfTeachers = buf;
		return (false);
	}
}

bool Faculty::SetQuantityOfCandidates(int buf)
{
	if (buf < 0 || buf > 100)
		return (true);
	else
	{
		quantityOfCandidates = buf;
		return (false);
	}
}

bool Faculty::SetQuantityOfDoctors(int buf)
{
	if (buf < 0 || buf > 100)
		return (true);
	else
	{
		quantityOfDoctors = buf;
		return (false);
	}
}

bool Faculty::SetQuantityOfDisciplines(int buf)
{
	if (buf < 0 || buf > 100)
		return (true);
	else
	{
		quantityOfDisciplines = buf;
		return (false);
	}
}

bool Faculty::SetStudentsInfo(int allQuantity, int bachelorsQuantity, int mastersQuantity)
{
	if (allQuantity < 0 || allQuantity > 1000 || bachelorsQuantity < 0 || bachelorsQuantity > 1000 || mastersQuantity < 0 || mastersQuantity > 1000)
		return (true);
	else
	{
		quantityOfStudents = allQuantity;
		quantityOfBachelors = bachelorsQuantity;
		quantityOfMasters = mastersQuantity;
		return (false);
	}
}

bool Faculty::SetTeachersInfo(int allQuantity, int candidatesQuantity, int doctorsQuantity)
{
	if (allQuantity < 0 || allQuantity > 100 || candidatesQuantity < 0 || candidatesQuantity > 100 || doctorsQuantity < 0 || doctorsQuantity > 100)
		return (true);
	else
	{
		quantityOfTeachers = allQuantity;
		quantityOfCandidates = candidatesQuantity;
		quantityOfDoctors = doctorsQuantity;
		return (false);
	}
}



string Faculty::GetFacultyName()
{
	return (string(facultyName));
}

int Faculty::GetQuantityOfStudents()
{
	return (quantityOfStudents);
}

int Faculty::GetQuantityOfBachelors()
{
	return (quantityOfBachelors);
}

int Faculty::GetQuantityOfMasters()
{
	return (quantityOfMasters);
}

int Faculty::GetQuantityOfTeachers()
{
	return (quantityOfTeachers);
}

int Faculty::GetQuantityOfCandidates()
{
	return (quantityOfCandidates);
}

int Faculty::GetQuantityOfDoctors()
{
	return (quantityOfDoctors);
}

int Faculty::GetQuantityOfDisciplines()
{
	return (quantityOfDisciplines);
}

double Faculty::GetProcentOfMasters()
{
	if (quantityOfStudents == 0)
		throw invalid_argument("Can't divide by QuantityOfStudents = 0");
	return(((double)quantityOfMasters) / ((double)quantityOfStudents) * 100);
}

double Faculty::GetProcentOfDoctors()
{
	if (quantityOfStudents == 0)
		throw invalid_argument("Can't divide by QuantityOfTeachers = 0");
	return(((double)quantityOfDoctors) / ((double)quantityOfTeachers) * 100);
}

double Faculty::GetStudToTeachRatio()
{
	if (quantityOfStudents == 0)
		throw invalid_argument("Can't divide by QuantityOfTeachers = 0");
	return(((double)quantityOfStudents) / ((double)quantityOfTeachers));
}

Faculty Faculty::GetWithMoreCandidates(Faculty buf)
{
	if ((*this).GetQuantityOfCandidates() >= buf.GetQuantityOfCandidates())
		return (*this);
	else
		return (buf);
}

void Faculty::IsHavingEnoughCandidates(bool *result)
{
	if (quantityOfCandidates > 30)
		*result = true;
	else
		*result = false;
}

void Faculty::IsHavingEnoughCandidates(bool &result)
{
	if (quantityOfCandidates > 30)
		result = true;
	else
		result = false;
}

Faculty::Faculty()
{
	facultyName  = new char[strlen("unstated") + 1];
	strcpy(facultyName, "unstated");
	quantityOfStudents = 0;
	quantityOfBachelors = 0;
	quantityOfMasters = 0;
	quantityOfTeachers = 0;
	quantityOfCandidates = 0;
	quantityOfDoctors = 0;
	quantityOfDisciplines = 0;
}

Faculty::Faculty(string bufFacultyName)
{
	facultyName = new char[strlen(bufFacultyName.c_str()) + 1];
	strcpy(facultyName, bufFacultyName.c_str());
	quantityOfStudents = 0;
	quantityOfBachelors = 0;
	quantityOfMasters = 0;
	quantityOfTeachers = 0;
	quantityOfCandidates = 0;
	quantityOfDoctors = 0;
	quantityOfDisciplines = 0;
}

Faculty::Faculty(string bufFacultyName, int studentsQuantity, int bachelorsQuantity, int mastersQuantity, 
	int teachersQuantity, int candidatesQuantity, int doctorsQuanity, int discpilinesQuantity)
{
	Faculty check;

	if (check.SetFacultyName(bufFacultyName) || check.SetQuantityOfStudents(studentsQuantity) ||
		check.SetQuantityOfBachelors(bachelorsQuantity) || check.SetQuantityOfMasters(mastersQuantity) ||
		check.SetQuantityOfTeachers(teachersQuantity) || check.SetQuantityOfCandidates(candidatesQuantity) ||
		check.SetQuantityOfDoctors(doctorsQuanity) || check.SetQuantityOfDisciplines(discpilinesQuantity))
	{
		facultyName = new char[strlen("unstated") + 1];
		strcpy(facultyName, "unstated");
		quantityOfStudents = 0;
		quantityOfBachelors = 0;
		quantityOfMasters = 0;
		quantityOfTeachers = 0;
		quantityOfCandidates = 0;
		quantityOfDoctors = 0;
		quantityOfDisciplines = 0;
	}
	else
	{
		facultyName = new char[strlen(bufFacultyName.c_str()) + 1];
		strcpy(facultyName, bufFacultyName.c_str());
		quantityOfStudents = studentsQuantity;
		quantityOfBachelors = bachelorsQuantity;
		quantityOfMasters = mastersQuantity;
		quantityOfTeachers = teachersQuantity;
		quantityOfCandidates = candidatesQuantity;
		quantityOfDoctors = doctorsQuanity;
		quantityOfDisciplines = discpilinesQuantity;
	}
}

Faculty::Faculty(const Faculty& bufFaculty)
{
	facultyName = bufFaculty.facultyName;
	quantityOfStudents = bufFaculty.quantityOfStudents*2;
	quantityOfBachelors = bufFaculty.quantityOfBachelors*2;
	quantityOfMasters = bufFaculty.quantityOfMasters*2;
	quantityOfTeachers = bufFaculty.quantityOfTeachers*2;
	quantityOfCandidates = bufFaculty.quantityOfCandidates*2;
	quantityOfDoctors = bufFaculty.quantityOfDoctors*2;
	quantityOfDisciplines = bufFaculty.quantityOfDisciplines*2;
}

Faculty& Faculty::operator=(Faculty& bufFaculty)
{
	if (facultyName)
		delete facultyName;
	facultyName = NULL;

	quantityOfStudents = bufFaculty.quantityOfStudents;
	quantityOfBachelors = bufFaculty.quantityOfBachelors;
	quantityOfMasters = bufFaculty.quantityOfMasters;
	quantityOfTeachers = bufFaculty.quantityOfTeachers;
	quantityOfCandidates = bufFaculty.quantityOfCandidates;
	quantityOfDoctors = bufFaculty.quantityOfDoctors;
	quantityOfDisciplines = bufFaculty.quantityOfDisciplines;

	facultyName = new char[strlen(bufFaculty.GetFacultyName().c_str()) + 1];
	strcpy(facultyName, bufFaculty.GetFacultyName().c_str());
	return (*this);
}


bool Faculty::Read()
{
	Faculty check;
	string bufString;

	bool readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter faculty name:" << endl;
			getline(cin, bufString);
			check.HardSetFacultyName(bufString);
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}

	readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter quantity of students:" << endl;
			getline(cin, bufString);
			check.HardSetQuantityOfStudents(stoi(bufString));
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}

	readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter quantity of bachelors:" << endl;
			getline(cin, bufString);
			check.HardSetQuantityOfBachelors(stoi(bufString));
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}

	readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter quantity of masters:" << endl;
			getline(cin, bufString);
			check.HardSetQuantityOfMasters(stoi(bufString));
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}
	
	readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter quantity of teachers:" << endl;
			getline(cin, bufString);
			check.HardSetQuantityOfTeachers(stoi(bufString));
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}

	readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter quantity of candidates:" << endl;
			getline(cin, bufString);
			check.HardSetQuantityOfCandidates(stoi(bufString));
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}

	readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter quantity of doctors:" << endl;
			getline(cin, bufString);
			check.HardSetQuantityOfDoctors(stoi(bufString));
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}
								
	readFlag = true;
	while (readFlag)
	{
		try
		{
			cout << "\nEnter quantity of disciplines:" << endl;
			getline(cin, bufString);
			check.HardSetQuantityOfDisciplines(stoi(bufString));
			readFlag = false;
		}
		catch (const std::exception& ex)
		{
			cout << ex.what();
		}
	}
						
	facultyName = new char[strlen(check.GetFacultyName().c_str()) + 1];
	strcpy(facultyName, check.GetFacultyName().c_str());
	quantityOfStudents = check.GetQuantityOfStudents();
	quantityOfBachelors = check.GetQuantityOfBachelors();
	quantityOfMasters = check.GetQuantityOfMasters();
	quantityOfTeachers = check.GetQuantityOfTeachers();
	quantityOfCandidates = check.GetQuantityOfCandidates();
	quantityOfDoctors = check.GetQuantityOfDoctors();
	quantityOfDisciplines = check.GetQuantityOfDisciplines();
	return (false);												
}

void operator<<(ostream& smth, Faculty operandFaculty)
{
	cout << "faculty name: " << operandFaculty.facultyName << endl;
	cout << "quantity of students:" << operandFaculty.quantityOfStudents << endl;
	cout << "quantity of bachelors: " << operandFaculty.quantityOfBachelors << endl;
	cout << "quantity of masters: " << operandFaculty.quantityOfMasters << endl;

	cout << "quantity of teachers: " << operandFaculty.quantityOfTeachers << endl;
	cout << "quantity of candidates: " << operandFaculty.quantityOfCandidates << endl;
	cout << "quantity of doctors: " << operandFaculty.quantityOfDoctors << endl;

	cout << "quantity of disciplines: " << operandFaculty.quantityOfDisciplines << endl;
}
