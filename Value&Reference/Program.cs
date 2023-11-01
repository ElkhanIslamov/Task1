int[] numbers = { 15, 2, 6, 3 };
Array.Resize(ref numbers, numbers.Length +1 );
int[] numbers2 = { 1, 2, 3, 4, };
Array.Resize(ref numbers, numbers2.Length );
foreach (var number in numbers)
   
    {
    Console.WriteLine(number);
   
}
foreach (var number in numbers2)
{
   Console.WriteLine(number);
}



