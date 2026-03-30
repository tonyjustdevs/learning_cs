// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

List<int> int_list = [1,2,3,4,5,6,7,8];
List<int> even_list = new();

//var results_list = int_list.Select((val) => (val));
var results_list = int_list.Where((val) => (val%2==0));

var results_str =string.Join(",", results_list);
Console.WriteLine(results_str);

// to dos
//- txfr db context
//- update warnings in northwindcontext contrauctor
//- update onconfugring -> sqlserver version
//- add services extesnion to AddNorthwindContext()
//- add sql server auth credentials: builder.ui & builder.pw
//- update some class-to - table mappings
//- add xunit class libraries test
//- mcp servers
//- http testing