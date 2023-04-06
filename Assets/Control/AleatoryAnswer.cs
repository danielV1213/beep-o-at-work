using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AleatoryAnswer : MonoBehaviour
{
    public ObjectAnswers ObjectAnswers;
    public PositionsAnswers positionsAnswers;

    private int numIncorrect = 2;


    void Start()
    {
        ChangeAnswers();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ChangeAnswers();
        }

    }



    public void ChangeAnswers()
    {
        positionsAnswers.DestroyObject();

        List<Transform> availablePositions = new List<Transform>(positionsAnswers.spawnPositions);
        
        //Posicion aleatoria
        int correctIxPos = Random.Range(0, availablePositions.Count);
        //Objeto aleatorio
        int correctIxObj = Random.Range(0, ObjectAnswers.correctObjects.Length);
        GameObject correctObject = ObjectAnswers.correctObjects[correctIxObj];
        //Generar obj aleatorio
        positionsAnswers.InstantiateCorrectObject(correctObject, correctIxPos);
        //instantiatedObjects.Add(correctObject);

        //Incorrecta lista
        List<int> incorrectIndexList = new List<int>();

        //Posicion
        for (int i = 0; i < availablePositions.Count; i++)
        {
            if (i != correctIxPos)
            {
                incorrectIndexList.Add(i);
            }

        }

        List<int> selectedIncorrectIx = new List<int>();

        for (int i = 0; i < numIncorrect; i++)
        {
            int randomIncorrectIx;

            do
            {
                randomIncorrectIx = Random.Range(0, ObjectAnswers.incorrectObjects.Length);
            }
            while (selectedIncorrectIx.Contains(randomIncorrectIx));

            selectedIncorrectIx.Add(randomIncorrectIx);
            
            GameObject incorrectObject = ObjectAnswers.incorrectObjects[randomIncorrectIx];

            positionsAnswers.InstantiateIncorrectObject(incorrectObject, incorrectIndexList[i]);

            //instantiatedObjects.Add(incorrectObject);
        }


    }
    

}
