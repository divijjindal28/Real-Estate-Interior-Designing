using Cognitive3D;
using Oculus.Interaction;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;


public class RecordGrabComponent : MonoBehaviour
{
    private GrabbableEventWrapper grabInteractable;
    private DynamicObject dynamicObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        grabInteractable = GetComponent<GrabbableEventWrapper>();
        dynamicObject = GetComponent<DynamicObject>();

        grabInteractable.onGrab.AddListener(RecordGrab);
        grabInteractable.onRelease.AddListener(RecordRelease);

        //grabInteractable.Pointer.AddListener(RecordGrab);
        //grabInteractable.selectExited.AddListener(RecordRelease);
    }

    public void RecordGrab() {
        dynamicObject.BeginEngagement("Grabbing");

    }

    public void RecordRelease()
    {
        dynamicObject.BeginEngagement("Grabbing");
    }
}
