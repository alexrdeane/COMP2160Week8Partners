using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    private PlayerInput playerInputs;
    private InputAction movement;

    private void Awake()
    {
        playerInputs = new PlayerInput();
        movement = playerInputs.playerActions.movement;
    }

    void OnEnable()
    {
        movement.Enable();
    }

    void OnDisable()
    {
        movement.Disable();
    }

    void Update()
    {
        float movementX = movement.ReadValue<Vector2>().x;
        float movementY = movement.ReadValue<Vector2>().y;

        transform.Translate(movementX * movementSpeed * Time.deltaTime, 0, movementY * movementSpeed * Time.deltaTime, Space.World);
    }
}