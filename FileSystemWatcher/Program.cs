var path = @"C:\Users\thiag\Desktop\Git\Directory\globe";
var fsw = new FileSystemWatcher(path);
fsw.Created += OnCreated;
fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine(@"Monitoring events in the file C:\Users\thiag\Desktop\Git\Directory\globe");
Console.WriteLine("Press [Enter] to finish");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"'{e.Name}' was created");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"'{e.Name}' was deleted");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"'{e.OldName}' was renamed to '{e.Name}'");
}