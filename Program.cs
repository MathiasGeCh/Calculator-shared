Console.WriteLine("Pick your option:");
Console.WriteLine("1: Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Divide");
Console.WriteLine("4. Multiply");

string keyInput = Console.ReadLine();
int input = int.Parse(keyInput);

switch (input) {
    case 1:
        string ad = "addition";
        math(ad);
        break;
    case 2:
        string sub = "subtraction";
        math(sub);
        break;
}

void math(string type) {
    int inputOne;
    int inputTwo;
    int result;
    if (type == "addition") {
        Console.WriteLine("This is addition, insert your first value and hit enter.");
    } else {
        Console.WriteLine("This is subtraction, insert your first value and hit enter.");
    }
    inputOne = int.Parse(Console.ReadLine());
    Console.WriteLine("Insert your second value and hit enter.");
    inputTwo = int.Parse(Console.ReadLine());
    if (type == "addition") {
        result = inputOne + inputTwo;
    } else {
        result = inputOne - inputTwo;
    }
    Console.WriteLine("This is your result: " + result);
    Console.ReadKey();
}