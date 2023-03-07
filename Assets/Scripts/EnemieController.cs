using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieController : MonoBehaviour
{
	public int rutina;
	public float cronometro;
	public Animator ani;
	public Quaternion angulo;
	public float grado;

	public bool atacando;
	public bool caminando;
	public bool corriendo;

	public GameObject target;

	public float Speed;


	

	void Start()
	{
		ani = GetComponent<Animator>();
		target = GameObject.Find("player");
	}

	public void Comportamiento_enemigo()
	{
	//cuando el jugador este fuera del rango del enemigo hara rutina de caminar aleatoriamente
		if(Vector3.Distance(transform.position, target.transform.position) >50)
		{

			corriendo = false;
			cronometro +=  Time.deltaTime;
			if(cronometro >= 4)
			{
				rutina = Random.Range(0, 3);
				cronometro = 0;
			}
				switch(rutina)
			{
				case 0:
					caminando = false;
					break;

				case 1:
					grado = Random.Range(0, 360);
					angulo = Quaternion.Euler(0, grado, 0);
					rutina++;
					break;

				case 2:
					transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
					transform.Translate(Vector3.forward *Speed* Time.deltaTime);
					caminando = true;
					break;
				}
		}
		else
		{
			


			if(Vector3.Distance(transform.position, target.transform.position) > 2.1f && !atacando)
			{

			
				var lookPos = target.transform.position - transform.position;
				lookPos.y = 0;
				var rotation = Quaternion.LookRotation(lookPos);
				transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
				caminando = false;

				corriendo = true;
				transform.Translate(Vector3.forward * 1.5f * Speed * Time.deltaTime);

				atacando = false;
			}
			else
			{
			Debug.Log("ataque");
			caminando = false;
			corriendo = false;

			atacando = true;
			}
		}
	}


	void Update()
	{
		Comportamiento_enemigo();
	}

	private void LateUpdate()
	{
		ani.SetBool("attack", atacando);
		ani.SetBool("walk", caminando);
		ani.SetBool("run", corriendo);
					
		atacando = false;

	}
}