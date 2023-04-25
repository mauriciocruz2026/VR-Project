using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Handheld", menuName = "HandHeld", order = 1)]
public class HandheldScriptableObject : ScriptableObject
{
    public GameObject HandheldPrefab;
    public RuntimeAnimatorController RigAnimationController;

}
