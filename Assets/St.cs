using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class St : MonoBehaviour
{
    // Start is called before the first frame update
    void LoadScene(string SampleScene)
    {               
        SceneManager.LoadScene(SampleScene);
    }
    



    
}
