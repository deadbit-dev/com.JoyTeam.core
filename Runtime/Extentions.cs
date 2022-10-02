using System;
using UnityEngine;

namespace JoyTeam.Core
{
    public static class Extentions
    {
        public static Coroutine ActionWithDelay(this MonoBehaviour script, Action callback, float time)
        {
            return script.StartCoroutine(CoroutineUtils.ActionWithDelay(time, callback));
        }
    }
}