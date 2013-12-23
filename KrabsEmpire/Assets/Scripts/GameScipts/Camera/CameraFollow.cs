using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    private Transform playerToFollow;

    public int CameraOffSetX = 2;
    public int CameraOffSetY = 2;

    void Update()
    {
        if (playerToFollow == null)
        {
            playerToFollow = GameObject.FindGameObjectWithTag("Player").transform;
        }
        var targetX = Mathf.Lerp(transform.position.x, playerToFollow.position.x, CameraOffSetX * Time.deltaTime);
        var targetY = Mathf.Lerp(transform.position.y, playerToFollow.position.y, CameraOffSetY * Time.deltaTime);
        transform.position = new Vector3(targetX, targetY, transform.position.z);
        //transform.position = new Vector3(playerToFollow.transform.position.x, playerToFollow.transform.position.y, transform.position.z);
        
    }
}
