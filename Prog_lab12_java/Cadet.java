package Prog_lab12_java;

public class Cadet extends Student implements Calculate
{
    //Attributes
    private int sessionRes;
    private String militaryRank;

    //Constructors
    public Cadet()
    {
        sessionRes = 0;
        militaryRank = "unstated";
    }
    public Cadet(Human bufHuman)
    {
        sessionRes = 0;
        militaryRank = "unstated";
    }
    public Cadet(int bufCourse, String bufEduProg, String bufGroup, String bufFacultyName, Human bufHuman)
    {
        super(bufCourse, bufEduProg, bufGroup, bufFacultyName, bufHuman);
        sessionRes = 0;
        militaryRank = "unstated";
    }
    public Cadet(int bufSessionRes, String bufMilitaryRank, int bufCourse, String bufEduProg, String bufGroup, String bufFacultyName, Human bufHuman)
    {
        Cadet check = new Cadet();

        if (check.setSessionRes(bufSessionRes) || check.setMilitaryRank(bufMilitaryRank) ||
                check.setCourse(bufCourse) || check.setEduProg(bufEduProg) ||
                check.setGroup(bufGroup) || check.setFacultyName(bufFacultyName))
        {
            sessionRes = 0;
            militaryRank = "unstated";
        }
        else
        {
            sessionRes = bufSessionRes;
            setMilitaryRank(bufMilitaryRank);
            course = bufCourse;
            setEduProg(bufEduProg);
            setGroup(bufGroup);
            setFacultyName(bufFacultyName);
            humanField = new Human(bufHuman.getId(), bufHuman.getAge(),
                    bufHuman.getHeight(), bufHuman.getWeight(),
                    bufHuman.getGender(), bufHuman.fioField);
        }
    }

    //Methods
    public boolean setSessionRes(int buf)
    {
        if (buf < 0 || buf > 100)
            return (true);
        else
        {
            sessionRes = buf;
            return (false);
        }
    }
    public boolean setMilitaryRank(String bufString)
    {
        String invalidSymbStr = "!@#$%^&*()_+1234567890-=\";:?*,./'][{}<>~` ";
        char[] invalidSymbols = invalidSymbStr.toCharArray();
        for (char symb : invalidSymbols)
        {
            if(bufString.indexOf(symb) != (-1))
                return (true);
        }

        militaryRank = String.copyValueOf(bufString.toCharArray());
        return (false);
    }

    public boolean setAll(int bufCourse, String bufEduProg, String bufGroup, String bufFacultyName, Human bufHuman)
    {
        System.out.print("Cadet SetAll has been called.\n");
        if (super.setAll(bufCourse, bufEduProg, bufGroup, bufFacultyName, bufHuman))
            return (true);

        sessionRes = 0;
        militaryRank = "unstated";
        return (false);
    }
    public boolean setAll(int bufSessionRes, String bufMilitaryRank, int bufCourse, String bufEduProg, String bufGroup, String bufFacultyName, Human bufHuman)
    {
        System.out.print("Cadet SetAll has been called.\n");
        Cadet check = new Cadet();

        if (check.setSessionRes(bufSessionRes) || check.setMilitaryRank(bufMilitaryRank) ||
                check.setCourse(bufCourse) || check.setEduProg(bufEduProg) ||
                check.setGroup(bufGroup) || check.setFacultyName(bufFacultyName))
            return (true);

        sessionRes = bufSessionRes;
        setMilitaryRank(bufMilitaryRank);
        course = bufCourse;
        setEduProg(bufEduProg);
        setGroup(bufGroup);
        setFacultyName(bufFacultyName);
        humanField = new Human(bufHuman.getId(), bufHuman.getAge(),
                bufHuman.getHeight(), bufHuman.getWeight(),
                bufHuman.getGender(), bufHuman.fioField);
        return (false);
    }

    public int GetSessionRes()
    {
        return (sessionRes);
    }
    public String GetMilitaryRank()
    {
        return (String.copyValueOf(militaryRank.toCharArray()));
    }

    public String toString()
    {
        String returnValue = "";
        returnValue += "session results: " + sessionRes +
                "\nmilitary rank: " + militaryRank +
                "\n" + super.toString();
        return (returnValue);
    }

    public int scholarshipCalc()
    {
        int bonusScholarship = 0;
        if (sessionRes <= 24)
            return (0);
        if ((sessionRes >= 50) && (sessionRes <= 74))
            bonusScholarship = 1000;
        if ((sessionRes >= 75) && (sessionRes <= 100))
            bonusScholarship = 2000;

        if (course == 0)
            return (0);

        if (course == 1)
            return (1500 + bonusScholarship);

        if (course == 2)
            return (1725 + bonusScholarship);

        if (course == 3)
            return (2000 + bonusScholarship);

        if (course == 4)
            return (2750 + bonusScholarship);

        if (course == 5)
            return (3400 + bonusScholarship);

        if (course == 6)
            return (4200 + bonusScholarship);

        return (-1);
    }
}
