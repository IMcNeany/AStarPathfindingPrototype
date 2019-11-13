using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeGenerator : MonoBehaviour
{
    int width = 25;
    int height = 30;
    int nodeSize = 1;

    public List<Node> nodeArray = new List<Node>();

    // Use this for initialization
    void Start()
    {
       
        NodeGrid();
      
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnDrawGizmos()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Gizmos.color = Color.magenta;
                Gizmos.DrawWireCube(new Vector3(i + 0.5f, 0, j + 0.5f), new Vector3(0.9f,1.0f,0.9f));
                
            
            }
         
        }
    }

    void NodeGrid()
    {
        for(int i = 0; i < width; i++)
        {
            for(int j = 0; j< height; j++)
            {
                nodeArray.Add(new Node(i, j));
            }
        }
    }

    public List<Node> GetNodes()
    {
        return nodeArray;
    }

    public int GetWidth()
    {
        return width;
    }

    public int GetHeight()
    {
        return height;
    }

    public void destory()
    {
        Destroy(this);
    }


}
