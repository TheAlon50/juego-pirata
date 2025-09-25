using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimiento : MonoBehaviour
{
    public float velocidad = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float velocidadx = Input.GetAxis("Horizontal") * Time.deltaTime * velocidad;
        float velocidady = Input.GetAxis("Vertical") * Time.deltaTime * velocidad;

        Vector2 posicion = transform.position;

        transform.position = new Vector2(velocidadx + posicion.x, velocidady + posicion.y);

    }
}
