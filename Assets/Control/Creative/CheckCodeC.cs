using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCodeC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerStay(Collider other)
    {
        CodeM codeM = other.gameObject.GetComponent<CodeM>();
        if (codeM != null)
        {
            CodeM.MyEnum selectedValue = codeM.SelectedValue;
            Debug.Log("Selected value: " + selectedValue.ToString());
        }
    }
}
