const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Set the quantity variable to the value obtained by extracting the text between the <span> and </span> tags.
const string span = "<span>";
const string spanEnd = "</span>";
int start = input.IndexOf(span) + span.Length;
int length = input.IndexOf(spanEnd) - start;

quantity = "Quantity: " + input.Substring(start, length);

// Replace the HTML character (&trade) with (&reg) in the output variable.
output = input.Replace("&trade", "&reg");

// Set the output variable to the value of input, then remove the <div> and </div> tags.
const string div = "<div>";
start = output.IndexOf(div);
output = output.Remove(start, div.Length);

const string divEnd = "</div>";
start = output.IndexOf(divEnd);
output = "Output: " + output.Remove(start, divEnd.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);