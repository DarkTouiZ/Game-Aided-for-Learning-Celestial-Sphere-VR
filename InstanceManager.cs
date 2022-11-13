using UnityEngine;


public class InstanceManager : MonoBehaviour
{
    [HideInInspector]
    [SerializeField]
    GameObject starInstance;
    [HideInInspector]
    [SerializeField]
    GameObject constellationsInstance;

    public StarDatabaseLoader starDatabaseLoader;
    public ConstellationDatabaseLoader constellationDatabaseLoader;


    public StarMeshGenerator starMeshGenerator;
    public ConstellationMeshGenerator constellationMeshGenerator;
    public MeshPrefabGenerator starPrefabGenerator;
    public MeshPrefabGenerator constellationPrefabGenerator;


    public void GenerateAndInstantiatePrefab()
    {
        starDatabaseLoader.LoadDatabase();
        //constellation database must load data after star database 
        constellationDatabaseLoader.LoadDatabase();

        starMeshGenerator.Generate();
        constellationMeshGenerator.Generate();

        starPrefabGenerator.Generate();
        constellationPrefabGenerator.Generate();
        InstantiatePrefab();
    }

    public void InstantiatePrefab()
    {
        if(starInstance != null)
            GameObject.DestroyImmediate(starInstance);
        if(constellationsInstance != null)
            GameObject.DestroyImmediate(constellationsInstance);

        var starPrefeb = AssetUtility.GetAssetsAtPath<GameObject>(starPrefabGenerator.folderPath)[0];
        starInstance = GameObject.Instantiate(starPrefeb, Vector3.zero, Quaternion.identity, transform);

        var constellationPrefab = AssetUtility.GetAssetsAtPath<GameObject>(constellationPrefabGenerator.folderPath)[0];
        constellationsInstance = GameObject.Instantiate(constellationPrefab, Vector3.zero, Quaternion.identity, transform);
    }
    
}