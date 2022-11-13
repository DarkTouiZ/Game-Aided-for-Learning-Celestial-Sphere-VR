using UnityEngine;
using System.Linq;



[CreateAssetMenu(menuName = "StarChart/Asset Generator/Constellation Mesh")]
public class ConstellationMeshGenerator : AssetGenerator
{
    public ConstellationDatabaseLoader database;

    protected override void GenerateAssets()
    {
        database
        .constellations.Select(ci => CreateMesh(ci.stars, ci.name))
        .ForEach(cm => AssetUtility.SaveMeshAsset(folderPath, cm));
    }

    Mesh CreateMesh(StarInfo[] stars, string name)
    {
        var mesh = new Mesh();
        mesh.name = name;

        mesh.vertices = stars
        .Select(s => s.position)
        .ToArray();

        mesh.normals = stars
        .Select(s => s.velocity)
        .ToArray();


        int[] indicles = stars
        .Select((s, i) => i)
        .ToArray();

        mesh.SetIndices(indicles, MeshTopology.Lines, 0);

        return mesh;
    }    
    
    
}