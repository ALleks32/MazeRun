using System;
using UnityEngine;

[RequireComponent(typeof(MazeConstructor))]               

public class GameController : MonoBehaviour
{
    private MazeConstructor generator;
    public int MazeX;
    public int Mazey;
    void Start()
    {
        generator = GetComponent<MazeConstructor>();      
        generator.GenerateNewMaze(MazeX, Mazey);
    }
}