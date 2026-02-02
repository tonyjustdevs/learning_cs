namespace TPNS.TPSharedLibNet2;

public class TextAndNumber
{
    public string? Text;
    public int Number;
}

public class LifeTheUniverseAndEverything
{
    public static TextAndNumber GetData() 
    {
        //[v1] var  test_and_number= 
        //[v1] return test_and_number;
        return new TextAndNumber { 
            Text = "The meaning of life?", 
            Number = 42 
        };
    }
}
