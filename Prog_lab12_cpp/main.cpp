#include <conio.h>
#include <iostream>
#include "Fio.h"
#include "Human.h"
#include "Student.h"
#include "Teacher.h"
#include "Faculty.h"
#include "Cadet.h"

int main()
{
	cout << "--------Fio class--------\n";
	cout << "---- << operator overload -----\n";
	Fio demoFio("Kuznetsov", "Oleg", "Vladimirovich");
	cout << demoFio;


	cout << "\n--------Human class--------\n";
	cout << "---- << operator overload -----\n";
	Human demoHuman(rand() % 500 + 1000, rand() % 20 + 25, rand() % 40 + 160, rand() % 40 + 80, 'M', demoFio);
	cout << demoHuman;

	cout << "\n--------Teacher class--------\n";
	cout << "---- << operator overload -----\n";
	Teacher demoTeacher(rand() % 40, "Doctor", "FoIT", demoHuman);
	cout << demoTeacher;



	cout << "\n------Faculty class----------\n";
	cout << "---- << operator overload -----\n";
	Faculty demoFaculty("FoMS", rand() % 50 + 150, rand() % 150, 30, rand() % 20 + 10, rand() % 10 + 10, 20, rand() % 20 + 10);
	cout << demoFaculty;
	
	cout << "\n--------Student class--------\n";
	cout << "---- << operator overload -----\n";
	Student demoStudent(rand() % 4, "Bachelor", "HS-03", "FoHS", demoHuman);
	cout << demoStudent;




	cout << "\n\n--------Cadet class--------\n";
	cout << "\n---- nested Student Constructor -----\n";
	Cadet demoCadet(demoHuman);
	cout << "---- << operator overload -----\n";
	cout << demoCadet;


	cout << "\n------Student methods overload----\n";
	demoCadet.SetAll(rand() % 4, "Bachelor", "HS-03", "FoHS", demoHuman);
	cout << demoCadet;
	cout << endl;
	demoCadet.SetAll(rand()%300 , "Lieutenant", rand() % 4, "Bachelor", "PI-03", "FoIT", demoHuman);
	cout << demoCadet;
	cout << endl;


	cout << "---- = operator overload -----\n";
	Fio fio1("Anasov", "Sergey", "Stepanovich");
	Human human1(rand() % 500 + 1000, rand() % 20 + 25, rand() % 40 + 160, rand() % 40 + 80, 'M', fio1);
	Student student1(rand() % 3 + 1, "Bachelor", "HS-03", "FoHS", human1);
	Cadet cadet1;

	cout << "\nStudent:\n";
	cout << student1;

	cout << "\nCadet:\n";
	cout << cadet1;

	cout << "\nCadet after assignment:\n";
	cadet1 = student1;
	cout << cadet1;


	cout << "\n------Virtual method demo----\n";
	cout << "-----------Step1--------------\n";
	student1.SetCourse(5);
	cout << "Student's scolarship: " << student1.ScholarshipÑalc() << endl;
	if (student1.IsScolarshipHigh())
		cout << "Student's scolarship is high.\n";
	else
		cout << "Student's scolarship is not high.\n";

	cadet1.SetCourse(5);
	cadet1.SetSessionRes(75);
	cout << "Cadet's scolarship: " << cadet1.ScholarshipÑalc() << endl;
	if (cadet1.IsScolarshipHigh())
		cout << "Cadet's scolarship is high.\n";
	else
		cout << "Cadet's scolarship is not high.\n";

	cout << "-----------Step2--------------\n";
	Student* student2 = new Student();
	Cadet* cadet2 = new Cadet();

	*student2 = student1;
	*cadet2 = cadet1;

	cout << "Student's scolarship: " << student2->ScholarshipÑalc() << endl;
	if (student2->IsScolarshipHigh())
		cout << "Student's scolarship is high.\n";
	else
		cout << "Student's scolarship is not high.\n";

	student2 = cadet2;
	cout << "Cadet's scolarship: " << student2->ScholarshipÑalc() << endl;
	if (student2->IsScolarshipHigh())
		cout << "Cadet's scolarship is high.\n";
	else
		cout << "Cadet's scolarship is not high.\n";

	/*cout << "Array content:\n";
	count = 0;
	for (i = 0; i < 5; i++)
	{
		cout << "[" << i << "]";
		arrStudent[i].Display();
		if (arrStudent[i].GetCourse() == 3)
			count++;
	}
	cout << "\nNumber of students on 3 course: " << count << endl;

	cout << "\nTwo-dimensional array:\n";
	Student students[2][2]
	{
		Student(rand()%4, "Master", "HS-03", "FoHS", humans[0][0]),
		Student(rand()%4, "Bachelor", "MS-03", "FoMS", humans[0][1]),
		Student(rand()%4, "Master", "IT-03", "FoIT", humans[1][0]),
		Student(rand()%4, "Bachelor", "CS-03", "FoCS", humans[1][1])
	};

	cout << "Array content:\n";
	count = 0;
	for (i = 0; i < 2; i++)
		for (j = 0; j < 2; j++)
		{
			cout << "[" << i << "][" << j << "]";
			students[i][j].Display();
			if (students[i][j].GetFacultyName() == "FoMS")
				count++;
		}
	cout << "\nNumber of students on FoMS faculty: \n" << count << endl;*/
	
	cout << "\nPress any key to exit.\n";
	_getch();
}
