using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DiscribingMostCommonAndUsefullMethodsString
{
    static void Main()
    {
        Console.WriteLine(
@"A string is a sequential collection of Unicode characters that is used to 
represent text. A String object is a sequential collection of System.Char 
objects that represent a string. The value of the String object is the content 
of the sequential collection, and that value is immutable (that is, it
is read-only). For more information about the immutability of strings, see 
the Immutability and the StringBuilder class section later in this topic.
The maximum size of a String object in memory is 2 GB, or about 1 BILION CHARCTERS.
    By assigning a string literal to a String variable. This is the most commonly used
method for creating a string. A single Char object usually represents a single code
point; that is, the numeric value of the Char equals the code point. For example, 
the code point for the character ""a"" is U+0061. However, a code point might require
more than one encoded element (more than one Charobject). The Unicode standard defines
three types of characters that correspond to multiple Char objects: graphemes, Unicode
supplementarycode points, and characters in the supplementary planes.An index is the 
position of a Char object (not a Unicode character) in a String. An index is a zero-based
,nonnegative number that starts from the first position in the string, which is index 
position zero. A number ofsearch methods, such as IndexOf and LastIndexOf, return the 
index of a character or substring in the string instance.Consecutive index values might
not correspond to consecutive Unicode characters, because a Unicode character might be 
encoded as more than one Char object. In particular, a string may contain multi-character
units of text that are formed by a base character followed by one or more combining
characters or by surrogate pairs. To work with Unicode characters instead of Char objects, 
use the System.Globalization.StringInfo and TextElementEnumerator classes.A string that
has been declared but has not been assigned a value is null. Attempting to call methods
on that string throws a NullReferenceException. 
    A null string is different from an empty string, which is a string whose value is "" or
String.Empty. In some cases, passing either a null string or an empty string as an 
argument in a method call throws 
an exception. For example, passing a null string to the Int32.Parse method throws
an ArgumentNullException, and passing an emptystring throws a FormatException. 
    In other cases, a method argument can be either a null string or an empty string.
For example, if you are providing an IFormattable implementation for a 
class, you want to equate both a null string and an empty string with the general
(""G"") format specifier."+
    "Immutability and the StringBuilder class \n"+
@"A String object is called immutable (read-only), because its value cannot be modified 
after it has been created. Methods that appear to modify a String object actually return 
a new String object that contains the modification. 
    Formatting and parsing are inverse operations. Formatting rules determine how to convert
a value, such as a date and time or a number, to its string representation, whereas parsing 
rules determine how to convert a string representation to a value such as a date and time. 
Both formatting and parsing rules are dependent on cultural conventions. "
);
    }
}
