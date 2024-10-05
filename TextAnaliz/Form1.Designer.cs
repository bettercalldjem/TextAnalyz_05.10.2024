namespace TextAnalyzer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxInput = new TextBox();
            buttonAnalyze = new Button();
            buttonClear = new Button();
            labelCharacterCount = new Label();
            labelWordCount = new Label();
            labelSentenceCount = new Label();
            labelUniqueWordCount = new Label();
            labelLongestWord = new Label();
            labelShortestWord = new Label();
            listBoxUniqueWords = new ListBox();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 12);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(360, 100);
            textBoxInput.TabIndex = 0;
            // 
            // buttonAnalyze
            // 
            buttonAnalyze.Location = new Point(12, 118);
            buttonAnalyze.Name = "buttonAnalyze";
            buttonAnalyze.Size = new Size(141, 23);
            buttonAnalyze.TabIndex = 1;
            buttonAnalyze.Text = "Анализировать";
            buttonAnalyze.Click += ButtonAnalyze_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(297, 118);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "Очистить";
            buttonClear.Click += ButtonClear_Click;
            // 
            // labelCharacterCount
            // 
            labelCharacterCount.Location = new Point(12, 145);
            labelCharacterCount.Name = "labelCharacterCount";
            labelCharacterCount.Size = new Size(228, 23);
            labelCharacterCount.TabIndex = 3;
            // 
            // labelWordCount
            // 
            labelWordCount.Location = new Point(12, 166);
            labelWordCount.Name = "labelWordCount";
            labelWordCount.Size = new Size(215, 23);
            labelWordCount.TabIndex = 4;
            // 
            // labelSentenceCount
            // 
            labelSentenceCount.Location = new Point(12, 188);
            labelSentenceCount.Name = "labelSentenceCount";
            labelSentenceCount.Size = new Size(228, 22);
            labelSentenceCount.TabIndex = 5;
            // 
            // labelUniqueWordCount
            // 
            labelUniqueWordCount.Location = new Point(12, 210);
            labelUniqueWordCount.Name = "labelUniqueWordCount";
            labelUniqueWordCount.Size = new Size(228, 23);
            labelUniqueWordCount.TabIndex = 6;
            // 
            // labelLongestWord
            // 
            labelLongestWord.Location = new Point(12, 230);
            labelLongestWord.Name = "labelLongestWord";
            labelLongestWord.Size = new Size(228, 23);
            labelLongestWord.TabIndex = 7;
            // 
            // labelShortestWord
            // 
            labelShortestWord.Location = new Point(12, 250);
            labelShortestWord.Name = "labelShortestWord";
            labelShortestWord.Size = new Size(228, 23);
            labelShortestWord.TabIndex = 8;
            // 
            // listBoxUniqueWords
            // 
            listBoxUniqueWords.ItemHeight = 15;
            listBoxUniqueWords.Location = new Point(12, 287);
            listBoxUniqueWords.Name = "listBoxUniqueWords";
            listBoxUniqueWords.Size = new Size(360, 94);
            listBoxUniqueWords.TabIndex = 9;
            // 
            // Form1
            // 
            ClientSize = new Size(384, 381);
            Controls.Add(textBoxInput);
            Controls.Add(buttonAnalyze);
            Controls.Add(buttonClear);
            Controls.Add(labelCharacterCount);
            Controls.Add(labelWordCount);
            Controls.Add(labelSentenceCount);
            Controls.Add(labelUniqueWordCount);
            Controls.Add(labelLongestWord);
            Controls.Add(labelShortestWord);
            Controls.Add(listBoxUniqueWords);
            Name = "Form1";
            Text = "ТекстоАнализатор 3000";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelCharacterCount;
        private System.Windows.Forms.Label labelWordCount;
        private System.Windows.Forms.Label labelSentenceCount;
        private System.Windows.Forms.Label labelUniqueWordCount;
        private System.Windows.Forms.Label labelLongestWord;
        private System.Windows.Forms.Label labelShortestWord;
        private System.Windows.Forms.ListBox listBoxUniqueWords;
    }
}
