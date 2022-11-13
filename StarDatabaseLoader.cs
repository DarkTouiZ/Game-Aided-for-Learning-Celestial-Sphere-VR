using UnityEngine;
using System.Linq;


[CreateAssetMenu(menuName = "StarChart/Database/Star")]
public class StarDatabaseLoader : DatabaseLoader
{
    public string databasePath;
    [HideInInspector]
    public StarInfo[] stars;

    public override void LoadDatabase()
    {
        string[] lines = IOUtility.OpenLines(databasePath);
        stars = lines
        .Skip(1)
        .Select(l => new StarInfo(l))
        .ToArray();
    }

    public StarInfo GetStarByHipId(int hipId)
    {
        var StarInfo = stars.FirstOrDefault(s => s.hipId == hipId);
        if(StarInfo == null){
            Debug.LogWarning("Warning: no star with id" + hipId + " found");
        }
        return StarInfo;
    }
}
    