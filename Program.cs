using HtmlAgilityPack;

Console.WriteLine("Loading!");


var url = "https://www.basketball-reference.com/boxscores/";
var web = new HtmlWeb();
var doc = web.Load(url);

var title = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/h1").First().InnerText;

var loserName = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[3]/div[1]/table[1]/tbody/tr[1]/td[1]/a").First().InnerText;
var loserScore = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/h1").First().InnerText;

var winnerName = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/h1").First().InnerText;
var winnerScore = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/h1").First().InnerText;

Console.WriteLine(loserName);