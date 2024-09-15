string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium, game);

static string GetEnjoymentLevel(){
    Console.WriteLine("Enter your preferred level of enjoyement");
    string enjoymentLevel = "";
    enjoymentLevel = Console.ReadLine();
    return enjoymentLevel;
}

static string GetStadiumRecommendation(string enjoymentLevel){
    string stadium = "";
    if (enjoymentLevel.ToLower() == "epic"){
        stadium = "Saban Field at Bryant-Denny Stadium";
    }
    else if (enjoymentLevel.ToLower() == "average"){
        stadium = "Jordan-Hare Stadium";
    }
    else if (enjoymentLevel.ToLower() == "fun"){
        stadium = "Tiger Stadium";
    }
    else if (enjoymentLevel.ToLower() == "boring"){
        stadium = "Neyland Stadium";
    }
    else{
        Console.WriteLine("No stadium for you");
    }
    return stadium;
}

static string GetGameRecommendation(string stadium){
    string game = "";
    if (stadium.ToLower() == "saban field at bryant-denny stadium"){
        game = "Auburn at Alabama";
    }
    else if (stadium.ToLower() == "jordan-hare stadium"){
        game = "Kentucky at Auburn";
    }
    else if (stadium.ToLower() == "tiger stadium"){
        game = "Alabama at LSU";
    }
    else if (stadium.ToLower() == "neyland stadium"){
        game = "Kent State at Tennessee";
    }
    else{
        Console.WriteLine("No football game for you");
    }
    return game;
}

static void DisplayStadiumDetails(string stadium, string game){
    Console.WriteLine($"The best stadium to attend is {stadium} for the {game} game.");
}

