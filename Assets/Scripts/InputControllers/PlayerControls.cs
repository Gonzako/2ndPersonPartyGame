// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputControllers/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Battle"",
            ""id"": ""d31c878b-a8f9-4cf4-a0b9-f6c7abc729ee"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""6337edac-b621-4cbc-8bea-c0ac32404116"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""6e888333-b892-4ec1-b071-5e4e1d929a5c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Deny"",
                    ""type"": ""Button"",
                    ""id"": ""bbfdced0-af91-4da6-898c-829045100b42"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Iterate"",
                    ""type"": ""Value"",
                    ""id"": ""05b217c5-c1fb-42aa-9dbc-980d7a26d830"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9bbff3be-035f-4164-9b79-1c38b49fdc4e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed0128e9-cf10-4164-a976-8ff3433f6e44"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4235ed01-ed2c-4d8a-a190-66778aca45f5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7bafa4df-81e8-4322-b874-11de16cd4d85"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB"",
                    ""action"": ""Deny"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""643bcd0c-496d-4054-9317-4176d9e4fb14"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB"",
                    ""action"": ""Deny"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""31a4138f-e7bc-44ba-a22d-c11607906d04"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b765da91-4d39-4d3f-bc68-1e4623908285"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""943a8733-6d38-4661-981c-fe572ba19820"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""87df5cc2-bed9-4127-a98d-1000d15b1f97"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d33a7027-0244-4160-9128-969b4faa0c8f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""12e17c69-a837-4557-a89e-6807a3a1654a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""04b592b8-87a1-46e3-ab20-1e19fddf12e4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""364e961d-3b6d-4532-997a-523a8142fafc"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4a25536b-8e88-4680-8fc0-4bd36c1fde69"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7730ec5c-5d30-4e84-8c75-7e48fbbb4500"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""8a429000-10a8-4c4f-9a0d-eabfc6bd5067"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Iterate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0a310413-f667-423d-9892-dcce7083faa3"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Iterate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1db6ceee-fdde-4ab1-95f9-28541c59476f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Iterate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KB"",
            ""bindingGroup"": ""KB"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Battle
        m_Battle = asset.FindActionMap("Battle", throwIfNotFound: true);
        m_Battle_Move = m_Battle.FindAction("Move", throwIfNotFound: true);
        m_Battle_Confirm = m_Battle.FindAction("Confirm", throwIfNotFound: true);
        m_Battle_Deny = m_Battle.FindAction("Deny", throwIfNotFound: true);
        m_Battle_Iterate = m_Battle.FindAction("Iterate", throwIfNotFound: true);
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

    // Battle
    private readonly InputActionMap m_Battle;
    private IBattleActions m_BattleActionsCallbackInterface;
    private readonly InputAction m_Battle_Move;
    private readonly InputAction m_Battle_Confirm;
    private readonly InputAction m_Battle_Deny;
    private readonly InputAction m_Battle_Iterate;
    public struct BattleActions
    {
        private @PlayerControls m_Wrapper;
        public BattleActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Battle_Move;
        public InputAction @Confirm => m_Wrapper.m_Battle_Confirm;
        public InputAction @Deny => m_Wrapper.m_Battle_Deny;
        public InputAction @Iterate => m_Wrapper.m_Battle_Iterate;
        public InputActionMap Get() { return m_Wrapper.m_Battle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BattleActions set) { return set.Get(); }
        public void SetCallbacks(IBattleActions instance)
        {
            if (m_Wrapper.m_BattleActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnMove;
                @Confirm.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnConfirm;
                @Deny.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnDeny;
                @Deny.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnDeny;
                @Deny.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnDeny;
                @Iterate.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnIterate;
                @Iterate.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnIterate;
                @Iterate.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnIterate;
            }
            m_Wrapper.m_BattleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Deny.started += instance.OnDeny;
                @Deny.performed += instance.OnDeny;
                @Deny.canceled += instance.OnDeny;
                @Iterate.started += instance.OnIterate;
                @Iterate.performed += instance.OnIterate;
                @Iterate.canceled += instance.OnIterate;
            }
        }
    }
    public BattleActions @Battle => new BattleActions(this);
    private int m_KBSchemeIndex = -1;
    public InputControlScheme KBScheme
    {
        get
        {
            if (m_KBSchemeIndex == -1) m_KBSchemeIndex = asset.FindControlSchemeIndex("KB");
            return asset.controlSchemes[m_KBSchemeIndex];
        }
    }
    public interface IBattleActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnDeny(InputAction.CallbackContext context);
        void OnIterate(InputAction.CallbackContext context);
    }
}
