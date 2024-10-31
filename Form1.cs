﻿using System;
using System.Windows.Forms;

namespace DaYuanSouTi
{
    public partial class DaYuan出题 : Form
    {
        private QuestionService _questionService;
        private float _currentFontSize = 12f; // 默认字体大小
        public DaYuan出题()
        {
            InitializeComponent();
            Console.WriteLine("!!!!!", Environment.CurrentDirectory);
            string questionDirectory = "../..";  // 指定题库目录路径
            var repository = new QuestionRepository(questionDirectory);
            _questionService = new QuestionService(repository);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var question = _questionService.GetRandomQuestion();
            if (question == null)
            {
                MessageBox.Show("所有题目已抽完！");
                return;
            }

            // 在 textBox1 中显示题目内容
            textBox1.Text = $"{question.Subject}\n{question.Content}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _questionService.ResetQuestions();
            MessageBox.Show("题库已重置！");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _currentFontSize += 2f;
            textBox1.Font = new System.Drawing.Font(textBox1.Font.FontFamily, _currentFontSize);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _currentFontSize = Math.Max(8f, _currentFontSize - 2f);  // 最小字体为 8
            textBox1.Font = new System.Drawing.Font(textBox1.Font.FontFamily, _currentFontSize);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
