using System.Text.Json;
using System.Text.Json.Serialization;

// Collapse the region to hide this huge chunk.
// Since this is a single file minimum api app - the data definition can't be moved to the bottom.
// In real life, you of course would get the data from some other source.

#region JSON_DATA
const string JSON_DATA = """
                        [
                          {
                            "Player": "QB1",
                            "Games": [
                              {
                                "Game": "Game1",
                                "Attempts": 21,
                                "Completions": 18,
                                "Yards": 323,
                                "Long": 56,
                                "LongTDPass": 28,
                                "Touchdowns": 5,
                                "Interceptions": 0,
                                "Sacks": 3
                              },
                              {
                                "Game": "Game10",
                                "Attempts": 34,
                                "Completions": 16,
                                "Yards": 178,
                                "Long": 30,
                                "LongTDPass": 0,
                                "Touchdowns": 0,
                                "Interceptions": 2,
                                "Sacks": 1
                              },
                              {
                                "Game": "Game11",
                                "Attempts": 56,
                                "Completions": 33,
                                "Yards": 358,
                                "Long": 21,
                                "LongTDPass": 19,
                                "Touchdowns": 1,
                                "Interceptions": 0,
                                "Sacks": 2
                              },
                              {
                                "Game": "Game12",
                                "Attempts": 5,
                                "Completions": 2,
                                "Yards": 13,
                                "Long": 9,
                                "LongTDPass": 0,
                                "Touchdowns": 0,
                                "Interceptions": 0,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game2",
                                "Attempts": 25,
                                "Completions": 15,
                                "Yards": 175,
                                "Long": 29,
                                "LongTDPass": 24,
                                "Touchdowns": 2,
                                "Interceptions": 0,
                                "Sacks": 2
                              },
                              {
                                "Game": "Game3",
                                "Attempts": 38,
                                "Completions": 25,
                                "Yards": 257,
                                "Long": 36,
                                "LongTDPass": 0,
                                "Touchdowns": 0,
                                "Interceptions": 0,
                                "Sacks": 3
                              },
                              {
                                "Game": "Game4",
                                "Attempts": 24,
                                "Completions": 13,
                                "Yards": 154,
                                "Long": 65,
                                "LongTDPass": 7,
                                "Touchdowns": 1,
                                "Interceptions": 3,
                                "Sacks": 4
                              },
                              {
                                "Game": "Game5",
                                "Attempts": 22,
                                "Completions": 10,
                                "Yards": 89,
                                "Long": 29,
                                "LongTDPass": 0,
                                "Touchdowns": 0,
                                "Interceptions": 0,
                                "Sacks": 4
                              },
                              {
                                "Game": "Game6",
                                "Attempts": 63,
                                "Completions": 36,
                                "Yards": 509,
                                "Long": 49,
                                "LongTDPass": 49,
                                "Touchdowns": 4,
                                "Interceptions": 1,
                                "Sacks": 3
                              },
                              {
                                "Game": "Game7",
                                "Attempts": 47,
                                "Completions": 26,
                                "Yards": 191,
                                "Long": 19,
                                "LongTDPass": 0,
                                "Touchdowns": 0,
                                "Interceptions": 0,
                                "Sacks": 1
                              },
                              {
                                "Game": "Game8",
                                "Attempts": 47,
                                "Completions": 25,
                                "Yards": 222,
                                "Long": 36,
                                "LongTDPass": 7,
                                "Touchdowns": 2,
                                "Interceptions": 1,
                                "Sacks": 2
                              },
                              {
                                "Game": "Game9",
                                "Attempts": 39,
                                "Completions": 21,
                                "Yards": 367,
                                "Long": 86,
                                "LongTDPass": 86,
                                "Touchdowns": 5,
                                "Interceptions": 0,
                                "Sacks": 2
                              }
                            ]
                          },
                          {
                            "Player": "QB2",
                            "Games": [
                              {
                                "Game": "Game1",
                                "Attempts": 35,
                                "Completions": 27,
                                "Yards": 361,
                                "Long": 78,
                                "LongTDPass": 78,
                                "Touchdowns": 2,
                                "Interceptions": null,
                                "Sacks": 4
                              },
                              {
                                "Game": "Game10",
                                "Attempts": 20,
                                "Completions": 13,
                                "Yards": 259,
                                "Long": 52,
                                "LongTDPass": 15,
                                "Touchdowns": 1,
                                "Interceptions": 0,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game11",
                                "Attempts": 25,
                                "Completions": 19,
                                "Yards": 286,
                                "Long": 74,
                                "LongTDPass": 74,
                                "Touchdowns": 3,
                                "Interceptions": 1,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game12",
                                "Attempts": 35,
                                "Completions": 27,
                                "Yards": 198,
                                "Long": 27,
                                "LongTDPass": 7,
                                "Touchdowns": 1,
                                "Interceptions": 1,
                                "Sacks": 4
                              },
                              {
                                "Game": "Game2",
                                "Attempts": 18,
                                "Completions": 10,
                                "Yards": 176,
                                "Long": 78,
                                "LongTDPass": 78,
                                "Touchdowns": 1,
                                "Interceptions": 0,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game3",
                                "Attempts": 30,
                                "Completions": 20,
                                "Yards": 226,
                                "Long": 69,
                                "LongTDPass": 69,
                                "Touchdowns": 3,
                                "Interceptions": 0,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game4",
                                "Attempts": 15,
                                "Completions": 10,
                                "Yards": 190,
                                "Long": 43,
                                "LongTDPass": 22,
                                "Touchdowns": 2,
                                "Interceptions": 1,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game5",
                                "Attempts": 16,
                                "Completions": 12,
                                "Yards": 250,
                                "Long": 55,
                                "LongTDPass": 55,
                                "Touchdowns": 4,
                                "Interceptions": 0,
                                "Sacks": 1
                              },
                              {
                                "Game": "Game6",
                                "Attempts": 20,
                                "Completions": 12,
                                "Yards": 306,
                                "Long": 81,
                                "LongTDPass": 81,
                                "Touchdowns": 3,
                                "Interceptions": 1,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game7",
                                "Attempts": 35,
                                "Completions": 25,
                                "Yards": 290,
                                "Long": 60,
                                "LongTDPass": 60,
                                "Touchdowns": 3,
                                "Interceptions": 3,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game8",
                                "Attempts": 30,
                                "Completions": 19,
                                "Yards": 293,
                                "Long": 58,
                                "LongTDPass": 39,
                                "Touchdowns": 2,
                                "Interceptions": 0,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game9",
                                "Attempts": 25,
                                "Completions": 13,
                                "Yards": 294,
                                "Long": 74,
                                "LongTDPass": 74,
                                "Touchdowns": 4,
                                "Interceptions": 0,
                                "Sacks": 1
                              }
                            ]
                          },
                          {
                            "Player": "QB3",
                            "Games": [
                              {
                                "Game": "Game1",
                                "Attempts": 28,
                                "Completions": 20,
                                "Yards": 276,
                                "Long": 49,
                                "LongTDPass": 42,
                                "Touchdowns": 1,
                                "Interceptions": 0,
                                "Sacks": 2
                              },
                              {
                                "Game": "Game10",
                                "Attempts": 37,
                                "Completions": 26,
                                "Yards": 250,
                                "Long": 32,
                                "LongTDPass": 32,
                                "Touchdowns": 1,
                                "Interceptions": 0,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game11",
                                "Attempts": 29,
                                "Completions": 16,
                                "Yards": 133,
                                "Long": 18,
                                "LongTDPass": 0,
                                "Touchdowns": 0,
                                "Interceptions": 3,
                                "Sacks": 1
                              },
                              {
                                "Game": "Game12",
                                "Attempts": 18,
                                "Completions": 14,
                                "Yards": 159,
                                "Long": 59,
                                "LongTDPass": 0,
                                "Touchdowns": 0,
                                "Interceptions": 0,
                                "Sacks": 1
                              },
                              {
                                "Game": "Game2",
                                "Attempts": 44,
                                "Completions": 27,
                                "Yards": 271,
                                "Long": 48,
                                "LongTDPass": 0,
                                "Touchdowns": null,
                                "Interceptions": 0,
                                "Sacks": 3
                              },
                              {
                                "Game": "Game3",
                                "Attempts": 35,
                                "Completions": 22,
                                "Yards": 201,
                                "Long": 30,
                                "LongTDPass": 0,
                                "Touchdowns": 0,
                                "Interceptions": 1,
                                "Sacks": 2
                              },
                              {
                                "Game": "Game4",
                                "Attempts": 40,
                                "Completions": 26,
                                "Yards": 368,
                                "Long": 71,
                                "LongTDPass": 71,
                                "Touchdowns": 2,
                                "Interceptions": 0,
                                "Sacks": 2
                              },
                              {
                                "Game": "Game5",
                                "Attempts": 37,
                                "Completions": 22,
                                "Yards": 319,
                                "Long": 70,
                                "LongTDPass": 9,
                                "Touchdowns": 2,
                                "Interceptions": 1,
                                "Sacks": 4
                              },
                              {
                                "Game": "Game6",
                                "Attempts": 31,
                                "Completions": 17,
                                "Yards": 195,
                                "Long": 45,
                                "LongTDPass": 8,
                                "Touchdowns": 2,
                                "Interceptions": 0,
                                "Sacks": null
                              },
                              {
                                "Game": "Game7",
                                "Attempts": 40,
                                "Completions": 25,
                                "Yards": 255,
                                "Long": 39,
                                "LongTDPass": 3,
                                "Touchdowns": 1,
                                "Interceptions": 1,
                                "Sacks": 4
                              },
                              {
                                "Game": "Game8",
                                "Attempts": 35,
                                "Completions": 26,
                                "Yards": 446,
                                "Long": 69,
                                "LongTDPass": 69,
                                "Touchdowns": 4,
                                "Interceptions": 0,
                                "Sacks": 1
                              },
                              {
                                "Game": "Game9",
                                "Attempts": 30,
                                "Completions": 18,
                                "Yards": 273,
                                "Long": 52,
                                "LongTDPass": 7,
                                "Touchdowns": 1,
                                "Interceptions": 1,
                                "Sacks": 1
                              }
                            ]
                          },
                          {
                            "Player": "QB4",
                            "Games": [
                              {
                                "Game": "Game1",
                                "Attempts": 11,
                                "Completions": 3,
                                "Yards": 39,
                                "Long": 18,
                                "LongTDPass": 0,
                                "Touchdowns": 0,
                                "Interceptions": 0,
                                "Sacks": 2
                              },
                              {
                                "Game": "Game10",
                                "Attempts": 32,
                                "Completions": 20,
                                "Yards": 251,
                                "Long": 68,
                                "LongTDPass": 68,
                                "Touchdowns": 2,
                                "Interceptions": 2,
                                "Sacks": 1
                              },
                              {
                                "Game": "Game11",
                                "Attempts": 43,
                                "Completions": 25,
                                "Yards": 170,
                                "Long": 22,
                                "LongTDPass": 22,
                                "Touchdowns": 2,
                                "Interceptions": 0,
                                "Sacks": 1
                              },
                              {
                                "Game": "Game2",
                                "Attempts": 19,
                                "Completions": 12,
                                "Yards": 83,
                                "Long": 15,
                                "LongTDPass": 9,
                                "Touchdowns": 2,
                                "Interceptions": 1,
                                "Sacks": 1
                              },
                              {
                                "Game": "Game3",
                                "Attempts": 19,
                                "Completions": 9,
                                "Yards": 90,
                                "Long": 25,
                                "LongTDPass": 5,
                                "Touchdowns": 1,
                                "Interceptions": 1,
                                "Sacks": 1
                              },
                              {
                                "Game": "Game4",
                                "Attempts": 33,
                                "Completions": 15,
                                "Yards": 190,
                                "Long": 40,
                                "LongTDPass": 37,
                                "Touchdowns": 1,
                                "Interceptions": 0,
                                "Sacks": 3
                              },
                              {
                                "Game": "Game5",
                                "Attempts": 44,
                                "Completions": 25,
                                "Yards": 348,
                                "Long": 34,
                                "LongTDPass": 34,
                                "Touchdowns": 3,
                                "Interceptions": 0,
                                "Sacks": 2
                              },
                              {
                                "Game": "Game6",
                                "Attempts": 27,
                                "Completions": 13,
                                "Yards": 161,
                                "Long": 47,
                                "LongTDPass": 47,
                                "Touchdowns": 3,
                                "Interceptions": 0,
                                "Sacks": 1
                              },
                              {
                                "Game": "Game7",
                                "Attempts": 23,
                                "Completions": 9,
                                "Yards": 76,
                                "Long": 20,
                                "LongTDPass": 0,
                                "Touchdowns": 0,
                                "Interceptions": 0,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game8",
                                "Attempts": 43,
                                "Completions": 22,
                                "Yards": 249,
                                "Long": 60,
                                "LongTDPass": 0,
                                "Touchdowns": 0,
                                "Interceptions": 2,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game9",
                                "Attempts": 38,
                                "Completions": 20,
                                "Yards": 166,
                                "Long": 26,
                                "LongTDPass": 12,
                                "Touchdowns": 1,
                                "Interceptions": 2,
                                "Sacks": 4
                              }
                            ]
                          },
                          {
                            "Player": "QB5",
                            "Games": [
                              {
                                "Game": "Game1",
                                "Attempts": 18,
                                "Completions": 7,
                                "Yards": 112,
                                "Long": 33,
                                "LongTDPass": 18,
                                "Touchdowns": 2,
                                "Interceptions": 1,
                                "Sacks": 2
                              },
                              {
                                "Game": "Game10",
                                "Attempts": 25,
                                "Completions": 19,
                                "Yards": 209,
                                "Long": 33,
                                "LongTDPass": 17,
                                "Touchdowns": 1,
                                "Interceptions": 0,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game11",
                                "Attempts": 22,
                                "Completions": 12,
                                "Yards": 137,
                                "Long": 34,
                                "LongTDPass": 19,
                                "Touchdowns": 1,
                                "Interceptions": 1,
                                "Sacks": 3
                              },
                              {
                                "Game": "Game12",
                                "Attempts": 22,
                                "Completions": 14,
                                "Yards": 218,
                                "Long": 68,
                                "LongTDPass": 68,
                                "Touchdowns": 1,
                                "Interceptions": 0,
                                "Sacks": 3
                              },
                              {
                                "Game": "Game14",
                                "Attempts": 11,
                                "Completions": 8,
                                "Yards": 109,
                                "Long": 37,
                                "LongTDPass": 0,
                                "Touchdowns": 0,
                                "Interceptions": 0,
                                "Sacks": 1
                              },
                              {
                                "Game": "Game2",
                                "Attempts": 17,
                                "Completions": 11,
                                "Yards": 242,
                                "Long": 45,
                                "LongTDPass": 25,
                                "Touchdowns": 3,
                                "Interceptions": 1,
                                "Sacks": 3
                              },
                              {
                                "Game": "Game3",
                                "Attempts": 17,
                                "Completions": 13,
                                "Yards": 251,
                                "Long": 64,
                                "LongTDPass": 10,
                                "Touchdowns": 1,
                                "Interceptions": 1,
                                "Sacks": 2
                              },
                              {
                                "Game": "Game4",
                                "Attempts": 37,
                                "Completions": 30,
                                "Yards": 371,
                                "Long": 39,
                                "LongTDPass": 25,
                                "Touchdowns": 5,
                                "Interceptions": 1,
                                "Sacks": 4
                              },
                              {
                                "Game": "Game5",
                                "Attempts": 11,
                                "Completions": 10,
                                "Yards": 108,
                                "Long": 32,
                                "LongTDPass": 0,
                                "Touchdowns": 0,
                                "Interceptions": 0,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game6",
                                "Attempts": 28,
                                "Completions": 22,
                                "Yards": 285,
                                "Long": 46,
                                "LongTDPass": 11,
                                "Touchdowns": 3,
                                "Interceptions": 0,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game7",
                                "Attempts": 22,
                                "Completions": 21,
                                "Yards": 274,
                                "Long": 58,
                                "LongTDPass": 58,
                                "Touchdowns": 5,
                                "Interceptions": 0,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game8",
                                "Attempts": 27,
                                "Completions": 18,
                                "Yards": 264,
                                "Long": 54,
                                "LongTDPass": 54,
                                "Touchdowns": 4,
                                "Interceptions": 0,
                                "Sacks": 0
                              },
                              {
                                "Game": "Game9",
                                "Attempts": 24,
                                "Completions": 15,
                                "Yards": 182,
                                "Long": 39,
                                "LongTDPass": 0,
                                "Touchdowns": 0,
                                "Interceptions": 1,
                                "Sacks": 0
                              }
                            ]
                          }
                        ]
                        """;
