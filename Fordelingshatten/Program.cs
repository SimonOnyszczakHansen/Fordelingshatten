namespace Fordelingshatten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates our object
            SortingHat sortinghat = new SortingHat();
        }
        enum Colleges
        { 
            //All of the colleges in the enum
            Gryffindor,
            Hufflepuff,
            Ravenclaw,
            Slytherin
        } 
        internal class SortingHat
        { 
            //Our method
            public SortingHat()
            {        
                //User interface
                Console.WriteLine("Tast 'Y' for at blive fordelt på et kollegie");
                char answer = char.Parse(Console.ReadLine());
                if (answer == 'Y' || answer == 'y')
                {
                    //Generate the random number
                    Random rnd = new Random();
                    int number = rnd.Next(1, 5);
                    if (number == 1)
                    {
                        //We convert the enums to string and returns it to the user
                        string gryffindor = ((Colleges)0).ToString();
                        Console.WriteLine("du blev tildelt kollegiet " + gryffindor);
                    }
                    else if (number == 2)
                    {
                        string hufflepuff = ((Colleges)1).ToString();
                        Console.WriteLine("du blev tildelt kollegiet " + hufflepuff);
                    }
                    else if (number == 3)
                    {
                        string ravenclaw = ((Colleges)2).ToString();
                        Console.WriteLine("du blev tildelt kollegiet " + ravenclaw);

                    }
                    else
                    {
                        string slytherin = ((Colleges)3).ToString();
                        Console.WriteLine("du blev tildelt kollegiet " + slytherin);

                    }
                }
                else
                {
                    //Error message
                    Console.WriteLine("Ugyldig værdi");
                }

            }
        }
        
    }
}