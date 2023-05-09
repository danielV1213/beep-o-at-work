using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalOrderC : MonoBehaviour
{
    public FinalOrderM finalOrderM;
    public FinalOrderV finalOrderV;

   

    public string textOC1;
    public string textOC2;

    public Transform contentParent;

    public string finalString = "";
    public bool inside = false;

    private GameObject[] listComponent;
    private CheckCodeC checkCodeC;

    void Start()
    {
        //listComponent = GameObject.FindGameObjectsWithTag("ComponentCrative");




        //// Obtener el transform del contentParent
        //Transform contentParentTransform = contentParent.transform;

        //// Suscribirse al evento childAdded del transform del contentParent
        //contentParentTransform.childAdded += OnChildAddedOrRemoved;

        //// Suscribirse al evento childRemoved del transform del contentParent
        //contentParentTransform.childRemoved += OnChildAddedOrRemoved;



        //foreach (Transform component in contentParent.transform)
        //{
        //    Transform panel = component.GetChild(1);
        //    TextMeshProUGUI textComponent = panel.GetChild(0).GetComponent<TextMeshProUGUI>();
        //    textComponent.onTextChanged.AddListener(() => GenerateFinalString());
        //}



        GenerateFinalString();
    }

    // Update is called once per frame
    void Update()
    {
        //textOC1 = finalOrderV.textOrderC1.text.ToString();
        //textOC2 = finalOrderV.textOrderC2.text.ToString();

        //finalOrderEvaluate();

        //finalOrderV.changeFinalOrder(finalOrderM.FinalOrder, finalOrderM.imageNum);

    }

    public void GenerateFinalString()
    {
        finalString = "";
        foreach (Transform component in contentParent.transform)
        {
            string componentName = component.name;
            // Obtener el objeto Panel que es el primer hijo de cada Component
            if (component.childCount > 1)
            {
                Transform panel = component.GetChild(1);


                Debug.Log("PANEL:" + panel.name);
                // Obtener el componente Text que es el primer hijo del objeto Panel
                TextMeshProUGUI textComponent = panel.GetChild(0).GetComponent<TextMeshProUGUI>();
                Debug.Log("textComponent:" + textComponent.name);
                // Agregar el texto al string final, separado por "+" o "*"

                if (textComponent.text == "")
                {

                }
                else
                {

                    if (componentName == "ComponentInsideFor(Clone)" || componentName == "ComponentInsideFor2(Clone)")
                    {
                        finalString += "*";
                    }
                    else
                    {
                        finalString += "+";
                    }

                    finalString += textComponent.text;
                }

            }
          
           
        }

        // Eliminar el último carácter agregado a finalString (que puede ser un "+" o "*")
        finalString = finalString.Substring(1);

        finalOrderV.finalString(finalString);
    }

    public void finalOrderEvaluate()
    {


        if (textOC1.Equals("O(1)"))
        {
            switch (textOC2)
            {
                case "O(n)":
                    finalOrderM.imageNum = 1;
                    finalOrderM.FinalOrder = textOC2;
                    break;
                case "O(n^2)":
                    finalOrderM.imageNum = 2;
                    finalOrderM.FinalOrder = textOC2;
                    break;
                case "O(Log n)":
                    finalOrderM.imageNum = 3;
                    finalOrderM.FinalOrder = textOC2;
                    break;
                default:
                    finalOrderM.FinalOrder = textOC1;
                    break;
            }

           
        }else if (textOC2.Equals("O(1)"))
        {
            switch (textOC1)
            {
                case "O(n)":
                    finalOrderM.imageNum = 1;
                    finalOrderM.FinalOrder = textOC1;
                    break;
                case "O(n^2)":
                    finalOrderM.imageNum = 2;
                    finalOrderM.FinalOrder = textOC1;
                    break;
                case "O(Log n)":
                    finalOrderM.imageNum = 3;
                    finalOrderM.FinalOrder = textOC1;
                    break;
                default:
                    finalOrderM.FinalOrder = textOC2;
                    break;
            }

        }
        else if (textOC1.Equals("") || textOC2.Equals(""))
        {
            finalOrderM.FinalOrder = "Vacio";
        }
        else
        {
            finalOrderM.FinalOrder = "Proximamante";
        }

    }

}
