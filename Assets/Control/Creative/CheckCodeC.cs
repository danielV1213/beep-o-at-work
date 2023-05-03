using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCodeC : MonoBehaviour
{
    public CheckCodeV checkCodeV;
    public CheckCodeM checkCodeM;

    public bool generateFor = true;
    public int indexSibilingFor;

    public string orderBigO;

    // Start is called before the first frame update
    void Start()
    {
        
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

                    checkCodeV.generateComponentFor(indexSibilingFor);
                    
                    generateFor = false;

                    Debug.Log(indexSibilingFor);
                }
            }
            else
            {
                Debug.Log("Función no reconocida");
            }

        }

      

    }

    private void OnTriggerExit(Collider other)
    {
        checkCodeV.cleanAnswerView();

        if(other.CompareTag("ContentFor"))
        {
            checkCodeV.destroyComponentFor(indexSibilingFor);
            generateFor = true;
        }

    }




}
