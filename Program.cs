// ***** Main ****** //

string season = GetSeason();

string message = GetSeasonMessage(season);

System.Console.WriteLine(message);

// ****** End *******//

static string GetSeason(){
    System.Console.WriteLine("What is the current season? (winter, spring, summer, fall)");
    return Console.ReadLine();
}

static string GetSeasonMessage(string season){
    string message;
    if(season == "fall"){
        message = FavoriteSeasonMessage("sherlenthia");
    } else if(season == "winter"){
        message = FavoriteSeasonMessage("manav");
    } else{
        message = "It is not a TAs favorite season";
    }

    return message;
}

static string FavoriteSeasonMessage(string name){
    return "Yay, it is " + name + "'s favorite season 🥳";
}