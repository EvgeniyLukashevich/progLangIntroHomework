//Seminar 3. Task 1 vers1.

bool FiveDigitPalindrome (int num)
{
    if (num / 10000 == num % 10  &&  (num / 1000) % 10 == (num % 100) / 10) return true;
    else return false;
}

Console.Write("Please, input your five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result;

if (num > 9999 && num < 100000)
{
    result = FiveDigitPalindrome(num);    
    if (result == true)
        Console.WriteLine($"Your number \"{num}\" is a palindrome!");
    else
        Console.WriteLine($"Your number \"{num}\" is not a palindrome... Sorry.");
}
else Console.WriteLine($"Your number is not a five-digit number. Please, try again");