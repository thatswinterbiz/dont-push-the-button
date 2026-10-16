using UnityEngine;
using UnityEngine.InputSystem;

public class TaskOne : MonoBehaviour
{
    private float yPosition = -4;
    [Range(-8.5f, 8f)]
    private float xLimit = 0f;

    InputAction moveAction;

    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    private void Update()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();

    }
}