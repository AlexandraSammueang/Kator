using Kata3_Delegates;

#region Kata test of Member and MemberList
Console.WriteLine("Create a couple of members");
var member1 = Member.Factory.CreateWithRandomData();
Console.WriteLine($"member1: {member1}");
var member2 = Member.Factory.CreateWithRandomData();
Console.WriteLine($"member2: {member2}");

Console.WriteLine("\nCreate a 20 Hilton members");
var HiltonMembers = MemberList.Factory.CreateWithRandomData(20, HelloNewMember); 
HiltonMembers.Sort();
Console.WriteLine(HiltonMembers);

Console.WriteLine("\nCreate a 20 Radisson members");
var RadissonMembers = MemberList.Factory.CreateWithRandomData(20, HelloNewMember1);
RadissonMembers.Sort();
Console.WriteLine(RadissonMembers);

Console.WriteLine($"\nHilton member[0]: {HiltonMembers[0]}");
Console.WriteLine($"Radisson member[0]: {RadissonMembers[0]}");
Console.WriteLine();
#endregion

#region Alexandras plugin(delegates)
static void HelloNewMember(IMember member)
{
    Console.WriteLine($"Warm welcome {member.FirstName}!!");
}
static void HelloNewMember1(IMember member)
{
    Console.WriteLine($"Not so warm welcome {member.FirstName}!!");
}
#endregion
#region For Exercise: Refresh how to generate random initialization data
Console.WriteLine(RandomDate());
Console.WriteLine(RandomCity());

static DateTime RandomDate()
{
    var rnd = new Random();
    while (true)
    {
        try
        {
            int year = rnd.Next(1980, DateTime.Today.Year);
            int month = rnd.Next(1, 13);
            int day = rnd.Next(1, 32);

            return new DateTime(year, month, day);
        }
        catch { }
    }
}
static string RandomCity()
{
    var rnd = new Random();
    string[] _cities = "Stockholm Göteborg Malmö".Split(' ');
    return _cities[rnd.Next(0, _cities.Length)];
}
#endregion