using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheckCodeV : MonoBehaviour
{
    // Start is called before the first frame update


    public TextMeshProUGUI textOrderC;


    public GameObject endFor;
    public GameObject insideFor;


    GameObject newObject;
    GameObject newObject2;


    //private string prefabEndForPath = "Assets/Vista/Prefabs/Creative/For/ComponentEndFor.prefab";
    //private string prefabInsideForPath = "Assets/Vista/Prefabs/Creative/For/ComponentInsideFor.prefab";

    //public GameObject parentObject;
    public int siblingIndex;

    public void changeAnswerView(string orderComplexity)
    {
        textOrderC.text = $"{orderComplexity}";
    }

    public void cleanAnswerView()
    {
        textOrderC.text = "";
    }


    public void generateComponentFor(int indexSibiling, Transform parentComponent, Transform parentContent)
    {
        //GameObject insideFor = UnityEditor.AssetDatabase.LoadAssetAtPath(prefabInsideForPath, typeof(GameObject)) as GameObject;
        //GameObject endFor = UnityEditor.AssetDatabase.LoadAssetAtPath(prefabEndForPath, typeof(GameObject)) as GameObject;

        newObject = Instantiate(insideFor, new Vector3(0, 0, 0), Quaternion.identity);
        newObject2 = Instantiate(endFor, new Vector3(0, 0, 0), Quaternion.identity);

        newObject.transform.SetParent(parentContent, false);
        newObject2.transform.SetParent(parentContent, false);

        newObject.transform.SetSiblingIndex(indexSibiling + 1);
        newObject2.transform.SetSiblingIndex(indexSibiling + 2);

    }


    public void destroyComponentFor(int parentIndex)
    {

        //GameObject grandparentObject = transform.parent.parent.gameObject;

        //GameObject parentObject = grandparentObject.transform.GetChild(parentIndex + 1).gameObject;
        //GameObject parentObject2 = grandparentObject.transform.GetChild(parentIndex + 2).gameObject;


        //GameObject parentComponent = transform.parent.gameObject;
        //GameObject parentContent = parentComponent.transform.parent.gameObject;

        //if (parentContent.transform.Find("ComponentInsideFor(Clone)")){

        //}

        //if (parentComponent.gameObject.name == "ComponentInsideFor(Clone)")
        //{
        //    GameObject componentStart = parentContent.transform.Find("ComponentInsideFor(Clone)").gameObject;
        //    GameObject componentEnd = parentContent.transform.Find("ComponentEndFunction1(Clone)").gameObject;

        //    for (int i = componentStart.transform.GetSiblingIndex(); i <= componentEnd.transform.GetSiblingIndex(); i++)
        //    {
        //        GameObject child = parentContent.transform.GetChild(i).gameObject;
        //        GameObject child2 = child.transform.GetChild(2).gameObject;
        //        GameObject child3 = child2.transform.GetChild(2).gameObject;

        //        Debug.Log("Nombre del hijo: " + child3.name);
        //        Destroy(child.gameObject);
        //    }


        //}
        //else
        //{
        //    GameObject componentStart = parentContent.transform.Find("ComponentInsideFor2").gameObject;
        //    GameObject componentEnd = parentContent.transform.Find("ComponentEndFunction2").gameObject;

        //    for (int i = componentStart.transform.GetSiblingIndex(); i <= componentEnd.transform.GetSiblingIndex(); i++)
        //    {
        //        Transform child = parentContent.transform.GetChild(i);
        //        Destroy(child.gameObject);
        //    }

        //}






        Destroy(newObject);
        Destroy(newObject2);


    }

    public void changeColorPanel(Color targetColor)
    {
        GameObject component = transform.parent.gameObject;
        GameObject panel1 = component.transform.Find("Panel").gameObject;
        GameObject panel2 = component.transform.Find("Panel (1)").gameObject;

        // Establecer el color de los materiales de Panel1 y Panel2
        panel1.GetComponent<Image>().color = targetColor;
        panel2.GetComponent<Image>().color = targetColor;


    }

    public void changeOriginalColorPanel(Color originalColor)
    {
        GameObject component = transform.parent.gameObject;
        GameObject panel1 = component.transform.Find("Panel").gameObject;
        GameObject panel2 = component.transform.Find("Panel (1)").gameObject;

        // Establecer el color de los materiales de Panel1 y Panel2
        panel1.GetComponent<Image>().color = originalColor;
        panel2.GetComponent<Image>().color = originalColor;
    }


}
