// Seminar 3. Task 1 vers2.

bool Palindrome (int num)
{
    int reverseNum = 0;
    int temp = num;
    while (temp > 0)
    {
        reverseNum = reverseNum * 10;
        reverseNum = reverseNum + temp % 10;
        temp = temp / 10;
    }
    
    if (reverseNum == num) return true;
    else return false;
}

Console.Write("Please, input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = Palindrome(num);

if (result == true)
    Console.WriteLine($"Your number \"{num}\" is a palindrome!");
else
    Console.WriteLine($"Your number \"{num}\" is not a palindrome... Sorry.");