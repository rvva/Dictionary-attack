using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruteForceAttack
{
    class Credentials
    {
        private LinkedList<Credential> listOfCredentials = new LinkedList<Credential>();

        internal LinkedList<Credential> ListOfCredentials { get => listOfCredentials; set => listOfCredentials = value; }


        public void loadCredentialsFormFile(string path)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(path);
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string [] tab = line.Trim().Split(':');
                        ListOfCredentials.AddLast(new Credential(tab[0], tab[1]));
                    }
                }
                streamReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                streamReader.Close();
            }
        }

        public string credentialsListToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Dictionary contains " + ListOfCredentials.Count + " credentials [login:password]");

            foreach (var item in ListOfCredentials)
            {
                stringBuilder.AppendLine('\t' + item.Login + ':' + item.Password);
            }
            return stringBuilder.ToString();
        }
    }
}

