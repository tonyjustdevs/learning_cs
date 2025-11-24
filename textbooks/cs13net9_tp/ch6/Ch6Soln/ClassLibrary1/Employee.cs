namespace TP.SharedLibraries
{
    public class Employee : Person
    {
        public int EmployeeNo { get; set; }
        //public DateOnly HireDate { get; set; }
        public DateOnly HireDate { get; set; } = new DateOnly(2025,01,01);
        public new void WriteToConsole() => Console.WriteLine(
        $"{Name} " +
        $"has EmployeeNo '{EmployeeNo}' " +
        $"was hired on {HireDate:yyyy-MM-dd}");

        //public new void ToString()
        //public override string ToString()
        //{
        //    return $"F* his name, he's #{EmployeeNo}";
        //}

        public void TestingThisAndBases() => Console.WriteLine($"Running TestingThisAndBases():" +
            $"\nthis.Name: {this.Name}, this.ToString(): {this.ToString()}" +
            $"\nbase.Name: {base.Name}, base.ToString(): {base.ToString()}");
    }

}
