// Bitwise Operations - operators that allow us to manipulate numbers on a bit level

// AND
var andOperator = Convert.ToString((5 & 4), 2); // 101 & 100 = 100
// if one bit is 1 and another bit is 0 then it remains 0
// if both bits are 0 then it remains a 0
// only write 1 if both bits are 1

// OR
var andOperator = Convert.ToString((5 | 4), 2); // 101 | 100 = 101
// as long as one bit is 1 then it will write a 1

// shift right
var andOperator = Convert.ToString((5 >> 4), 2); // 101 >> 1 = 10
// shifts your bits to the right 

// shift left
var andOperator = Convert.ToString((5 << 4), 2); // 101 << 1 = 1010
// shifts your bits to the left or adds 0 bits to the end 


// exclusive-OR
var andOperator = Convert.ToString((5 ^ 4), 2); // 101 ^ 100 = 001
// it will only print out a 1 if the bits are different 

// invert
var andOperator = Convert.ToString((~5), 2); // ~101 = 11111111111111111111111111111010
// Basically inverts the bits
// Since the example above is an int = 32 bits, the 29 0's will invert to 1's
