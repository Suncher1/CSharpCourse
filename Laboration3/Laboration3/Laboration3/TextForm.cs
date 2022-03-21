using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace Laboration3
{
    public partial class TextForm : Form
    {
        //Global variables
        bool textIsChanged;
        const string defaultFileName = "dok1.txt";
        string currentFilePath = string.Empty;

        public TextForm()
        {
            InitializeComponent();
            this.Text = GetCurrentFileName();
            UpdateStatusBar();
        }

        #region Help functions
        private bool FileExists()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ResetForm()
        {
            TextInputBox.Text = "";
            currentFilePath = String.Empty;
            textIsChanged = false;
            //fileExist = false;
            this.Text = GetCurrentFileName();
        }
        private void ExeptionHandler()
        {
            MessageBox.Show("Något gick fel!", "", MessageBoxButtons.OK);
            ResetForm();
        }
        private string GetCurrentFileName()
        {
            //try
            //{
            if (currentFilePath == string.Empty)
            {
                return defaultFileName;
            }
            else
            {
                return Path.GetFileName(currentFilePath);
            }
            //}
            //catch
            //{
            //    ExeptionHandler();
            //    return null;
            //}
        }
        private string ReadTextFile(string filepath)
        {
            string fileContent = File.ReadAllText(filepath, Encoding.Unicode);
            return fileContent;
        }
        #endregion

        #region Buttons and textbox funtions
        private void NewButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((FileExists() && !textIsChanged) || TextInputBox.Text == "")
                {
                    ResetForm();
                    UpdateStatusBar();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Vill du spara texten?", "", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (FileExists())
                        {
                            SaveButton.PerformClick();
                        }
                        else
                        {
                            SaveToFileButton.PerformClick();
                        }
                        ResetForm();
                        UpdateStatusBar();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        ResetForm();
                        UpdateStatusBar();
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        //do nothing
                    }
                }

            }
            catch
            {
                ExeptionHandler();
            }
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                var fileContent = string.Empty;

                if (textIsChanged)
                {
                    DialogResult dialogResult = MessageBox.Show("Vill du spara texten?", "", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (FileExists())
                        {
                            SaveButton.PerformClick();
                        }
                        else
                        {
                            SaveToFileButton.PerformClick();
                        }
                    }

                    else if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                }

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "txt files (*.txt)|*.txt";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        currentFilePath = openFileDialog.FileName;
                        fileContent = File.ReadAllText(currentFilePath, Encoding.Unicode);

                        TextInputBox.Text = fileContent;
                        textIsChanged = false;
                        //fileExist = true;
                        currentFilePath = openFileDialog.FileName;
                        this.Text = GetCurrentFileName();
                        UpdateStatusBar();
                    }
                }
            }
            catch
            {
                ExeptionHandler();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentFilePath == string.Empty)
                {
                    SaveToFileButton.PerformClick();
                }
                else
                {
                    var stream = new FileStream(currentFilePath, FileMode.Create);
                    // Create a StreamWriter from FileStream  
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.Unicode))
                    {
                        writer.Write(TextInputBox.Text);
                    }
                    this.Text = GetCurrentFileName();
                    textIsChanged = false;
                }
            }
            catch
            {
                ExeptionHandler();
            }
        }
        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                Stream myStream;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = GetCurrentFileName();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog.OpenFile()) != null)
                    {
                        Encoding unicode = Encoding.Unicode;

                        // Convert unicode string into a byte array.  
                        byte[] byteArray = unicode.GetBytes(TextInputBox.Text);
                        myStream.Write(byteArray, 0, byteArray.Length);
                        myStream.Close();
                        //fileExist = true;
                        textIsChanged = false;
                        currentFilePath = saveFileDialog.FileName;
                        this.Text = GetCurrentFileName();
                    }
                }
            }
            catch
            {
                ExeptionHandler();
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((FileExists() && !textIsChanged) || TextInputBox.Text == "")
                {
                    Application.Exit();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Vill du spara texten?", "", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (FileExists())
                        {
                            SaveButton.PerformClick();

                        }
                        else
                        {
                            SaveToFileButton.PerformClick();
                        }
                        Application.Exit();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        //do nothing
                    }
                }
            }
            catch
            {
                ExeptionHandler();
            }
        }
        private void TextInputBox_TextChanged(object sender, EventArgs e)
        {
            textIsChanged = true;
            this.Text = $"*{GetCurrentFileName()}";
            UpdateStatusBar();
        }
        #endregion

        #region Calculators and an updater for status bar
        private void UpdateStatusBar()
        {
            StatusLabel1.Text = $"Antal tecken med mellanslag: {CalculateCharWithSpace()}";
            StatusLabel2.Text = $"Antal tecken utan mellanslag: {CalculateCharWithoutSpace()}";
            StatusLabel3.Text = $"Antal ord: {CalculateWords()}";
            StatusLabel4.Text = $"Antal rader: {CalculateRows()}";
        }
        private string CalculateCharWithSpace()
        {
            string result = TextInputBox.Text.Length.ToString();
            return result;
        }
        private string CalculateCharWithoutSpace()
        {
            string text = TextInputBox.Text;
            text = text.Replace(" ", "");
            return text.Length.ToString();
        }
        private string CalculateWords()
        {
            string text = TextInputBox.Text;
            string[] words = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length.ToString();
        }
        private string CalculateRows()
        {
            string text = TextInputBox.Text;
            string[] rows = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return rows.Length.ToString();
        }
        #endregion

        #region Drag drop and closing of the form functions
        private void TextInputBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        private void TextInputBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                string fileContent = "";

                if (files.Length != 1)
                {
                    MessageBox.Show("Du kan bara dra in en fil åt gången!", "", MessageBoxButtons.OK);
                }
                else
                {
                    string filename = files[0];
                    if (Path.GetExtension(filename) == ".txt")
                    {
                        if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
                        {
                            fileContent = ReadTextFile(filename);
                            TextInputBox.Text = TextInputBox.Text + fileContent;
                        }
                        else if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
                        {
                            fileContent = ReadTextFile(filename);
                            TextInputBox.SelectedText = fileContent;
                        }
                        else
                        {
                            bool openDragableFileInTextBox = true;

                            if (FileExists())
                            {
                                DialogResult dialogResult = MessageBox.Show("Vill du spara texten?", "", MessageBoxButtons.YesNoCancel);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    SaveButton.PerformClick();
                                    openDragableFileInTextBox = true;
                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    openDragableFileInTextBox = true;
                                }
                                else if (dialogResult == DialogResult.Cancel)
                                {
                                    openDragableFileInTextBox = false;
                                }
                            }
                            if (openDragableFileInTextBox)
                            {
                                fileContent = ReadTextFile(filename);
                                TextInputBox.Text = fileContent;
                                currentFilePath = filename;
                                textIsChanged = false;
                                this.Text = $"{GetCurrentFileName()}";
                            }
                        }
                        UpdateStatusBar();
                    }
                    else
                    {
                        MessageBox.Show("Du kan bara dra in en textfil!", "", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                ExeptionHandler();
            }
        }
        private void TextForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                ExitButton.PerformClick();
            }
        }
        #endregion
    }
}
