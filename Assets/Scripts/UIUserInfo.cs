using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIUserInfo : MonoBehaviour
{
	public TextMeshProUGUI userName;
	public TextMeshProUGUI characterClass;
	public TextMeshProUGUI level;

	public Button levelUpButton;
	public Button deleteButton;

	private UserData userData;

	private void Awake()
	{
		levelUpButton.onClick.AddListener(LevelUpButtonClick);
		deleteButton.onClick.AddListener(DeleteButtonClick);
	}

	public void UserInfoOpen(UserData userData)
	{
		this.userData = userData;
		userName.text = userData.userName;
		characterClass.text = userData.characterClass;
		level.text = $"Lv.{userData.level}";
	}

	private void LevelUpButtonClick()
	{
		DatabaseManager.Instance.LevelUp(userData);
	}

	private void DeleteButtonClick()
	{
		DatabaseManager.Instance.DeleteAccount(userData);
	}
}
