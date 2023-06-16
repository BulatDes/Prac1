using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_1._3
{
    public partial class Form1 :Form
    {
        private Playlist playlist = new Playlist ();
        public Form1 ()
        {
            InitializeComponent();
        }

        private void addbut_Click (object sender, EventArgs e)
        {
            string author = authorTextBox.Text;
            string name = titleTextBox.Text;
            string filename = filenameTextBox.Text;

            if (string.IsNullOrEmpty(author) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("Для добавления песни, заполните все поля!", "Внимание!");
                return;
            }

            playlist.AddSong(author, name, filename);

            authorTextBox.Clear();
            titleTextBox.Clear();
            filenameTextBox.Clear();

            MessageBox.Show("Композиция была добавлена!", "Отлично!");
        }
        private void RefreshSong ()
        {
            try
            {
                Song vybrsong = playlist.CurrentSong();
                authorLabel.Text = vybrsong.Author;
                titleLabel.Text = vybrsong.Title;
                filenameLabel.Text = vybrsong.Filename;
            } catch (IndexOutOfRangeException)
            {
                authorLabel.Text = string.Empty;
                titleLabel.Text = string.Empty;
                filenameLabel.Text = string.Empty;
            }
        }

        private void NextBut_Click (object sender, EventArgs e)
        {
            playlist.NextSong();
            RefreshSong();
        }

        private void BackBut_Click (object sender, EventArgs e)
        {
            playlist.PreviousSong();
            RefreshSong();
        }

        private void pereity_Click (object sender, EventArgs e)
        {
            playlist.GoToStart();
            RefreshSong();
        }

        private void ClearBut_Click (object sender, EventArgs e)
        {
            playlist.ClearPlaylist();
            RefreshSong();
        }

        private void DeleteSongBut_Click (object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int index))
            {
                try
                {
                    playlist.RemoveSong(index);
                    RefreshSong();
                } catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
            } else
                MessageBox.Show("Введите корректный индекс.", "Ошибка!");
        }

        private void PereityInd_Click (object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int index))
            {
                try
                {
                    playlist.GoToSong(index);
                    RefreshSong();
                } catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
            } else
                MessageBox.Show("Введите корректный индекс.", "Ошибка!");
        }
    }
}
