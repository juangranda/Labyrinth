using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;

		//Camera.mainCamera.transform.eulerAngles = Vector3.Lerp(Camera.mainCamera.transform.eulerAngles, new Vector3(90, 0, 0), Time.deltaTime*speed);
	}
}
