using UnityEngine;
using System.Collections;

public class GyroStatusDisplay : MonoBehaviour {

	
	public Rect GUIArea = new Rect (10, 10, 500, 500);
	
	
	/**
	void Start () {
		Input.gyro.enabled = true;
	}

	// Update is called once per frame
	void Update () {
		Debug.Log ("updating rotation from gyro");
		Gyroscope gyro = Input.gyro;
		transform.rotation = gyro.attitude;
	}

**/
	
	void OnGUI () {
		Debug.Log ("on gui");
		GUIStyle mystyle = new GUIStyle (GUI.skin.label);
		mystyle.fontSize = mystyle.fontSize * 4;
		GUI.BeginGroup (GUIArea);
		GUI.Label (new Rect (0, 0, 500, 50), "Rotation x: " + Input.gyro.attitude.eulerAngles.x, mystyle);
		GUI.Label (new Rect (0, 50, 500, 50), "Rotation y: " + Input.gyro.attitude.eulerAngles.y, mystyle);
		GUI.Label (new Rect (0, 100, 500, 50), "Rotation z: " + Input.gyro.attitude.eulerAngles.z, mystyle);
		GUI.Label (new Rect (0, 150, 500, 50), SystemInfo.supportsGyroscope ? "Gyroscope supported" : "Gyrocope not supported!!", mystyle);
		GUI.EndGroup ();
	}
}
