﻿using System;

namespace Exercise10_ScreenText
{
    /// <summary>
    /// Create a class ScreenText, to display a certain text in specified screen coordinates. 
    /// It must have a constructor which will receive X, Y and the string to write. 
    /// It must also have 3 setters and a "Display" method.
    /// 
    /// Create a class CenteredText, based on ScreenText, to display text centered(horizontally) 
    /// in a certain row of the screen.Its constructor will receive only Y and the text. 
    /// SetX should not change the horizontal position.
    /// 
    /// Create a class FramedText, to display text centered and inside a rectangle.
    /// It will receive the starting row and the text.
    /// 
    /// Finally, create a test program for all of them, which will create an object of each type and display them.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
