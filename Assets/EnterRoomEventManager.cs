using UnityEngine;
using static Meta.XR.MRUtilityKit.TelemetryConstants;

public class EnterRoomEventManager : MonoBehaviour
{
    public string eventName = "Player Sneezed ";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Cognitive3D.CustomEvent customEvent = new Cognitive3D.CustomEvent(eventName);
            customEvent.Send();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    
}
