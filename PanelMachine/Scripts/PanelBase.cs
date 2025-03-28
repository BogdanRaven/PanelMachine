﻿using UnityEngine;

namespace Game.Mephistoss.PanelMachine.Scripts
{
    public class PanelBase : MonoBehaviour
    {
        protected PanelMachine machine;

        public virtual void Enter(PanelMachine machineInstance)
        {
            machine = machineInstance;
            Debug.Log("Enter panel: " + "(script name:" + name + "//" + "gameObjectName" + gameObject.name + ")");
        }

        public virtual void Exit(PanelMachine machineInstance)
        {
            machine = machineInstance;
            Debug.Log("Exit panel: " + "(script name:" + name + "//" + "gameObjectName" + gameObject.name + ")");
        }

        public virtual bool CanExit() => true;

        public virtual void EscapeKeyPressed()
        {
        }
    }
}