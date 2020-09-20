using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public enum Character 
        {
            Lower,
            Upper,
            Number,
            Special
        };

        private const int INT_LENGTH = 4;
        private const int CLASS_COUNT = 4;
        private const int LETTER_COUNT = 26;
        private const int NUMBER_COUNT = 10;
        private const int SPECIAL_COUNT = 29;

        private static bool upperC = true;
        private static bool lowerC = true;
        private static bool numberC = false;
        private static bool specialC = false;
        private static int length = 15;

        private static readonly String upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly String lower = "abcdefghijklmnopqrstuvwxyz";
        private static readonly String number = "0123456789";
        private static readonly String special = "&~'(-è_çà)=%!§µ*;:?+-`|[{#@]}";


        public Form1()
        {
            InitializeComponent();
            Error_Label.ForeColor = Color.Red;
            Error_Label.BackColor = Color.Transparent;
        }

        private void Lenght_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Error_Label.Text = "";
                if (Lenght_txt.Text != "")
                    length = Int32.Parse(Lenght_txt.Text);
            } catch (OverflowException)
            {
                ErrorMessage("Taille > " + Int32.MaxValue.ToString(), Error_Label);
            } catch (FormatException)
            {
                ErrorMessage("Entrez un chiffre", Error_Label);
            }
        }

        private void Lower_chk_CheckedChanged(object sender, EventArgs e)
        {
            lowerC = Lower_chk.Checked;
            CheckCheckbox(Error_Label);
        }

        private void Number_chk_CheckedChanged(object sender, EventArgs e)
        {
            numberC = Number_chk.Checked;
            CheckCheckbox(Error_Label);
        }

        private void Special_chk_CheckedChanged(object sender, EventArgs e)
        {
            specialC = Special_chk.Checked;
            CheckCheckbox(Error_Label);
        }

        private void Upper_chk_CheckedChanged(object sender, EventArgs e)
        {
            upperC = Upper_chk.Checked;
            CheckCheckbox(Error_Label);
        }

        private static bool CheckCheckbox(Label Error_label)
        {
            if (!lowerC && !upperC && !numberC && !specialC)
            {
                ErrorMessage("Selectionner au moins une case", Error_label);
                return false;
            }
            else
            {
                Error_label.Text = "";
                return true;
            }
        }

        private static void ErrorMessage(String errorMessage, Label label)
        {
            label.Text = errorMessage;
        }

        private void Generate_bttn_Click(object sender, EventArgs e)
        {
            Copy_Label.Text = "";
            string password = "";

            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

            byte[] bufferInt = new byte[INT_LENGTH];

            if (CheckCheckbox(Error_Label))
            {
                for (int i = 0; i < length; i++)
                {
                    rngCsp.GetBytes(bufferInt);

                    int randomClassInt = 0;

                    foreach (byte b in bufferInt)
                        randomClassInt += b;

                    int randomCharInt = 0;
                    byte[] bufferCharInt = new byte[INT_LENGTH];

                    rngCsp.GetBytes(bufferCharInt);

                    foreach (byte b in bufferCharInt)
                        randomCharInt += b;

                    switch (randomClassInt % CLASS_COUNT)
                    {
                        case (int)Character.Lower:
                            if (lowerC)
                                password += lower[randomCharInt % LETTER_COUNT];
                            else
                                i--;
                            break;
                        case (int)Character.Upper:
                            if (upperC)
                                password += upper[randomCharInt % LETTER_COUNT];
                            else
                                i--;
                            break;
                        case (int)Character.Number:
                            if (numberC)
                                password += number[randomCharInt % NUMBER_COUNT];
                            else
                                i--;
                            break;
                        case (int)Character.Special:
                            if (specialC)
                                password += special[randomCharInt % SPECIAL_COUNT];
                            else
                                i--;
                            break;
                    }
                }
                Result_txt.Visible = true;
                Result_txt.Text = password;
            }
        }

        private void Copy_bttn_Click(object sender, EventArgs e)
        {
            if (Result_txt.Text != "")
            {
                Clipboard.SetText(Result_txt.Text);
                Copy_Label.ForeColor = Color.Green;
                Copy_Label.Text = "Copié !";
            }
        }
    }
}