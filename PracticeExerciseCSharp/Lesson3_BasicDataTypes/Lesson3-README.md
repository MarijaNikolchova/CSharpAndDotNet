# Lesson C# Sharp: 3 - Basic data types
&nbsp;
#### Exercise C# Sharp: 3.01 Char
>
> Write a program to ask the user for three letters and display them in reverse order.
>
#### Exercise C# Sharp: 3.02 Triangle
>
> Write a program which asks for a symbol and a width, and displays a triangle of that width, using that number for the inner symbol, as in this example:
>
> Enter a symbol: 4
> Enter the desired width: 5
> 
> 44444
> 4444
> 444
> 44
> 4.
>
#### Exercise C# Sharp: 3.03 Password as string
>
> Write a program to ask the user for his/her name and his/her password (both must be strings) and repeat it as many times as necessary, until the entered name is "user" and the password is "password".
>
#### Exercise C# Sharp: 3.04 Password, 5 attempts
>
> Write a program which asks the user for his login and password. Both must be strings. After 5 wrong attempts, the user will be rejected.
>
#### Exercise C# Sharp: 3.05 Calculator – if
>
> Write a program which asks the user for two numbers and an operation to perform on them (+,-,*,x,/) and displays the result of that operation, as in this example:
> 
> Enter first number: 5
> Enter operation: +
> Enter second number: 7
> 5+7=12
>
> Note: you MUST use "if", not "switch".
>
#### Exercise C# Sharp: 3.06 Calculator – switch
>
> Write a program which asks the user for two numbers and an operation to perform on them (+,-,*,x,/) and displays the result of that operation, as in this example:
>
> Enter first number: 5
> Enter operation: +
> Enter second number: 7
> 5+7=12
>
> Note: you MUST use "switch", not "if"
>
#### Exercise C# Sharp: 3.07 Double
>
> Calculate the perimeter, area and diagonal of a rectangle, given its width and its height.
> (Hint: use y = Math.Sqrt(x) to calculate a square root)
>
#### Exercise C# Sharp: 3.08 Calculate values of a function
>
> Create a program to display certain values of the function y = x2 - 2x + 1 (using integer numbers for x, ranging from -10 to +10)
>
#### Exercise C# Sharp: 3.09 Display a function
>
> Create a program to "draw" the graphic of the function y = (x-4)2 for integer values of x ranging -1 to 8. It will show as many asterisks on screen as the value obtained for "y", like this:
> ```
> *************************
> ****************
> *********
> ****
> *
>
> *
> ****
> *********
> ****************
> ```
#### Exercise C# Sharp: 3.10 Float, speed units
>
> Create a program to ask the user for a distance (in meters) and the time taken (as three numbers: hours, minutes, seconds), and display the speed, in meters per second, kilometers per hour and miles per hour (hint: 1 mile = 1609 meters).
>
#### Exercise C# Sharp: 3.11 Sphere – float
>
> Calculate the surface and volume of a sphere, given its radius (surface = 4 * pi* radius squared; volume = 4/3 * pi * radius cubed).
> 
> Hint: for "float" numbers, you must use Convert.ToSingle(...)
> 
#### Exercise C# Sharp: 3.12 Vowel – switch
>
> Create a program to ask the user for a symbol and answer if it is a (lowercase)vowel, a digit, or any other symbol, using "switch".
#### Exercise C# Sharp: 3.13 Vowel – if
> 
> Create a program to ask the user for a symbol and answer if it is a (lowercase)vowel, a digit, or any other symbol, using "if".
> 
#### Exercise C# Sharp: 3.14 Triangle, NorthEast
> 
> Write a program which asks for a width, and displays a triangle like this one:
> 
> Enter the desired width: 5
> ```
> *****
> _****
> __***
> ___**
> ____*
> ```
#### Exercise C# Sharp: 3.15 Prime factors
>
> Create a program that displays a number (entered by the user) as a product of its prime factors. For example, 60 = 2 · 2 · 3 · 5
>
> (Hint: it can be easier if the solution is displayed as 60 = 2 · 2 · 3 · 5 · 1)
>
#### Exercise C# Sharp: 3.15 Prime factors
>
> Create a program that displays a number (entered by the user) as a product of its prime factors. For example, 60 = 2 · 2 · 3 · 5
> 
> (Hint: it can be easier if the solution is displayed as 60 = 2 · 2 · 3 · 5 · 1)
>
#### Exercise C# Sharp: 3.16 If, symbols
>
> Create a program to ask the user for a symbol and answer if is an uppercase vowel, a lowercase vowel, a digit or any other symbol, using "if".
>
#### Exercise C# Sharp: 3.17 Char + for
>
> Create a program to write the letters "B" to "N" (uppercase), using "for"
>
#### Exercise C# Sharp: 3.18 Double, approximation of Pi
>
> Create a program to calculate an approximation for PI using the expression
>
> pi/4 = 1/1 - 1/3 + 1/5 -1/7 + 1/9 - 1/11 + 1/13 ...
>
> The user will indicate how many terms must be used, and the program will displayb all the results until that amount of terms.
>
#### Exercise C# Sharp: 3.19 Perimeter, area, diagonal
>
> Create a program to write the letters "B" to "N" (uppercase), using "for"
>
#### Exercise C# Sharp: 3.20 Hexadecimal and binary
>
> Create a program to ask the user for a number an display it both in hexadecimal and binary. It must repeat until the user enters 0.
>
#### Exercise C# Sharp: 3.21 Hexadecimal table
>
> Create a program to display the hexadecimal numbers from 0 to 255 (decimal), in 16 rows with 16 numbers each (first row will contain the numbers 0 to 15 -decimal-, second will have 16 to 31 -decimal-, and so on).
> ```
> The result should be:
> 00 01 02 03 04 05 06 07 08 09 0a 0b 0c 0d 0e 0f
> 10 11 12 13 14 15 16 17 18 19 1a 1b 1c 1d 1e 1f
> 20 21 22 23 24 25 26 27 28 29 2a 2b 2c 2d 2e 2f
> 30 31 32 33 34 35 36 37 38 39 3a 3b 3c 3d 3e 3f
> 40 41 42 43 44 45 46 47 48 49 4a 4b 4c 4d 4e 4f
> 50 51 52 53 54 55 56 57 58 59 5a 5b 5c 5d 5e 5f
> 60 61 62 63 64 65 66 67 68 69 6a 6b 6c 6d 6e 6f
> 70 71 72 73 74 75 76 77 78 79 7a 7b 7c 7d 7e 7f
> 80 81 82 83 84 85 86 87 88 89 8a 8b 8c 8d 8e 8f
> 90 91 92 93 94 95 96 97 98 99 9a 9b 9c 9d 9e 9f
> a0 a1 a2 a3 a4 a5 a6 a7 a8 a9 aa ab ac ad ae af
> b0 b1 b2 b3 b4 b5 b6 b7 b8 b9 ba bb bc bd be bf
> c0 c1 c2 c3 c4 c5 c6 c7 c8 c9 ca cb cc cd ce cf
> d0 d1 d2 d3 d4 d5 d6 d7 d8 d9 da db dc dd de df
> e0 e1 e2 e3 e4 e5 e6 e7 e8 e9 ea eb ec ed ee ef
> f0 f1 f2 f3 f4 f5 f6 f7 f8 f9 fa fb fc fd fe ff
>```
#### Exercise C# Sharp: 3.22 Binary
>
> Create a program that asks the user for a decimal number and displays its equivalent in binary form. It should be repeated until the user enters the word "end." You must not use "ToString", but succesive divisions.
>
#### Exercise C# Sharp: 3.23 Conditional and Boolean
>
> Create a program that uses the conditional operator to give a boolean variable named "bothEven" the value "true" if two numbers entered by the user are the even, or "false" if any of them is odd.
>
#### Exercise C# Sharp: 3.24 Exceptions
>
> Create a program to ask the user for a real number and display its square root. Errors must be trapped using "try..catch".
>
> Does it behave as you expected?
>