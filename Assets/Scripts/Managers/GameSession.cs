using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameSession : MonoBehaviour
{
	[Header("UI objects")]
	[SerializeField] TextMeshProUGUI currentScoreText;
	[SerializeField] TextMeshProUGUI scoreMenu;
	[SerializeField] TextMeshProUGUI timerText;
	[SerializeField] TextMeshProUGUI storedHighScore;
	[SerializeField] GameObject newHighScoreText;
	[SerializeField] GameObject scoreTextWindow;
	[SerializeField] GameObject gameOverContainer;
	[SerializeField] GameObject tapToStart;
	[SerializeField] GameObject scoreAndTimerContainer;
	[SerializeField] Canvas parentCanvas;

	[Header("Script reference")]
	[SerializeField] Spawner spawner;


	int currentScore = 0;
	int savedHighScore = 0;
	bool gameStarted = false;
	float timer = 0;

	
	Coroutine spawnCorutine = null;

	private void Start()
	{
		Time.timeScale = 1;

		spawner = spawner.GetComponent<Spawner>();

		savedHighScore = PlayerPrefs.GetInt("HighScore", 0);
		timerText.text = string.Format("{0:00}:{1:00}", 0, 0);
		currentScoreText.text = currentScore.ToString();
		
	}
	void Update()
	{
		
		if(gameStarted == true)
        {
			currentScoreText.text = currentScore.ToString();
			timer += Time.deltaTime;

			float seconds = Mathf.Floor(timer % 60);
			float minutes = Mathf.FloorToInt(timer / 60);

			timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

	}

	public void AddToScore()
	{
		currentScore++;
		currentScoreText.text = currentScore.ToString();
	}

	public void GameOver()
    {
		Time.timeScale = 0;
		gameStarted = false;
		StopCoroutine(spawnCorutine);

		parentCanvas.sortingOrder = 10;
		gameOverContainer.SetActive(true);
		scoreAndTimerContainer.SetActive(false);
		scoreMenu.text = currentScore.ToString();



		if (currentScore > savedHighScore)
        {
			PlayerPrefs.SetInt("HighScore", currentScore);
			newHighScoreText.SetActive(true);
			storedHighScore.gameObject.SetActive(false);
			scoreTextWindow.SetActive(false);
			

		}
		else
        {
			storedHighScore.gameObject.SetActive(true);
			storedHighScore.text = $"High Score: {PlayerPrefs.GetInt("HighScore")}";
        }
	}

	public void StartGame()
    {
		Time.timeScale = 1;
		gameStarted = true;

		tapToStart.SetActive(false);
		scoreAndTimerContainer.SetActive(true);

		spawnCorutine = StartCoroutine(spawner.SpawnCircles());
	}
	public void ResetScene()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		StartGame();
	}



	


	

}
