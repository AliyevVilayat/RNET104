
/*HomeTask
 * 
int[] arr =  LastHomeTask.AddArrayelements(6);
foreach (var item in arr)
{
    Console.Write(item+" ");
}*/

using HomeTask;

Console.Write("Zehmet olmasa arrayin sayini daxil edin: ");
int count = Convert.ToInt32(Console.ReadLine());
int index = 0;
int j;
while (index < count)
{
    j = 0;

    int[] arr = LastHomeTask.AddArrayelements(count);
    while (j < arr.Length)
    {
        Console.Write(arr[j] + " ");
        j++;
    }
    Console.WriteLine("\n");
    Console.WriteLine("-----------------------");

    index++;

}