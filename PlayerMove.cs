using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//en ambos archivos faltaria unir el script con el player/camara
//por ej aca en unity hay que arrastrar el character controller al script "Player Move"
//por ej2 en unity hay que arrastrar el playerBody de la jerarquia  al script "Camera Look" 
//HACER UN OBJ GROUND CHECK(UNITY) PARA VERIFICAR QUE ESTAMOS EN EL PISO Y COMO AFECTARIA AL PERSONAJE EN CASO DE SALTAR/MOVERSE
//ej3 en unity ARRASTRAR variables "Ground Check" (jump/ground check y distance/mask) hacia el script de "Player Move"
//en cuanto a la variable de mask, se va a la pestaña de LAYERS y se asigna en la de GROUND. Se le asigna la variable a todos los objetos del mapa que esten al piso

public class PlayerMove : MonoBehaviour
//variables para el movimiento de arriba a abajo/cabeza del jugador
public CharacterController controller;
public float speed = 10f;


//variables para validar el groundCheck
public float gravity = -9.8f; //fuerza de gravedad que nos atrae, variable modificable
public float jumpHeight = 3; //altura que quiere saltar
public Transform groundCheck; //referencia para saber donde queda nuestra player
public float groundDistance = 0.3f; //distancia a que tenemos el piso
public LayerMask groundMask; 
Vector3 velocity; //velocidad de nuestro personaje, velocidad etc
bool isGrounded; 

{
    void Start()
    {
        
    }

    void Update()
    {
        isGrounded = Physics.checkSphere(groundCheck.position; groundDistance, groundMask);
        if (isGrounded && velocity.y <0){
            velocity.y = -2f; //siempre es flotante, por eso se pone la f
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical"); //guarda la tecla hacia arriba o abajo para mover la camara

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move (move * speed *Time.deltaTime);

        if (Input.GetButtonDown("Space") && isGrounded){
            velocity.y = Mathf.Sqrt (jumpHeight * -2 * gravity); //formula de fisica para un SALTO
        }

        velocity.y += gravity * Time.deltaTime; //fuerza de atraccion de la gravedad
        controller.Move(velocity* Time.deltaTime); //control que toma en cuenta la velocidad
    }
}