using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cars
{
    public class PlayerInputController : BaseInputController
    {
        private CarControls _controls;

        [SerializeField]
        private bool gamePaused;
        public void SetGamePaused() => gamePaused = true;


        protected override void FixedUpdate()
        {
            if (!gamePaused)
             {
                //Rotation
                var direction = _controls.Car.Rotation.ReadValue<float>();

                if (direction == 0f && Rotate != 0f)
                {
                    Rotate = Rotate < 0f
                        ? Rotate + Time.fixedDeltaTime
                        : Rotate - Time.fixedDeltaTime;
                }
                else
                {
                    Rotate = Mathf.Clamp(Rotate + direction * Time.fixedDeltaTime, -1f, 1f);
                }

                //Drive
                Acceleration = _controls.Car.Acceleration.ReadValue<float>();
            }
           
            
        }

        protected override void Start()
        {
            base.Start();
            _controls.Car.HandBrake.performed += _ => CallHandBrake(true);
            _controls.Car.HandBrake.canceled += _ => CallHandBrake(false);
        }


        #region

        private void Awake()
        {
            _controls = new CarControls();
        }

        private void OnEnable()
        {
            _controls.Car.Enable();
        }

        private void OnDisable()
        {
            _controls.Car.Disable();
        }

        private void OnDestroy()
        {
            _controls.Dispose();
        }

        #endregion
    }
}
