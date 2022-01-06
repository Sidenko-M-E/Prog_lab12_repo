using System;

namespace Prog_lab12
{
	public class Demo
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			Console.Write("--------Fio class--------\n");
			Fio demoFio = new Fio("Sidenko");
			Console.Write(demoFio.ToString());
			//Console.Write("Arrays of objects\n");
			//Console.Write("One-dimensional array:\n");
			//int i, j, count;
			//Fio[] arrFio = new Fio[5];
			//arrFio[0] = new Fio("Sidenko");
			//arrFio[1] = new Fio("Baranov");
			//arrFio[2] = new Fio("Suslov");
			//arrFio[3] = new Fio("Petriakov");
			//arrFio[4] = new Fio("Anosov");

			//Console.Write("Array content:\n");
			//count = 0;
			//for (i = 0; i < 5; i++)
			//{
			//	arrFio[i].Display();
			//	if (arrFio[i].GetSurname().StartsWith("S"))
			//		count++;
			//}
			//Console.Write("\nNumber of surnames which had started with 'S': {0}\n", count);

			//Console.Write("\nTwo-dimensional array:\n");
			//Fio[,] fios = new Fio[2,2];
			//fios[0, 0] = new Fio("Lisizin");
			//fios[0, 1] = new Fio("Kutepov");
			//fios[1, 0] = new Fio("Shurov");
			//fios[1, 1] = new Fio("Kulagin");

			//Console.Write("Array content:\n");
			//count = 0;
			//for (i = 0; i < 2; i++)
			//	for (j = 0; j < 2; j++)
			//	{
			//		if (fios[i, j].GetSurname().StartsWith("A"))
			//			count++;
			//		fios[i, j].Display();
			//	}
			//Console.Write("\nNumber of surnames which had started with 'A': {0}\n", count);



			Console.Write("\n--------Human class--------\n");
			Human demoHuman = new Human(rnd.Next(1899), rnd.Next(10, 60), rnd.Next(176, 200), rnd.Next(60, 100), 'M', demoFio);
			Console.Write(demoHuman.ToString() + "\n");
			Human newHuman = new Human();
			newHuman = (Human)demoHuman.Clone();
			demoHuman.fioField.SetPatronymic("abrakadabra");
			Console.Write(newHuman.ToString() + "\n");
			//Console.Write("Arrays of objects\n");
			//Console.Write("One-dimensional array:\n");
			//Random rnd = new Random();
			//Human[] arrHuman = new Human[5];
			//for (i = 0; i < 5; i++)
			//{
			//	arrHuman[i] = new Human(i, rnd.Next(10, 60), rnd.Next(176, 200), rnd.Next(60, 100), 'M', arrFio[i]);
			//}

			//Console.Write("Array content:\n");
			//count = 0;
			//for (i = 0; i < 5; i++)
			//{
			//	arrHuman[i].Display();
			//	if (arrHuman[i].GetAge() > 45)
			//		count++;
			//}
			//Console.Write("\nNumber of humans with age more than 45: {0}\n", count);

			//Console.Write("\nTwo-dimensional array:\n");
			//Human[,] humans = new Human[2, 2];
			//for (i = 0; i < 2; i++)
			//	for (j = 0; j < 2; j++)
			//	{
			//		humans[i, j] = new Human(i + j * 2, rnd.Next(10, 60), rnd.Next(170, 200), rnd.Next(60, 100), 'M', arrFio[i]);
			//	}

			//Console.Write("Array content:\n");
			//count = 0;
			//for (i = 0; i < 2; i++)
			//	for (j = 0; j < 2; j++)
			//	{
			//		if (humans[i, j].GetHeight() < 185)
			//			count++;
			//		humans[i, j].Display();
			//	}
			//Console.Write("\nNumber of humans with height less than 185: {0}\n", count);



