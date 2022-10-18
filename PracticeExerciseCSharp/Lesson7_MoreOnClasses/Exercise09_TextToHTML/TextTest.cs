using System;

namespace Exercise09_TextToHTML
{
    /// <summary>
    /// Create a class "TextToHTML", which must be able to convert several texts entered 
    /// by the user into a HTML sequence, like this one:
    /// 
    /// Hola
    /// Soy yo
    /// Ya he terminado
    /// 
    /// should become
    /// 
    /// Hola
    /// 
    /// Soy yo
    /// 
    /// Ya he terminado
    /// 
    /// The class must contain:
    /// An array of strings
    /// A method "Add", to include a new string in it
    /// A method "Display", to show its contents on screen
    /// A method "ToString", to return a string containing all the texts, separated by "\n".
    /// Create also an auxiliary class containing a "Main" function, to help you test it.
    /// </summary>
    internal class TextTest
    {
        static void Main(string[] args)
        {
            TextToHTML example = new TextToHTML();
            example.Add("Hola");
            example.Add("uno dos");
            example.Add("tres cuatro");
            example.Display();
        }
    }
}
