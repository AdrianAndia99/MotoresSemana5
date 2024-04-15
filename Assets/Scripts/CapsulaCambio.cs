using UnityEngine;
using UnityEngine.SceneManagement;

public class CapsulaCambio : MonoBehaviour
{
    public string nextSceneName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            SceneManager.LoadScene(nextSceneName); 
        }
    }
}