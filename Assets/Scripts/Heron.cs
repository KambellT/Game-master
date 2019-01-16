using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heron : MonoBehaviour
{

    // Unity calls this function automatically
    // when our spikes touch any other object
    private void OnCollisionEnter2D(Collision2D collision)
    {

        // Check if the thing that we collided with
        // is the player (aka has a Player script)
        Frog playerScript = collision.collider.GetComponent<Frog>();

        // Only do something if the thing we ran into
        // was in fact the player
        // aka playerScript is not null
        if (playerScript != null)
        {
            // We DID hit the player!

            // KILL THEM
            playerScript.Kill();
        }
    }


}
