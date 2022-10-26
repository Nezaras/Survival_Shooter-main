using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPickup : Pickup
{
    public float SpeedMult = 2.5f;
    public float MultTimer = 10f;

    public override void OnPlayerEnter(Collider player)
    {
        GameOverManager gameOverManager = FindObjectOfType<GameOverManager>();

        PlayerMovement playerMove = player.GetComponent<PlayerMovement>();

        if(gameOverManager != null)
        {
            gameOverManager.ShowSpeedUpText();
        }

        playerMove.AddMoveMult(SpeedMult, MultTimer);
    }
}
