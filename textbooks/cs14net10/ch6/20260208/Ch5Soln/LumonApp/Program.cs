//using TPNS.Lumon.TPSharedModernLib;
using Dumpify;
using System.Collections.Generic;
using TPSharedModernLib;
//Console.WriteLine("Welcome to Lumon Industries");
//SeveredEmployee marky = new("Marky",true);
//SeveredEmployee heleny = new("Helly",false);
//mark.SitInThePark();
//mark.WorkOnProject();
//TimeClock clocky= new();
//clocky.ClockIn(marky);
//clocky.ClockIn(heleny);
//heleny.Department = "Macrodata Refinement";

#region Impliciy & Explicity Casting: Employee 

Employee john = new()
{
    Name = "John Jones",
    Born = new(year: 1990, month: 7, day: 28,
    hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};

john.WriteToConsole();
john.EmployeeCode = "JJ001";
john.HireDate = new(year: 2014, month: 11, day: 23);

WriteLine($"{john.Name} was hired on {john.HireDate:yyyy-MM-dd}.");

WriteLine(john.ToString());

Employee aliceInEmployee = new()
{ Name = "Alice", EmployeeCode = "AA123",HireDate= new(year: 2027, month: 04, day: 1) };

Person aliceInPerson = aliceInEmployee;

aliceInEmployee.WriteToConsole();       // "Alice was born on {default} and hired on {default}.",
aliceInPerson.WriteToConsole();         // "Alice was born on {default} and hired on {default}.",

//WriteLine("{0}",default(DateTimeOffset));
WriteLine(aliceInEmployee.ToString());  //  "{alice}'s code is {EmployeeCode}.
WriteLine(aliceInPerson.ToString());    //"{alice}'s code is {EmployeeCode}.
aliceInPerson.Dump();
//Employee explicitAlice = aliceInPerson; // compiler error: not every Person is definitely an employee
// we must tell the compiler that we indeed have an employee via casting
Employee explicitAlice = (Employee)aliceInPerson;
WriteLine("explicitAlice.HireDate: {0}", explicitAlice.HireDate);
WriteLine("default(DateOnly): {0}", default(DateOnly));

explicitAlice.Dump();

if (aliceInPerson is Employee explicitAlice2)
{
    WriteLine($"{nameof(aliceInPerson)} is an Employee.");
    // Safely do something with explicitAlice.
    explicitAlice2.WriteToConsole();
}
#endregion

#region TextBook Oldschool Extensions
Console.WriteLine();
string email1 = "pamela@test.com";
string email2 = "ian&test.com";
WriteLine("{0} is a valid e-mail address: {1}",
  arg0: email1,
  arg1: StringExtensions.IsValidEmail(email1));
WriteLine("{0} is a valid e-mail address: {1}",
  arg0: email2,
  arg1: StringExtensions.IsValidEmail(email2));



WriteLine("{0} is a valid e-mail address: {1}",
  arg0: email1,
  arg1: email1.IsValidEmail2());
WriteLine("{0} is a valid e-mail address: {1}",
  arg0: email2,
  arg1: email2.IsValidEmail2());

#endregion

#region Inherity Exceptions: PersonalException
//try
//{
//    john.TimeTravel(when: new(1992,1,1));
//    john.TimeTravel(when: new(1990,1,1));

//}
//catch (PersonalException e)
//{
//    WriteLine($"{e.Message}");
//}

#endregion

#region MethodChaining or FluentStyle

Person messi = new Person().SetName("messi2");
//Person messi2= new().SetName("messi2");
//messi.Dump();
//messi.SetAge(39).SetName("Lionel Messi");
//messi.Dump();;
#endregion

#region ExtensionMethods: Old & NewMethod
WriteLine("\nExtensionMethods: Old & NewMethod\n");

int[] int_list = [1, 2, 3, 4, 5];   // 1. create some list:

// 2. test extended method
WriteLine("- [old] int_list.IsEmptyOldExtended(): {0} (exp: False)", int_list.IsEmptyOLDExtended());
WriteLine("- [new] int_list.IsEmptyNewExtended: {0} (exp: False)", int_list.IsEmptyNEWExtended);
#endregion

#region Enumerables
var some_enumerable = Enumerable.Range(1, 5);

var some_list = some_enumerable.ToList();

//var some_list2 = (List<int>)some_enumerable; // cast exception
WriteLine("\nCreating Enumerable.Range(1, 5): ");
foreach (var item in some_enumerable)
{
    WriteLine(item);
}
#endregion

#region IEnumrable<int> Extensions
IEnumerable<int> some_int_list = [2, 4, 6, 8];
var filtered_int_list = some_int_list.IsGreaterThanThreshold(5);
foreach (var item in filtered_int_list)
{
    Write("{0} ", item);
}
#endregion
#region IEnum<Int>: Extension Methods
// add range via extension
var new_list = IEnumerable<int>.Range(1, 10);
WriteLine("\nIEnum<Int>: Extension Methods:\n");
WriteLine("create 1-10 range\n");
foreach (var item in new_list)
{
    Write($"{item} ");
}
int[] empty_list = [];
WriteLine($"\nempty_list.IsItEmpty: {empty_list.IsItEmpty}"); //list.IsItEmpty // False
var list_greater_than_4 = new_list.IsGreaterThan(4);
Write("Applied new_list.IsGreaterThan(4)...\n");
foreach (var item in list_greater_than_4)
{
    Write($"{item} ");
}
//list.IsGreaterThan // returns some property

#endregion


WriteLine("\n\nend of program!");