			//Console.Write("\n--------Student class--------\n");
			//Student demoStudent = new Student();
			//Console.Write(demoStudent.ToString());
			//Console.Write("Arrays of objects\n");
			//Console.Write("One-dimensional array:\n");
			//Student[] arrStudent = new Student[5];
			//arrStudent[0] = new Student(rnd.Next(4), "Bachelor", "HS-03", "FoHS", arrHuman[0]);
			//arrStudent[1] = new Student(rnd.Next(4), "Bachelor", "FI-03", "FoMS", arrHuman[1]);
			//arrStudent[2] = new Student(rnd.Next(4), "Master", "IT-03", "FoIT", arrHuman[2]);
			//arrStudent[3] = new Student(rnd.Next(4), "Bachelor", "CS-03", "FoCS", arrHuman[3]);
			//arrStudent[4] = new Student(rnd.Next(4), "Master", "JK-03", "FoJK", arrHuman[4]);

			//Console.Write("Array content:\n");
			//count = 0;
			//for (i = 0; i < 5; i++)
			//{
			//	arrStudent[i].Display();
			//	if (arrStudent[i].GetCourse() == 3)
			//		count++;
			//}
			//Console.Write("\nNumber of students on 3 course: {0}\n", count);

			//Console.Write("\nTwo-dimensional array:\n");
			//Student[,] students = new Student[2, 2];
			//students[0,0] = new Student(rnd.Next(4), "Master", "HS-03", "FoHS", humans[0,0]);
			//students[0,1] = new Student(rnd.Next(4), "Bachelor", "MS-03", "FoMS", humans[0,1]);
			//students[1,0] = new Student(rnd.Next(4), "Master", "IT-03", "FoIT", humans[1,0]);
			//students[1,1] = new Student(rnd.Next(4), "Bachelor", "CS-03", "FoCS", humans[1,1]);

			//Console.Write("Array content:\n");
			//count = 0;
			//for (i = 0; i < 2; i++)
			//	for (j = 0; j < 2; j++)
			//	{
			//		if (students[i, j].GetFacultyName() == "FoMS")
			//			count++;
			//		students[i, j].Display();
			//	}
			//Console.Write("\nNumber of students on FoMS faculty: {0}\n", count);



			//Console.Write("\n--------Teacher class--------\n");
			//Teacher demoTeacher = new Teacher();
			//Console.Write(demoTeacher.ToString());
			//Console.Write("Arrays of objects\n");
			//Console.Write("One-dimensional array:\n");
			//Teacher[] arrTeacher = new Teacher[5];
			//arrTeacher[0] = new Teacher(rnd.Next(0, 40), "Doctor", "FoIT", arrHuman[0]);
			//arrTeacher[1] = new Teacher(rnd.Next(0, 40), "Candidate", "FoCS", arrHuman[1]);
			//arrTeacher[2] = new Teacher(rnd.Next(0, 40), "Doctor", "FoHS", arrHuman[2]);
			//arrTeacher[3] = new Teacher(rnd.Next(0, 40), "Candidate", "FoHS", arrHuman[3]);
			//arrTeacher[4] = new Teacher(rnd.Next(0, 40), "Candidate", "FoMS", arrHuman[4]);

			//Console.Write("Array content:\n");
			//count = 0;
			//for (i = 0; i < 5; i++)
			//{
			//	arrTeacher[i].Display();
			//	if (arrTeacher[i].GetWorkExp() > 20)
			//		count++;
			//}
			//Console.Write("\nNumber of teachers with working experience more than 20 years: {0}\n", count);

			//Console.Write("\nTwo-dimensional array:\n");
			//Teacher[,] teachers = new Teacher[2, 2];
			//teachers[0, 0] = new Teacher(rnd.Next(0, 40), "Candidate", "FoMS", humans[0, 0]);
			//teachers[0, 1] = new Teacher(rnd.Next(0, 40), "Doctor", "FoCS", humans[0, 1]);
			//teachers[1, 0] = new Teacher(rnd.Next(0, 40), "Candidate", "FoHS", humans[1, 0]);
			//teachers[1, 1] = new Teacher(rnd.Next(0, 40), "Doctor", "FoIT", humans[1, 1]);

