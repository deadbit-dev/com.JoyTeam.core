using System;
using System.Collections;

using UnityEngine;

namespace JoyTeam.Core.Tools
{
    public static class Coroutines
    {
        public static IEnumerator ActionWithDelay(float time, Action callback)
        {
            yield return new WaitForSeconds(time);
            callback();
        }
    }
}