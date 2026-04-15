using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscene : MonoBehaviour
{

    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            // Do something for the first scene
            LoadScene1();
        }
    }
    public void LoadScene1()
    {
        SceneManager.LoadScene(1);
    }


    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
