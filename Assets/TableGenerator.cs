using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableGenerator : MonoBehaviour
{

    public GameObject leftBottomCorner;
    public GameObject rightUpperCorner;
    public GameObject table;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rcX, rcY, rcZ; //Right corner x,y,z
        rcX = rightUpperCorner.transform.position.x;
        rcY = rightUpperCorner.transform.position.y;
        rcZ = rightUpperCorner.transform.position.z;
        table.transform.position.Set(rcX / 2, -0.1f, rcZ / 2);
        table.transform.localScale.Set(rcX, 0.1f, rcZ);
    }
}
