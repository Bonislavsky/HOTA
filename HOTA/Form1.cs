using System.Media;

namespace HOTA
{
    public partial class Form1 : Form
    {
        private string _filePathLoger = @"Logs.txt";
        private Label _currentNote = null;
        private Color _originalColor = Color.Black;

        public Form1()
        {
            InitializeComponent();
            InitializeColorTimer();
        }

        private void InitializeColorTimer()
        {
            colorTimer.Interval = 1000; 
            colorTimer.Tick += (sender, e) =>
            {
                if (_currentNote != null)
                {
                    _currentNote.ForeColor = _originalColor; 
                    colorTimer.Stop(); 
                }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WriteToFile("програма була запущена");

            richTextBox1.Text = "1 - До\n2 - Ре\n3 - Мi\n4 - Фа\n5 - Соль\n6 - Ля\n7 - Сi";
            richTextBox1.ReadOnly = true;
            richTextBox1.Enabled = false;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@$"Images\key.jpg");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            WriteToFile("програма була закрита");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string note = "";

            if (e.KeyCode == Keys.D1)
            {
                note = "До";
                ChangeNoteColor(Notedo, Color.Red);
                PlaySound(@"Sounds\zvuk-notyi-do.wav");
            }
            else if (e.KeyCode == Keys.D2)
            {
                note = "Ре";
                ChangeNoteColor(NoteRe, Color.Orange);
                PlaySound(@"Sounds\zvuk-notyi-re.wav");
            }
            else if (e.KeyCode == Keys.D3)
            {
                note = "Мi";
                ChangeNoteColor(NoteMe, Color.Yellow);
                PlaySound(@"Sounds\zvuk-notyi-mi.wav");
            }
            else if (e.KeyCode == Keys.D4)
            {
                note = "Фа";
                ChangeNoteColor(NoteFa, Color.Green);
                PlaySound(@"Sounds\zvuk-notyi-fa.wav");
            }
            else if (e.KeyCode == Keys.D5)
            {
                note = "Соль";
                ChangeNoteColor(NoteSol, Color.Blue);
                PlaySound(@"Sounds\zvuk-notyi-sol.wav");
            }
            else if (e.KeyCode == Keys.D6)
            {
                note = "Ля";
                ChangeNoteColor(NoteL, Color.CadetBlue);
                PlaySound(@"Sounds\zvuk-notyi-lya.wav");
            }
            else if (e.KeyCode == Keys.D7)
            {
                note = "Сi";
                ChangeNoteColor(NoteS, Color.Purple);
                PlaySound(@"Sounds\zvuk-notyi-si.wav");
            }

            if (string.IsNullOrEmpty(note))
            {
                WriteToFile("була натиснута неправильно клавіша");
                MessageBox.Show("жодна нота не прив'язана до цієї клавіші");
            }
            else
            {
                WriteToFile($"була натиснута нота: {note}");
            }
        }

        private void PlaySound(string soundFile)
        {
            SoundPlayer simpleSound = new SoundPlayer(soundFile);
            simpleSound.Play();
        }

        private void ChangeNoteColor(Label note, Color color)
        {
            if (_currentNote != null)
            {
                _currentNote.ForeColor = _originalColor;
            }

            _currentNote = note;
            _originalColor = note.ForeColor;
            note.ForeColor = color; 
            colorTimer.Start(); 
        }

        private void WriteToFile(string message)
        {
            if (!File.Exists(_filePathLoger))
            {
                using StreamWriter createFileWriter = File.CreateText(_filePathLoger);
                createFileWriter.Close();
            }

            using StreamWriter writer = File.AppendText(_filePathLoger);

            writer.WriteLine($"{DateTime.UtcNow:G} -- {message}");
        }
    }
}