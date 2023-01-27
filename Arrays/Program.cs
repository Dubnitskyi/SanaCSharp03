Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

int N = 0;
bool ok;
do
{
    Console.Write("Введіть число N = ");
    ok = int.TryParse(Console.ReadLine(), out N);
    if (!ok) Console.WriteLine("Число введено неправельно , повторить спробу!\n");
} while (!ok);

int[] arr=new int[N];
Random rand = new Random();
int minus = 0,max=0,index = 0, sqrtmax = 0,maxindex = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-15,15);
    Console.Write($" |{arr[i]}|");
    if (arr[i] < 0) minus += arr[i];
    if (arr[i] > max) { 
        max = arr[i];
        index = i; 
    }
    if (Math.Sqrt(arr[i]) > Math.Sqrt(sqrtmax))
    {
        sqrtmax = arr[i];
    }
    if(arr[i] >= 0)
    {
        maxindex += i;
    } 
}   
Console.WriteLine($"\n\nСума відємних чисел: {minus}");
Console.WriteLine($"максимальний елемент масиву: {max}");
Console.WriteLine($"індекс максимального елемента масиву: {index}");
Console.WriteLine($"максимальний за модулем елемент масиву: { Math.Sqrt(sqrtmax):f2}");
Console.WriteLine($"суму індексів додатних елементів: { maxindex}");
Console.WriteLine($"кількість цілих чисел у масиві: {N}");