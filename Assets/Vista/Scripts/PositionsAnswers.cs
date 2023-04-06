using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionsAnswers : MonoBehaviour
{
    public Transform[] spawnPositions;
    public List<GameObject> instantiatedObjects = new List<GameObject>();

    public void InstantiateCorrectObject(GameObject correctObject, int positionIndex)
    {
        GameObject clon = Instantiate(correctObject, spawnPositions[positionIndex].position, spawnPositions[positionIndex].rotation) as GameObject;
        instantiatedObjects.Add(clon);
    }

    public void InstantiateIncorrectObject(GameObject incorrectObject, int positionIndex)
    {
        GameObject clon = Instantiate(incorrectObject, spawnPositions[positionIndex].position, spawnPositions[positionIndex].rotation) as GameObject;
        instantiatedObjects.Add(clon);
    }
        
    public void DestroyObject()
    {
        foreach (GameObject instantiatedObject in instantiatedObjects)
        {
            Destroy(instantiatedObject);
        }
        instantiatedObjects.Clear();

    }
}
