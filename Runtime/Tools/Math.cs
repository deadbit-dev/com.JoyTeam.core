using UnityEngine;
using JoyTeam.Core.DataType;

namespace JoyTeam.Core.Tools
{
    public static class Math
    {
        public static Vector3 RandomInUnitCube()
        {
            return new Vector3(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f)
            );
        }

        public static Vector3 RandomInCube(Cube cube)
        {
            Vector3 point = RandomInUnitCube();

            point.x = Mathf.Lerp(cube.Base.x, cube.Base.size.x, point.x);
            point.y = Mathf.Lerp(cube.Height * 0.5f, cube.Height, point.y);
            point.z = Mathf.Lerp(cube.Base.y, cube.Base.size.y, point.z);

            return point; 
        }
    }
}