#endregion

var passingStats = JsonSerializer.Deserialize<List<Player>>(JSON_DATA);

// 1. Which player had the highest single game Completion Percentage?
GetHighestSingleGameCompletionPercentagePlayer(passingStats!);

// 2. Which player had the lowest single game Yards Per Attempt?
GetLowestSingleGameYardsPerAttemptPlayer(passingStats!);

// 3. Which player had the least Passing Yards for the season?
GetLeastPassingYardsPerSeasonPlayer(passingStats!);

// 4. Which player had the most Touchdowns for the season?
GetMostTouchdownsPerSeasonPlayer(passingStats!);

// 5. List the player names by their Season Completion Percentage in descending order.
GetSeasonCompletionPercentagePlayers(passingStats!);

// 6. Which player had the highest single game Passer Rating?
// 7. What was the value of the highest single game Passer Rating?
GetPlayerWithRating(passingStats!, RatingType.Highest);

// 8. Which player had the lowest single game Passer Rating?
// 9. What was the value of the lowest single game Passer Rating?
GetPlayerWithRating(passingStats!, RatingType.Lowest);

// 10. Which player had the highest season Passer Rating?
GetPlayerWithHighestRating(passingStats!);

// 11. Which player had the highest season Passer Rating?
GetPlayerWithHighestRating(passingStats!, 3);

