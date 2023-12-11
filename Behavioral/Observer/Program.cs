using ObserverPattern;
using ObserverPattern.Notify;

VideoData videoData = new();

EmailNotifier emailNotifier = new(videoData);
YoutubeNotifier youtubeNotifier = new(videoData);
SmsNotifier smsNotifier = new(videoData);


videoData.Title = "This is title";

Console.WriteLine("-------------------------------------");

videoData.Dettach(youtubeNotifier);

videoData.Description = "Description";