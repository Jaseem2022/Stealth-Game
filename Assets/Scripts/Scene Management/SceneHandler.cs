using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneHandler : MonoBehaviour
{
    [SerializeField] Investigate investigate;
    Investigate[] enemies;

    void Start()
    {
        enemies = FindObjectsOfType<Investigate>();
    }

    void Update()
    {
        foreach (var enemy in enemies)
        {
            if (enemy.isPlayerTouched)
            {
                Debug.LogError("Reloading Scene...");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

}