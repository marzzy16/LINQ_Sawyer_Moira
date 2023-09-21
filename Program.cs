// See https://aka.ms/new-console-template for more information

using LINQ_Sawyer_Moira;
{
    Game[] games = new Game[]
    {
        // An array of Games called games, initialized with 10 games.
        new Game("Minecraft", 'E', "Action-Adventure"),
        new Game("Horizon zero Dawn", 'T', "Action-Adventure"),
        new Game("Days gone", 'M', "Action-Adventure"),
        new Game("Red Dead Redemption 2", 'M', "Action-Adventure"),
        new Game("Untel Dawn", 'M', "Horror"),
        new Game("Fran Bow", 'T', "Horror"),
        new Game("Detroit Become Human", 'M', "Drama-Adventure"),
        new Game("Devil May Cry 3", 'T', "Action-Adventure"),
        new Game("Outlast", 'M', "Survival Horror"),
        new Game("Genshin Impact", 'T', "Action-RPG"),
    };

    // A LINQ Query that gets all the games with less than 9 characters in the title and assigns them to a var called shortGames.
    var shortGames = from game in games
                     where game.Title.Length < 9
                     select $"Game Title: {game.Title.ToUpper()}";

    //// Loops through and print each element in shortGames.
   foreach(var game in shortGames)
   {
        Console.WriteLine(games);
   }

    // A LINQ method query that finds the game "Minecraft" from the games array and assigns it to a var called mineCraft.
    var mineCraft = games.Where(game => game.Title == "Minecraft")
                    .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre:{game.Genre}");

    // Prints all the game properties of mineCraft to console using the FirstOrDefault method.
    Console.WriteLine(mineCraft.FirstOrDefault());

    // A var named tRated and select the titles where the esrb rating is 'T'.
    var tRated = from game in games
                 where game.Esrb == 'T'
                 select game.Title;

    // Prints to console, "TRated Games:".
    Console.WriteLine("T Rated Games:");
    foreach(var game in tRated)
    {
        // Loops through tRated and prints each element to the console.
        Console.WriteLine(game);
    }

    // A var called eRatedAction that selects the titles where the esrb rating is 'E' and genre is "Action". 
    var eRatedAction = from game in games
                       where game.Esrb == 'E' && game.Genre.Contains("Action")
                       select game.Title;

    // Prints to console, "E Rated Action Games:".
    Console.WriteLine("E Rated Action Games:");
    foreach (var game in tRated)
    {
        // Loops through eRatedAction and prints each element to the console.
        Console.WriteLine(game);
    }
}