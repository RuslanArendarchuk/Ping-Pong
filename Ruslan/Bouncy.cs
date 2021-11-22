using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            // Дає силу м'ячу в потилежному напрямку щоб він відскочив 
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
        }
    }
}
