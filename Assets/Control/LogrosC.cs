using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogrosC : MonoBehaviour
{
    public Image image;
    private int contImg = 0;
    public List<Sprite> logros;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void changeHoloLibro()
    {
        image.sprite = logros[contImg];
        contImg++;
    }


}
