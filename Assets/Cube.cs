using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cube : MonoBehaviour
{

    PlayerControls controls;

    //Vector2 move;

    void Awake()
    {
        controls = new PlayerControls();
        controls.Gameplay.Grow.performed += ctx => Grow();
        //controls.Gameplay.move.performed += ctx => move = ctx.ReadValue<Vector2>();
        //controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;
    }

    void Grow()
    {
        transform.localScale *= 2f;
    }

    //void Update()
    //{
    //    Vector2 m = new Vector2(-move.x, move.y) * Time.deltaTime;
    //    transform.Translate(m, Space.World);
    //}

    void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
