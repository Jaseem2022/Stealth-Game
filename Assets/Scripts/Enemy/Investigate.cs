using NUnit.Framework;
using UnityEditor.Callbacks;
using UnityEngine;

public class Investigate : MonoBehaviour
{
    FOV fov;
    EnemyPatrol enemyPatrol;
    [SerializeField] Transform playerTransform;
    public bool isPlayerTouched;

    void OnTriggerEnter(Collider other)
    {
        isPlayerTouched = false;
        if(other.CompareTag("Player"))
        {
            isPlayerTouched = true;
            Debug.Log("Player touched!");
        }
    }

    void InvestigatePlayer()
    {
        //Face the player
        Vector3 direction = (playerTransform.position - transform.position).normalized;
        transform.forward = Vector3.Lerp(transform.forward, direction, Time.deltaTime * 5f);

        //move over there , increase speed for some intensity
        Vector3 newPosition = Vector3.MoveTowards(transform.position,
                                                playerTransform.position,
                                                (enemyPatrol.enemySpeed + 2) * Time.deltaTime);

        transform.position = newPosition;

        //if enemy touches player game over
        if(isPlayerTouched)
        {
            Debug.Log("Game Over : Player Died");
        }
    }
    
    
    void Start()
    {
        fov = GetComponent<FOV>();
        enemyPatrol = GetComponent<EnemyPatrol>();
        isPlayerTouched = false;
    }

   
    void Update()
    {
        if (fov.isPlayerDetected)
        {
            InvestigatePlayer();
        }
    }
}
