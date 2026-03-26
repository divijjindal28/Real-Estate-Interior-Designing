using System.Globalization;
using Cognitive3D;
using Oculus.Interaction;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;


public class RecordGrabComponent : MonoBehaviour
{
    private GrabInteractable grabInteractable;
    private InteractableUnityEventWrapper interactableUnityEventWrapper;
    private DynamicObject dynamicObject;
    public string eventName = "Player Sneezed ";
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    private Grabbable grabbable;



    void Start()
    {
        grabbable = GetComponent<Grabbable>();
        grabbable.WhenPointerEventRaised += OnPointerEvent;
        
        dynamicObject = GetComponent<DynamicObject>();
        //Cognitive3D.CustomEvent customEvent = new Cognitive3D.CustomEvent(eventName);
        //customEvent.Send();


    }



    private void OnPointerEvent(PointerEvent evt)
    {
        if (evt.Type == PointerEventType.Select)
        {
            Debug.Log("Object Grabbed");
            RecordGrab();
        }
        if (evt.Type == PointerEventType.Unselect)
        {
            Debug.Log("Released");
            RecordRelease();
        }
    }

    public void RecordGrab() {
        new Cognitive3D.CustomEvent("Component Grabbed : "+gameObject.name).SetDynamicObject(dynamicObject).Send();

    }

    public void RecordRelease()
    {
        new Cognitive3D.CustomEvent("Component Released : " + gameObject.name).SetDynamicObject(dynamicObject).Send();
    }
}
