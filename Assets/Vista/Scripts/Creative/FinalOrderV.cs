using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinalOrderV : MonoBehaviour
{
    public TextMeshProUGUI textOrderC1;
    public TextMeshProUGUI textOrderC2;
    public TextMeshProUGUI textFinalOrder;

    public Image imageOrder;

    public List<Sprite> answerImageOrder; 

    public void changeFinalOrder(string finalOrder, int image)
    {
        textFinalOrder.text = $"<b><size=36>{textOrderC1.text} * {textOrderC2.text} = {finalOrder}</size></b>";

        imageOrder.sprite = answerImageOrder[image];

    }

    public void finalString(string finalString)
    {
        textFinalOrder.text = $"<b><size=36>{finalString}</size></b>";
    }





}
