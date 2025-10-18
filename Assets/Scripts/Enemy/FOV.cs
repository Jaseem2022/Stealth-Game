using System.Collections;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;

public class FOV : MonoBehaviour
{
    [SerializeField] GameObject playerRef;
    [SerializeField] LayerMask targetMask;
    [SerializeField] LayerMask obstructionMask;
    [SerializeField] float radius;
    [SerializeField] float angle;

    public bool isPlayerDetected;

    void Start()
    {
        StartCoroutine(FieldOfView());

    }
    private IEnumerator FieldOfView()
    {

        WaitForSeconds wait = new WaitForSeconds(0.2f);
        while (true)
        {
            yield return wait;
            CheckFOV();
        }
    }

    private void CheckFOV()
    {
        Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, targetMask);

        if (rangeChecks.Length != 0)
        {
            Transform target = rangeChecks[0].transform;
            Vector3 directionToTarget = (target.position - transform.position).normalized;
            float angleToTarget = Vector3.Angle(transform.forward, directionToTarget);
            Debug.DrawLine(transform.position, directionToTarget);

            if (Vector3.Angle(transform.forward, directionToTarget) < angle / 2)
            {
                float distanceToTarget = Vector3.Distance(transform.position, target.position);

                if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, obstructionMask))
                {
                    Debug.DrawLine(transform.position, directionToTarget);
                    isPlayerDetected = true;
                    Debug.Log("Player spotted!");

                }
                else
                {
                    isPlayerDetected = false;
                }
            }
            else
            {
                isPlayerDetected = false;
            }
        }
        else
        {
            isPlayerDetected = false;
        }
    }

}
