using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_player : MonoBehaviour {

    public GameObject player;

    public float timeOffset;

    public Vector2 posOffset;

    public float leftLimit;

    public float rightLimit;

    public float bottomLimit;

    public float topLimit;

    private Vector3 velocity;

    private void Start() {}

    // Update is called once per frame
    void Update () {
        //cameras curreent position
        Vector3 startPos = transform.position;

        //Players current position
        Vector3 endPos = player.transform.position;

        endPos.x += posOffset.x;
        endPos.y += posOffset.y;
        endPos.z = -10;

        //smoothly move the camera towards the player's position
        transform.position = Vector3.Lerp(startPos, endPos, timeOffset * Time.deltaTime);

        transform.position = new Vector3
        (
            Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
            Mathf.Clamp(transform.position.y, bottomLimit, topLimit),
            transform.position.z
        );
    }
}