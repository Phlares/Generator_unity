using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Generator_Script : MonoBehaviour {
	//Eyes: Vary in position, orientation, colour, size, shape/style

	public Transform[] eyeStyles;
	public Transform leftEye;
	public Transform rightEye;

	// Use this for initialization
	void Start () {
	

		Transform eyeToUse = eyeStyles [Random.Range (0, eyeStyles.Length)];
		Transform eyeToUse2 = eyeStyles [Random.Range (0, eyeStyles.Length)];
		Transform newLeftEye = Instantiate(eyeToUse);
		newLeftEye.parent = leftEye;
		newLeftEye.localPosition = Vector3.zero;
		Transform newRightEye = Instantiate(eyeToUse2);
		newRightEye.parent = rightEye;
		newRightEye.localPosition = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene (0);
		}
	
	}


	 
}
