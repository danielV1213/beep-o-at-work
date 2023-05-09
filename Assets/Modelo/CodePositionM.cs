using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodePositionM : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform parent;

    void Start()
    {
        parent = transform.parent;
    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
