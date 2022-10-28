using LibaryWord;


namespace WinFormsAppLab3

{
    public partial class Form1 : Form
    {
        private WordList currentWordList = null;
        private List<string[]> addedWords = new List<string[]>();
        private List<string[]> removedWords = new List<string[]>();
        private Word practiceWord;

        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string fullpath = Path.Combine(path, "lab 3");

        private bool ignoreAskForSaveOnClose = false;
        private bool isSaved = true;
        int correctPracticeAnswer = 0;
        int totalPracticeAnswer = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            enableSaveButton();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridLanguageWords.Columns.Clear();
            dataGridLanguageWords.Rows.Clear();
            string? selectedList = listBox1.Items[listBox1.SelectedIndex].ToString();
            currentWordList = WordList.LoadList(selectedList);

            dataGridLanguageWords.Visible = true;
            addButton.Visible = true;
            removeButton.Visible = true;
            practiceButton.Visible = true;
            SaveButtonTab1.Visible = true;
            CancelButtonTab1.Visible = true;

            for (int i = 0; i < currentWordList.Languages.Length; i++)
            {
                dataGridLanguageWords.Columns.Add(currentWordList.Languages[i].ToString(), currentWordList.Languages[i].ToString());

            }
            currentWordList.List(0, PrintWord);


            void PrintWord(string[] translations)
            {
                int rowIndex = dataGridLanguageWords.Rows.Add();


                for (int i = 0; i < translations.Length; i++)
                {
                    dataGridLanguageWords.Rows[rowIndex].Cells[i].Value = translations[i];
                    dataGridLanguageWords.Rows[rowIndex].ReadOnly = true;
                }
                //dataGridView1.SelectedCells[].ColumnIndex[];
                //dataGridView1.SelectedCells[].RowIndex[];
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(WordList.GetLists());
            dataGridLanguageWords.ReadOnly = false;

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

        }

        private void addButtonTab1_Click(object sender, EventArgs e)
        {
            dataGridLanguageWords.Rows.Insert(0);
            listBox1.Enabled = false;
            isSaved = false;


        }

        private void removeButtonTab1_Click(object sender, EventArgs e)
        {
            if (dataGridLanguageWords.SelectedRows.Count > 0)
            {
                //string? selectedList = listBox1.Items[listBox1.SelectedIndex].ToString();
                //WordList showWordList = WordList.LoadList(selectedList);
                var rowIndex = this.dataGridLanguageWords.SelectedRows[0].Index;
                string? word = dataGridLanguageWords.Rows[rowIndex].Cells[0].Value?.ToString();
                List<string> translations = new List<string>();

                foreach (DataGridViewCell currentCell in dataGridLanguageWords.Rows[rowIndex].Cells)
                {

                    translations.Add(currentCell.Value?.ToString());
                }
                
                removedWords.Add(translations.ToArray());
                dataGridLanguageWords.Rows.RemoveAt(rowIndex);
                isSaved = false;
            }
            
        }

        private void practiceButtonTab1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            StatisticLabelTab3.Visible = false;
            correctPracticeAnswer = 0;
            totalPracticeAnswer = 0;
            practiceWordPage();
        }

        private void saveButtonTab1_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            foreach (string[] row in addedWords)
            {
                currentWordList.Add(row);
            }
            addedWords.Clear();

            foreach (string[] row in removedWords)
            {
                currentWordList.Remove(0, row[0]);
            }
            removedWords.Clear();

