// See https://aka.ms/new-console-template for more information

//a-(n* int(a/n)) is the key to finding out the mod of a/n!

Console.WriteLine("What is the number you're trying to find the mod for!");

int num = Convert.ToInt32(Console.ReadLine());
bool primeTime = true;
for (int i = 2; i< num; i+=1)
{
    for (int newNum = 2; newNum < i; newNum += 1)
    {
        primeTime = true;

        if (i % newNum == 0)
        {

            primeTime = false;
            break;
        }

        
    }
    if (primeTime== true){
        Console.WriteLine(i); }
}
// This was really fun!