#pragma once
#include "Fio.h"

class Human {
private:
	int id;
	int age;
	int height;
	double weight;
	char gender;

public:
	Fio fioField;

	void HardSetId(int buf);
	void HardSetAge(int buf);
	void HardSetHeight(int buf);
	void HardSetWeight(double buf);
	void HardSetGender(char buf);

	bool SetId(int buf);
	bool SetAge(int buf);
	bool SetHeight(int buf);
	bool SetWeight(double buf);
	bool SetGender(char buf);

	int GetId();
	int GetAge();
	int GetHeight();
	double GetWeight();
	char GetGender();

	Human();
	Human(int bufId);
	Human(int bufId, int bufAge, int bufHeight, double bufWeight, char bufGender, Fio bufFio);

	void Read();
	friend void operator<<(ostream& smth, Human operandHuman);
};
