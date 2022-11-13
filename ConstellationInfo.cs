using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;




[System.Serializable]
public class ConstellationInfo
{
    public StarInfo[] stars;
    public string id;
    public string name;
    public vector3 position;

    public ConstellationInfo(string whiteSpaceText, StarDatabaseLoader starDatabase)
    {
        var lines = Regex.Split(whiteSpaceText.Trim(),@"\s+")
        .ToArray();
        id = lines[0];

        stars = lines
            .Skip(2)
            .Select(idStr => int.Parse(idStr))
            .Select(idInt => starDatabase.GetStarByHipId(idInt))
            .ToArray();

        position = stars
            .Select(s => position)
            .Aggregate((s,total) => total + s.position) 
            / stars.Length;
    }

    public override string ToString()
    {
        return string.Format("id: {0}\tname: {1}\tnumber of star: {2}", id, name, stars.Length / 2);
    }
}