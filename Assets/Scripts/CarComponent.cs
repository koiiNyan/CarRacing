using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cars
{
    [RequireComponent(typeof(BaseInputController), typeof(WheelsComponent), typeof(Rigidbody))]
    public class CarComponent : MonoBehaviour
    {
        private BaseInputController _input;
        private WheelsComponent _wheels;
        private Rigidbody _body;

        [SerializeField, Min(1f)]
        private float _torque = 2500f;
        [SerializeField, Range(5f, 40f)]
        private float _maxSteerAngle = 25f;
        [SerializeField, Range(0f, float.MaxValue)]
        private float _brakeTorque = float.MaxValue;
        [SerializeField]
        private Vector3 _centerOfMass;
        [SerializeField]
        private bool gamePaused;


        public void SetGamePaused(bool pause) => gamePaused = pause;

        private void Awake()
        {
            gamePaused = true;
        }
        private void OnDrive()
        {
            var torque = _input.Acceleration * _torque / 2f;
            foreach (var wheel in _wheels.GetFrontWheelColliders) wheel.motorTorque = torque;
        }

        private void OnRotate()
        {
            _wheels.UpdateVisual(_input.Rotate * _maxSteerAngle);
        }


        private void FixedUpdate()
        {
            if (!gamePaused)
            {
                OnDrive();
                OnRotate();
                var rb = gameObject.GetComponent<Rigidbody>();
                rb.constraints = RigidbodyConstraints.None;
            }

            if(gamePaused)
            {
                foreach (var wheel in _wheels.GetFrontWheelColliders) wheel.motorTorque = 0f;
                var rb = gameObject.GetComponent<Rigidbody>();
                rb.constraints = RigidbodyConstraints.FreezePositionX;
               
            }
        }

        private void OnHandBrake(bool isHandBrake)
        {
            if (!gamePaused)
            {
                if (isHandBrake)
                {
                    foreach (var wheel in _wheels.GetRearWheelColliders)
                    {
                        wheel.brakeTorque = _brakeTorque;
                        wheel.motorTorque = 0f;
                    }
                }
                else
                {
                    foreach (var wheel in _wheels.GetRearWheelColliders)
                    {
                        wheel.brakeTorque = 0f;
                    }
                }
            }
        }

        private void Start()
        {
            _input = GetComponent<BaseInputController>();
            _wheels = GetComponent<WheelsComponent>();
            _body = GetComponent<Rigidbody>();

            _input.OnHandBrake += OnHandBrake;
            _body.centerOfMass = _centerOfMass;
        }


        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(transform.TransformPoint(_centerOfMass), .5f);
        }

        private void OnDestroy()
        {
            _input.OnHandBrake -= OnHandBrake;
        }
    }
}
