using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
	[Tooltip("The direction and speed in units per second the object spins.")]
    public Vector3 SpinMagnitude;

    private void Update()
    {
        transform.Rotate(SpinMagnitude * Time.deltaTime);
    }
}
