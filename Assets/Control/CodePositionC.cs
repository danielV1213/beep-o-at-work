using System.Collections;
using System.Collections.Generic;
using UltimateXR.Manipulation;
using UnityEngine;

public class CodePositionC : MonoBehaviour
{
    public CodePositionM codePositionM;
    public CodePositionV codePositionV;
    [SerializeField] private UxrGrabbableObject _targetGrabbable;
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
        if (other.gameObject.CompareTag("Hand"))
        {
            codePositionV.changeColorOpacity();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            codePositionV.changeColorToOriginal();
        }

    }




    // OnEnable is a recommended place to subscribe to events
    private void OnEnable()
    {
        if (_targetGrabbable != null)
        {
            _targetGrabbable.Grabbed += Grabbable_Grabbed;
            _targetGrabbable.Released += Grabbable_Released;
        }
    }

    // OnDisable is a recommended place to unsubscribe from events
    private void OnDisable()
    {
        if (_targetGrabbable != null)
        {
            _targetGrabbable.Grabbed -= Grabbable_Grabbed;
            _targetGrabbable.Released -= Grabbable_Released;
        }
    }

    // This is the event handler called when the object was grabbed
    private void Grabbable_Grabbed(object sender, UxrManipulationEventArgs e)
    {
        // This method receives a lot of information on the event in "e". We use it here to print the name of the object that was grabbed.
        //Debug.Log($"Object {e.GrabbableObject.name} was grabbed!");

    }

    // This is the event handler called when the object was released
    private void Grabbable_Released(object sender, UxrManipulationEventArgs e)
    {
        // This method receives a lot of information on the event in "e". We use it here to print the name of the object that was released.
        //Debug.Log($"Object {e.GrabbableObject.name} was grabbed Released!");
        transform.position = codePositionM.parent.position;
        transform.rotation = codePositionM.parent.rotation;

    }

}
