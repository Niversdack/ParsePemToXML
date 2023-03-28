// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;

TextReader reader;
if (args.Length > 0) {
    reader = new StreamReader(new FileStream(args[0], FileMode.Open));
}
else
{
    reader = Console.In;
    
}
var key = reader.ReadToEnd();
var encryptor = RSA.Create();
encryptor.ImportFromPem(key.ToCharArray());
var isPrivate = Strings.InStr(key, "PRIVATE") != 0;

Console.WriteLine(encryptor.ToXmlString(isPrivate));
