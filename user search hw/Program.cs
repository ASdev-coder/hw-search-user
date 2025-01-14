
// Написать метод для поиска пользователя (-ей) по разным критериям

using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

List<int> ints = new List<int>();
{
    ints.Add(1);
    ints.Add(2);
    ints.Add(3);
    ints.Add(4);
    ints.Add(5);
    ints.Add(6);
    ints.Add(7);  
    ints.Add(8);
    ints.Add(9);
    ints.Add(10);
}
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



List<T> Find<T>(List<T> items, Predicate<T> predicate)
{
    List<T> result = new List<T>();

    foreach (T item in items)
    {
        if (predicate(item))
            result.Add(item);
    }

    return result;
}

//List<User> Find(List<User> users, Predicate predicate )
//{

//    List<User> result = new List<User>();

//    foreach ( User user in users )
//    {
//        if (predicate(user))
//            result.Add( user );
//    }

//    return result;
//};


//List<User> foundUsers = Find(users, user => user.Id > 3 && user.Email == "anton@gmail.com" && user.Age > 18);

//foreach (User user in foundUsers)
//{
//    Console.WriteLine(user.ToString());
//}

List<int> foundInts = Find<int>(ints, number => number > 5 && number%2 == 0);

foreach ( int user in foundInts )
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

