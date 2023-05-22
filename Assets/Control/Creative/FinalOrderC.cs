using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class FinalOrderC : MonoBehaviour
{
    public FinalOrderM finalOrderM;
    public FinalOrderV finalOrderV;

    public Transform contentParent;

    public string finalString = "";
    public bool inside = false;


    List<string> results = new List<string>();


    void Start()
    {

        GenerateFinalString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RunAnswer()
    {
        GenerateFinalString();

        results.Clear();

        separateTerms();

        (string maxOrder, int index) = GetMaxOrder();

        finalOrderV.changeFinalOrder(maxOrder, index);



        //Debug.Log(GetMaxOrder());
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

    

    public void separateTerms()
    {
        results.Clear();

        string[] terms = finalString.Split('+');

        foreach (string term in terms)
        {
            //Debug.Log(term);
            if (term.Contains("*"))
            {
                if (term.Count(c => c == '*') == 1)
                {
                    //simpleMult.Add(term);
                    string res = evaluateMultiplication(term);
                    results.Add(res);
                }
                else if (term.Count(c => c == '*') == 2)
                {

                    string[] tempTerm = term.Split('*');

                    string temp2Term = tempTerm[0] + "*" + tempTerm[1];

                    string res = evaluateMultiplication(temp2Term);

                    string temp3Term = res + "*" + tempTerm[2];

                    string res2 = evaluateMultiplication(temp3Term);

                    results.Add(res2);
                }
            }
            else
            {
                results.Add(term);
            }

        }
    }
    public string evaluateMultiplication(string mult)
    {
        string result = "";

        if (mult.Contains("*O(1)"))
        {
            result = mult.Replace("*O(1)", "");
        }
        else if (mult.Contains("O(1)*"))
        {
            result = mult.Replace("O(1)*", "");
        }
        else
        {
            if (mult.Contains("O(n)"))
            {
                bool count = RepeatedValue("O(n)", mult);

                if (count)
                {
                    result = "O(n^2)";
                    //results.Add("O(n^2)");
                }
                else
                {
                    if (mult.Contains("O(n^2)"))
                    {
                        result = "O(n^3)";
                        //results.Add("O(n^3)");
                    }
                    else if (mult.Contains("O(n^3)")) //result prev
                    {
                        result = "O(n^4)";
                    }
                    else if (mult.Contains("O(n^4)")) //result prev
                    {
                        result = "O(n^5)";
                    }
                    else if (mult.Contains("O(Logn)"))
                    {
                        result = "O(nLogn)";
                    }
                    else if (mult.Contains("O(nLogn)")) //result prev
                    {
                        result = "O(n^2Logn)";
                    }
                    else if (mult.Contains("O(n^2Logn)")) //result prev
                    {
                        result = "O(n^3Logn)";
                    }
                    else if (mult.Contains("O(Log^2n)")) //result prev
                    {
                        result = "O(nLog^2n)";
                    }
                    else
                    {
                        Debug.Log("No se encuentra el resultado de: " + mult);
                    }

                }

            }
            else if (mult.Contains("O(n^2)"))
            {
                bool count = RepeatedValue("O(n^2)", mult);

                if (count)
                {
                    result = "O(n^4)";
                    //results.Add("O(n^4)");
                }
                else
                {

                    if (mult.Contains("O(n^3)")) //result prev
                    {
                        result = "O(n^5Logn)";
                    }
                    else if (mult.Contains("O(n^4)")) //result prev
                    {
                        result = "O(n^6Logn)";
                    }
                    else if (mult.Contains("O(Logn)"))
                    {
                        result = "O(n^2Logn)";
                    }
                    else if (mult.Contains("O(nLogn)")) //result prev
                    {
                        result = "O(n^3Logn)";
                    }
                    else if (mult.Contains("O(n^2Logn)")) //result prev
                    {
                        result = "O(n^4Logn)";
                    }
                    else if (mult.Contains("O(Log^2n)")) //result prev
                    {
                        result = "O(n^2Log^2n)";
                    }
                    else
                    {
                        Debug.Log("No se encuentra el resultado de: " + mult);
                    }
                }
            }
            else if (mult.Contains("O(Logn)"))
            {
                bool count = RepeatedValue("O(Logn)", mult);

                if (count)
                {
                    result = "O(Log^2n)";
                    //results.Add("O(Log^2n)");
                }
                else
                {
                    if (mult.Contains("O(n^3)")) //result prev
                    {
                        result = "O(n^3Logn)";
                    }
                    else if (mult.Contains("O(n^4)")) //result prev
                    {
                        result = "O(n^4Logn)";
                    }
                    else if (mult.Contains("O(nLogn)")) //result prev
                    {
                        result = "O(nLog^2n)";
                    }
                    else if (mult.Contains("O(n^2Logn)")) //result prev
                    {
                        result = "O(n^2Log^2n)";
                    }
                    else if (mult.Contains("O(Log^2n)")) //result prev
                    {
                        result = "O(Log^3n)";
                    }
                    else
                    {
                        Debug.Log("No se encuentra el resultado de: " + mult);
                    }

                }
            }
            else if (mult.Contains("O(n^3)"))
            {
                bool count = RepeatedValue("O(n^3)", mult);

                if (count)
                {
                    result = "O(n^6)";
                }
                else
                {
                    if (mult.Contains("O(n^4)")) //result prev
                    {
                        result = "O(n^7)";
                    }
                    else if (mult.Contains("O(nLogn)")) //result prev
                    {
                        result = "O(n^4Logn)";
                    }
                    else if (mult.Contains("O(n^2Logn)")) //result prev
                    {
                        result = "O(n^5Logn)";
                    }
                    else if (mult.Contains("O(Log^2n)")) //result prev
                    {
                        result = "O(n^3Log^2n)";
                    }
                    else
                    {
                        Debug.Log("No se encuentra el resultado de: " + mult);
                    }

                }
            }
            else if (mult.Contains("O(n^4)"))
            {
                bool count = RepeatedValue("O(n^4)", mult);

                if (count)
                {
                    result = "O(n^8)";
                }
                else
                {
                    if (mult.Contains("O(nLogn)")) //result prev
                    {
                        result = "O(n^5Logn)";
                    }
                    else if (mult.Contains("O(n^2Logn)")) //result prev
                    {
                        result = "O(n^6Logn)";
                    }
                    else if (mult.Contains("O(Log^2n)")) //result prev
                    {
                        result = "O(n^4Log^2n)";
                    }
                    else
                    {
                        Debug.Log("No se encuentra el resultado de: " + mult);
                    }

                }
            }
            else if (mult.Contains("O(nLogn)"))
            {
                bool count = RepeatedValue("O(nLogn)", mult);

                if (count)
                {
                    result = "O(n^2Log^2n)";
                }
                else
                {
                    if (mult.Contains("O(n^2Logn)")) //result prev
                    {
                        result = "O(n^3Log^2n)";
                    }
                    else if (mult.Contains("O(Log^2n)")) //result prev
                    {
                        result = "O(Log^4n)";
                    }
                    else
                    {
                        Debug.Log("No se encuentra el resultado de: " + mult);
                    }

                }
            }
            else if (mult.Contains("O(n^2Logn)"))
            {
                bool count = RepeatedValue("O(n^2Logn)", mult);

                if (count)
                {
                    result = "O(n^4Log^2n)";
                }
                else
                {
                    if (mult.Contains("O(Log^2n)")) //result prev
                    {
                        result = "O(n^2Log^3n)";
                    }
                    else
                    {
                        Debug.Log("No se encuentra el resultado de: " + mult);
                    }

                }
            }
            else if (mult.Contains("O(Log^2n)"))
            {
                bool count = RepeatedValue("O(Log^2n)", mult);

                if (count)
                {
                    result = "O(Log^4n)";
                }
                else
                {
                    Debug.Log("No se encuentra el resultado de: " + mult);
                }
            }
        }

        return result;
    }
    private bool RepeatedValue(string secuency, string termino)
    {
        int count = 0;
        int index = termino.IndexOf(secuency);

        while (index != -1)
        {
            count++;
            index = termino.IndexOf(secuency, index + 1);
        }
        if (count == 2)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    Dictionary<string, int> complexityValues = new Dictionary<string, int>()
    {
    {"O(1)", 1},
    {"O(Logn)", 2},
    {"O(Log^2n)", 3},
    {"O(Log^3n)", 4},
    {"O(Log^4n)", 5},
    {"O(n)", 6},
    {"O(nLogn)", 7},
    {"O(nLog^2n)", 8},
    {"O(n^2)", 9},
    {"O(n^2Logn)", 10},
    {"O(n^2Log^2n)", 11},
    {"O(n^2Log^3n)", 12},
    {"O(n^3)", 13},
    {"O(n^3Logn)", 14},
    {"O(n^3Log^2n)", 15},
    {"O(n^4)", 16},
    {"O(n^4Logn)", 17},
    {"O(n^4Log^2n)", 18},
    {"O(n^5)", 19},
    {"O(n^5Logn)", 20},
    {"O(n^6)", 21},
    {"O(n^6Logn)", 22},
    {"O(n^8)", 23}
    };
    private (string, int) GetMaxOrder()
    {
        // Variables para almacenar el resultado con el número mayor
        string resultWithMaxComplexity = "";
        int maxComplexityValue = 0;

        foreach (string result in results)
        {
            if (complexityValues.TryGetValue(result, out int complexityValue))
            {
                if (complexityValue > maxComplexityValue)
                {
                    maxComplexityValue = complexityValue;
                    resultWithMaxComplexity = result;
                }
            }
        }

        return (resultWithMaxComplexity, maxComplexityValue);
    }







}
