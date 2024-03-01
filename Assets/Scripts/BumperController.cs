using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    // Menyimpan variabel bola sebagai referensi untuk pengecekan
    public Collider bola;

    private void OnCollisionEnter(Collision collision)
    {
        // Pastikan yang menabrak adalah bola
        if (collision.gameObject.GetComponent<Collider>() == bola && bola != null)
        {
            // Lakukan debug
            Debug.Log("Kena Bola!");
        }
    }
}