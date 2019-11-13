using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Node 
{
   
    public int gCost;
    public int hCost;
    public int gridXPos, gridYPos;
    public Node parent;
    public bool walkable = true;
    public int calculateFCost() { return gCost + hCost; }

    public Node(int x, int y)
    {
        gridXPos = x;
        gridYPos = y;
    }
    private void Start()
    {

        walkable = true;
    }

  
}

