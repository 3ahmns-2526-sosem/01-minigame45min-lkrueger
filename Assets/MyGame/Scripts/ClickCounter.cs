using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickCounter : MonoBehaviour
{

    public int clicK;
    public TextMeshProUGUI youWin;
    public TextMeshProUGUI counter;
    public GameObject empty;
    public GameObject circle;
    public GameObject reload;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        empty.SetActive(false);
        reload.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (clicK == 10)
        {
            empty.SetActive (true);
            reload.SetActive (true);
            circle.SetActive (false);
        }

        counter.text = "Clicked Times: " + clicK;
    }

    private void OnMouseDown()
    {
        clicK++;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
