
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using TP.SharedNamespace;

Hoomans kid2 = new Hoomans() {Name="kid2_nm",Age=2};
Hoomans kid3 = new() { Name ="kid3_nm",Age=3};
Hoomans kid1 = new Hoomans();
kid1.Name = "ki1_nm";
kid1.Age = 1;

Hoomans tony = new();
tony.Name = "tony";
tony.Age = 69;
tony.LittleHoomans = new List<Hoomans>
{
    kid1, kid2, kid3
};

Console.WriteLine($"tony.Name: {tony.Name}");
Console.WriteLine($"tony.Age: {tony.Age}");

var tony_kiddos_IESTR = tony.LittleHoomans.Select( x => x.Name ); // return [IE_STR]
var tony_kiddos_STR = string.Join(", ", tony_kiddos_IESTR);
Console.WriteLine($"tony.LittleHoomans: {tony_kiddos_STR}");



// create a IEnumerable str
// apply join() method: {str}.join with ", 

