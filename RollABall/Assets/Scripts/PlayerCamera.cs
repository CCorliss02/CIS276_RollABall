using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private GameObject player;
    private Vector3 cameraOffset;

    public void Awake()
    {
        player = FindObjectOfType<PlayerMovement>().gameObject;
    }

    void Start()
    {
        cameraOffset = transform.position - player.transform.position;
    }

    void Update()
    {
        transform.position = cameraOffset + player.transform.position;
    }
}
