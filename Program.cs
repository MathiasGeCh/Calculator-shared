//Global declared variables
const string _ad = "addition";
const string _sub = "subtraction";
const string _div = "divide";
const string _mul = "multiply";

Console.WriteLine("Pick your option:");
Console.WriteLine("1: Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiply");
Console.WriteLine("4. Divide");

ConsoleKeyInfo keyInput = Console.ReadKey(true);
int input = int.Parse(keyInput.KeyChar.ToString());

switch (input) {
    case 1:
        math(_ad);
        break;
    case 2:
        math(_sub);
        break;
    case 3:
        math(_div);
        break;
    case 4:
        math(_mul);
        break;
    default:
        Console.WriteLine("Wrong choice!");
        break;
}

Console.ReadKey();

void math(string type) {
    int result = 0;
    switch (type) {
        case _ad:
            Console.WriteLine("This will add.");
            calculation(_ad);
            Console.WriteLine("This is your result: " + result);
            break;
        case _sub:
            Console.WriteLine("This will subtract.");
            calculation(_sub);
            Console.WriteLine("This is your result: " + result);
            break;
        case _div:
            Console.WriteLine("This will divide.");
            calculation(_div);
            Console.WriteLine("This is your result: " + result);
            break;
        case _mul:
            Console.WriteLine("This will multiply.");
            calculation(_mul);
            Console.WriteLine("This is your result: " + result);
            break;

        void calculation(string input){
            int inputOne;
            int inputTwo;
            Console.WriteLine("Insert your first value and hit enter.");
            inputOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert your second value and hit enter.");
            inputTwo = int.Parse(Console.ReadLine());
            switch (input) {
                case _ad:
                result = inputOne + inputTwo;
                break;
                case _sub:
                result = inputOne - inputTwo;
                break;
                case _div:
                result = inputOne / inputTwo;
                break;
                case _mul:
                result = inputOne * inputTwo;
                break;
            }            
        }
    }
} 