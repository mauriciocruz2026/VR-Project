using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHandHeldObject : StandardControls.IGameplay_01Actions

{
    void OnAttachedCarrier(CarrierSystem attachedCarrier);
    void OnEquip();
    void OnUnequip();
}
