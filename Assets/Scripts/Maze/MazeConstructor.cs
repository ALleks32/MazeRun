using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeConstructor : MonoBehaviour
{
    public bool showDebug;
    public GameObject WallMaze;
    public GameObject FloorMaze;
    private MazeDataGenerator dataGenerator;
    public List<GameObject> Food;
    public int ChanceSpawnFood = 25;

    
    public int[,] data
    {
        get; private set;
    }

    void Awake()
    {
        dataGenerator = new MazeDataGenerator();
        data = new int[,]
        {
            {1, 1, 1},
            {1, 0, 1},
            {1, 1, 1}
        };
        
    }
    private void Start()
    {
        SpritsGenerate();

    }

    public void GenerateNewMaze(int sizeRows, int sizeCols)
    {
        if (sizeRows % 2 == 0 && sizeCols % 2 == 0)
        {
            Debug.LogError("Odd numbers work better for dungeon size.");
        }

        data = dataGenerator.FromDimensions(sizeRows, sizeCols);
    }
    void SpritsGenerate()
    {

        int[,] maze = data;
        int rMax = maze.GetUpperBound(0);
        int cMax = maze.GetUpperBound(1);

        for (int i = rMax; i >= 0; i--)
        {
            for (int j = 0; j <= cMax; j++)
            {
                if (maze[i, j] == 0)
                {     
                    Instantiate(FloorMaze, new Vector3(j * 2, i * 2, 0), Quaternion.identity);
                    if (UnityEngine.Random.Range(1, 99) < ChanceSpawnFood)
                    {
                        Instantiate(Food[UnityEngine.Random.Range(0, Food.Count)], new Vector3(j * 2, i * 2, 0), Quaternion.identity);
                    }
                }
                else
                {
                    if (i == 0 && j == 3 || i == rMax && j == 20|| i == 1 && j == 3 || i == rMax-1 && j == 20)
                    {
                        Instantiate(FloorMaze, new Vector3(j * 2, i * 2, 0), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(WallMaze, new Vector3(j * 2, i * 2, 0), Quaternion.identity);
                    }
                }              
            }
        }
    }
}