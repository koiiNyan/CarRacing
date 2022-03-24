// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/CarControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Cars
{
    public class @CarControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @CarControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""CarControls"",
    ""maps"": [
        {
            ""name"": ""Car"",
            ""id"": ""73eb4b09-8cf7-4c11-acaf-1287b96182ba"",
            ""actions"": [
                {
                    ""name"": ""HandBrake"",
                    ""type"": ""Button"",
                    ""id"": ""cb66f2d9-0eb2-42cb-bb04-783c4ecd8ed5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""Button"",
                    ""id"": ""546b1dce-82bf-48ae-a3f5-a9bf04e1fc86"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Button"",
                    ""id"": ""ba7b2f7f-393a-4659-9003-a6c324049c2a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b9f4ce9d-99a0-499b-af90-0d8e13ddb77b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HandBrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""f91429cd-0ef2-4275-9d43-d6b35d76962c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""400781cd-36bc-42e0-9843-274ce5bca1cd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""312df234-3f47-49ae-80c3-9420bdb7ccb5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""eca67892-9b38-4d90-bfa5-facba2437e8f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a9ebc486-05c1-440a-88bf-f7041e38dfc6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""618c0e5f-39fd-4164-9a91-36437d93091d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Car
            m_Car = asset.FindActionMap("Car", throwIfNotFound: true);
            m_Car_HandBrake = m_Car.FindAction("HandBrake", throwIfNotFound: true);
            m_Car_Acceleration = m_Car.FindAction("Acceleration", throwIfNotFound: true);
            m_Car_Rotation = m_Car.FindAction("Rotation", throwIfNotFound: true);
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

        // Car
        private readonly InputActionMap m_Car;
        private ICarActions m_CarActionsCallbackInterface;
        private readonly InputAction m_Car_HandBrake;
        private readonly InputAction m_Car_Acceleration;
        private readonly InputAction m_Car_Rotation;
        public struct CarActions
        {
            private @CarControls m_Wrapper;
            public CarActions(@CarControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @HandBrake => m_Wrapper.m_Car_HandBrake;
            public InputAction @Acceleration => m_Wrapper.m_Car_Acceleration;
            public InputAction @Rotation => m_Wrapper.m_Car_Rotation;
            public InputActionMap Get() { return m_Wrapper.m_Car; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CarActions set) { return set.Get(); }
            public void SetCallbacks(ICarActions instance)
            {
                if (m_Wrapper.m_CarActionsCallbackInterface != null)
                {
                    @HandBrake.started -= m_Wrapper.m_CarActionsCallbackInterface.OnHandBrake;
                    @HandBrake.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnHandBrake;
                    @HandBrake.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnHandBrake;
                    @Acceleration.started -= m_Wrapper.m_CarActionsCallbackInterface.OnAcceleration;
                    @Acceleration.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnAcceleration;
                    @Acceleration.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnAcceleration;
                    @Rotation.started -= m_Wrapper.m_CarActionsCallbackInterface.OnRotation;
                    @Rotation.performed -= m_Wrapper.m_CarActionsCallbackInterface.OnRotation;
                    @Rotation.canceled -= m_Wrapper.m_CarActionsCallbackInterface.OnRotation;
                }
                m_Wrapper.m_CarActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @HandBrake.started += instance.OnHandBrake;
                    @HandBrake.performed += instance.OnHandBrake;
                    @HandBrake.canceled += instance.OnHandBrake;
                    @Acceleration.started += instance.OnAcceleration;
                    @Acceleration.performed += instance.OnAcceleration;
                    @Acceleration.canceled += instance.OnAcceleration;
                    @Rotation.started += instance.OnRotation;
                    @Rotation.performed += instance.OnRotation;
                    @Rotation.canceled += instance.OnRotation;
                }
            }
        }
        public CarActions @Car => new CarActions(this);
        public interface ICarActions
        {
            void OnHandBrake(InputAction.CallbackContext context);
            void OnAcceleration(InputAction.CallbackContext context);
            void OnRotation(InputAction.CallbackContext context);
        }
    }
}
