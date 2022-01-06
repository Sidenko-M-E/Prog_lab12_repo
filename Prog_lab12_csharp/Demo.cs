using System;

namespace Prog_lab12
{
	public class Demo
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			Console.Write("--------Fio class--------\n");
			Console.Write("-----ToString() overload-----\n");
			Fio demoFio = new Fio("Kuznetsov", "Oleg", "Vladimirovich");
			Console.Write(demoFio.ToString());



			Console.Write("\n--------Human class--------\n");
			Console.Write("-----ToString() overload + Clone demo-----\n");
			Human demoHuman = new Human(rnd.Next(1899), rnd.Next(10, 60), rnd.Next(176, 200), rnd.Next(60, 100), 'M', demoFio);
			Console.Write(demoHuman.ToString() + "\n");
			Human newHuman = new Human();
			newHuman = (Human)demoHuman.Clone();
			demoHuman.fioField.SetPatronymic("abrakadabra");
			Console.Write(newHuman.ToString() + "\n");
			Console.Write("It's a deep copy\n");
			demoHuman.fioField.SetPatronymic("Vladimirovich");


			Console.Write("\n--------Teacher class--------\n");
			Teacher demoTeacher = new Teacher();
			Console.Write(demoTeacher.ToString());



			Console.Write("\n--------Faculty class--------\n");
			Faculty demoFaculty = new Faculty();
			Console.Write(demoFaculty.ToString());
			


			Console.Write("\n--------Student class--------\n");
			Console.Write("-----ToString() overload-----\n");
			Student demoStudent = new Student(rnd.Next(4), "Bachelor", "HS-03", "FoHS", demoHuman);
			Console.Write(demoStudent.ToString());
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

			Console.Write("\n\n--------Cadet class--------\n");
			Console.Write("\n---- nested Student Constructor -----\n");
			Cadet demoCadet = new Cadet(rnd.Next(4), "Bachelor", "HS-03", "FoHS", demoHuman);
			Console.Write("-----ToString() overload-----\n");
			Console.Write(demoCadet + "\n");


			Console.Write("\n------Student methods overload----\n");
			demoCadet.SetAll(rnd.Next(4), "Bachelor", "HS-03", "FoHS", demoHuman);
			Console.Write(demoCadet + "\n");
			demoCadet.SetAll(rnd.Next(300), "Lieutenant", rnd.Next(4), "Bachelor", "PI-03", "FoIT", demoHuman);
			Console.Write(demoCadet + "\n");



			Console.Write("\n------Interface demo----\n");
			demoStudent = new Student();
			demoStudent.SetCourse(5);
			Console.Write("Student's scolarship: {0}\n", demoStudent.ScholarshipСalc());

			demoCadet = new Cadet();
			demoCadet.SetCourse(5);
			demoCadet.SetSessionRes(75);
			Console.Write("Cadet's scolarship: {0}\n", demoCadet.ScholarshipСalc());



			Console.Write("\n------Abstract class demo----\n");
			Fio[] fios = new Fio[3];
			fios[0] = new Fio("Anasov", "Oleg", "Petrovich");
			fios[1] = new Fio("Smirnov", "Vladislav", "Victorovich");
			fios[2] = new Fio("Popov", "Sergey", "Trofimovich");

			StaffMember[] stuffMembers = new StaffMember[3];
			stuffMembers[-0] = new Assistant(10, 10, fios[0]);
			stuffMembers[1] = new Docent(10, 10, fios[1]);
			stuffMembers[2] = new Assistant(3, 7, fios[2]);

			for (int i = 0; i < 3; i++)
				Console.Write("Salary of Staff Member: {0}\n", stuffMembers[i].CalculateSalary());


			Console.ReadKey();
		}
	}
}
