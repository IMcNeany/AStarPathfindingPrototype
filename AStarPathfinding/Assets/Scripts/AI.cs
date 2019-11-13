using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{

    Vector3 startClick;
    Vector3 endClick;
    bool firstClicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!firstClicked)
            {
                
                startClick = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Debug.Log(startClick);
                firstClicked = true;
            }
            else if(firstClicked)
            {
                endClick = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                FindPath();
                firstClicked = false;
            }
        }
    }

    private void FindPath()
    {
        AStarPathfinding aStar = FindObjectOfType<AStarPathfinding>().GetComponent<AStarPathfinding>();

        aStar.CreatePath(aStar.FindClickedNode(startClick), aStar.FindClickedNode(endClick));
    }
}
