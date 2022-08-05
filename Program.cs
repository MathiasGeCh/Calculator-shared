Console.WriteLine("Pick your option:");
Console.WriteLine("1: Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiply");
Console.WriteLine("4. Divide");

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
    case 3:
        string multi = "multiply";
        math(multi);
        break;
    case 4:
        string div = "divide";
        math(div);
        break;
}

void math(string type) {
    int inputOne;
    int inputTwo;
    int result;
    if (type == "addition") {
        Console.WriteLine("This is addition, insert your first value and hit enter.");
    } else if (type == "substraction"){
        Console.WriteLine("This is subtraction, insert your first value and hit enter.");
    }
    else if (type == "multiply") {
        Console.WriteLine("This is multiplication, insert your first value and hit enter.");
    } else
        Console.WriteLine("This is divide, insert your first value and hit enter.");
    inputOne = int.Parse(Console.ReadLine());
    Console.WriteLine("Insert your second value and hit enter.");
    inputTwo = int.Parse(Console.ReadLine());
    if (type == "addition") {
        result = inputOne + inputTwo;
    } else if (type == "substraction") {
        result = inputOne - inputTwo;
    }
    else if (type == "multiply")
    {
        result = inputOne * inputTwo;
    }
    else
    {
        result = inputOne / inputTwo;
    }
    Console.WriteLine("This is your result: " + result);
    Console.ReadKey();
}