using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform rect;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void prueba()
    {
        LayoutRebuilder.ForceRebuildLayoutImmediate(rect);
    }

}
