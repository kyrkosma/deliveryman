using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] GameObject thingToFollow;

    // Camera's position should be same as the car's
    void LateUpdate() {
        transform.position = thingToFollow.transform.position + new Vector3 (0, 0, -10);
    }
}
