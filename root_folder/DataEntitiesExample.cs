using System;
using System.Collections.Generic;

namespace DataEntitiesExample
{
    // Enum example
    public enum UserRole
    {
        Admin,
        User,
        Guest
    }

    // Struct example
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    // Interface example
    public interface IEntity
    {
        int Id { get; set; }
        string Name { get; set; }
        void DisplayInfo();
    }

    // Class example
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UserRole Role { get; set; }

        // Auto-implemented property
        public DateTime CreatedAt { get; set; }

        // Field example
        private string _password;

        // Constructor
        public User(int id, string name, UserRole role, string password)
        {
            Id = id;
            Name = name;
            Role = role;
            _password = password;
            CreatedAt = DateTime.Now;
        }

        // Method example
        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Role: {Role}, CreatedAt: {CreatedAt}");
        }

        // Nested class
        public class Profile
        {
            public string Address { get; set; }
            public string PhoneNumber { get; set; }

            public Profile(string address, string phoneNumber)
            {
                Address = address;
                PhoneNumber = phoneNumber;
            }

            public void DisplayProfile()
            {
                Console.WriteLine($"Address: {Address}, PhoneNumber: {PhoneNumber}");
            }
        }
    }

    // Class with a collection of entities
    public class EntityCollection<T> where T : IEntity
    {
        private List<T> _entities;

        public EntityCollection()
        {
            _entities = new List<T>();
        }

        public void AddEntity(T entity)
        {
            _entities.Add(entity);
        }

        public void DisplayAllEntities()
        {
            foreach (var entity in _entities)
            {
                entity.DisplayInfo();
            }
        }
    }

    // Program class to demonstrate the usage of these entities
    public class Program
    {
        public static void Main(string[] args)
        {
            // Enum usage
            UserRole role = UserRole.Admin;
            Console.WriteLine($"UserRole: {role}");

            // Struct usage
            Point point = new Point(10, 20);
            Console.WriteLine($"Point: {point}");

            // Class and interface usage
            User user1 = new User(1, "Alice", UserRole.User, "password123");
            User user2 = new User(2, "Bob", UserRole.Guest, "password456");

            user1.DisplayInfo();

            // Nested class usage
            User.Profile profile = new User.Profile("123 Main St", "123-456-7890");
            profile.DisplayProfile();

            // Collection of entities
            EntityCollection<User> userCollection = new EntityCollection<User>();
            userCollection.AddEntity(user1);
            userCollection.AddEntity(user2);
            userCollection.DisplayAllEntities();
        }
    }
}
