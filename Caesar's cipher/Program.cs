using System;

class CaesarCipher
{
    static string Encrypt(string text, int shift)
    {
        char[] result = text.ToCharArray();

        for (int i = 0; i < result.Length; i++)
        {
            if (char.IsLetter(result[i]))
            {
                char offset = char.IsUpper(result[i]) ? 'A' : 'a';
                result[i] = (char)(((result[i] + shift - offset) % 26) + offset);
            }
        }

        return new string(result);
    }

    static string Decrypt(string text, int shift)
    {
        return Encrypt(text, 26 - shift); // Decrypting is the same as encrypting with the reverse shift
    }

    static void Main()
    {
        string originalText = "Ваш текст"; // Замініть на свій текст
        int shift = 3; // Кількість позицій для зсуву

        string encryptedText = Encrypt(originalText, shift);
        string decryptedText = Decrypt(encryptedText, shift);

        Console.WriteLine("Оригінальний текст: " + originalText);
        Console.WriteLine("Зашифрований текст: " + encryptedText);
        Console.WriteLine("Розшифрований текст: " + decryptedText);
    }
}