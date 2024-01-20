using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variables
    public GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(0, 5, -7); //This new Object is passed to Vehicle so it follows it
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()     //LateUpdate moves camera after car moves so removes stutter
    {
        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
