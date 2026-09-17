using System.IO;
using System.Linq;

namespace BBStoVideos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string BbsFolder;
        DialogResult BbsFolderOk;
        String VideoFolder;
        DialogResult VideoFolderOk;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BbsFolderOk = folderBrowserDialog1.ShowDialog();
            if (BbsFolderOk == DialogResult.OK)
                BbsFolder = folderBrowserDialog1.SelectedPath;
            MessageBox.Show(BbsFolder);
        }

        private void VFolderSelector_Click(object sender, EventArgs e)
        {
            VideoFolderOk = folderBrowserDialog2.ShowDialog();
            if (VideoFolderOk == DialogResult.OK)
                VideoFolder = folderBrowserDialog2.SelectedPath;
            MessageBox.Show(VideoFolder);
        }

        private void TxtDeletor_Click(object sender, EventArgs e)
        {
            string[] logFiles;
            logFiles = Directory.GetFiles(BbsFolder, "*.log");
            MessageBox.Show(string.Join(Environment.NewLine, logFiles));
            foreach (string file in logFiles)
                File.Delete(file);
        }

        private void Move_Click(object sender, EventArgs e)
        {
            string[] videoFiles;
            videoFiles = Directory.GetFiles(BbsFolder, "*.mp4");
            MessageBox.Show(string.Join(Environment.NewLine, videoFiles));
            foreach (string file in videoFiles)
                File.Move(file, Path.Combine(VideoFolder, Path.GetFileName(file)), overwrite: true);

        }

        private void SorterMax_Click(object sender, EventArgs e)
        {
            DirectoryInfo Vdir = new DirectoryInfo(VideoFolder);
            FileInfo[] videoInfos;
            int number = 1;

            videoInfos = Vdir.GetFiles("*.mp4");
            videoInfos = videoInfos.OrderBy(x => x.CreationTime).ToArray();
            foreach (var video in videoInfos)
            {
                String oldPath = video.FullName;
                String newFileName = number.ToString() + ".mp4";
                String newPath = Path.Combine(VideoFolder, newFileName);
                File.Move(oldPath, newPath);
                number++;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Rememberity_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
