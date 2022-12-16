int a = Convert.ToInt32(Console.ReadLine());
int i = 2;
Console.Write("Все четные числа от 0 до " + a + ": ");
while (i <= a) {
    if (i % 2 == 0) {
        Console.Write(i + ", ");
    }
    i++;
}
