using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnIniciar : MonoBehaviour {

    public InputField tf1,tf2;
    public Text t1,t2;
    GameObject g1, g2;
     void Start()
    {
        
        t1.text = PlayerPrefs.GetString("txt1",t1.text);
        t2.text = PlayerPrefs.GetString("txt2",t2.text);
        
    }
    public void Guardar()
    {
        t1.text = tf1.text;
        t2.text = tf2.text;

        PlayerPrefs.SetString("txt1", tf1.text);
        PlayerPrefs.SetString("txt2",tf2.text);

        g1 = new GameObject(PlayerPrefs.GetString("txt1"));
        g1.transform.tag = "numero1";

        g2 = new GameObject(PlayerPrefs.GetString("txt2"));
        g2.transform.tag = "numero2";

        DontDestroyOnLoad(g1);
        DontDestroyOnLoad(g2);

        SceneManager.LoadScene("OEMSCENNE");
    }

    public void gutHub()
    {
        Application.OpenURL("https://github.com/AngieArrieta/OEM");
    }
    
}
