using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIRank : MonoBehaviour
{
	public Button goBackButton;

	public List<TextMeshProUGUI> userNameTexts;
	public List<TextMeshProUGUI> levelTexts;

	private Dictionary<int, UserData> ranking;

	private void Awake()
	{
		goBackButton.onClick.AddListener(GoBackButtonClick);
	}

	private void Start()
	{
		DatabaseManager.Instance.GetAllAccount();
	}

	private void GoBackButtonClick()
	{
		UIManager.Instance.PageOpen("UserInfo");
	}
}
