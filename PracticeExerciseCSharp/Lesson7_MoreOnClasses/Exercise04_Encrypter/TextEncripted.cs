using System;

namespace Exercise04_Encrypter
{
    /// <summary>
    /// Create a class "Encrypter" to encrypt and decrypt text.
    /// 
    /// It will have a "Encrypt" method, which will receive a string and return another string. 
    /// It will be a static method, so that we do not need to create any object of type "Encrypter".
    /// 
    /// There will be also a "Decrypt" method.
    /// 
    /// In this first approach, the encryption method will be a very simple one: 
    /// to encrypt we will add 1 to each character, so that "Hello" would become "Ipmb", 
    /// and to decrypt we would subtract 1 to each character.
    /// 
    /// An example of use might be
    /// 
    /// string newText = Encrypter.Encrypt("Hola");
    /// </summary>
    internal class TextEncripted
    {
        static void Main(string[] args)
        {
            bool debug = true;

            string newText = Encrypter.Encrypt("Hola");
            Console.WriteLine("Text encripted: {0}", newText);
            string TextDescripted = Encrypter.Decrypt(newText);
            Console.WriteLine("Text Decripted: {0}", TextDescripted);

            if (debug)
                Console.ReadLine();
        }
    }
}
