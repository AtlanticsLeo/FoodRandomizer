using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }
    public Button rollBtn;
    public GameObject loading;


    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    public void RollFood()
    {
        StartCoroutine(Roll());
    }

    public IEnumerator Roll()
    {
        rollBtn.gameObject.SetActive(false);
        yield return new WaitForSeconds(1);
        rollBtn.gameObject.SetActive(true);
    }
}
