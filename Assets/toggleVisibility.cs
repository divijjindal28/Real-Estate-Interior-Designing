using UnityEngine;

public class toggleVisibility : MonoBehaviour
{
    CognitiveVREvents cognitiveVREvents;
     void Start()
    {
        cognitiveVREvents = GetComponent<CognitiveVREvents>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ChangeFurniture(GameObject gameObject)
    {
        gameObject.SetActive(!gameObject.activeSelf);
        if (gameObject.activeSelf) {
            cognitiveVREvents.SendCognitiveVREvent(gameObject.GetComponent<Cognitive3D.DynamicObject>());
        }
    }

}
