﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Object = UnityEngine.Object;
using Input = BepInEx.IL2CPP.UnityEngine.Input;
using HarmonyLib;

namespace YGOTranslate
{
    public class DebugHelper : MonoBehaviour
    {
        public DebugHelper(IntPtr ptr) : base()
        {
            BepInExLoader.log.LogMessage("Debug Helper Constructor!");
        }

        [HarmonyPostfix]
        public static void Update()
        {
            if (Input.GetKeyInt(BepInEx.IL2CPP.UnityEngine.KeyCode.F9) && Event.current.type == EventType.KeyDown && Event.current.control)
            {
                BepInExLoader.log.LogMessage("Ctrl + F9 Pressed");
                // Data.SaveModifiedCards();
                Event.current.Use();
            }
        }
    }
}