using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEsena : MonoBehaviour
{
    public string sceneName; 

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}