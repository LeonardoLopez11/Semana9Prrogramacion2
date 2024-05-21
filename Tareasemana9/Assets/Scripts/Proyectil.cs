using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public int damage = 10;

    void OnCollisionEnter(Collision collision)
    {
        VidaEnemigos vidaEnemigos = collision.gameObject.GetComponent<VidaEnemigos>();
        if (vidaEnemigos != null)
        {
            vidaEnemigos.TakeDamage(damage);
            Destroy(gameObject); 
        }
    }
}
