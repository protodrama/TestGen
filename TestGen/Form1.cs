using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace TestGen
{
    public partial class Form1 : Form
    {
        public string ResourcePath = ".\\TestData";
        public List<FileInfo> TestFiles;
        Dictionary<string, string> TestLines;
        Dictionary<string, string> WrongAnswers;
        public int NumRest;
        public int AnsRight;
        public int AnsWrong;
        public int WordPosition;

        public Form1()
        {
            InitializeComponent();
        }

        //Get Files and Starts the app
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDirIfnotExist(ResourcePath);
            TestFiles = new DirectoryInfo(ResourcePath).GetFiles().ToList();
            foreach (FileInfo currentfile in TestFiles)
            {
                TestFileList.Items.Add(currentfile.Name);
            }
        }

        //Load test from file name selected
        private void TestFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupTest();
            StartTest();
            StartWordCounting();
        }

        //Gets items list for the extam
        public Dictionary<string, string> GetTestItems(FileInfo filename)
        {
            List<string> content = File.ReadAllText(filename.FullName).Split("\r\n").ToList();
            Dictionary<string, string> ToReturn = new Dictionary<string, string>();
            foreach (string line in content)
            {
                ToReturn.Add(line.Split(',')[0], line.Split(',')[1]);
            }
            return Shuffle(ToReturn);
        }

        public Dictionary<string, string> Shuffle(Dictionary<string, string> source)
        {
            Random r = new Random();
            return source.OrderBy(x => r.Next())
               .ToDictionary(item => item.Key, item => item.Value);
        }

        //Setup UI for test
        public void SetupTest()
        {
            TestFileList.Enabled = false;
            CheckBtn.Enabled = true;
            btnReset.Enabled = true;
            txtAnswer.Enabled = true;
        }

        public void StartTest()
        {
            TestLines = GetTestItems(TestFiles[TestFileList.SelectedIndex]);
            WrongAnswers = new Dictionary<string, string>();
        }

        public void RestartTest()
        {
            TestLines = Shuffle(WrongAnswers);
            WrongAnswers = new Dictionary<string, string>();
        }
        
        public void StartWordCounting()
        {
            AnsRight = 0;
            AnsWrong = 0;
            WordPosition = 0;
            LabelRest.Text = TestLines.Count.ToString();
            LabelGood.Text = AnsRight.ToString();
            LabelWrong.Text = AnsWrong.ToString();
            WordToTranslate.Text = TestLines.Keys.ElementAt(WordPosition);
        }

        //Create resources Dir if not exist
        public void CreateDirIfnotExist(string dirpath)
        {
            if (!Directory.Exists(dirpath))
            {
                Directory.CreateDirectory(dirpath);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetApp();
        }

        //Reset App, cancell test
        public void resetApp()
        {
            TestFileList.Enabled = true;
            CheckBtn.Enabled = false;
            btnReset.Enabled = false;
            txtAnswer.Enabled = false;
            AnsRight = 0;
            AnsWrong = 0;
            WordPosition = 0;
            LabelRest.Text = "-";
            LabelGood.Text = "-";
            LabelWrong.Text = "-";
            WordToTranslate.Text = "-";
            MistakesList.Items.Clear();
            txtAnswer.Text = "";
            CorrectList.Items.Clear();
        }

        //Check answer and continue exam
        private void CheckBtn_Click(object sender, EventArgs e)
        {
            CheckAnswer(TestLines);
        }

        public void CheckAnswer(Dictionary<string, string> WordsFromTest)
        {

            if (WordPosition < WordsFromTest.Count)
            {
                //Check Answer and update UI lists
                if (WordsFromTest.Values.ElementAt(WordPosition).Equals(txtAnswer.Text))
                {
                    AnsRight++;
                    LabelGood.Text = AnsRight.ToString();
                    CorrectList.Items.Add(WordsFromTest.Keys.ElementAt(WordPosition) + "-" + WordsFromTest.Values.ElementAt(WordPosition));
                }
                else
                {
                    AnsWrong++;
                    LabelWrong.Text = AnsWrong.ToString();
                    MistakesList.Items.Add(WordsFromTest.Keys.ElementAt(WordPosition));
                    WrongAnswers.Add(WordsFromTest.Keys.ElementAt(WordPosition), WordsFromTest.Values.ElementAt(WordPosition));
                }

                //setup next word
                WordPosition++;
                if (WordPosition < WordsFromTest.Count)
                {
                    LabelRest.Text = (WordsFromTest.Count - WordPosition).ToString();
                    WordToTranslate.Text = WordsFromTest.Keys.ElementAt(WordPosition);
                    txtAnswer.Text = "";
                }
                else
                {
                    EndExam(true);
                }
            }
            else
            {
                EndExam(true);
            }
        }

        public void EndExam(bool finished)
        {
            if (finished)
            {
                txtAnswer.Text = "";
                LabelRest.Text = "-";
                WordToTranslate.Text = "-";
                CheckBtn.Enabled = false;
                BtnRepeatMistakes.Enabled = true;
                MessageBox.Show("Test Terminado", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                resetApp();
            }
        }

        public void ShowException(string Exception)
        {
            MessageBox.Show(Exception, "Ha habido un fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            EndExam(false);
        }

        private void BtnRepeatMistakes_Click(object sender, EventArgs e)
        {
            SetupTest();
            RestartTest();
            StartWordCounting();
            MistakesList.Items.Clear();
            CorrectList.Items.Clear();
        }
    }
}