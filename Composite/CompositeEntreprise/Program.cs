
using PatternComposite.Entities;

DirectoryElement root = new DirectoryElement("root");
DirectoryElement user = new DirectoryElement("user");
FileElement file = new FileElement("file");



DirectoryElement user2 = new DirectoryElement("user2");

FileElement file2 = new FileElement("file2");
FileElement file3 = new FileElement("file3");
FileElement file4 = new FileElement("file4");

root.AddElement(file4);

user.AddElement(file);
root.AddElement(user);
user.AddElement(user2);
user2.AddElement(file2);
user.AddElement(file3);


user.GetCount();
Console.WriteLine("Nombre d' éléments dans root "+ root.GetCount());
Console.WriteLine("Nombre d' éléments dans user " + user.GetCount());
Console.WriteLine("Nombre d' éléments dans user2 " + user2.GetCount());
Console.WriteLine("Nombre d' éléments dans file " + file.GetCount());