            currentWordList.Save();
            MessageBox.Show($"Saved!", "Saved");
            listBox1.Enabled = true;
            isSaved = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            switch (NumberOfLanguage.Value)
            {
                case 3:
                    Language3Label.Visible = true;
                    Language3TextBox.Visible = true;
                    Language4Label.Visible = false;
                    Language4TextBox.Visible = false;
                    break;

                case 4:
                    Language4Label.Visible = true;
                    Language4TextBox.Visible = true;
                    Language5Label.Visible = false;
                    Language5TextBox.Visible = false;
                    break;

                case 5:
                    Language5Label.Visible = true;
                    Language5TextBox.Visible = true;
                    Language6Label.Visible = false;
                    Language6TextBox.Visible = false;
                    break;

                case 6:
                    Language6Label.Visible = true;
                    Language6TextBox.Visible = true;
                    Language7Label.Visible = false;
                    Language7TextBox.Visible = false;
                    break;

                case 7:
                    Language7Label.Visible = true;
                    Language7TextBox.Visible = true;
                    Language8Label.Visible = false;
                    Language8TextBox.Visible = false;
                    break;

                case 8:
                    Language8Label.Visible = true;
                    Language8TextBox.Visible = true;
                    Language9Label.Visible = false;
                    Language9TextBox.Visible = false;
                    break;

                case 9:
                    Language9Label.Visible = true;
                    Language9TextBox.Visible = true;
                    break;

                default:
                    Language3Label.Visible = false;
                    Language3TextBox.Visible = false;
                    break;


            }
        }

        private void cancelButtonTab2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        bool enableSaveButton()
        {
            while (tabControl1.SelectedIndex == 1)
            {

                if ((FileNameTextBox.Text == String.Empty) || (Language1TextBox.Text == String.Empty) || (Language2TextBox.Text == String.Empty))
                {
                    SavebuttonTab2.Enabled = false;
                    return false;
                }
                else
                {
                    SavebuttonTab2.Enabled = true;
                    return true;
                }

            }

            return true;
        }



        private void saveButtonTab2_Click(object sender, EventArgs e)
        {
            List<string> languages = new List<string>();

            void addLanguages()
            {
                switch (NumberOfLanguage.Value)
                {
                    case 3:

                        languages.Add(Language1TextBox.Text);
                        languages.Add(Language2TextBox.Text);
                        languages.Add(Language3TextBox.Text);
                        break;

                    case 4:
                        languages.Add(Language1TextBox.Text);
                        languages.Add(Language2TextBox.Text);
                        languages.Add(Language3TextBox.Text);
                        languages.Add(Language4TextBox.Text);
                        break;

                    case 5:
                        languages.Add(Language1TextBox.Text);
                        languages.Add(Language2TextBox.Text);
                        languages.Add(Language3TextBox.Text);
                        languages.Add(Language4TextBox.Text);
                        languages.Add(Language5TextBox.Text);
                        break;

                    case 6:
                        languages.Add(Language1TextBox.Text);
                        languages.Add(Language2TextBox.Text);
                        languages.Add(Language3TextBox.Text);
                        languages.Add(Language4TextBox.Text);
                        languages.Add(Language5TextBox.Text);
                        languages.Add(Language6TextBox.Text);
                        break;

                    case 7:
                        languages.Add(Language1TextBox.Text);
                        languages.Add(Language2TextBox.Text);
                        languages.Add(Language3TextBox.Text);
                        languages.Add(Language4TextBox.Text);
                        languages.Add(Language5TextBox.Text);
                        languages.Add(Language6TextBox.Text);
                        languages.Add(Language7TextBox.Text);
                        break;

                    case 8:
                        languages.Add(Language1TextBox.Text);
                        languages.Add(Language2TextBox.Text);
                        languages.Add(Language3TextBox.Text);
                        languages.Add(Language4TextBox.Text);
                        languages.Add(Language5TextBox.Text);
                        languages.Add(Language6TextBox.Text);
                        languages.Add(Language7TextBox.Text);
                        languages.Add(Language8TextBox.Text);
                        break;

                    case 9:
                        languages.Add(Language1TextBox.Text);
                        languages.Add(Language2TextBox.Text);
                        languages.Add(Language3TextBox.Text);
                        languages.Add(Language4TextBox.Text);
                        languages.Add(Language5TextBox.Text);
                        languages.Add(Language6TextBox.Text);
                        languages.Add(Language7TextBox.Text);
                        languages.Add(Language8TextBox.Text);
                        languages.Add(Language9TextBox.Text);
                        break;

                    default:
                        languages.Add(Language1TextBox.Text);
                        languages.Add(Language2TextBox.Text);
                        break;
                }
            }
            addLanguages();
            WordList languageList = new WordList(FileNameTextBox.Text, languages.ToArray());
            languageList.Save();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(WordList.GetLists());
            tabControl1.SelectedIndex = 0;

        }

        private void FileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(FileNameTextBox.Text == string.Empty))
            {
                enableSaveButton();
            }


        }

        private void Language1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(Language1TextBox.Text == string.Empty))
            {
                enableSaveButton();
            }
        }

        private void Language2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(Language2TextBox.Text == string.Empty))
            {
                enableSaveButton();
            }
        }

        private void CancelButtonTab1_Click(object sender, EventArgs e)
        {
            listBox1.Enabled = true;
        }

        private void dataGridLanguageWords_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool hasValue = true;
            List<string> translations = new List<string>();

            foreach (DataGridViewCell currentCell in dataGridLanguageWords.Rows[e.RowIndex].Cells)
            {

                if (currentCell.Value == null)
                {
                    hasValue = false;
                }
                else
                {
                    translations.Add(currentCell.Value.ToString());
                }
            }

            if (hasValue)
            {
                addedWords.Add(translations.ToArray());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void EndPracticeButtonTab3_Click(object sender, EventArgs e)
        {
            StatisticLabelTab3.Visible = true;
            float correctPercentage = (float)correctPracticeAnswer / (float)totalPracticeAnswer * 100;
            StatisticLabelTab3.Text = $"Nice Work! \nYou practiced {totalPracticeAnswer} times! " +
                                      $"\nWith {correctPracticeAnswer} correct answers! " +
                                      $"\nWith an total of {correctPercentage}% correct overall! ";
        }


        private void submitButtonTab3_Click(object sender, EventArgs e)
        {
            
            if (PracticeAnswerTextBox.Text.ToLower() == this.practiceWord.Translations[this.practiceWord.ToLanguage].ToLower())
            {
                falseCorrectLabelTab3.Visible = true;
                falseCorrectLabelTab3.Text = "Correct";
                falseCorrectLabelTab3.ForeColor = Color.Lime;
                correctPracticeAnswer++;
                Task.Delay(3000).Wait();
                falseCorrectLabelTab3.Visible = false;
                PracticeAnswerTextBox.Text = string.Empty;

            }
            else
            {
                falseCorrectLabelTab3.Visible = true;
                falseCorrectLabelTab3.Text = "Wrong!";
                falseCorrectLabelTab3.ForeColor = Color.Red;
                Task.Delay(3000).Wait();
                falseCorrectLabelTab3.Visible = false;
                PracticeAnswerTextBox.Text = string.Empty;
            }
            
            totalPracticeAnswer++;
            
            practiceWordPage();
            
        }

        private void practiceWordPage()
        {
            
            practiceWord = currentWordList.GetWordToPractice();
            string wordFrom = practiceWord.Translations[practiceWord.FromLanguage];
            string wordTo = practiceWord.Translations[practiceWord.ToLanguage];
            string languageFrom = currentWordList.Languages[practiceWord.FromLanguage];
            string languageTo = currentWordList.Languages[practiceWord.ToLanguage];

            
            TranslateLabelTab3.Text = $"Translate {wordFrom} from {languageFrom} to {languageTo}: ";
        }

        private void PracticeAnswerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                submitButtonTab3_Click(this,new EventArgs());
            }

            if (e.KeyData == Keys.Escape)
            {
                EndPracticeButtonTab3_Click(this,new EventArgs());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!isSaved && !ignoreAskForSaveOnClose)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "My Application", MessageBoxButtons.YesNoCancel);
                // Display a MsgBox asking the user to save changes or abort.
                if (result == DialogResult.Yes)
                {
                    Save();
                    isSaved = true;
                    Close();
                }
                else if (result == DialogResult.No)
                {
                    ignoreAskForSaveOnClose = true;
                    Close();
                }
                else
                {
                    e.Cancel = true;
                }
                
            }
        }
    }
}