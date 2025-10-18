using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private CharacterController controller;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // A/D or arrow keys
        float vertical = Input.GetAxis("Vertical");     // W/S or arrow keys

        Vector3 move = new Vector3(horizontal, 0, vertical);
        controller.Move(move * moveSpeed * Time.deltaTime);
    }
}
