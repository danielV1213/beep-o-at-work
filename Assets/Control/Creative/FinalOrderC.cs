using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalOrderC : MonoBehaviour
{
    public FinalOrderM finalOrderM;
    public FinalOrderV finalOrderV;

    public string textOC1;
    public string textOC2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textOC1 = finalOrderV.textOrderC1.text.ToString();
        textOC2 = finalOrderV.textOrderC2.text.ToString();

        finalOrderEvaluate();

        finalOrderV.changeFinalOrder(finalOrderM.FinalOrder, finalOrderM.imageNum);
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
