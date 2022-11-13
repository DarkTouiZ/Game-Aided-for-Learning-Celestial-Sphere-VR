using UnityEngine;



public abstract class AssetGenerator : ScriptableObject
{

    public string folderPath;

    protected abstract void GenerateAssets();

    public void Generate()
    {
        AssetUtility.ClearAssetFolder(folderPath);
        GenerateAssets();
    }
}