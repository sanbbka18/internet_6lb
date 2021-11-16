using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play_again : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("game");
    }

    void OnMouseUp()
    {
    }
}