// 12. Excluding each player’s highest and lowest single game Passer Rating, which player had the highest Passer Rating for the season?
GetHighestSeasonRatingPlayer(passingStats!);

return;

//===============================================================

string GetHighestSingleGameCompletionPercentagePlayer(List<Player> stats)
{
  // completion percentage = (completions / attempts) * 100
  
  var highestCompletionPercentage = 0.0;
  var highestCompletionPlayer = string.Empty;
  var highestCompletionGame = string.Empty;

  foreach (var player in stats)
  {
    foreach (var game in player.Games)
    {
      if (game.Attempts <= 0) 
        continue;
      
      var completionPercentage = (double)game.Completions / game.Attempts * 100.0;

      if (!(completionPercentage > highestCompletionPercentage))
        continue;
      
      highestCompletionPercentage = completionPercentage;
      highestCompletionPlayer = player.Name;
      highestCompletionGame = game.Name;
    }
  }

  Console.WriteLine($"{highestCompletionPlayer} in {highestCompletionGame} had the highest completion percentage of {highestCompletionPercentage:0.##}%");
  
  return highestCompletionPlayer;
}

string GetLowestSingleGameYardsPerAttemptPlayer(IEnumerable<Player> stats)
{
  var lowestGame = stats
    .SelectMany(player => player.Games, (player, game) => new { Player = player, Game = game })
    .MinBy(x => x.Game.Yards);

  Console.WriteLine($"{lowestGame!.Player.Name} in {lowestGame.Game.Name} had the lowest yards per attempt of {lowestGame.Game.Yards:0.##}");
  
  return lowestGame.Player.Name;
}

