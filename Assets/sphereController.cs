using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class sphereController : MonoBehaviour
{

    Vector2 latestMovInput;

    public void OnMovement(InputAction.CallbackContext ctx)
    {
        latestMovInput = ctx.ReadValue<Vector2>();
    }

    private void Update()
    {
        transform.Translate(new Vector3(latestMovInput.x, 0, latestMovInput.y));
    }
}
