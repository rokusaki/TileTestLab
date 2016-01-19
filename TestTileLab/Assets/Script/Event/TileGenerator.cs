using UnityEngine;
using System.Collections;

public class TileGenerator : MonoBehaviour {

    public GameObject tilePrefab;
    public Transform tileParent;

    public int maxX;
    public int maxY;

    public Vector3 offset;

    GameObject[,] tile;


    void Awake()
    {


    }

    void Start()
    {
        GenerateTile();
    }

    void GenerateTile()
    {
        tile = new GameObject[maxX, maxY];

        for(int x = 0; x < maxX; x++)
        {
            for(int y = 0; y < maxY; y++)
            {
                tile[x,y] = Instantiate(tilePrefab, new Vector3(x, y, 0) - offset , Quaternion.identity) as GameObject;
                tile[x, y].name = string.Format("Tile : {0} , {1}", x, y);
                tile[x, y].transform.parent = tileParent;
                
            }

        }

    }

}