string GetLeastPassingYardsPerSeasonPlayer(IEnumerable<Player> stats)
{
  var leastYardsPlayer = stats.MinBy(player => player.TotalYards);

  Console.WriteLine($"{leastYardsPlayer!.Name} had the least passing yards per season with {leastYardsPlayer.TotalYards} yards.");
  
  return leastYardsPlayer.Name;
}

string GetMostTouchdownsPerSeasonPlayer(IEnumerable<Player> stats)
{
  var mostTouchdownsPlayer = stats.MaxBy(player => player.TotalTouchdowns);

  Console.WriteLine($"{mostTouchdownsPlayer!.Name} had the most touchdowns for the season with {mostTouchdownsPlayer.TotalTouchdowns} touchdowns.");

  return mostTouchdownsPlayer.Name;
}

string GetSeasonCompletionPercentagePlayers(IEnumerable<Player> stats)
{
  var players = stats.OrderByDescending(p => p.SeasonCompletionPercentage).Select(p => p.Name).ToList();
        
  var result = string.Join(",", players);
  Console.WriteLine(result);
  return result;
}

(string Name, double Rating) GetPlayerWithRating(IEnumerable<Player> players, RatingType ratingType)
{
  var ratings = players
    .SelectMany(p => p.Games, (player, game) => new { player.Name, game.PasserRating });

  ratings = ratingType == RatingType.Highest ?
    ratings.OrderByDescending(x => x.PasserRating) :
    ratings.OrderBy(x => x.PasserRating);

  var player = ratings.First();
  
  Console.WriteLine($"{player!.Name} has {(ratingType == RatingType.Highest ? "highest" : "lowest")} Passer Rating of {player.PasserRating:F1}.");
  
  return (player.Name, player.PasserRating);
}

