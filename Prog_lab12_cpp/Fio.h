#pragma once
#include <string>
using namespace std;


class Fio {
private:
	string surname;
	string name;
	string patronymic;

public:
	void HardSetSurname(string bufString);
	void HardSetName(string bufString);
	void HardSetPatronymic(string bufString);

	bool SetSurname(string bufString);
	bool SetName(string bufString);
	bool SetPatronymic(string bufString);

	string GetSurname();
	string GetName();
	string GetPatronymic();

	Fio();
	Fio(string bufSurname);
	Fio(string bufSurname, string bufName, string bufPatronymic);
	
	void Read();
	friend void operator<<(ostream& smth, Fio operandFio);
};
