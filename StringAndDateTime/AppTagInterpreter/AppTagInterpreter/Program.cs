string? input = Console.ReadLine();


input = input.Remove(0, 1);
input = input.Remove(input.Length - 1, 1);

string[] arr = input.Split("><", StringSplitOptions.RemoveEmptyEntries);

int openTagCount = 0;
int closeTabCount = 0;

foreach (var item in arr)
{
    if (item == "app")
    {
        openTagCount++;
    }
    else if (item == "/app")
    {
        if (openTagCount > 0)
        {
            openTagCount--;
        }
        else
        {
            closeTabCount++;
        }
    }
}

int result = Math.Abs(openTagCount + closeTabCount);

Console.WriteLine(result);

//<app><app><app></app></app>
//<app></app></app></app><app>
//</app><app><app></app></app>