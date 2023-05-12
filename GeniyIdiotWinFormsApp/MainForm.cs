using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeniyIdiotClassLibrary;


namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<Question> _questions;
        private Question _currentQuestion;
        private User _user;
        private List<int> _indexes;
        private int _questionNumber;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void mainForm_Load(object sender, EventArgs e)
        {
            _questions = QuestionStorage.GetQuestions();
            _user = new User("Неизвестно");
            _questionNumber = 0;
            _indexes = new List<int>();
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var random = new Random();
            var randomQuestionIndex = random.Next(0, _questions.Count);
            for (var j = 0; j < _indexes.Count; j++)
            {
                if (_indexes[j] != randomQuestionIndex) continue;
                randomQuestionIndex = random.Next(0, _questions.Count);
                j = -1;
            }
            _indexes.Add(randomQuestionIndex);
            
            _currentQuestion = _questions[randomQuestionIndex];
            questionTextLabel.Text = _currentQuestion._text;

            _questionNumber++;
            questionNumberLabel.Text = @"Вопрос №" + _questionNumber;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = UserResultStorage.GetNumber(userAnswerTextBox.Text);
            var rightAnswer = _currentQuestion._answer;
            if (userAnswer == rightAnswer)
            {
                _user.AddCountRightAnswers();
            }

            var endGame = _indexes.Count == _questions.Count;
            if (endGame)
            {
                MessageBox.Show(@"Количество правильных ответов: " + _user._countRightAnswers);
                var diagnoses = QuestionStorage.GetDiagnoses();
                MessageBox.Show(_user._username + @", Ваш диагноз: " + diagnoses[_user._countRightAnswers]);
                return;
            }
            ShowNextQuestion();
        }
    }
}