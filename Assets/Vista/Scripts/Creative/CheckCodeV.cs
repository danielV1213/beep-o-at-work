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


    public void destroyComponentFor()
    {

        Transform parentComponent = transform.parent;
        int indexComponent = parentComponent.GetSiblingIndex();

        Transform parentContent = parentComponent.transform.parent;

        Transform forContent = parentContent.GetChild(indexComponent + 1);
        int indexForComponent = forContent.GetSiblingIndex();

        Debug.Log("Nombre For: " + forContent.name);
    
        //Debug.Log("EXIIIT: " + parentComponent.name);

        int indexEndFor = 0;
      
   
        if (forContent.name == "ComponentInsideFor(Clone)")
        {
            //Debug.Log("EXIIIT: " + transform.parent.name);

            for (int i = 0; i < parentContent.childCount; i++)
            {
                Transform componentsChilds = parentContent.GetChild(i);

                if (componentsChilds.name == "ComponentEndFunction1(Clone)" && i > indexForComponent)
                {
                    indexEndFor = i;
                    break; // salir del loop una vez que se encuentre "endFor"
                }
            }

            for (int i = indexForComponent; i <= indexEndFor; i++)
            {
                Destroy(parentContent.GetChild(i).gameObject);
            }

        }

        if (forContent.name == "ComponentInsideFor2(Clone)")
        {
            //Debug.Log("EXIIIT: " + transform.parent.name);

            for (int i = 0; i < parentContent.childCount; i++)
            {
                Transform componentsChilds = parentContent.GetChild(i);

                if (componentsChilds.name == "ComponentEndFunction2(Clone)")
                {
                    indexEndFor = i;
                    break; // salir del loop una vez que se encuentre "endFor"
                }
            }

            for (int i = indexForComponent; i <= indexEndFor; i++)
            {
                Destroy(parentContent.GetChild(i).gameObject);
            }

        }

        //Destroy(newObject);
        //Destroy(newObject2);


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
