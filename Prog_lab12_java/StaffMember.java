package Prog_lab12_java;

public abstract class StaffMember
{
    //Attributes
    protected int workExp;
    protected int numberOfPubl;
    public Fio fioField;

    //Constructors
    public StaffMember()
    {
        workExp = 0;
        numberOfPubl = 0;
        fioField = new Fio();
    }
    public StaffMember(int bufWorkExp, int bufNumberOfPubl, Fio bufFio)
    {
        workExp = 0;
        numberOfPubl = 0;
        setWorkExp(bufWorkExp);
        setNumberOfPubl(bufNumberOfPubl);
        fioField = new Fio(bufFio.getSurname(), bufFio.getName(), bufFio.getPatronymic());
    }

    public boolean setWorkExp(int buf)
    {
        if (buf < 0 || buf > 60)
            return (true);
        else
        {
            workExp = buf;
            return (false);
        }
    }
    public boolean setNumberOfPubl(int buf)
    {
        if (buf < 0 || buf > 100)
            return (true);
        else
        {
            numberOfPubl = buf;
            return (false);
        }
    }

    public int getWorkExp()
    {
        return (workExp);
    }
    public int getNumberOfPubl()
    {
        return (numberOfPubl);
    }

    public abstract int calculateSalary();
    public String toString()
    {
        String returnValue = "";
        returnValue += "working experience: " + workExp +
                "\nnumber of publications: " + numberOfPubl +
                "\n" + fioField;
        return (returnValue);
    }
}