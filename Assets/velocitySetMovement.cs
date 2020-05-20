using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class velocitySetMovement : MonoBehaviour
{
    public float Velocity = 10f;
    public Transform forwardOverride;

    bool moving = false;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.sleepThreshold = 0;
    }

    void OnEnable()
    {
        playerEvents.Instance.Controls.Battle.Move.started += Move_started;
        playerEvents.Instance.Controls.Battle.Move.canceled += Move_canceled;
    }
    void OnDisable()
    {

        playerEvents.Instance.Controls.Battle.Move.started -= Move_started;
        playerEvents.Instance.Controls.Battle.Move.canceled -= Move_canceled;
    }


    private void FixedUpdate()
    {
        if (moving)
        {
            var inputVect = playerEvents.Instance.Controls.Battle.Move.ReadValue<Vector2>();
            inputVect *= Velocity;

            
            rb.velocity = new Vector3(inputVect.x, 0, inputVect.y);
        }
    }


    private void Move_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        moving = true;
        rb.drag = 0;
    }

    private void Move_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        moving = false;
        //DOTween.To(() => rb.velocity.x, x => rb.velocity.x, 0, 0.1);
        rb.drag = 2;
    }


}
