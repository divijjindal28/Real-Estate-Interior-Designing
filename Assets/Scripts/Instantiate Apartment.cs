using UnityEngine;

public class InstantiateApartment : MonoBehaviour
{
    [SerializeField] private GameObject parent;
    [SerializeField] private GameObject appartment;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("IntantiateAppartment", 0.5f);
    }

    // Update is called once per frame
    void IntantiateAppartment()
    {
        GameObject newAppartment = Instantiate(appartment, transform.position, transform.rotation);
        newAppartment.transform.SetParent(parent.transform);
    }
}
