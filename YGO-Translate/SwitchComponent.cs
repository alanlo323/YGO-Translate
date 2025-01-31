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
    public class SwitchComponent : MonoBehaviour
    {
        public static BepInEx.IL2CPP.UnityEngine.KeyCode key;

        public SwitchComponent(IntPtr ptr) : base()
        {
            BepInExLoader.log.LogMessage("Switch Component Constructor!");
        }

        [HarmonyPostfix]
        public static void Update()
        {
            if (Input.GetKeyInt(key) && Event.current.type == EventType.KeyDown && Event.current.control)
            {
                Translate.isActive = !Translate.isActive;
                BepInExLoader.log.LogMessage("YGO-Translate is " + (Translate.isActive ? "on" : "off"));
                Event.current.Use();
            }
        }
    }
}