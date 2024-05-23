using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector3.up);
    }
}
