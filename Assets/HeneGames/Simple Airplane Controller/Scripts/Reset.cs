using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Reset : MonoBehaviour {

	public bool shouldReset = false;
	public Text resetText;
	public Image resetBackdrop;
	void Start()
    {
		Debug.Log("Started");
    }
	void Update() 
	{
		if (shouldReset == true)
        {
			StartCoroutine(WaitForExplosion());
			if (Input.GetKeyDown(KeyCode.Space))
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
		}
		
		
	}
	private void ResetText()
    {
		resetBackdrop.gameObject.SetActive(true);
		resetText.gameObject.SetActive(true);
    }
	IEnumerator WaitForExplosion()
	{
		yield return new WaitForSeconds(3);
		ResetText();
	}

}