(string Name, double Rating) GetPlayerWithHighestRating(IEnumerable<Player> stats, int gamesNumber = int.MaxValue)
{
  var playerRatings = stats.Select(p => new 
    {
      p.Name,
      Stats = new
      {
        Attempts = p.Games.Take(gamesNumber).Sum(g => g.Attempts),
        Completions = p.Games.Take(gamesNumber).Sum(g => g.Completions),
        PassingYards = p.Games.Take(gamesNumber).Sum(g => g.Yards),
        Touchdowns = p.Games.Take(gamesNumber).Sum(g => g.Touchdowns ?? 0),
        Interceptions = p.Games.Take(gamesNumber).Sum(g => g.Interceptions ?? 0)
      }
    })
    .Select(p => new
    {
      p.Name,
      Rating = Game.GetPasserRating(p.Stats.Completions, p.Stats.Attempts, p.Stats.PassingYards, p.Stats.Touchdowns, p.Stats.Interceptions)
    }).MaxBy(p => p.Rating);

  Console.WriteLine($"{playerRatings!.Name} has the highest {(gamesNumber == int.MaxValue ? "season" : $"{gamesNumber} games" )} Passer Rating with a rating of {playerRatings.Rating:F1}.");

  return (playerRatings.Name, playerRatings.Rating);
}

