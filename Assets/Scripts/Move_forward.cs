using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_forward : MonoBehaviour
{
    public float speed = 40f;


    private void Update()
    {
        //funcion que hace mover hacia delante a la velocidad indicada
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
