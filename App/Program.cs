// See https://aka.ms/new-console-template for more information

using Model.storage;

Console.WriteLine("Hello, World!");

MusicianStorage m = new MusicianStorage();

var s = await m.Create("r", "r", "r", []);

Console.WriteLine(s);

