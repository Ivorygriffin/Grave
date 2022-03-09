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
                    ""name"": ""move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9fc1ae0d-f0c1-4595-89de-99b7821e3a7a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""cam"",
                    ""type"": ""Value"",
                    ""id"": ""e3fa7ae4-3a02-4340-92b1-04d871e153c4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""click"",
                    ""type"": ""Button"",
                    ""id"": ""80e19870-8d9f-4938-8bc4-c82117b12e5a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""mouseposition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f37814a7-951e-4fff-b974-58fdda175c83"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""04b0ae5a-35d4-4845-bafa-e5785ead059c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4e0a1f3c-bd83-4eda-afc4-09be0aa5ed80"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1c15dc73-5d4a-47a8-9674-e39e4f731f10"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d9ca1c55-a223-40bb-8f51-06a971acaffd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5050d0be-88e4-43c8-a202-960c8463e631"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d4f757fe-1712-4c64-a51c-0c5b7379e81e"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3667fd0e-a6ef-4096-9a31-904b280d21b4"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + mouse"",
                    ""action"": ""cam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8de1e009-3e8d-404f-8a57-637ad2d4716d"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""xbox"",
                    ""action"": ""cam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32d62482-4dca-4833-bc91-5e185306055f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + mouse"",
                    ""action"": ""click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f9b8112-1fa4-4a37-84db-9405b810add4"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard + mouse"",
                    ""action"": ""mouseposition"",
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
        m_Player_move = m_Player.FindAction("move", throwIfNotFound: true);
        m_Player_cam = m_Player.FindAction("cam", throwIfNotFound: true);
        m_Player_click = m_Player.FindAction("click", throwIfNotFound: true);
        m_Player_mouseposition = m_Player.FindAction("mouseposition", throwIfNotFound: true);
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
    private readonly InputAction m_Player_move;
    private readonly InputAction m_Player_cam;
    private readonly InputAction m_Player_click;
    private readonly InputAction m_Player_mouseposition;
    public struct PlayerActions
    {
        private @ControlMaster m_Wrapper;
        public PlayerActions(@ControlMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_Player_move;
        public InputAction @cam => m_Wrapper.m_Player_cam;
        public InputAction @click => m_Wrapper.m_Player_click;
        public InputAction @mouseposition => m_Wrapper.m_Player_mouseposition;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @cam.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCam;
                @cam.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCam;
                @cam.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCam;
                @click.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClick;
                @click.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClick;
                @click.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnClick;
                @mouseposition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseposition;
                @mouseposition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseposition;
                @mouseposition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseposition;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @cam.started += instance.OnCam;
                @cam.performed += instance.OnCam;
                @cam.canceled += instance.OnCam;
                @click.started += instance.OnClick;
                @click.performed += instance.OnClick;
                @click.canceled += instance.OnClick;
                @mouseposition.started += instance.OnMouseposition;
                @mouseposition.performed += instance.OnMouseposition;
                @mouseposition.canceled += instance.OnMouseposition;
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
        void OnMove(InputAction.CallbackContext context);
        void OnCam(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnMouseposition(InputAction.CallbackContext context);
    }
}
