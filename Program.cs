// Strings
string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
Console.WriteLine(alice);
Console.WriteLine("Search for a word within this string: ");
string searchWord = Console.ReadLine();
string word = searchWord.ToLower();
string aliceLower = alice.ToLower();

if (aliceLower.IndexOf(word, 0) != -1)
{
    Console.WriteLine("true");
    Console.WriteLine(alice.Length)

}
else
{
    Console.WriteLine("false");
}