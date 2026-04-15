using UnityEngine;

public class SingletonLoadScene : MonoBehaviour
{
    public static SingletonLoadScene Instance;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            DestroyImmediate(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}