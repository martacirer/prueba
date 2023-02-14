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

	public GameObject target;

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

			ani.SetBool("run", false);
			cronometro += 1 * Time.deltaTime;
			if(cronometro >= 4)
			{
				rutina = Random.Range(0, 2);
			}
				switch(rutina)
			{
				case 0:
					ani.SetBool("walk", false);
					break;

				case 1:
					grado = Random.Range(0, 360);
					angulo = Quaternion.Euler(0, grado, 0);
					rutina++;
					break;

				case 2:
					transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
					transform.Translate(Vector3.forward * 1 * Time.deltaTime);
					ani.SetBool("walk", true);
					break;
				}
		}
		else
		{
			var lookPos = target.transform.position - transform.position;
			lookPos.y = 0;
			var rotation = Quaternion.LookRotation(lookPos);
			transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
			ani.SetBool("walk", false);

			ani.SetBool("run", true);
			transform.Translate(Vector3.forward * 2 * Time.deltaTime);
		}
	}

	void Update()
	{
		Comportamiento_enemigo();
	}
}
