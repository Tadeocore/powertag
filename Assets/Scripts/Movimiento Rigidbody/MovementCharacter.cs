using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCharacter : MonoBehaviour
{
	//Declaro la variable de tipo RigidBody que luego asociaremos a nuestro Jugador
	private Rigidbody rb;

	//Declaro la variable pública velocidad para poder modificarla desde la Inspector window
	[Range(5,20)]
	public float velocidad = 15;
	
	public float rotacion = 90;

	void Start()
	{

		//Capturo el rigidbody del jugador al iniciar el juego
		rb = GetComponent<Rigidbody>();

	}

	void FixedUpdate()
	{

		//Capturo el movimiento en horizontal y vertical de nuestro teclado
		float movimientoH = Input.GetAxis("Horizontal");
		float movimientoV = Input.GetAxis("Vertical");
		float movimientoA = 1.5f;

		//Genero el vector de movimiento asociado, teniendo en cuenta la velocidad
		Vector3 movimiento = new Vector3(movimientoH * velocidad, movimientoA, movimientoV * velocidad);
		transform.rotation = Quaternion.Euler(0f, movimientoH*rotacion, 0f);
		
		if(movimientoV == -1) transform.rotation = Quaternion.Euler(0f, 180f, 0f);

		//Aplico ese movimiento al RigidBody del jugador
		rb.AddForce(movimiento);
	}
}
