using System;

class Teste5
{
    public static void InverterString(string input)
    {
        char[] charArray = input.ToCharArray();

        int left = 0;
        int right = charArray.Length - 1;
        
        while (left < right)
        {
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;

            left++;
            right--;
        }

        string stringInvertida = new string(charArray);

        Console.WriteLine("String original: " + input);
        Console.WriteLine("String invertida: " + stringInvertida);
    }
}
