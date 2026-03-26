using UnityEngine;

public class CognitiveVREvents : MonoBehaviour
{
    public void SendCognitiveVREvent(Cognitive3D.DynamicObject dynamicObject)
    {

        Cognitive3D.CustomEvent customEvent = new Cognitive3D.CustomEvent("Furniture Selected : "+ dynamicObject.name).SetDynamicObject(dynamicObject);
        customEvent.Send();
        
    }
}
