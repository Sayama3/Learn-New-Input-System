// GENERATED AUTOMATICALLY FROM 'Assets/Profiles/PlayerController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""2a0967eb-9b0d-4a1b-932f-f3d2981f9137"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""81549bed-862c-444f-b2d6-24fb635a1024"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""03ca59fb-c1e1-4458-a338-ac7b89975c35"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Strife"",
                    ""type"": ""Value"",
                    ""id"": ""bf254a1a-86f5-4e12-b1cb-41d833bcafbb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""27706a29-938e-4070-8eb5-2e50613dfc40"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""063f7579-ac2e-4a49-983a-852cf2262ca9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c8f9ed87-a5ce-4ff4-838c-b6e591b84f8b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""4752d767-eb5e-4cc9-8ce6-45e0e7ecbfcd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Direction"",
                    ""id"": ""8deb182b-df96-4776-a12a-86c7a4131f06"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""02b19a23-51bd-4a1f-842c-3f086290fc1f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cf650f67-65a2-44dd-8462-79662fba029f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6747fcfe-c887-436b-a7be-c0901063c7df"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""07660826-5279-44b0-9516-cabc7f3eae98"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""aed934ff-f2ea-4eba-9aa4-d1888bbcd592"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Strife"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da8578d2-3db5-46e1-80de-7bb44f4400e2"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1094fea-fd7d-4c14-85f0-ee5e4ff64095"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b14a881-5e6c-415d-a970-30b8858b544c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d604d0ad-33ff-4725-a95f-1a508c565fd0"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b52de92-4200-4f89-89fa-ccba40c858e4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
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
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Movement = m_GamePlay.FindAction("Movement", throwIfNotFound: true);
        m_GamePlay_Camera = m_GamePlay.FindAction("Camera", throwIfNotFound: true);
        m_GamePlay_Strife = m_GamePlay.FindAction("Strife", throwIfNotFound: true);
        m_GamePlay_Run = m_GamePlay.FindAction("Run", throwIfNotFound: true);
        m_GamePlay_Attack = m_GamePlay.FindAction("Attack", throwIfNotFound: true);
        m_GamePlay_Jump = m_GamePlay.FindAction("Jump", throwIfNotFound: true);
        m_GamePlay_Shoot = m_GamePlay.FindAction("Shoot", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_Movement;
    private readonly InputAction m_GamePlay_Camera;
    private readonly InputAction m_GamePlay_Strife;
    private readonly InputAction m_GamePlay_Run;
    private readonly InputAction m_GamePlay_Attack;
    private readonly InputAction m_GamePlay_Jump;
    private readonly InputAction m_GamePlay_Shoot;
    public struct GamePlayActions
    {
        private @PlayerController m_Wrapper;
        public GamePlayActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_GamePlay_Movement;
        public InputAction @Camera => m_Wrapper.m_GamePlay_Camera;
        public InputAction @Strife => m_Wrapper.m_GamePlay_Strife;
        public InputAction @Run => m_Wrapper.m_GamePlay_Run;
        public InputAction @Attack => m_Wrapper.m_GamePlay_Attack;
        public InputAction @Jump => m_Wrapper.m_GamePlay_Jump;
        public InputAction @Shoot => m_Wrapper.m_GamePlay_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMovement;
                @Camera.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCamera;
                @Strife.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStrife;
                @Strife.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStrife;
                @Strife.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStrife;
                @Run.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRun;
                @Attack.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnAttack;
                @Jump.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJump;
                @Shoot.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Strife.started += instance.OnStrife;
                @Strife.performed += instance.OnStrife;
                @Strife.canceled += instance.OnStrife;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IGamePlayActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnStrife(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
}
