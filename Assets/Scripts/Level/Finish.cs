using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered with: " + other.name);
        if(other.CompareTag("Player"))
        {

            Debug.Log("Level Cleared!");
            Debug.LogError("Reloading level again");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
