using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShoot : MonoBehaviour {

	public int gunDamage = 1; 
	public float fireRate = 0.25f;
	public float weaponRange = 50f; 
	public float hitForce = 100f;
	public Transform gunEnd;

	private Camera fpsCam;
	private WaitForSeconds shotDuration = new WaitForSeconds(0.7f);
	private AudioSource gunAudio;
	private LineRenderer laserLine;
	private float nextFire;

	void Start () {

	}


	void Update () {

	}
}
