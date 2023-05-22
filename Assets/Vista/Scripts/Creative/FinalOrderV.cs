using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinalOrderV : MonoBehaviour
{
    public TextMeshProUGUI textFinalOrder;
    public TextMeshProUGUI textOperation;

    public Image imageOrder;
    public List<Sprite> answerImageOrder; 

    public void changeFinalOrder(string finalOrder, int image)
    {
        textFinalOrder.text = $"<b><size=36>{finalOrder}</size></b>";
        imageOrder.sprite = answerImageOrder[image-1];

    }

    public void finalString(string finalString)
    {
        textOperation.text = $"<b><size=36>{finalString}</size></b>";
    }





}
