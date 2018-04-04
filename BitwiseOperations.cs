// Bitwise Operations - operators that allow us to manipulate numbers on a bit level

// AND
var andOperator = Convert.ToString((5 & 4), 2); 

Console.WriteLine(andOperator); // 101 & 100 = 100
Console.ReadKey(); 
// if one bit is 1 and another bit is 0 then it remains 0
// both bits are 0 then it remains a 0
// only write 1 if both bits are 1

// OR
var orOperator = Convert.ToString((5 | 4), 2); 

Console.WriteLine(orOperator); // 101 | 100 = 101
Console.ReadKey();
// as long as one bit is 1 then it will write a 1

// shift right
var shiftRightOperator = Convert.ToString((5 >> 1), 2); 

Console.WriteLine(shiftRightOperator); // 101 >> 1 = 10
Console.ReadKey();
// shifts your bits to the right 

// shift left
var shiftLeftOperator = Convert.ToString((5 << 1), 2); 

Console.WriteLine(shiftLeftOperator); // 101 << 1 = 1010
Console.ReadKey();
// shifts your bits to the left or adds 0 bits to the end 


// exclusive-OR
var exclusiveOrOperator = Convert.ToString((5 ^ 4), 2); 
            
Console.WriteLine(exclusiveOrOperator); // 101 ^ 100 = 1
Console.ReadKey();
// it will only print out a 1 if the bits are different 

// invert
var invertOperator = Convert.ToString((~5), 2); 

Console.WriteLine(invertOperator); // ~101 = 11111111111111111111111111111010
Console.ReadKey();
// Basically inverts the bits
// Since the example above is an int = 32 bits, the 29 0's will invert to 1's


// Look into Enum flags: 

/*-- Abstract class
    - Why would you use an abstract class instead of an interface?
    - Why would you use an abstract class instead of a regular class?