			//Console.Write("Array content:\n");
			//count = 0;
			//for (i = 0; i < 2; i++)
			//	for (j = 0; j < 2; j++)
			//	{
			//		if (teachers[i, j].GetFacultyName() == "FoHS")
			//			count++;
			//		teachers[i, j].Display();
			//	}
			//Console.Write("\nNumber of teachers on FoHS faculty: {0}\n", count);



			//Console.Write("\n--------Faculty class--------\n");
			//Faculty demoFaculty = new Faculty();
			//Console.Write(demoFaculty.ToString());
			//Console.Write("Arrays of objects\n");
			//Console.Write("One-dimensional array:\n");
			//Faculty[] arrFaculty = new Faculty[5];
			//arrFaculty[0] = new Faculty("FoMS", rnd.Next(150, 200), rnd.Next(0, 150), 30, rnd.Next(10, 30), rnd.Next(10, 20), 20, rnd.Next(10, 30));
			//arrFaculty[1] = new Faculty("FoIT", rnd.Next(150, 200), rnd.Next(0, 150), 30, rnd.Next(10, 30), rnd.Next(10, 20), 20, rnd.Next(10, 30));
			//arrFaculty[2] = new Faculty("FoCS", rnd.Next(150, 200), rnd.Next(0, 150), 30, rnd.Next(10, 30), rnd.Next(10, 20), 20, rnd.Next(10, 30));
			//arrFaculty[3] = new Faculty("FoIT", rnd.Next(150, 200), rnd.Next(0, 150), 30, rnd.Next(10, 30), rnd.Next(10, 20), 20, rnd.Next(10, 30));
			//arrFaculty[4] = new Faculty("FoHS", rnd.Next(150, 200), rnd.Next(0, 150), 30, rnd.Next(10, 30), rnd.Next(10, 20), 20, rnd.Next(10, 30));

			//Console.Write("Array content:\n");
			//count = 0;
			//for (i = 0; i < 5; i++)
			//{
			//	arrFaculty[i].Display();
			//	if (arrFaculty[i].GetQuantityOfTeachers() > 20)
			//		count++;
			//}
			//Console.Write("\nNumber of faculties with more than 15 teachers: {0}\n", count);

			//Console.Write("\nTwo-dimensional array:\n");
			//Faculty[,] faculties = new Faculty[2, 2];
			//faculties[0, 0] = new Faculty("FoCS", rnd.Next(150, 200), rnd.Next(0, 150), 30, rnd.Next(10, 30), rnd.Next(10, 20), 20, rnd.Next(10, 30));
			//faculties[0, 1] = new Faculty("FoHS", rnd.Next(150, 200), rnd.Next(0, 150), 30, rnd.Next(10, 30), rnd.Next(10, 20), 20, rnd.Next(10, 30));
			//faculties[1, 0] = new Faculty("FoMS", rnd.Next(150, 200), rnd.Next(0, 150), 30, rnd.Next(10, 30), rnd.Next(10, 20), 20, rnd.Next(10, 30));
			//faculties[1, 1] = new Faculty("FoIT", rnd.Next(150, 200), rnd.Next(0, 150), 30, rnd.Next(10, 30), rnd.Next(10, 20), 20, rnd.Next(10, 30));

			//Console.Write("Array content:\n");
			//count = 0;
			//for (i = 0; i < 2; i++)
			//	for (j = 0; j < 2; j++)
			//	{
			//		if (faculties[i, j].GetQuantityOfStudents() > 170)
			//			count++;
			//		faculties[i, j].Display();
			//	}
			//Console.Write("\nNumber of faculties with more than 170 students: {0}\n", count);

			Console.ReadKey();
		}
	}
}
