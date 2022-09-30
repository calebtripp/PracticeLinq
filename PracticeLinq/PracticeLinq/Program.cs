using System.Linq;

var vGList = new List<string>();

vGList.Add("Command and Conquer Tiberian Sun");
vGList.Add("Warcraft 3");
vGList.Add("Halo");
vGList.Add("Tomorrow Never Dies");
vGList.Add("Delta Force");
vGList.Add("Contra");
vGList.Add("Super Mario Bros");
vGList.Add("Twisted Metal");

vGList.OrderBy(vGList => vGList.Length)
      .ToList()
      .ForEach(vGList => Console.WriteLine(vGList));