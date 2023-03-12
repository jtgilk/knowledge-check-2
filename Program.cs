using KC2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Classes.Player>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var PlayerInfo = new Classes.Player();

    recordList.Add(PlayerInfo);
}

for (int i = 0;i < numberOfRecords; i++)
{
    Console.WriteLine(recordList[i].Name + " is a level " + recordList[i].Level + " " + recordList[i].PlayerClass);
}
// Print out the list of records using Console.WriteLine()