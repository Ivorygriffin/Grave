// GENERATED AUTOMATICALLY FROM 'Assets/Input/controlMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControlMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""controlMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""5a5d3270-1d7d-409b-ba06-d16fa21e5dca"",
            ""actions"": [
                {
                    ""name"": ""moveup"",
                    ""type"": ""Button"",
                    ""id"": ""9fc1ae0d-f0c1-4595-89de-99b7821e3a7a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""movedown"",
                    ""type"": ""Button"",
                    ""id"": ""931bd6c3-f946-41da-90f3-a96fbf422a66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveleft"",
                    ""type"": ""Button"",
                    ""id"": ""742db507-ea81-48f9-9aeb-60b84862b9f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveright"",
                    ""type"": ""Button"",
                    ""id"": ""8b9166c8-67ae-4801-bc6b-b3976e44cddd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5743f2a9-59fa-457e-a1e1-1fcd32782f61"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""moveup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41ade66d-d530-4ed3-b741-d50c87494167"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + mouse"",
                    ""action"": ""moveup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb048c26-6570-4441-a9f9-551823b298b8"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""movedown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fed03792-6d0f-4279-92cc-c202baa2b07d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + mouse"",
                    ""action"": ""movedown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2567c226-5fca-4e32-9b49-0f1888a6cf2d"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""moveleft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0535059a-f47f-4789-9ec6-a15c4afe4e0c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + mouse"",
                    ""action"": ""moveleft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b9d421b-22e3-4cb3-a99c-45dc37153947"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""moveright"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eff1ccbf-7988-4523-a357-56231e858759"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + mouse"",
                    ""action"": ""moveright"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""xbox"",
            ""bindingGroup"": ""xbox"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard + mouse"",
            ""bindingGroup"": ""Keyboard + mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_moveup = m_Player.FindAction("moveup", throwIfNotFound: true);
        m_Player_movedown = m_Player.FindAction("movedown", throwIfNotFound: true);
        m_Player_moveleft = m_Player.FindAction("moveleft", throwIfNotFound: true);
        m_Player_moveright = m_Player.FindAction("moveright", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_moveup;
    private readonly InputAction m_Player_movedown;
    private readonly InputAction m_Player_moveleft;
    private readonly InputAction m_Player_moveright;
    public struct PlayerActions
    {
        private @ControlMaster m_Wrapper;
        public PlayerActions(@ControlMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @moveup => m_Wrapper.m_Player_moveup;
        public InputAction @movedown => m_Wrapper.m_Player_movedown;
        public InputAction @moveleft => m_Wrapper.m_Player_moveleft;
        public InputAction @moveright => m_Wrapper.m_Player_moveright;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @moveup.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveup;
                @moveup.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveup;
                @moveup.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveup;
                @movedown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovedown;
                @movedown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovedown;
                @movedown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovedown;
                @moveleft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveleft;
                @moveleft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveleft;
                @moveleft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveleft;
                @moveright.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveright;
                @moveright.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveright;
                @moveright.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveright;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @moveup.started += instance.OnMoveup;
                @moveup.performed += instance.OnMoveup;
                @moveup.canceled += instance.OnMoveup;
                @movedown.started += instance.OnMovedown;
                @movedown.performed += instance.OnMovedown;
                @movedown.canceled += instance.OnMovedown;
                @moveleft.started += instance.OnMoveleft;
                @moveleft.performed += instance.OnMoveleft;
                @moveleft.canceled += instance.OnMoveleft;
                @moveright.started += instance.OnMoveright;
                @moveright.performed += instance.OnMoveright;
                @moveright.canceled += instance.OnMoveright;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_xboxSchemeIndex = -1;
    public InputControlScheme xboxScheme
    {
        get
        {
            if (m_xboxSchemeIndex == -1) m_xboxSchemeIndex = asset.FindControlSchemeIndex("xbox");
            return asset.controlSchemes[m_xboxSchemeIndex];
        }
    }
    private int m_KeyboardmouseSchemeIndex = -1;
    public InputControlScheme KeyboardmouseScheme
    {
        get
        {
            if (m_KeyboardmouseSchemeIndex == -1) m_KeyboardmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard + mouse");
            return asset.controlSchemes[m_KeyboardmouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMoveup(InputAction.CallbackContext context);
        void OnMovedown(InputAction.CallbackContext context);
        void OnMoveleft(InputAction.CallbackContext context);
        void OnMoveright(InputAction.CallbackContext context);
    }
}
