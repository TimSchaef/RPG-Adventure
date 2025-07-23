using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textCounterCoin;

    [SerializeField] private GameObject panelLost;
    
    [SerializeField] Button buttonreloadLevel;

    [SerializeField] private GameObject winPanel;
    
        
    private void Start()
    {
        winPanel.SetActive(false);
        UpdateCoinText(0);
    }
    
    

    public void UpdateCoinText(int newCoinCount)
    {
        textCounterCoin.text = newCoinCount.ToString(); 
    }

    public void ShowPanelLost()
    {
        panelLost.SetActive(true);
        buttonreloadLevel.onClick.AddListener(ReloadLevel);
    }
    

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ShowWinPanel()
    {
        winPanel.SetActive(true);
        buttonreloadLevel.onClick.AddListener(ReloadLevel);
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene("GameScene");
    }
    
}







