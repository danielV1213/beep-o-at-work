using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckCodeV : MonoBehaviour
{
    // Start is called before the first frame update


    public TextMeshProUGUI textOrderC;


    public GameObject endFor;
    public GameObject insideFor;
    public GameObject parentObject;
    public int siblingIndex;

    public void changeAnswerView(string orderComplexity)
    {
        textOrderC.text = $"{orderComplexity}";
    }

    public void cleanAnswerView()
    {
        textOrderC.text = "";
    }


    public void generateComponentFor(int indexSibiling)
    {
        Transform parent = parentObject.transform;

        GameObject newObject = Instantiate(insideFor, new Vector3(0, 0, 0), Quaternion.identity);
        GameObject newObject2 = Instantiate(endFor, new Vector3(0, 0, 0), Quaternion.identity);

        newObject.transform.SetParent(parent, false);
        newObject2.transform.SetParent(parent, false);

        newObject.transform.SetSiblingIndex(indexSibiling + 1);
        newObject2.transform.SetSiblingIndex(indexSibiling + 2);

    }


    public void destroyComponentFor(int parentIndex)
    {
        
        GameObject grandparentObject = transform.parent.parent.gameObject;

        GameObject parentObject = grandparentObject.transform.GetChild(parentIndex + 1).gameObject;
        GameObject parentObject2 = grandparentObject.transform.GetChild(parentIndex + 2).gameObject;

        Destroy(parentObject);
        Destroy(parentObject2);

    }



}
