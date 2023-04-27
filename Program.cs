var rand = new Random(4711);
long newRandom = rand.Next(1,1000000001);
decimal average = 0;
decimal min = newRandom;
decimal max= newRandom;

for (long i = 0; i < 1000000; i++)
{
    newRandom = rand.Next(1,1000000001);

    if(min>newRandom)
    {
        min = newRandom;
    }
    if ( max <newRandom)
    {
        max=newRandom;
    }
}
average=max-min;
average/=1000000-1;

System.Console.WriteLine(average);
/*
do
{
        switched = false;
    for (long i = 0; i < (newRandom.Length-1); i++)
    {
        long x = newRandom[i];
        long y = newRandom[i+1];

        if (y < x)
        {
            switched = true;
            (newRandom[i],newRandom[i+1])=(newRandom[i+1],newRandom[i]);
        }
    }
} while (switched);

for (long i = 0; i < (newRandom.Length-1); i++)
{
    long x = newRandom[i];
    long y = newRandom[i+1];

    average += y - x;
}
average/=newRandom.Length-1;
System.Console.WriteLine(average);
*/