using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TextAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAnalyze_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text.Trim();

            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show("Пожалуйста, введите текст для анализа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int characterCount = inputText.Length;

            string[] words = Regex.Split(inputText, @"\W+");
            int wordCount = words.Count(w => !string.IsNullOrEmpty(w));

            int sentenceCount = Regex.Matches(inputText, @"[.!?]").Count;

            var uniqueWords = words.Where(w => !string.IsNullOrEmpty(w)).Distinct().ToList();
            int uniqueWordCount = uniqueWords.Count;

            string longestWord = uniqueWords.OrderByDescending(w => w.Length).FirstOrDefault() ?? string.Empty;
            string shortestWord = uniqueWords.OrderBy(w => w.Length).FirstOrDefault() ?? string.Empty;

            labelCharacterCount.Text = $"Количество символов: {characterCount}";
            labelWordCount.Text = $"Количество слов: {wordCount}";
            labelSentenceCount.Text = $"Количество предложений: {sentenceCount}";
            labelUniqueWordCount.Text = $"Количество уникальных слов: {uniqueWordCount}";
            labelLongestWord.Text = $"Самое длинное слово: {longestWord}";
            labelShortestWord.Text = $"Самое короткое слово: {shortestWord}";

            listBoxUniqueWords.Items.Clear();
            foreach (var word in uniqueWords)
            {
                int count = words.Count(w => w.Equals(word, StringComparison.OrdinalIgnoreCase));
                listBoxUniqueWords.Items.Add($"{word} - {count}");
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            labelCharacterCount.Text = string.Empty;
            labelWordCount.Text = string.Empty;
            labelSentenceCount.Text = string.Empty;
            labelUniqueWordCount.Text = string.Empty;
            labelLongestWord.Text = string.Empty;
            labelShortestWord.Text = string.Empty;
            listBoxUniqueWords.Items.Clear();
        }
    }
}
