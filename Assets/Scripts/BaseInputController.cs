﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cars
{


    public abstract class BaseInputController : MonoBehaviour
    {
        public float Acceleration { get; protected set; }
        // В Отн. ед.
        public float Rotate { get; protected set; }
        public event System.Action<bool> OnHandBrake;
        protected abstract void FixedUpdate();
        protected virtual void Start() { }
        protected void CallHandBrake(bool value) => OnHandBrake?.Invoke(value);


    }

}
