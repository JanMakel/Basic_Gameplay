using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_out_of_bounds : MonoBehaviour
{
    private float upperlimit = 20f;
    private float lowerlimit = -10f;

    private void Update()
    {
        //Limite inferior -> Animales
        if(transform.position.z < lowerlimit) {
            Destroy(gameObject);
            //Mecanica de Game over
            Debug.Log("GAME OVER"); 
            Time.timeScale = 0;
        }
        //Limite Superior -> Proyectiles
        if(transform.position.z > upperlimit)
        {
            Destroy(gameObject);
        }
    }
    
}
