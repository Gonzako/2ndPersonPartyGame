using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delayedMovement : MonoBehaviour
{
    public float waitTime = 0.5f;
    public float Velocity = 10f;

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
            var velocity = new Vector3(inputVect.x, 0, inputVect.y);
            StartCoroutine(delayedVelocitySet(velocity, waitTime));
        }
    }


    private void Move_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        moving = true;
        StartCoroutine(delayedDragSet(0, waitTime));
    }

    private void Move_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        moving = false;
        //DOTween.To(() => rb.velocity.x, x => rb.velocity.x, 0, 0.1);
        StartCoroutine(delayedDragSet(2, waitTime));
    }

    IEnumerator delayedVelocitySet(Vector3 velocity, float time)
    {
        yield return new WaitForSeconds(time);
        rb.velocity = velocity;
    }

    IEnumerator delayedDragSet(float drag, float time)
    {
        yield return new WaitForSeconds(time);
        rb.drag = drag;
    }
}
