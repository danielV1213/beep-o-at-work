using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCodeC : MonoBehaviour
{
    public CheckCodeV checkCodeV;
    public CheckCodeM checkCodeM;

    public bool generateFor = true;
    public int indexSibilingFor;

    public string orderBigO;

    public Color targetColor;
    public Color originalColor;

    // Start is called before the first frame update
    void Start()
    {
        GameObject component = transform.parent.gameObject;
        GameObject panel1 = component.transform.Find("Panel").gameObject;

        // Establecer el color de los materiales de Panel1 y Panel2
        originalColor = panel1.GetComponent<Image>().color;
       
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
            
            string orderC = selectedValue.ToString();

            //Debug.Log("Selected value: " + selectedValue.ToString());

            if (checkCodeM.ordersComplexity.ContainsKey(orderC))
            {
                //Debug.Log(checkCodeM.ordersComplexity[orderC]);
                orderBigO = checkCodeM.ordersComplexity[orderC];
                checkCodeV.changeAnswerView(orderBigO);

                if (other.CompareTag("ContentFor") && generateFor)
                {
                    indexSibilingFor = transform.parent.GetSiblingIndex();

                    Transform parentComponent = transform.parent.transform;
                    Transform parentContent = parentComponent.transform.parent.transform;

                    checkCodeV.generateComponentFor(indexSibilingFor, parentComponent, parentContent);
                    
                    generateFor = false;

                    Debug.Log("INDEX SIBILING: " + indexSibilingFor);
                }
            }
            else
            {
                Debug.Log("Función no reconocida");
            }

        }

        // Comprobar si el otro objeto tiene el componente 'Image'
        Image imageComponent = other.gameObject.GetComponentInChildren<Image>();
        if (imageComponent != null)
        {
            // Obtener el color de la imagen
            targetColor = imageComponent.color;
            // Asignar el color al objeto actual

            checkCodeV.changeColorPanel(targetColor);

        }

    }

    private void OnTriggerExit(Collider other)
    {
        checkCodeV.cleanAnswerView();
        checkCodeV.changeOriginalColorPanel(originalColor);

        if (other.CompareTag("ContentFor"))
        {
            checkCodeV.destroyComponentFor(indexSibilingFor);
            generateFor = true;
        }

        //if(other.gameObject.name == "")


    }




}
