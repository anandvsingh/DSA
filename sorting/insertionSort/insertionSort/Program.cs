int min = 20;
int max = 100;

int[] input = new int[10];

Random randnum = new Random(); 

for (int i = 0; i<input.Length; i++)
{
    input[i]=randnum.Next(min, max);
}


for (int i = 1; i<input.Length; i++)
{
    int key = input[i];
    int j=i-1;
    while (j>=0 && input[j]>key)
    {
        input[j+1] = input[j];
        j--;
    }
    input[j+1] = key;
            
}

foreach(int a in input){
    Console.WriteLine(a);
}
