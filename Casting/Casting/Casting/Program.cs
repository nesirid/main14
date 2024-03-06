using Casting;

class Program
{
    static void Main(string[] args)
    {
        CustomVector v1 = new CustomVector(2, 3);
        CustomVector v2 = new CustomVector(1, 4);


        CustomVector sum = v1 + v2;
        CustomVector difference = v1 - v2;
        CustomVector scaled = v1 * 2;

        if (v1 == v2)
        {
            Console.WriteLine("v1 and v2 are equal");
        }
        else
        {
            Console.WriteLine("v1 and v2 are not equal");
        }

        string vectorString = (string)v1;
        Console.WriteLine(vectorString);
    }
}