
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int PinCount;
	public Text text;

	void Start ()
	{
		PinCount = 0;
	}

	public void Update ()
	{
		text.text = PinCount.ToString();
        
    }
	}
   
