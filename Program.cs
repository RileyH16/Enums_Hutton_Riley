// See https://aka.ms/new-console-template for more information
using System.IO;
//int called myBirthMonth and set to june
int myBirthMonth = (int)Months.Jun;
//int called myBirthDay and set to 22
int myBirthDay = 22;
//int called myBirthYear and set to 2005
int myBirthYear = 2005;

//String called myBirthDate and says "My birthday is on <myBirthMonth>/<myBirthDay>/<myBirthYear>."
string myBirthDate = $"Mybirthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

//Creates the file called "myFile.txt" and adds text to it, then prints it to console
File.WriteAllText("myFile.txt", "This is my text file!\n");
Console.WriteLine(File.ReadAllText("myFile.txt"));

//Appends new text onto the file, and prints it to console again
File.AppendAllText("myFile.txt", "WooHoo more text added to my file!\n");
Console.WriteLine(File.ReadAllText("myFile.txt"));

//If the file does not exist it will copy my file to a new file
if (!File.Exists("newFile.txt"))
{
    File.Copy("myFile.txt", "newFile.txt");
}
//If the file does exist it will replace it with my file
else
{
    File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
}

//Adds myBirthDate to the end of the file, and prints it to console 
File.AppendAllText("newFile.txt", myBirthDate);
Console.WriteLine(File.ReadAllText("newFile.txt"));

//Enum that lists the months
enum Months
{
    Jan = 1,
    Feb,
    Mar,
    Apr,
    May,
    Jun,
    Jul, 
    Aug, 
    Sep,
    Oct,
    Nov,
    Dec, 
}

