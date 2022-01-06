package Prog_lab12_java;

import java.util.Random;

public class Demo{
	public static void main(String[] args)
	{
		Random rnd = new Random();
		System.out.print("--------Fio class--------\n");
		System.out.print("-----ToString() overload-----\n");
		Fio demoFio = new Fio("Kuznetsov", "Oleg", "Vladimirovich");
		System.out.print(demoFio.toString());



		System.out.print("\n--------Human class--------\n");
		System.out.print("-----ToString() overload + Clone demo-----\n");
		Human demoHuman = new Human(rnd.nextInt(1899), rnd.nextInt(10, 60), rnd.nextInt(176, 200), rnd.nextInt(60, 100), 'M', demoFio);
		System.out.print(demoHuman.toString() + "\n");
		Human newHuman = new Human();

		newHuman = (Human)demoHuman.clone();

		demoHuman.fioField.setPatronymic("abrakadabra");
		System.out.print(newHuman.toString() + "\n");
		System.out.print("It's a shallow copy\n");
		demoHuman.fioField.setPatronymic("Vladimirovich");


		System.out.print("\n--------Teacher class--------\n");
		Teacher demoTeacher = new Teacher();
		System.out.print(demoTeacher.toString());



		System.out.print("\n--------Faculty class--------\n");
		Faculty demoFaculty = new Faculty();
		System.out.print(demoFaculty.toString());



		System.out.print("\n--------Student class--------\n");
		System.out.print("-----ToString() overload-----\n");
		Student demoStudent = new Student(rnd.nextInt(4), "Bachelor", "HS-03", "FoHS", demoHuman);
		System.out.print(demoStudent.toString());



		System.out.print("\n\n--------Cadet class--------\n");
		System.out.print("\n---- nested Student Constructor -----\n");
		Cadet demoCadet = new Cadet(rnd.nextInt(4), "Bachelor", "HS-03", "FoHS", demoHuman);
		System.out.print("-----ToString() overload-----\n");
		System.out.print(demoCadet + "\n");


		System.out.print("\n------Student methods overload----\n");
		demoCadet.setAll(rnd.nextInt(4), "Bachelor", "HS-03", "FoHS", demoHuman);
		System.out.print(demoCadet + "\n");
		demoCadet.setAll(rnd.nextInt(300), "Lieutenant", rnd.nextInt(4), "Bachelor", "PI-03", "FoIT", demoHuman);
		System.out.print(demoCadet + "\n");



		System.out.print("\n------Interface demo----\n");
		demoStudent = new Student();
		demoStudent.setCourse(5);
		System.out.printf("Student's scolarship: %d\n", demoStudent.scholarshipCalc());

		demoCadet = new Cadet();
		demoCadet.setCourse(5);
		demoCadet.setSessionRes(75);
		System.out.printf("Cadet's scolarship: %d\n", demoCadet.scholarshipCalc());



		System.out.print("\n------Abstract class demo----\n");
		Fio[] fios = new Fio[3];
		fios[0] = new Fio("Anasov", "Oleg", "Petrovich");
		fios[1] = new Fio("Smirnov", "Vladislav", "Victorovich");
		fios[2] = new Fio("Popov", "Sergey", "Trofimovich");

		StaffMember[] stuffMembers = new StaffMember[3];
		stuffMembers[-0] = new Assistant(10, 10, fios[0]);
		stuffMembers[1] = new Docent(10, 10, fios[1]);
		stuffMembers[2] = new Assistant(3, 7, fios[2]);

		for (int i = 0; i < 3; i++)
			System.out.printf("Salary of Staff Member: %d\n", stuffMembers[i].calculateSalary());
	}
}