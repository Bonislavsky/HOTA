using System.Media;

namespace HOTA
{
    public partial class Form1 : Form
    {
        private string _path = @"D:\Programming\CSharp\yHiBep\Hota\HOTA\HOTA\";
        private string _filePath = @"D:\Programming\CSharp\yHiBep\Hota\HOTA\HOTA\Logs.txt";
        private Label _currentNote = null;
        private Color _originalColor = Color.Black;

        public Form1()
        {
            InitializeComponent();
            InitializeColorTimer();
        }

        private void InitializeColorTimer()
        {
            colorTimer.Interval = 1000; // Интервал в миллисекундах (1 секунды)
            colorTimer.Tick += (sender, e) =>
            {
                if (_currentNote != null)
                {
                    _currentNote.ForeColor = _originalColor; // Возврат цвета ноты
                    colorTimer.Stop(); // Остановка таймера
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
            pictureBox1.Image = Image.FromFile(@$"{_path}Images\key.jpg");
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
            SoundPlayer simpleSound = new SoundPlayer(@$"{_path}{soundFile}");
            simpleSound.Play();
        }

        private void ChangeNoteColor(Label note, Color color)
        {
            if (_currentNote != null)
            {
                _currentNote.ForeColor = _originalColor; // Возврат цвета предыдущей ноты
            }

            _currentNote = note;
            _originalColor = note.ForeColor; // Сохранение оригинального цвета
            note.ForeColor = color; // Установка нового цвета
            colorTimer.Start(); // Запуск таймера для возврата цвета
        }

        private void WriteToFile(string message)
        {
            // Проверяем, существует ли файл
            if (!File.Exists(_filePath))
            {
                // Если файл не существует, создаем его
                using StreamWriter createFileWriter = File.CreateText(_filePath);
                createFileWriter.Close();
            }

            // Открываем файл для добавления сообщения
            using StreamWriter writer = File.AppendText(_filePath);

            // Записываем сообщение в файл
            writer.WriteLine($"{DateTime.UtcNow:G} -- {message}");
        }
    }
}