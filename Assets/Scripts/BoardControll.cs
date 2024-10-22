using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BoardControll : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] int total;

    public int Total { get { return total; } set {  total = value; } }

    private StringBuilder sb = new StringBuilder();

    private void ScoreTextReset(string msg)
    {
        sb.Clear();
        sb.AppendLine(msg);
        scoreText.SetText(sb.ToString());
    }

    private void LateUpdate()
    {
        ScoreTextReset(total.ToString());
    }
}
