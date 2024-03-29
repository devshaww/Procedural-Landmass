using UnityEngine;


public class MapDisplay : MonoBehaviour
{
    public Renderer textureRender;
	public MeshFilter meshFilter;
	public MeshRenderer meshRenderer;

	public void DrawTexture(Texture2D texture)
    {
        textureRender.sharedMaterial.mainTexture = texture;
        textureRender.transform.localScale = new Vector3(texture.width, 1, texture.height);
    }

    public void DrawMesh(MeshData meshData, Texture2D texture)
    {
        meshFilter.sharedMesh = meshData.CreateMesh();
        meshRenderer.sharedMaterial.mainTexture = texture;
    }

    //public void DrawNoiseMap(float[,] noiseMap)
    //{
    //    int width = noiseMap.GetLength(0);
    //    int height = noiseMap.GetLength(1);

    //    Texture2D texture = new Texture2D(width, height);

    //    Color[] colorMap = new Color[width * height];
    //    for (int y = 0; y < height; y++)
    //    {
    //        for (int x = 0; x < width; x++)
    //        {
    //            colorMap[y * width + x] = Color.Lerp(Color.black, Color.white, noiseMap[x, y]);
    //        }
    //    }
    //    texture.SetPixels(colorMap);
    //    texture.Apply();

    //    // to be able to see the texture in editor mode
    //    textureRender.sharedMaterial.mainTexture = texture;
    //    // set size of the plane to the same size of the map
    //    textureRender.transform.localScale = new Vector3(width, 1, height);
    //}
}
