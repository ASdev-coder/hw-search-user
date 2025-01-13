
// Написать метод для поиска пользователя (-ей) по разным критериям

using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

List<User> users = new List<User>()
{
    new User (1, "ilya@gmail.com",  15 ),
    new User (2, "sasha@gmail.com",  26 ),
    new User (3, "anton@gmail.com",  8 ),
    new User (4, "anton@gmail.com",  71 ),
    new User (5, "sasha@gmail.com",  29 ),
    new User (6, "anton@gmail.com",  30 ),
    new User (7, "anton@gmail.com",  2 ),
    new User (8, "sasha@gmail.com",  40 ),
    new User (9, "ilya@gmail.com",  22 ),
    new User (10, "ilya@gmail.com",  39 ),
    new User (11, "anton@gmail.com",  68 ),
    new User (12, "sasha@gmail.com",  25 ),

};

List<User> Find(List<User> users, Predicate predicate )
{

    List<User> result = new List<User>();

    foreach ( User user in users )
    {
        if (predicate(user))
            result.Add( user );
    }

    return result;
};

// Find<T>()        // <<<<< !!!!!!!    ***

List<User> foundUsers = Find(users, user => user.Id > 3 && user.Email == "anton@gmail.com" && user.Age > 18);

foreach( User user in foundUsers )
{
    Console.WriteLine(user.ToString());
}

class User
{
    public int Id { get; set; }
    public string? Email { get; set; }
    public int Age { get; set; }
    public User(int id, string? email, int age)
    {
        Id = id;
        Email = email;
        Age = age;
    }
    public override string ToString()
    {
        return $"{Id} {Email} {Age}";
    }

}

delegate bool Predicate(User user);

