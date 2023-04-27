using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlosarioV : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject interfacesGlosario;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enableGlosario()
    {
        interfacesGlosario.SetActive(!interfacesGlosario.activeSelf);
    }


}
