public record userDetails
{
    public string Name { get; init; }
    public string Mail { get; init; }
    public DateTime BirthDate { get; init; }
    public string userLevel { get; init; }
    public userDetails(string name, string surname, string mail, string birthDate, int userLevel)
    {
        Name = name + " " + surname;
        Mail = mail;
        BirthDate = DateTime.ParseExact(birthDate, "d.M.yyyy HH:mm:ss", null);
        this.userLevel = userLevel switch
        {
            0 => "Admin",
            1 => "User",
            _ => "Unknown"
        };
    }

    public static userDetails deleteData()
    {
        return new userDetails("", "", "", "1.1.0001 00:00:00", -1);
    }

    public override string ToString()
    {
        return Name;
    }
}