(string Name, double Rating) GetHighestSeasonRatingPlayer(IEnumerable<Player> stats)
{
  var player = stats.Select(p => new
  {
    p.Name,
    Rating = p.Games.Count > 2 ? 
      p.Games
        .Select(g => Game.GetPasserRating(g.Completions, g.Attempts, g.Yards, g.Touchdowns ?? 0, g.Interceptions ?? 0))
        .OrderBy(x => x)
        .Skip(1)
        .Take(p.Games.Count - 2)
        .Average() : double.MinValue // games <= 2 => MinValue.
  }).MaxBy(p => p.Rating);

  Console.WriteLine($"{player!.Name} has the highest Passer Rating, excluding Min and Max games with a rating of {player.Rating:F1}.");
  
  return (player.Name, player.Rating);
}

public enum RatingType
{
  Highest,
  Lowest
}

public class Player
{
  [JsonPropertyName("Player")]
  public string Name { get; set; }
  public List<Game> Games { get; set; }
  public int TotalYards => Games.Sum(game => game.Yards);
  public int TotalTouchdowns => Games.Sum(game => game.Touchdowns ?? 0);

  public double SeasonCompletionPercentage 
  {
    get 
    {
      var totalCompletions = Games.Sum(game => game.Completions);
      var totalAttempts = Games.Sum(game => game.Attempts);

      if (totalAttempts == 0)
        return 0;
      
      return (double)totalCompletions / totalAttempts;
    }
  }
}

public class Game
{
  [JsonPropertyName("Game")]
  public string Name { get; set; }
  public int Attempts { get; set; }
  public int Completions { get; set; }
  public int Yards { get; set; }
  public int Long { get; set; }
  public int LongTDPass { get; set; }
  public int? Touchdowns { get; set; }
  public int? Interceptions { get; set; }
  public int? Sacks { get; set; }
  
  public double PasserRating => GetPasserRating(Completions, Attempts, Yards, Touchdowns ?? 0, Interceptions ?? 0);

  public static double GetPasserRating(int completions, int attempts, int yards, int touchdowns, int interceptions)
  {
    const double MIN_VALUE = 0;
    const double MAX_VALUE = 2.375;
    
    var a = ((double)completions / attempts - 0.3) * 5;
    var b = ((double)yards / attempts - 3) * 0.25;
    var c = (double)touchdowns / attempts * 20;
    var d = MAX_VALUE - (double)interceptions / attempts * 25;

    a = Math.Clamp(a, MIN_VALUE, MAX_VALUE);
    b = Math.Clamp(b, MIN_VALUE, MAX_VALUE);
    c = Math.Clamp(c, MIN_VALUE, MAX_VALUE);
    d = Math.Clamp(d, MIN_VALUE, MAX_VALUE);
    
    return (a + b + c + d) / 6 * 100;
  }  
}
