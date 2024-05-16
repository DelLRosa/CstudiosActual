// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";


System.Console.WriteLine("Enter a string here: ");
string userStr = Console.ReadLine();
userStr= userStr.ToLower();
Dictionary<char,int> letters = new Dictionary<char, int>();
char[] charactersInString = userStr.ToCharArray();

foreach(char letter in charactersInString){
    if(!letters.ContainsKey(letter)){
        letters.Add(letter,1);
    } else {
        letters[letter] = letters[letter]+1;
    }
}

foreach(KeyValuePair<char,int> key in letters){
System.Console.WriteLine(key.Key + ": "+key.Value);
}