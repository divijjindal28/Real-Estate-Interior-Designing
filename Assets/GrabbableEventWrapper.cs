using UnityEngine;
using UnityEngine.Events;
using Oculus.Interaction;

public class GrabbableEventWrapper : Grabbable
{
    public UnityEvent onGrab;
    public UnityEvent onRelease;

    public override void ProcessPointerEvent(PointerEvent evt)
    {
        if (evt.Type == PointerEventType.Select)
        {
            onGrab?.Invoke();
            Debug.Log("GrabbableEventWrapper Grabbed: " + gameObject.name);
        }

        if (evt.Type == PointerEventType.Unselect)
        {
            onRelease?.Invoke();
            Debug.Log("GrabbableEventWrapper Released: " + gameObject.name);
        }

        base.ProcessPointerEvent(evt);
    }
}