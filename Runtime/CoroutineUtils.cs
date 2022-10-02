using System;
using System.Collections;
using UnityEngine;

namespace JoyTeam.Core
{
    public static class CoroutineUtils
    {
        public static IEnumerator ActionWithDelay(float time, Action callback)
        {
            yield return new WaitForSeconds(time);
            callback();
        }
    }
}