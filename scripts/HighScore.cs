using System;
using Godot;
using System.Collections.Generic;
using System.IO;
using File = System.IO.File;

public class HighScore : Node
{
    private void AddHighScore(int current_score)
    {
        if (File.Exists("Highscore.txt"))
        {
            List<string> scores = new List<string>();
            scores.AddRange(File.ReadAllLines("Highscore.txt"));
            for (int i = 0; i < scores.Count; i++)
            {
                string score = scores[i];
                if (current_score > Convert.ToInt32(score.Remove(0, score.IndexOf(','))))
                {
                    // ? предложение ввести имя
                    string name = "";
                    scores.Insert(i, $"{ current_score }, { name }");
                    if (scores.Count == 6)
                        scores.Remove(scores[5]);
                    break;
                }
            }
            FileStream file = new FileStream("Highscore.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            scores.ForEach((string score) =>
            {
                if (scores.IndexOf(score) != scores.Count - 1)
                    writer.WriteLine(score);
                else
                writer.Write(score);
            });
            writer.Close();
            file.Close();
        }
        else
        {
            // ? предложение ввести имя
            string name = "";
            FileStream file = new FileStream("Highscore.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            writer.Write($"{ current_score }, { name }");
            writer.Close();
            file.Close();
        }
    }
    private void GetHighScores()
    {
        // ! вывод на экран всех хайскоров. Будет реализован после создания соответствующей сцены
    }
}