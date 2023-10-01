
/* simple program to count amount of odd numbers in the array
int[] numArray = { 4124, 4412, 42, 565, 64, 41, 543, 412, 5436, 412, 2, 6, 56, 32, 4132, 3124, 6, 9, 15, 3, 7, 15 };
int counter = 0;

for  (int i = 0; i < numArray.Length; i++)
{
    int divider = (int)numArray[i] % 2;

  
    if(divider != 0)
    {
        counter++;
    }

}

Console.WriteLine("Ampunt of odd numbers in the array is: " + counter); */

/* simple program to count sum of the array
int[] numArray = { 4124, 4412, 42, 565, 64, 41, 543, 412, 5436, 412, 2, 6, 56, 32, 4132, 3124, 6, 9, 15, 3, 7, 15,-100000};
long sum = 0;

for (int i = 0; i < numArray.Length; i++)
{
    sum += numArray[i];
}
Console.WriteLine(sum);*/

/* reverse a string
string simpleWord = "Kukaracha!";
char[] wordArray = simpleWord.ToCharArray();
Array.Reverse(wordArray);
string reversedWord = new string (wordArray);

Console.WriteLine(reversedWord); */

