using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckCodeV : MonoBehaviour
{
    // Start is called before the first frame update


    public TextMeshProUGUI textOrderC;

    public void changeAnswerView(string orderComplexity)
    {
        textOrderC.text = $"{orderComplexity}";
    }

    public void cleanAnswerView()
    {
        textOrderC.text = "";
    }


}
