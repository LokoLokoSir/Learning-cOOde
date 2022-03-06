using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Transform pivot;
    private void FixedUpdate() {
        transform.position = Vector2.Lerp(pivot.position, player.position, 0.1f);
    }
}