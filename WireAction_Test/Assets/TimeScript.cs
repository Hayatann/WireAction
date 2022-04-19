using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
	private int minute;
	[SerializeField]
	public static float seconds;
	//　前のUpdateの時の秒数
	private float oldSeconds;
	//　タイマー表示用テキスト
	private Text timerText;
    void Start()
    {
        minute = 0;
		seconds = 0.00f;
		oldSeconds = 0f;
		timerText = GetComponentInChildren<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
		if(seconds >= 60f) {
			minute++;
			seconds = seconds - 60;
		}
		//値が変わった時だけテキストUIを更新
		if((int)seconds != (int)oldSeconds) {
			timerText.text = minute.ToString("00") + "." + ((int) seconds).ToString ("00");
		}
		oldSeconds = seconds;
		
    }

		public static string getSeconds(){
			int int_seconds = (int)seconds;
			string str_seconds = int_seconds.ToString();
			return str_seconds;
		}
}
