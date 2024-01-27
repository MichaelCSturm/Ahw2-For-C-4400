// See https://aka.ms/new-console-template for more information
int[] numbers = [5, 2, 3, 1, 4, 200, 90, 100000, 10000000, 23, 1,1,1,1,1,];
int temp = 0;
var watch = System.Diagnostics.Stopwatch.StartNew();
for (int i = 0; i< numbers.Length; i++) {
    //Console.WriteLine(numbers[i]);
    for (int j = 0; j < numbers.Length; j++)
    {
        
        temp = numbers[i];
        if (numbers[j] > numbers[i])
        {
            numbers[i] = numbers[j];
            numbers[j] = temp;  
        }
        



    }


}
foreach(int num in numbers)
{

    Console.WriteLine(num);
}
watch.Stop();
Console.WriteLine($"Using system.dia whatever to calcuate this operation took ${watch} to work");
Console.WriteLine("You sent me down a rabithole of looking into cool algorythms. If i had more time I woulda tried the heap one!");