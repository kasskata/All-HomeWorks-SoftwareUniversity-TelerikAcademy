namespace ChatDatabaseInMongoLab
{
    using System;
    using System.Collections.Generic;
    using MongoDB.Driver;
    using MongoDB.Driver.Builders;

    class Program
    {
        static void Main()
        {
            try
            {


                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Title = "Mongo ICQ®";
                Console.WindowHeight = 54;
                Console.WindowWidth = 100;
                Console.Beep(432, 200);

                var client = new MongoClient();
                var server = client.GetServer();
                var db = server.GetDatabase("ChatSystem");

                //The database should keep messages. Each message has a text, date and an embedded field user. Users have username.

                var collection = db.GetCollection<Message>("messages");
                var users = db.GetCollection<User>("users");

                Seed(collection, users);

                string username = string.Empty;
                MongoCursor<Message> postsFromUser;

                Console.WriteLine("Wellcome Kasskata™ Test Chat system");
                Console.Write("Enter you username:");
                username = Console.ReadLine();
                Console.WriteLine("User: {0}", username);

                while (true)
                {
                    var message = Console.ReadLine();
                    Console.Beep(432, 200);

                    switch (message)
                    {
                        case "bastis":
                            Environment.Exit(1);
                            break;
                        case "history":
                            Console.WriteLine("Your Post");
                            var userPosts = Query.EQ("UserName", username);
                            postsFromUser = collection.Find(userPosts);
                            Console.WriteLine(string.Join("\n", postsFromUser));
                            break;
                        case "logout":
                            Console.Write("Enter you username:");
                            username = Console.ReadLine();
                            Console.WriteLine("User: {0}", username);
                            break;
                        case "clean":
                            Console.Clear();
                            Console.WriteLine("Wellcome Kasskata™ Test Chat system");
                            break;
                        default:
                            collection.Insert(new Message
                            {
                                Text = message,
                                Time = DateTime.Now,
                                UserName = username
                            });
                            break;
                    }
                }
            }
            catch (MongoConnectionException e)
            {
                Console.WriteLine("Check YOur MnogoDB local Database is ON and try again");
            }
        }

        private static void Seed(MongoCollection<Message> collection, MongoCollection<User> users)
        {

            collection.InsertBatch(new List<Message>
            {
                new Message
                {
                    Text = "chatim chatim",
                    Time = DateTime.Now,
                    UserName = "Pesho"
                },
                new Message
                {
                    Text = "Mnogo chatim",
                    Time = DateTime.Now,
                    UserName = "Gosho"
                },
                new Message
                {
                    Text = "S pesho chatim",
                    Time = DateTime.Now,
                    UserName = "Pesho"
                }
            });

            users.InsertBatch(new List<User>
            {
                new User
                {
                    Username = "Pesho"
                },
                new User
                {
                    Username = "Gosho"
                }
            });
        }
    }
}
