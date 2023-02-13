// using Formatter;

namespace ID;

public class ID
{
    
    private String idNumber;

    private DateTime dateOfBirth;

    public ID(String idNumber)
    {
        this.idNumber = idNumber;

        this.setDateOfBirth();
    }

    public String getIdNumber()
    {
        return this.idNumber;
    }

    public int getYear()
    {
        return this.dateOfBirth.Year;
    }

    public int getMonth()
    {
        return this.dateOfBirth.Month;
    }

    public int getDay()
    {
        return this.dateOfBirth.Day;
    }

    private void setDateOfBirth()
    {
        this.dateOfBirth = Formatter.idNumberToDate(this.idNumber);
    }
}