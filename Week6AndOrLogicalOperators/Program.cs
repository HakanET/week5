string username, password;
Console.WriteLine("Enter the username");
username = Console.ReadLine();

Console.WriteLine("Enter the password");
password = Console.ReadLine();

if(username != "admin" || password != "admin1234")
{
    Console.WriteLine("invalid user credential");
}
else
{
    Console.WriteLine("welcome");
}


//if (username == "admin" && password == "admin1234")
//{
//    Console.WriteLine("Welcome");
//}
//else
//{
//    Console.WriteLine("invalid user credentials");
//}