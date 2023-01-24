using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    private float xrange = 15f; //Limite horizontal
    private float speed = 10f; //Velocidad del jugador
    private float horizontalInput;
    public GameObject proyectilePrefab;

    private void Update()
    {
        //Movimiento horizontal del jugador
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        PlayerinBounds();//Mantiene le player en el entorno de juego
        //Mecanica de disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Firepoyectile();
        }
    }

    //Funcion para mantener el jugador en los limites horizontales de la pantalla
    private void PlayerinBounds()
    {
        Vector3 pos = transform.position;
        if(pos.x < -xrange)
        {
            transform.position = new Vector3(-xrange, pos.y, pos.z);
        }
        if(pos.x > xrange)
        {
            transform.position = new Vector3(xrange, pos.y, pos.z);
        }
    }
    //Función para disparar proyectiles
    private void Firepoyectile()
    {
        Instantiate(proyectilePrefab, transform.position, Quaternion.identity);
    }
}
