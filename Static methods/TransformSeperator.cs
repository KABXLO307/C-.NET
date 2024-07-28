//I dont use top level statements in my .net

//This is a static method which changes the seperators in an array, useful during code implementation or primary keys

//passing the string, seperator and the new seperator we want
Console.WriteLine(StringsTransformer.TransformSeperators("this,is,some,string", ",", "+"));

public static class StringsTransformer
{
    public static string TransformSeperators(string input, string originalSeperator, string targetSeperator)
    {


      //converting the array here
        string inputString = input;
        string[] stringArray = inputString.Split(originalSeperator);
        string result = string.Join(targetSeperator, stringArray);

        return result;


    }
}
