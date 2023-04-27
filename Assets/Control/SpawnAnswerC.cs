using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnswerC : MonoBehaviour
{
    public SpawnAnswerM ObjectAnswers;
    public SpawnAnswerV positionsAnswers;

    public int numIncorrect = 3;


    void Start()
    {
        ChangeAnswers();
    }
  
    public void ChangeAnswers()
    {
        positionsAnswers.DestroyObject();

        List<Transform> availablePositions = new(positionsAnswers.spawnPositions);
        
        //Posicion aleatoria
        int correctIxPos = Random.Range(0, availablePositions.Count);

        //Objeto aleatorio
        int correctIxObj = Random.Range(0, ObjectAnswers.correctObjects.Length);
        GameObject correctObject = ObjectAnswers.correctObjects[correctIxObj];

        //Generar obj aleatorio
        positionsAnswers.InstantiateCorrectObject(correctObject, correctIxPos);

        //Incorrecta lista
        List<int> incorrectIndexList = new();

        //Posicion
        for (int i = 0; i < availablePositions.Count; i++)
        {
            if (i != correctIxPos)
            {
                incorrectIndexList.Add(i);
            }

        }

        List<int> selectedIncorrectIx = new();

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

        }


    }
    

}
