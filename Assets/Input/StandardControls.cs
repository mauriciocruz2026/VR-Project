//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Input/StandardControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @StandardControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @StandardControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""StandardControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay_01"",
            ""id"": ""ecab42df-6c81-48ed-b836-c6992a49f468"",
            ""actions"": [
                {
                    ""name"": ""Action_00"",
                    ""type"": ""Button"",
                    ""id"": ""c0227e02-acab-472f-a15a-583f97822132"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action_01"",
                    ""type"": ""Button"",
                    ""id"": ""831c01e1-3ff9-4702-9100-c483a060049e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action_02"",
                    ""type"": ""Button"",
                    ""id"": ""7df89f14-7ccc-4ec3-b396-fc4d86e7a463"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action_03"",
                    ""type"": ""Button"",
                    ""id"": ""e97637d2-90bc-4742-a408-7f71340be5ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action_04"",
                    ""type"": ""Button"",
                    ""id"": ""fbface2b-fd16-4308-bb77-a3ef351efba9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action_05"",
                    ""type"": ""Button"",
                    ""id"": ""668657b5-b7fb-4378-a216-f1eaa5cf8ffc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action_06"",
                    ""type"": ""Button"",
                    ""id"": ""de39d341-9964-4e30-8c0d-3ee5f53eb9db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a7b67417-259b-4e28-a6e4-9e9b81aca3e4"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_00"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""948beef4-2ca0-41f4-baa9-8dcbce705ff0"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_01"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b83cabcb-21c1-4e03-8c5f-202bd8543753"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_02"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13e5bd21-4944-464f-9365-d4b27f37e363"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_03"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6c7867b-3b30-4b74-8b8f-92983f144449"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_04"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ff1b65d-f7ab-493a-ae6f-271b4861b801"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_05"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""162690f7-3654-4d2c-a1c0-89bf63a9a629"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action_06"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay_01
        m_Gameplay_01 = asset.FindActionMap("Gameplay_01", throwIfNotFound: true);
        m_Gameplay_01_Action_00 = m_Gameplay_01.FindAction("Action_00", throwIfNotFound: true);
        m_Gameplay_01_Action_01 = m_Gameplay_01.FindAction("Action_01", throwIfNotFound: true);
        m_Gameplay_01_Action_02 = m_Gameplay_01.FindAction("Action_02", throwIfNotFound: true);
        m_Gameplay_01_Action_03 = m_Gameplay_01.FindAction("Action_03", throwIfNotFound: true);
        m_Gameplay_01_Action_04 = m_Gameplay_01.FindAction("Action_04", throwIfNotFound: true);
        m_Gameplay_01_Action_05 = m_Gameplay_01.FindAction("Action_05", throwIfNotFound: true);
        m_Gameplay_01_Action_06 = m_Gameplay_01.FindAction("Action_06", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay_01
    private readonly InputActionMap m_Gameplay_01;
    private List<IGameplay_01Actions> m_Gameplay_01ActionsCallbackInterfaces = new List<IGameplay_01Actions>();
    private readonly InputAction m_Gameplay_01_Action_00;
    private readonly InputAction m_Gameplay_01_Action_01;
    private readonly InputAction m_Gameplay_01_Action_02;
    private readonly InputAction m_Gameplay_01_Action_03;
    private readonly InputAction m_Gameplay_01_Action_04;
    private readonly InputAction m_Gameplay_01_Action_05;
    private readonly InputAction m_Gameplay_01_Action_06;
    public struct Gameplay_01Actions
    {
        private @StandardControls m_Wrapper;
        public Gameplay_01Actions(@StandardControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Action_00 => m_Wrapper.m_Gameplay_01_Action_00;
        public InputAction @Action_01 => m_Wrapper.m_Gameplay_01_Action_01;
        public InputAction @Action_02 => m_Wrapper.m_Gameplay_01_Action_02;
        public InputAction @Action_03 => m_Wrapper.m_Gameplay_01_Action_03;
        public InputAction @Action_04 => m_Wrapper.m_Gameplay_01_Action_04;
        public InputAction @Action_05 => m_Wrapper.m_Gameplay_01_Action_05;
        public InputAction @Action_06 => m_Wrapper.m_Gameplay_01_Action_06;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay_01; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Gameplay_01Actions set) { return set.Get(); }
        public void AddCallbacks(IGameplay_01Actions instance)
        {
            if (instance == null || m_Wrapper.m_Gameplay_01ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Gameplay_01ActionsCallbackInterfaces.Add(instance);
            @Action_00.started += instance.OnAction_00;
            @Action_00.performed += instance.OnAction_00;
            @Action_00.canceled += instance.OnAction_00;
            @Action_01.started += instance.OnAction_01;
            @Action_01.performed += instance.OnAction_01;
            @Action_01.canceled += instance.OnAction_01;
            @Action_02.started += instance.OnAction_02;
            @Action_02.performed += instance.OnAction_02;
            @Action_02.canceled += instance.OnAction_02;
            @Action_03.started += instance.OnAction_03;
            @Action_03.performed += instance.OnAction_03;
            @Action_03.canceled += instance.OnAction_03;
            @Action_04.started += instance.OnAction_04;
            @Action_04.performed += instance.OnAction_04;
            @Action_04.canceled += instance.OnAction_04;
            @Action_05.started += instance.OnAction_05;
            @Action_05.performed += instance.OnAction_05;
            @Action_05.canceled += instance.OnAction_05;
            @Action_06.started += instance.OnAction_06;
            @Action_06.performed += instance.OnAction_06;
            @Action_06.canceled += instance.OnAction_06;
        }

        private void UnregisterCallbacks(IGameplay_01Actions instance)
        {
            @Action_00.started -= instance.OnAction_00;
            @Action_00.performed -= instance.OnAction_00;
            @Action_00.canceled -= instance.OnAction_00;
            @Action_01.started -= instance.OnAction_01;
            @Action_01.performed -= instance.OnAction_01;
            @Action_01.canceled -= instance.OnAction_01;
            @Action_02.started -= instance.OnAction_02;
            @Action_02.performed -= instance.OnAction_02;
            @Action_02.canceled -= instance.OnAction_02;
            @Action_03.started -= instance.OnAction_03;
            @Action_03.performed -= instance.OnAction_03;
            @Action_03.canceled -= instance.OnAction_03;
            @Action_04.started -= instance.OnAction_04;
            @Action_04.performed -= instance.OnAction_04;
            @Action_04.canceled -= instance.OnAction_04;
            @Action_05.started -= instance.OnAction_05;
            @Action_05.performed -= instance.OnAction_05;
            @Action_05.canceled -= instance.OnAction_05;
            @Action_06.started -= instance.OnAction_06;
            @Action_06.performed -= instance.OnAction_06;
            @Action_06.canceled -= instance.OnAction_06;
        }

        public void RemoveCallbacks(IGameplay_01Actions instance)
        {
            if (m_Wrapper.m_Gameplay_01ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplay_01Actions instance)
        {
            foreach (var item in m_Wrapper.m_Gameplay_01ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Gameplay_01ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Gameplay_01Actions @Gameplay_01 => new Gameplay_01Actions(this);
    public interface IGameplay_01Actions
    {
        void OnAction_00(InputAction.CallbackContext context);
        void OnAction_01(InputAction.CallbackContext context);
        void OnAction_02(InputAction.CallbackContext context);
        void OnAction_03(InputAction.CallbackContext context);
        void OnAction_04(InputAction.CallbackContext context);
        void OnAction_05(InputAction.CallbackContext context);
        void OnAction_06(InputAction.CallbackContext context);
    }
}
