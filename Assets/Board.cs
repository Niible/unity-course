using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Board : MonoBehaviour
{
    private PlayerInputAction _playerInputAction;

    public float maxAngle = 45f;

    private void Awake()
    {
        _playerInputAction = new PlayerInputAction();
        _playerInputAction.Player.Enable();
    }
    private void Update()
    {
        Vector2 inputVector = _playerInputAction.Player.Movements.ReadValue<Vector2>();
        float degreesPerSeconds = 40;
        if (inputVector.y <= -0.1f && transform.rotation.eulerAngles.x >= 15 && transform.rotation.eulerAngles.x < 16 ) inputVector.y = 0;
        if (inputVector.y >= 0.1f && transform.rotation.eulerAngles.x <= 360 - 15 && transform.rotation.eulerAngles.x > 360 - 16 ) inputVector.y = 0;
        if (inputVector.x >= 0.1f && transform.rotation.eulerAngles.z >= 15 && transform.rotation.eulerAngles.z < 16 ) inputVector.x = 0;
        if (inputVector.x <= -0.1f && transform.rotation.eulerAngles.z <= 360 - 15 && transform.rotation.eulerAngles.z > 360 - 16 ) inputVector.x = 0;

        this.transform.Rotate(new Vector3(-inputVector.y, 0, inputVector.x).normalized * degreesPerSeconds * Time.deltaTime);
    }
    
    
}
