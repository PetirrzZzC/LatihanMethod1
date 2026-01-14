
static void tambah(int a, int b)
{
    int c = 0;

    c = a + b;
    Console.WriteLine ($"{a} + {b} = {c}");
}


static void kurang(int a, int b)
{
    int c = 0;

    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}


static void kali(int a, int b)
{
    int c = 0;

    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}


static void bagi(int a, int b)
{
    int c = 0;

    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

tambah(5,7);
tambah(5,9);

kurang(8,3);
kurang(12, 5);

kali(7,4);
kali(8,7);

bagi(12,2);
bagi(15, 3);