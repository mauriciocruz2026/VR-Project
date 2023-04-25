using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandHeldBranch : MonoBehaviour, IHandHeldObject
{

    private CarrierSystem carrierSystem; 

    public void OnAction_00(InputAction.CallbackContext context)
    {

    }

    public void OnAction_01(InputAction.CallbackContext context) 
    { 
    }

    public void OnAction_02(InputAction.CallbackContext context)
    {
    }

    public void OnAction_03(InputAction.CallbackContext context) 
    { 
    }

    public void OnAction_04(InputAction.CallbackContext context) 
    { 
    }

    public void OnAction_05(InputAction.CallbackContext context)
    {

    }

    public void OnAction_06(InputAction.CallbackContext context) 
    { 
    }

    public void OnUnequip()
    {

    }
    
    public void OnEquip()
    {

    }

    public void OnAttachedCarrier(CarrierSystem carrier)
    {
        carrierSystem = carrier; 
    }

}


