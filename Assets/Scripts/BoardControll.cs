using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BoardControll : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] List<GameObject> boards;
    [SerializeField] int total;
    public int Total { get { return total; } set {  total = value; } }

    private StringBuilder sb = new StringBuilder();

    private void Update()
    {
        ActiveBoard();
    }

    private void LateUpdate()
    {
        ScoreTextReset(total.ToString());
    }

    private void ScoreTextReset(string msg)
    {
        sb.Clear();
        sb.AppendLine(msg);
        scoreText.SetText(sb.ToString());
    }

    private void ActiveBoard()
    {
        for (int i = 0; i < boards.Count; i++)
        {
            if (boards[i].activeSelf) return;

            boards[i].SetActive(true);
        }
    }
}
