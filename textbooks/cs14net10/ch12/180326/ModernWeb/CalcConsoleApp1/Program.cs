// ----- BASIC ----- //
// ----- 1. DECLARE: `BASIC DELEGATE----- //
Action<int, int> Action_DoCalculate1A = (a, b) =>
{
    Console.WriteLine($"\nActionCalculator({a},{b})");
    Console.WriteLine($"- a+b: {a + b}");
    Console.WriteLine($"- a-b: {a - b}");
    Console.WriteLine($"- a/b: {a / b}");
    Console.WriteLine($"- a*b: {a * b}");
};              // [A] ASSN [ANONYMOUSE] FUNCTION
void VoidCalcMethod(int i, int j)
{
    int a = i;
    int b=j;
    Console.WriteLine($"\nVoidCalcMethod({a},{b})");
    Console.WriteLine($"- a+b: {a + b}");
    Console.WriteLine($"- a-b: {a - b}");
    Console.WriteLine($"- a/b: {a / b}");
    Console.WriteLine($"- a*b: {a * b}");
}                          // [B] DECLARE METHOD
Action<int, int> Action_DoCalculate1Bi = (a, b) => VoidCalcMethod(a,b); // [B] ASSN [DECLARED] METHOD
Action<int, int> Action_DoCalculate1Bii = (a, b) => VoidCalcMethod(b,a); // [B] ASSN [DECLARED] METHOD

// ----- 2. INVOKE:     BASIC DELEGATE ----- //
Action_DoCalculate1A(4, 2);     // [1A]
Action_DoCalculate1Bi(4, 2);    // [1B]
Action_DoCalculate1Bii(4, 2);   // [1B]


// ----- ADVANCED----- //
// ----- 3. DECLARE:    COMPLEX DELEGATE----- //
//void ComplexCalculate(int a, int b, Action<int, int>? action_complex_operation=null)
//{
//    action_complex_operation = (a, b) =>
//    {
//        Console.WriteLine($"\nComplexCalculate({a},{b},Action<int, int> action_operation)");
//        Console.WriteLine($"- a+b: {a + b}");
//        Console.WriteLine($"- a-b: {a - b}");
//        Console.WriteLine($"- a/b: {a / b}");
//        Console.WriteLine($"- a*b: {a * b}");
//    };
//    action_complex_operation(a, b);
//}
//ComplexCalculate(4, 2);
// ----- 4. INVOKE:     COMPLEX DELEGATE ----- //

//void ComplexCalculate2(int a, int b, Action<int, int> action_complexOperation)

Action<int, int> action_complexOperation = (a, b) => { };
void ComplexCalculate2(int a, int b, Action<int, int> action_complexOperation)
{
    Console.WriteLine("entered: ComplexCalculate2");
    action_complexOperation(a, b);
}
Action<int, int> action_mate = (a, b) => {
    Console.WriteLine("entered: action_mate ");
    Console.WriteLine($"a+b: {a + b}");
};
Action<int, int> action_mate2 = declared_mate;

void declared_mate(int a,int b)
{
    Console.WriteLine("entered: declared_mate ");
    Console.WriteLine($"a+b: {a + b}");
};
//ComplexCalculate2(2, 4, action_mate);

//ComplexCalculate2(3,6, action_mate2);

//Func<int, int, int> adderers = (a, b) => a + b;
//Console.WriteLine($"adderers(2,4): {adderers(2, 4)}");

int ApplyModel(int a, int b, Func<int, int, int> model)
{

    Console.WriteLine($"\nentered ApplyModel({a},{b},{model})");
    return model(a, b);
}
Console.WriteLine($"ApplyModel(2, 4, (a, b) =>return a + b;) is [{ApplyModel(2, 4, (a, b) => { return a + b; })}]");

//declared_mate\\h
