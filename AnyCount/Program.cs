using System.Diagnostics;

var myList = new List<int>();
var endNumber = 1000000;
for (var i = 1; i <= endNumber; i++)
{
    myList.Add(i);
}

// explores the whole list
var stopWatch1 = new Stopwatch();
stopWatch1.Start();
var existUsingCount = myList.Count(x => x == endNumber / 5) > 0;
stopWatch1.Stop();
if (existUsingCount)
{
    Console.WriteLine($"Result count {existUsingCount} found in {stopWatch1.ElapsedMilliseconds} ms");
}

// stops at the find moment
var stopWatch2 = new Stopwatch();
stopWatch2.Restart();
var existUsingAny = myList.Any(x => x == endNumber / 5);
stopWatch2.Stop();
if (existUsingAny)
{
    Console.WriteLine($"Result any {existUsingAny} found in {stopWatch2.ElapsedMilliseconds} ms");
}
