using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerEvents : MonoBehaviour
{
    public static playerEvents Instance
    {
        get
        {
            if(_instance == null)
            {
                var GO = new GameObject("Player Input")
                    .AddComponent<playerEvents>();
                GO.gameObject.hideFlags = HideFlags.HideAndDontSave;
                _instance = GO;
            }
            return _instance;
        }
    }

    #region Events
    /// <summary>
    /// Vector2 is actual input bool is whether we are holding input
    /// </summary>
    public event Action<Vector2, bool> onMove;
    public event Action onConfirm;
    public event Action onDeny;
    public event Action<float, bool> onIterate;
    public PlayerControls Controls { get { return controls; } }
    #endregion


    #region PrivateFields
    private static playerEvents _instance;

    private const float rate = 0.15f;

    private PlayerControls controls;
    private Coroutine moveLoop;
    private Coroutine iterateLoop;
    #endregion

    #region UnityAPI
    private void Awake()
    {
        controls = new PlayerControls();
    }

    private void OnEnable()
    {

        controls.Battle.Enable();

        controls.Battle.Move.canceled -= Move_canceled;
        controls.Battle.Confirm.performed -= Confirm_performed;
        controls.Battle.Move.started -= Move_started;
        controls.Battle.Confirm.performed -= Confirm_performed;
        controls.Battle.Deny.performed -= Deny_performed;

        controls.Battle.Confirm.performed += Confirm_performed;
        controls.Battle.Deny.performed += Deny_performed;
        controls.Battle.Move.performed += Move_performed;
        controls.Battle.Move.canceled += Move_canceled;
        controls.Battle.Move.started += Move_started;

        controls.Battle.Iterate.started += Iterate_started;
        controls.Battle.Iterate.performed += Iterate_performed;
        controls.Battle.Iterate.canceled += Iterate_canceled;
    }


    private void OnDisable()
    {
        controls.Battle.Deny.performed -= Deny_performed;
        controls.Battle.Confirm.performed -= Confirm_performed;
        controls.Battle.Move.performed -= Move_performed;
        controls.Battle.Move.canceled -= Move_canceled;
        controls.Battle.Move.started -= Move_started;
        controls.Battle.Iterate.started -= Iterate_started;
        controls.Battle.Iterate.performed -= Iterate_performed;
        controls.Battle.Iterate.canceled -= Iterate_canceled;

        
    }

    #endregion


    #region PrivateMethods
    private void Deny_performed(InputAction.CallbackContext obj)
    {
        onDeny?.Invoke();
    }
    private void Move_started(InputAction.CallbackContext ctx)
    {
        onMove?.Invoke(ctx.ReadValue<Vector2>(), false);
    }

    private void Move_canceled(InputAction.CallbackContext ctx)
    {
        if (moveLoop != null)
        {
            StopCoroutine(moveLoop);
            moveLoop = null;
        }
    }

    private void Move_performed(InputAction.CallbackContext ctx)
    {
        onMove?.Invoke(controls.Battle.Move.ReadValue<Vector2>(), true);
        moveLoop = StartCoroutine(moveCycle());
    }

    private void Confirm_performed(InputAction.CallbackContext ctx)
    {
        onConfirm?.Invoke();
    }

    private IEnumerator moveCycle()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(rate);
            onMove?.Invoke(controls.Battle.Move.ReadValue<Vector2>(), true);
        }
    }


    private void Iterate_performed(InputAction.CallbackContext obj)
    {
        Debug.Log(controls.Battle.Iterate.ReadValue<float>());
        onIterate?.Invoke(controls.Battle.Iterate.ReadValue<float>(), true);
        iterateLoop = StartCoroutine(iterateCycle());

    }

    private void Iterate_started(InputAction.CallbackContext obj)
    {

        Debug.Log(controls.Battle.Iterate.ReadValue<float>());
        onIterate?.Invoke(obj.ReadValue<float>(), false);
    }

    private void Iterate_canceled(InputAction.CallbackContext obj)
    {
        if(iterateLoop != null)
            StopCoroutine(iterateLoop);
    }

    private IEnumerator iterateCycle()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(rate);
            onIterate?.Invoke(controls.Battle.Iterate.ReadValue<float>(), true);

            Debug.Log(controls.Battle.Iterate.ReadValue<float>());
        }
    }


    #endregion



}
