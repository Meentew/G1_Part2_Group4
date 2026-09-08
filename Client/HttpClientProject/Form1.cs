using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace HttpClientApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdoHttp.Checked = true; // ค่าเริ่มต้นเป็น HTTP
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string serverIP = txtServerIP.Text.Trim();
            string uri = txtURI.Text.Trim();

            // ตรวจสอบว่ากรอกครบไหม
            if (string.IsNullOrEmpty(serverIP) || string.IsNullOrEmpty(uri))
            {
                MessageBox.Show("กรุณากรอก Server IP และ URI ให้ครบ", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // เลือก Protocol ตาม RadioButton
            string protocol = rdoHttps.Checked ? "https" : "http";

            // ประกอบ URL เต็ม (กัน // ซ้ำถ้า uri มี / นำหน้าอยู่แล้ว)
            if (!uri.StartsWith("/"))
                uri = "/" + uri;

            string fullUrl = $"{protocol}://{serverIP}{uri}";

            try
            {
                // ปิดการเช็ค SSL Certificate เผื่อทดสอบกับ localhost ที่ certificate self-signed
                ServicePointManager.ServerCertificateValidationCallback =
                    (senderObj, certificate, chain, sslPolicyErrors) => true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fullUrl);
                request.Method = "GET";
                request.Timeout = 10000; // 10 วินาที

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    byte[] responseBytes = ms.ToArray();

                    string responseText = Encoding.UTF8.GetString(responseBytes);

                    // 1) แสดงผลแบบ Text
                    txtResponseText.Text = responseText;

                    // 2) แสดงผลแบบ Hexadecimal
                    txtResponseHex.Text = ConvertToHex(responseBytes);

                    // 3) แสดงผลผ่าน WebBrowser Control (Render จริง ไม่ใช่ Source Code)
                    webBrowser1.DocumentText = responseText;
                }
            }
            catch (WebException wex)
            {
                // กรณี Server ตอบกลับเป็น error code (เช่น 404, 500) ให้ดึง response มาแสดงด้วย
                if (wex.Response != null)
                {
                    using (Stream errorStream = wex.Response.GetResponseStream())
                    using (MemoryStream ms = new MemoryStream())
                    {
                        errorStream.CopyTo(ms);
                        byte[] responseBytes = ms.ToArray();
                        string responseText = Encoding.UTF8.GetString(responseBytes);

                        txtResponseText.Text = responseText;
                        txtResponseHex.Text = ConvertToHex(responseBytes);
                        webBrowser1.DocumentText = responseText;
                    }
                }
                else
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + wex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// แปลงข้อมูล byte array เป็นข้อความ Hexadecimal (จัดรูปแบบอ่านง่าย มี offset นำหน้า)
        /// </summary>
        private string ConvertToHex(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            int bytesPerLine = 16;

            for (int i = 0; i < data.Length; i += bytesPerLine)
            {
                // แสดง offset ตำแหน่งเริ่มต้นของแต่ละบรรทัด
                sb.Append(i.ToString("X8") + "   ");

                int lineLength = Math.Min(bytesPerLine, data.Length - i);
                for (int j = 0; j < lineLength; j++)
                {
                    sb.Append(data[i + j].ToString("X2") + " ");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }

        private void Server_IP_Click(object sender, EventArgs e)
        {

        }

        private void ResponseText_Click(object sender, EventArgs e)
        {

        }

        private void ResponseHex_Click(object sender, EventArgs e)
        {

        }
    }
}