using UnityEngine;
using System.Collections;

public class Fractal : MonoBehaviour {

	public Mesh mesh;
	public Material material;
	

	private void Start () {
		gameObject.AddComponent<MeshFilter> ().mesh = mesh;
		gameObject.AddComponent<MeshRenderer> ().material = material;
	}
}
