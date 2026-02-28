using QRCoder;

namespace MyQrCodeGenerator
{
    public partial class QrCode : Form
    {
        public QrCode()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = textBox1?.Text;

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Url must not be empty", "Empty url");
                return;
            }

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrCode.GetGraphic(10);

            pictureBox1.Image = qrCodeImage.GetThumbnailImage(267, 250, null, nint.Zero);
        }
    }
}
