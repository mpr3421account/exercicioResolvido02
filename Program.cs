using exercicioResolvido02.Entities;

Comment c1 = new Comment("Have a nice trip!");
Comment c2 = new Comment("Wow that's awsome!");

Post p1 = new Post(
    DateTime.Parse("21/06/2018 13:05:44"),
    "Traveling to New Zealand",
    "I'm going to visit the wonderful country!",
    12);

p1.AddComment(c1);
p1.AddComment(c2);