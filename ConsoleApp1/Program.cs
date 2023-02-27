using EncryptionService;

var key = "b14ca5898a4e4133bbce2ea2315a1916";

Console.WriteLine("Please enter a string for encryption");
var str = Console.ReadLine();
string encryptedString = str.Encrypt(key);
Console.WriteLine($"encrypted string = {encryptedString}");

var decryptedString = encryptedString.Decrypt(key);
Console.WriteLine($"decrypted string = {decryptedString}");


key = "b14ca5898a4e4133";

encryptedString = str.Encrypt(key);
Console.WriteLine($"encrypted string = {encryptedString}");

decryptedString = encryptedString.Decrypt(key);
Console.WriteLine($"decrypted string = {decryptedString}");

Console.ReadKey();