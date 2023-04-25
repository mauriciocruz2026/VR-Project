using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarrierSystem : MonoBehaviour, StandardControls.IGameplay_01Actions
{
    [SerializeField]
    private Transform RigSocket;

    [SerializeField]
    private Animator RigAnimator;

    public List<HandheldScriptableObject> EquipableHandheld;

    private HandheldScriptableObject current_handheld_scriptableobject;
    private GameObject current_handheld_gameobject;
    private IHandHeldObject current_handheld_interface;
    private int current_handheld_index;

    public Animator GetAnimator()
    {
        return RigAnimator;
    }

    private void Awake()
    {
        SwitchHandheld(EquipableHandheld[0]);
    }

    public void SwitchHandheld(HandheldScriptableObject handheld)
    {
        if (current_handheld_scriptableobject == handheld)
            return;
        Destroy(current_handheld_gameobject);

        current_handheld_scriptableobject = handheld;
        current_handheld_gameobject = Instantiate(current_handheld_scriptableobject.HandheldPrefab, RigSocket, true);
        current_handheld_gameobject.transform.localPosition = Vector3.zero;
        current_handheld_gameobject.transform.localRotation = Quaternion.identity;

        current_handheld_interface = current_handheld_gameobject.GetComponentInChildren<IHandHeldObject>(); 

        if (current_handheld_interface != null)
        {
            current_handheld_interface.OnAttachedCarrier(this);
            current_handheld_interface.OnEquip();

            RigAnimator.runtimeAnimatorController = handheld.RigAnimationController; 
        }
        else
        {
            DestroyImmediate(current_handheld_gameobject);
            current_handheld_scriptableobject = null;
            current_handheld_interface = null;
            current_handheld_gameobject = null; 
        }
    }

    public void OnAction_00(InputAction.CallbackContext context)
    {
        if (current_handheld_interface != null)
        {
            current_handheld_interface.OnAction_00(context);
        }
    }

    public void OnAction_01(InputAction.CallbackContext context)
    {
        if (current_handheld_interface != null)
        {
            current_handheld_interface.OnAction_01(context);
        }
    }

    public void OnAction_02(InputAction.CallbackContext context)
    {
        if (current_handheld_interface != null)
        {
            current_handheld_interface.OnAction_02(context);
        }
    }

    public void OnAction_03(InputAction.CallbackContext context)
    {
        if (current_handheld_interface != null)
        {
            current_handheld_interface.OnAction_03(context);
        }
    }

    public void OnAction_04(InputAction.CallbackContext context)
    {
        if (current_handheld_interface != null)
        {
            current_handheld_interface.OnAction_04(context);
        }
    }

    public void OnAction_05(InputAction.CallbackContext context)
    {
        if (current_handheld_interface != null)
        {
            current_handheld_interface.OnAction_05(context);
        }
    }

    public void OnAction_06(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            current_handheld_index += 1 * (int)Mathf.Sign(context.ReadValue<float>());
            current_handheld_index = Mathf.Clamp(current_handheld_index, 0, EquipableHandheld.Count - 1);

            SwitchHandheld(EquipableHandheld[current_handheld_index]);
        }

        if (current_handheld_interface != null)
        {
            current_handheld_interface.OnAction_06(context);
        }
    }
}
