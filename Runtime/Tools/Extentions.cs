using System;

using UnityEngine;

namespace JoyTeam.Core.Tools
{
    public static class Extentions
    {
        public static Coroutine ActionWithDelay(this MonoBehaviour script, Action callback, float time)
        {
            return script.StartCoroutine(Coroutines.ActionWithDelay(time, callback));
        }
    }
}