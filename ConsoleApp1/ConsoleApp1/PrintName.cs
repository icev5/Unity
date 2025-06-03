// See https://aka.ms/new-console-template for more information
string Name(string Xing, string Ming)
{
    return Xing + Ming;
}

string MyXing = "吴";
string MyMing = "炳灿";
string MyName = Name(MyXing, MyMing);
Console.WriteLine(MyName);
Console.ReadKey();
