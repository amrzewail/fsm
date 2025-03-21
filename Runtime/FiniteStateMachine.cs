﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FiniteStateMachine
{
    public class FiniteStateMachine : MonoBehaviour
    {
        [SerializeField] private FSMRunner finiteStateMachine;

        private void Awake()
        {
            finiteStateMachine.Awake();
        }

        private void Update()
        {
            finiteStateMachine.Update();
        }
    }
}