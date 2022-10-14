int num = int.Parse(Console.ReadLine());
List<int> array = new List<int>();

for (int i = 1; i <= num; i++)
{ 
    array.Add(i*i*i);
}

Console.Write(String.Join(", ", array));