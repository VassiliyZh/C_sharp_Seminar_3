// Вводим число n и на выходе получаем числовой ряд по возразтанию до n, 
// каждый из которых возведенный в куб
string TableCubes(int n) 
{
    string answer = string.Empty;

    for (int i = 1; i<=n; i++)
    {
        answer+=(i==n)? Math.Pow(i,3).ToString() : Math.Pow(i,3).ToString() + ",";
    }
    return answer;
}
int n = 6;
Console.WriteLine(TableCubes(n));
