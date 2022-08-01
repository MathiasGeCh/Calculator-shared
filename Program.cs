Console.WriteLine("Pick your option:");
Console.WriteLine("1: Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Divide");
Console.WriteLine("4. Multiply");

string keyInput = Console.ReadKey();
int input = int.Parse(keyInput);

switch (input) {
    case 1:
        adittion();
}

void adittion() {
    Console.WriteLine("This is addition, insert your first value and hit enter.");
    int inputOne = int.Parse(Console.ReadLine());
    Console.WriteLine("Insert your second value and hit enter.");
    int inputTwo = int.Parse(Console.ReadLine());
    int result = inputOne + inputTwo;
    Console.WriteLine("This is your result:" + result);
    Console.ReadKey();
}