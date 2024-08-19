int[] arr = { -2, -1, 0, 10 };

Console.WriteLine(arr[3]);
Console.WriteLine(arr[1]);

int sum = 0;
foreach (int tal in arr) {
    sum += tal;
}

Console.Write(sum);