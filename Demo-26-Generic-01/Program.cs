using Demo_26_Generic_01.Models;
using Demo_26_Generic_01.Utils;

List<string> listStrings = new(["b", "c", "a"]);
List<int> ints = new([4, 8, 2]);

List<Person> persons = new List<Person>([
    //new() { // si pas de constructeur
    //    FirstName = "Phil",
    //    LastName  = "Haerens"
    //},
    new("Phil", "Haerens"),
    new("Samuel", "LeGrain")
]);

listStrings.Sort();
ints.Sort();

int positionC = ArrayUtils.FindPosition(listStrings, "c");

int position4 = ArrayUtils.FindPosition(ints, 4);

int positionSamuel = ArrayUtils.FindPosition(persons, (target) => { 
    if(target.FirstName == "Samuel")
    {
        return true;
    }
    else
    {
        return false;
    }
});