/*string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(') +1;// index of openning parenthes. added +1 as index is zero based
int closingPosition = message.IndexOf(')');// index of closing parenthes

int length = closingPosition - openingPosition;

Console.WriteLine(message.Substring(openingPosition, length));*/

/*string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";// to avoid hardcoding
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length; //add a length of string instead of hardcoded value
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));*/


/*string message = "(What if) I am (only interested) in the last (set of parentheses)?";


while (true)
{
    int openingPosition = message.IndexOf('(');//return an index of last parenthes
    if (openingPosition == -1) break; //if paranthes not found

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}*/

/*string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
char[] openSymbols = { '[', '{', '(' };
// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;//no more occurences

    string currentSymbol = message.Substring(openingPosition, 1);//to extract current char

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}*/

/*string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20); //remove 20 characters starting from 5 index
Console.WriteLine(updatedData);

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");//replaces all -- with spaces
message = message.Replace("-", "");//replace - with nothing
Console.WriteLine(message);*/

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>"; 

int startingPosition = input.IndexOf("<span>") + "<span>".Length; //to find a position there span ends
int closingPosition = input.IndexOf("</span>");//find first char of span end
int length = closingPosition - startingPosition; //find a distance between them

string quantity = input.Substring(startingPosition, length); // cut everything between two spans
string output = input.Replace("<div>", ""); //take spans away
output = input.Replace("/div>", "");
output = output.Replace("&trade", "&reg");//replace trademoark

Console.WriteLine(quantity);
Console.WriteLine(output);