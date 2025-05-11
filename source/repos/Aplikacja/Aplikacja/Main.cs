using Aplikacja.Properties;

namespace Aplikacja
{

    public partial class MainScreen : Form
    {
        Button LearnButton = new Button();
        CheckBox LearnCheckBox = new CheckBox();
        ComboBox LearnComboBox = new ComboBox();
        Label LearnLabel = new Label();
        ProgressBar LearnProgressBar = new ProgressBar();
        RadioButton LearnRadioButton = new RadioButton();
        TextBox LearnTextBox = new TextBox();

        Label Instrukcje = new Label();
        Button Powrot = new Button();
        int przycisk;

        int liczbaZrobionych = 0;
        bool zadanie = false;
        bool tekst2 = false;

        bool ButtonDone = false;
        bool CheckBoxDone = false;
        bool ComboBoxDone = false;
        bool LabelDone = false;
        bool ProgressBarDone = false;
        bool RadioButtonDone = false;
        bool TextBoxDone = false;
        bool PropertiesDone = false;


        public MainScreen()
        {
            InitializeComponent();


        }

        private void btnOpenSettings_Click(object sender, EventArgs e)
        {
            boxSettings.Visible = true;
            boxSettings.Enabled = true;
        }

        private void btnCloseSettings_Click(object sender, EventArgs e)
        {
            boxSettings.Visible = false;
            boxSettings.Enabled = false;

            if (rbButton.Checked == false)
            {
                ButtonDone = false;
            }

            if (rbCheckBox.Checked == false)
            {
                CheckBoxDone = false;
            }

            if (rbComboBox.Checked == false)
            {
                ComboBoxDone = false;
            }

            if (rbLabel.Checked == false)
            {
                LabelDone = false;
            }

            if (rbProgressBar.Checked == false)
            {
                ProgressBarDone = false;
            }

            if (rbRadioButton.Checked == false)
            {
                RadioButtonDone = false;
            }

            if (rbTextBox.Checked == false)
            {
                TextBoxDone = false;
            }

            if (rbProperties.Checked == false)
            {
                PropertiesDone = false;
            }



        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();

            string kod = txtKod.Text;
            if (kod.Length == 0)
            {
                errorProvider1.SetError(btnZatwierdz, "Nie wpisano kodu");
                return;
            }

            int numerrowna = kod.IndexOf("=");
            if (numerrowna < 0)
            {
                errorProvider1.SetError(btnZatwierdz, "Nie wpisano znaku r�wna si�");
                return;
            }
            int numerkoniec = kod.IndexOf(";");
            if (numerrowna < 0)
            {
                errorProvider1.SetError(btnZatwierdz, "Nie wpisano �rednika");
                return;
            }

            if (zadanie == true)
            {
                int numerSpacja = kod.IndexOf(" ");
                string przycisk2 = kod.Substring(0, numerSpacja);
                string nazwaPrzycisku;

                if (przycisk2 == "Button")
                {
                    nazwaPrzycisku = kod.Substring(numerSpacja + 1, numerrowna - (numerSpacja + 2));
                    string NowyB = kod.Substring(numerrowna + 2, numerkoniec - numerrowna - 1);
                    Point Punkt = new Point(100, 300);

                    if (NowyB == "new Button();")
                    {

                        if (nazwaPrzycisku == "LearnButton")
                        {
                            LearnButton.Location = Punkt;
                            LearnButton.Text = "LearnButton";
                            LearnButton.AutoSize = true;
                            this.Controls.Add(LearnButton);
                            ButtonDone = true;
                            rbButton.Checked = true;

                        }
                    }

                }
                if (przycisk2 == "CheckBox")
                {
                    nazwaPrzycisku = kod.Substring(numerSpacja + 1, numerrowna - (numerSpacja + 2));
                    string NowyB = kod.Substring(numerrowna + 2, numerkoniec - numerrowna - 1);
                    Point Punkt = new Point(100, 300);

                    if (NowyB == "new CheckBox();")
                    {

                        if (nazwaPrzycisku == "LearnCheckBox")
                        {
                            LearnCheckBox.Location = Punkt;
                            LearnCheckBox.Text = "LearnCheckBox";
                            LearnCheckBox.AutoSize = true;
                            this.Controls.Add(LearnCheckBox);
                            CheckBoxDone = true;
                            rbCheckBox.Checked = true;
                            return;
                        }
                    }

                }
                if (przycisk2 == "ComboBox")
                {
                    nazwaPrzycisku = kod.Substring(numerSpacja + 1, numerrowna - (numerSpacja + 2));
                    string NowyB = kod.Substring(numerrowna + 2, numerkoniec - numerrowna - 1);
                    Point Punkt = new Point(100, 300);

                    if (NowyB == "new ComboBox();")
                    {

                        if (nazwaPrzycisku == "LearnComboBox")
                        {
                            LearnComboBox.Location = Punkt;
                            LearnComboBox.Text = "LearnComboBox";
                            LearnComboBox.AutoSize = true;
                            this.Controls.Add(LearnComboBox);
                            ComboBoxDone = true;
                            rbComboBox.Checked = true;
                            return;

                        }
                    }

                }
                if (przycisk2 == "Label")
                {
                    nazwaPrzycisku = kod.Substring(numerSpacja + 1, numerrowna - (numerSpacja + 2));
                    string NowyB = kod.Substring(numerrowna + 2, numerkoniec - numerrowna - 1);
                    Point Punkt = new Point(100, 300);

                    if (NowyB == "new Label();")
                    {

                        if (nazwaPrzycisku == "LearnLabel")
                        {
                            LearnLabel.Location = Punkt;
                            LearnLabel.Text = "LearnLabel";
                            LearnLabel.AutoSize = true;
                            this.Controls.Add(LearnLabel);
                            LabelDone = true;
                            rbLabel.Checked = true;
                            return;

                        }
                    }

                }
                if (przycisk2 == "ProgressBar")
                {
                    nazwaPrzycisku = kod.Substring(numerSpacja + 1, numerrowna - (numerSpacja + 2));
                    string NowyB = kod.Substring(numerrowna + 2, numerkoniec - numerrowna - 1);
                    Point Punkt = new Point(100, 300);

                    if (NowyB == "new ProgressBar();")
                    {

                        if (nazwaPrzycisku == "LearnProgressBar")
                        {
                            LearnProgressBar.Location = Punkt;
                            LearnProgressBar.Text = "LearnProgressBar";
                            LearnProgressBar.AutoSize = true;
                            this.Controls.Add(LearnProgressBar);
                            ProgressBarDone = true;
                            rbProgressBar.Checked = true;
                            return;
                        }
                    }

                }
                if (przycisk2 == "RadioButton")
                {
                    nazwaPrzycisku = kod.Substring(numerSpacja + 1, numerrowna - (numerSpacja + 2));
                    string NowyB = kod.Substring(numerrowna + 2, numerkoniec - numerrowna - 1);
                    Point Punkt = new Point(100, 300);

                    if (NowyB == "new RadioButton();")
                    {

                        if (nazwaPrzycisku == "LearnRadioButton")
                        {
                            LearnRadioButton.Location = Punkt;
                            LearnRadioButton.Text = "LearnRadioButton";
                            LearnRadioButton.AutoSize = true;
                            this.Controls.Add(LearnRadioButton);
                            RadioButtonDone = true;
                            rbRadioButton.Checked = true;
                            return;

                        }
                    }

                }
                if (przycisk2 == "TextBox")
                {
                    nazwaPrzycisku = kod.Substring(numerSpacja + 1, numerrowna - (numerSpacja + 2));
                    string NowyB = kod.Substring(numerrowna + 2, numerkoniec - numerrowna - 1);
                    Point Punkt = new Point(100, 300);

                    if (NowyB == "new TextBox();")
                    {

                        if (nazwaPrzycisku == "LearnTextBox")
                        {
                            LearnTextBox.Location = Punkt;
                            LearnTextBox.Text = "LearnTextBox";
                            LearnTextBox.AutoSize = true;
                            this.Controls.Add(LearnTextBox);
                            TextBoxDone = true;
                            rbTextBox.Checked = true;
                            return;

                        }
                    }

                }


                return;
            }


            int numerkropka = kod.IndexOf(".");


            int numercudzy1 = kod.IndexOf("\"");
            int numercudzy2 = kod.LastIndexOf("\"");



            if (numerkropka < 0)
            {
                errorProvider1.SetError(btnZatwierdz, "Nie wpisano kropki");
                return;
            }
            string przycisk = kod.Substring(0, numerkropka);

            string funkcja = kod.Substring(numerkropka + 1, numerrowna - (numerkropka + 2));


            if (przycisk == "btnButton")
            {

                if (funkcja == "BackColor")
                {
                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnButton.BackColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnButton.BackColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.ButtonColor = btnButton.BackColor;
                    Settings1.Default.Save();
                    return;

                }
                else if (funkcja == "ForeColor")
                {

                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnButton.ForeColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnButton.ForeColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.ButtonTColor = btnButton.ForeColor;
                    Settings1.Default.Save();
                    return;
                }


            }

            else if (przycisk == "btnCheckBox")
            {

                if (funkcja == "BackColor")
                {
                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnCheckBox.BackColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnCheckBox.BackColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.CheckBoxColor = btnCheckBox.BackColor;
                    Settings1.Default.Save();
                    return;

                }
                else if (funkcja == "ForeColor")
                {

                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnCheckBox.ForeColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnCheckBox.ForeColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.CheckBoxTColor = btnCheckBox.ForeColor;
                    Settings1.Default.Save();
                    return;
                }


            }

            else if (przycisk == "btnComboBox")
            {

                if (funkcja == "BackColor")
                {
                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnComboBox.BackColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnComboBox.BackColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.ComboBoxColor = btnComboBox.BackColor;
                    Settings1.Default.Save();
                    return;

                }
                else if (funkcja == "ForeColor")
                {

                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnComboBox.ForeColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnComboBox.ForeColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.ComboBoxTColor = btnComboBox.ForeColor;
                    Settings1.Default.Save();
                    return;
                }


            }

            else if (przycisk == "btnLabel")
            {

                if (funkcja == "BackColor")
                {
                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnLabel.BackColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnLabel.BackColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.LabelColor = btnLabel.BackColor;
                    Settings1.Default.Save();
                    return;


                }

                else if (funkcja == "ForeColor")
                {

                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnLabel.ForeColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnLabel.ForeColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.LabelTColor = btnLabel.ForeColor;
                    Settings1.Default.Save();
                    return;
                }


            }

            else if (przycisk == "btnProgressBar")
            {

                if (funkcja == "BackColor")
                {
                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnProgressBar.BackColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnProgressBar.BackColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.ProgressBarColor = btnProgressBar.BackColor;
                    Settings1.Default.Save();
                    return;
                }

                else if (funkcja == "ForeColor")
                {

                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnProgressBar.ForeColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnProgressBar.ForeColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.ProgressBarTColor = btnProgressBar.ForeColor;
                    Settings1.Default.Save();
                    return;
                }


            }

            else if (przycisk == "btnRadioButton")
            {

                if (funkcja == "BackColor")
                {
                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnRadioButton.BackColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnRadioButton.BackColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.RadioButtonColor = btnRadioButton.BackColor;
                    Settings1.Default.Save();
                    return;
                }


                else if (funkcja == "ForeColor")
                {

                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnRadioButton.ForeColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnRadioButton.ForeColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.RadioButtonTColor = btnRadioButton.ForeColor;
                    Settings1.Default.Save();
                    return;
                }

            }

            else if (przycisk == "btnTextBox")
            {

                if (funkcja == "BackColor")
                {
                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnTextBox.BackColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnTextBox.BackColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.TextBoxColor = btnTextBox.BackColor;
                    Settings1.Default.Save();
                    return;

                }

                else if (funkcja == "ForeColor")
                {

                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnTextBox.ForeColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnTextBox.ForeColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.TextBoxTColor = btnTextBox.ForeColor;
                    Settings1.Default.Save();
                    return;
                }


            }

            else if (przycisk == "btnProperties")
            {

                if (funkcja == "BackColor")
                {
                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnProperties.BackColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnProperties.BackColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.PropertiesColor = btnProperties.BackColor;
                    Settings1.Default.Save();
                    return;

                }

                else if (funkcja == "ForeColor")
                {

                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        btnProperties.ForeColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        btnProperties.ForeColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.PropertiesTColor = btnProperties.ForeColor;
                    Settings1.Default.Save();
                    return;
                }


            }

            else if (przycisk == "this")
            {

                if (funkcja == "BackColor")
                {
                    Color kolor;
                    int kropka = kod.LastIndexOf(".");


                    if (kropka != -1 && kropka != numerkropka)
                    {

                        string wybor = kod.Substring(kropka + 1, numerkoniec - kropka - 1);
                        kolor = Color.FromName(wybor);

                        this.BackColor = kolor;



                    }
                    else
                    {
                        int nawias1 = kod.IndexOf("(");
                        int nawias2 = kod.IndexOf(")");
                        string wybor = kod.Substring(nawias1 + 1, nawias2 - nawias1 - 1);



                        string[] rgb = wybor.Split(",");
                        int red = int.Parse(rgb[0]);
                        int green = int.Parse(rgb[1]);
                        int blue = int.Parse(rgb[2]);



                        this.BackColor = Color.FromArgb(red, green, blue);
                    }

                    Settings1.Default.ThisColor = this.BackColor;
                    Settings1.Default.Save();
                    return;

                }


            }

            errorProvider1.SetError(btnZatwierdz, "B��dnie wpisana nazwa przycisku");
            return;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            hide_buttons();
            Instrukcje.Location = new Point(50, 120);
            Instrukcje.Text = "Witaj w module dotycz�cym w�a�ciwo�ci pozosta�ych kontrolek. Tym razem aby zacz�� najpierw wpisujemy wybran� przez nas\nnazw� kontrolki. " +
                "Nast�pnie, nie robi�c odst�p�w wpisujemy kropk�, a po nie nazw� w�a�ciwo�ci kt�r� chcemy zmieni�.\nZacznijmy od zmiany koloru t�a.W tym celu" +
                "dzia�aniem kt�re chcemy zrobi� to zmiana parametru BackColor.\nNast�pn� cz�sci� r�wnania jest podanie koloru, kt�ry chcemy wybra� co mo�na zrobi� na dwa sposoby. " +
                "Pierwszy z nich to\nwpisanie Color i kropki a nast�pnie nazwy koloru. Drugi to podanie paremetr�w rgb barwy czyli ponownie zaczynamy od\nColor i kropki" +
                "ale po tym wpisujemy FromArgb �eby zaznaczy� nasz zamiar u�ycia innego formatu,\na nast�pnie w nawiasie podajemy 3 liczby odzielone przecinkiem." +
                "\n\nAby kontynuowa� zmie� kolor 2 przycisk�w";
            Instrukcje.AutoSize = true;
            this.Controls.Add(Instrukcje);
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            btnButton.BackColor = Settings1.Default.ButtonColor;
            btnButton.ForeColor = Settings1.Default.ButtonTColor;

            btnCheckBox.BackColor = Settings1.Default.CheckBoxColor;
            btnCheckBox.ForeColor = Settings1.Default.CheckBoxTColor;

            btnComboBox.BackColor = Settings1.Default.ComboBoxColor;
            btnComboBox.ForeColor = Settings1.Default.ComboBoxTColor;

            btnLabel.BackColor = Settings1.Default.LabelColor;
            btnLabel.ForeColor = Settings1.Default.LabelTColor;

            btnProgressBar.BackColor = Settings1.Default.ProgressBarColor;
            btnProgressBar.ForeColor = Settings1.Default.ProgressBarTColor;

            btnRadioButton.BackColor = Settings1.Default.RadioButtonColor;
            btnRadioButton.ForeColor = Settings1.Default.RadioButtonTColor;

            btnTextBox.BackColor = Settings1.Default.TextBoxColor;
            btnTextBox.ForeColor = Settings1.Default.TextBoxTColor;

            btnProperties.BackColor = Settings1.Default.PropertiesColor;
            btnProperties.ForeColor = Settings1.Default.PropertiesTColor;

            this.BackColor = Settings1.Default.ThisColor;




        }

        private void hide_buttons()
        {

            zadanie = true;

            btnButton.Visible = false;
            btnButton.Enabled = false;

            btnCheckBox.Visible = false;
            btnCheckBox.Enabled = false;

            btnComboBox.Visible = false;
            btnComboBox.Enabled = false;

            btnLabel.Visible = false;
            btnLabel.Enabled = false;

            btnProgressBar.Visible = false;
            btnProgressBar.Enabled = false;

            btnRadioButton.Visible = false;
            btnRadioButton.Enabled = false;

            btnTextBox.Visible = false;
            btnTextBox.Enabled = false;

            btnProperties.Visible = false;
            btnProperties.Enabled = false;




        }

        private void show_butons()
        {
            zadanie = false;

            btnButton.Visible = true;
            btnButton.Enabled = true;

            btnCheckBox.Visible = true;
            btnCheckBox.Enabled = true;

            btnComboBox.Visible = true;
            btnComboBox.Enabled = true;

            btnLabel.Visible = true;
            btnLabel.Enabled = true;

            btnProgressBar.Visible = true;
            btnProgressBar.Enabled = true;

            btnRadioButton.Visible = true;
            btnRadioButton.Enabled = true;

            btnTextBox.Visible = true;
            btnTextBox.Enabled = true;

            btnProperties.Visible = true;
            btnProperties.Enabled = true;


            btnTip.Visible = false;
            btnTip.Enabled = false;
            lblTipText.Visible = false;


            this.Controls.Remove(Instrukcje);
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            if (ButtonDone)
            {
                return;
            }
            hide_buttons();
            przycisk = 1;

            Instrukcje.Location = new Point(50, 120);
            Instrukcje.Text = "Witaj w module przycisku. Jest on jednym z najbardziej podstawowych kontrolek w ka�dym programie. " +
                "Mo�na go wykorzysta�\nna wiele r�nych sposob�w, a mi�dzy innymi do wy�twietlania nowych element�w, ukrywania poprzednich, " +
                "przeje�cia do innej strony\n i zmiany wygl�du a tak�e ma mo�liwo�� obs�ugiwania innych opcji zaprogramowanych przez autora aplikacji. Przyciski " +
                "kalulatora\nczy klawiatury s� typu Button.\n\n\n Naci�nij Dalej aby kontynuowa�";
            Instrukcje.AutoSize = true;
            this.Controls.Add(Instrukcje);
        }

        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            if (CheckBoxDone)
                return;
            przycisk = 2;
            hide_buttons();
            Instrukcje.Location = new Point(50, 120);
            Instrukcje.Text = "Witaj w module dotycz�cym kontrolki CheckBox. Jest ona cz�sto stosowana przy formularzach oraz arkuszach. Ma te� ona  " +
                "zastosowanie \nw miejscach, kt�re wymagaj� potwierdzenia zaznajomienia si� u�ytkownika z informacjami" +
                "\n\n\nNaci�nij Dalej aby kontynuowa�";

            Instrukcje.AutoSize = true;
            this.Controls.Add(Instrukcje);
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
            if (ComboBoxDone)
                return;
            przycisk = 3;
            hide_buttons();
            Instrukcje.Location = new Point(50, 120);
            Instrukcje.Text = "Witaj w module dotycz�cym przycisku, aby zacz�� zdefiniujmy przycisk i jego nazw�. Aby to zrobi� nale�y " +
                "stworzy� r�wanie \nsk�adaj�ce si� z 2 cz�ci. Pierwsza cz�� to nazwa kontrolki kt�r� chcemy doda� czyli w naszym przypadku ComboBox.\n" +
                "Nast�pnie musimy my nada� nazw�. Dla potrzeb programu nazwijmy j� LearnComboBox. Drug� stron� r�wnania b�dzie polecenie\nkt�re " +
                "nale�y wykona�. Aby podkre�li� �e to nowy przycisk najpierw piszemy new, a nast�onie ponownie nazw� kontrolki\nale tym razem " +
                "zako�czon� nawiasem czyli ComboBox().\n\nAby kontynuowa� wpisz komend� do pola tekstowego i naci�nij zatwierd�.\nW przypadku problem�w" +
                "naci�nij przycisk ze wskaz�wk�";
            Instrukcje.AutoSize = true;
            this.Controls.Add(Instrukcje);
        }

        private void btnLabel_Click(object sender, EventArgs e)
        {
            if (LabelDone)
                return;
            przycisk = 4;
            hide_buttons();
            Instrukcje.Location = new Point(50, 120);
            Instrukcje.Text = "Witaj w module dotycz�cym przycisku, aby zacz�� zdefiniujmy przycisk i jego nazw�. Aby to zrobi� nale�y " +
                "stworzy� r�wanie \nsk�adaj�ce si� z 2 cz�ci. Pierwsza cz�� to nazwa kontrolki kt�r� chcemy doda� czyli w naszym przypadku Label.\n" +
                "Nast�pnie musimy my nada� nazw�. Dla potrzeb programu nazwijmy j� LearnLabel. Drug� stron� r�wnania b�dzie polecenie\nkt�re " +
                "nale�y wykona�. Aby podkre�li� �e to nowy przycisk najpierw piszemy new, a nast�onie ponownie nazw� kontrolki\nale tym razem " +
                "zako�czon� nawiasem czyli Label().\n\nAby kontynuowa� wpisz komend� do pola tekstowego i naci�nij zatwierd�.\nW przypadku problem�w" +
                "naci�nij przycisk ze wskaz�wk�";
            Instrukcje.AutoSize = true;
            this.Controls.Add(Instrukcje);
        }

        private void btnProgressBar_Click(object sender, EventArgs e)
        {
            if (ProgressBarDone)
                return;
            przycisk = 5;
            hide_buttons();
            Instrukcje.Location = new Point(50, 120);
            Instrukcje.Text = "Witaj w module dotycz�cym przycisku, aby zacz�� zdefiniujmy przycisk i jego nazw�. Aby to zrobi� nale�y " +
                "stworzy� r�wanie \nsk�adaj�ce si� z 2 cz�ci. Pierwsza cz�� to nazwa kontrolki kt�r� chcemy doda� czyli w naszym przypadku ProgressBar.\n" +
                "Nast�pnie musimy my nada� nazw�. Dla potrzeb programu nazwijmy j� LearnProgressBar. Drug� stron� r�wnania b�dzie polecenie\nkt�re " +
                "nale�y wykona�. Aby podkre�li� �e to nowy przycisk najpierw piszemy new, a nast�onie ponownie nazw� kontrolki\nale tym razem " +
                "zako�czon� nawiasem czyli ProgressBar().\n\nAby kontynuowa� wpisz komend� do pola tekstowego i naci�nij zatwierd�.\nW przypadku problem�w" +
                "naci�nij przycisk ze wskaz�wk�";
            Instrukcje.AutoSize = true;
            this.Controls.Add(Instrukcje);
        }

        private void btnRadioButton_Click(object sender, EventArgs e)
        {
            if (RadioButtonDone)
                return;
            przycisk = 6;
            hide_buttons();
            Instrukcje.Location = new Point(50, 120);
            Instrukcje.Text = "Witaj w module dotycz�cym przycisku, aby zacz�� zdefiniujmy przycisk i jego nazw�. Aby to zrobi� nale�y " +
                "stworzy� r�wanie \nsk�adaj�ce si� z 2 cz�ci. Pierwsza cz�� to nazwa kontrolki kt�r� chcemy doda� czyli w naszym przypadku RadioButton.\n" +
                "Nast�pnie musimy my nada� nazw�. Dla potrzeb programu nazwijmy j� LearnRadioButton. Drug� stron� r�wnania b�dzie polecenie\nkt�re " +
                "nale�y wykona�. Aby podkre�li� �e to nowy przycisk najpierw piszemy new, a nast�onie ponownie nazw� kontrolki\nale tym razem " +
                "zako�czon� nawiasem czyli RadioButton().\n\nAby kontynuowa� wpisz komend� do pola tekstowego i naci�nij zatwierd�.\nW przypadku problem�w" +
                "naci�nij przycisk ze wskaz�wk�";
            Instrukcje.AutoSize = true;
            this.Controls.Add(Instrukcje);
        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            if (TextBoxDone)
                return;
            przycisk = 7;
            hide_buttons();
            Instrukcje.Location = new Point(50, 120);
            Instrukcje.Text = "Witaj w module dotycz�cym przycisku, aby zacz�� zdefiniujmy przycisk i jego nazw�. Aby to zrobi� nale�y " +
                "stworzy� r�wanie \nsk�adaj�ce si� z 2 cz�ci. Pierwsza cz�� to nazwa kontrolki kt�r� chcemy doda� czyli w naszym przypadku TextBox.\n" +
                "Nast�pnie musimy my nada� nazw�. Dla potrzeb programu nazwijmy j� LearnTextBox. Drug� stron� r�wnania b�dzie polecenie\nkt�re " +
                "nale�y wykona�. Aby podkre�li� �e to nowy przycisk najpierw piszemy new, a nast�onie ponownie nazw� kontrolki\nale tym razem " +
                "zako�czon� nawiasem czyli TextBox().\n\nAby kontynuowa� wpisz komend� do pola tekstowego i naci�nij zatwierd�.\nW przypadku problem�w" +
                "naci�nij przycisk ze wskaz�wk�";
            Instrukcje.AutoSize = true;
            this.Controls.Add(Instrukcje);
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {

            if (tekst2 == true)
            {
                if (ButtonDone || CheckBoxDone)
                {
                    Controls.Remove(LearnButton);
                    Controls.Remove(LearnComboBox);
                    Controls.Remove(LearnLabel);
                    Controls.Remove(LearnProgressBar);
                    Controls.Remove(LearnRadioButton);
                    Controls.Remove(LearnTextBox);
                    Controls.Remove(LearnCheckBox);


                    show_butons();
                    return;
                }
                else
                {
                    btnButton_Click(this, e);
                    tekst2 = false;
                }
            }
            else
            {
                Controls.Remove(LearnButton);
                Controls.Remove(LearnComboBox);
                Controls.Remove(LearnLabel);
                Controls.Remove(LearnProgressBar);
                Controls.Remove(LearnRadioButton);
                Controls.Remove(LearnTextBox);
                Controls.Remove(LearnCheckBox);


                show_butons();
            }
        }

        private void btnDalej_Click(object sender, EventArgs e)
        {


            if (zadanie == true)
            {
                tekst2 = true;
                btnTip.Visible = true;
                btnTip.Enabled = true;

                if (przycisk == 1)
                {
                    Instrukcje.Text = "Witaj w module dotycz�cym przycisku, aby zacz�� zdefiniujmy przycisk i jego nazw�. Aby to zrobi� nale�y " +
                "stworzy� r�wanie \nsk�adaj�ce si� z 2 cz�ci. Pierwsza cz�� to nazwa kontrolki kt�r� chcemy doda� czyli w naszym przypadku Button.\n" +
                "Nast�pnie musimy my nada� nazw�. Dla potrzeb programu nazwijmy j� LearnButton. Drug� stron� r�wnania b�dzie polecenie\nkt�re " +
                "nale�y wykona�. Aby podkre�li� �e to nowy przycisk najpierw piszemy new, a nast�onie ponownie nazw� kontrolki\nale tym razem " +
                "zako�czon� nawiasem czyli Button().\n\nAby kontynuowa� wpisz komend� do pola tekstowego i naci�nij zatwierd�.\n\nW przypadku problem�w" +
                "naci�nij przycisk ze wskaz�wk�";
                    return;
                }
                if (przycisk == 2)
                {
                    Instrukcje.Text = "Witaj w module dotycz�cym przycisku, aby zacz�� zdefiniujmy przycisk i jego nazw�. Aby to zrobi� nale�y " +
                "stworzy� r�wanie \nsk�adaj�ce si� z 2 cz�ci. Pierwsza cz�� to nazwa kontrolki kt�r� chcemy doda� czyli w naszym przypadku CheckBox.\n" +
                "Nast�pnie musimy my nada� nazw�. Dla potrzeb programu nazwijmy j� LearnCheckBox. Drug� stron� r�wnania b�dzie polecenie\nkt�re " +
                "nale�y wykona�. Aby podkre�li� �e to nowy przycisk najpierw piszemy new, a nast�onie ponownie nazw� kontrolki\nale tym razem " +
                "zako�czon� nawiasem czyli CheckBox().\n\nAby kontynuowa� wpisz komend� do pola tekstowego i naci�nij zatwierd�.\n\nW przypadku problem�w" +
                "naci�nij przycisk ze wskaz�wk�";
                }
                if (przycisk == 3)
                {
                    Instrukcje.Text = " ";
                }
                if (przycisk == 4)
                {
                    Instrukcje.Text = " ";
                }
                if (przycisk == 5)
                {
                    Instrukcje.Text = " ";
                }
                if (przycisk == 6)
                {
                    Instrukcje.Text = " ";
                }
                if (przycisk == 7)
                {
                    Instrukcje.Text = " ";
                }

            }
        }

        private void btnTip_Click(object sender, EventArgs e)
        {
            lblTipText.Visible = true;
            if (przycisk == 1)
            {
                lblTipText.Text = "Button LearnButton = new Button();";
            }
            if (przycisk == 2)
            {
                lblTipText.Text = "CheckBox LearnCheckBox = new CheckBox();";
            }
            if (przycisk == 3)
            {
                lblTipText.Text = "ComboBox LearnComboBox = new ComboBox();";
            }
            if (przycisk == 4)
            {
                lblTipText.Text = "Label LearnLabel = new Label();";
            }
            if (przycisk == 5)
            {
                lblTipText.Text = "ProgressBar LearnProgressBar = new ProgressBar();";
            }
            if (przycisk == 6)
            {
                lblTipText.Text = "RadioButton LearnRadioButton = new RadioButton();";
            }
            if (przycisk == 7)
            {
                lblTipText.Text = "TextBox LearnTextBox = new TextBox();";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CompletedHover(object sender, EventArgs e)
        {

            if (ButtonDone)
            {
                Control kontrol = (Control)sender;
                toolTip1.SetToolTip(kontrol, "Uko�czono");
            }
        }

        private void btnCheckBox_MouseHover(object sender, EventArgs e)
        {
            if (CheckBoxDone)
            {
                Control kontrol = (Control)sender;
                toolTip1.SetToolTip(kontrol, "Uko�czono");
            }

        }

        private void btnComboBox_MouseHover(object sender, EventArgs e)
        {
            if (ComboBoxDone)
            {
                Control kontrol = (Control)sender;
                toolTip1.SetToolTip(kontrol, "Uko�czono");
            }
        }

        private void btnLabel_MouseHover(object sender, EventArgs e)
        {
            if (LabelDone)
            {
                Control kontrol = (Control)sender;
                toolTip1.SetToolTip(kontrol, "Uko�czono");
            }
        }

        private void btnProgressBar_MouseHover(object sender, EventArgs e)
        {
            if (ProgressBarDone)
            {
                Control kontrol = (Control)sender;
                toolTip1.SetToolTip(kontrol, "Uko�czono");
            }
        }

        private void btnRadioButton_MouseHover(object sender, EventArgs e)
        {
            if (RadioButtonDone)
            {
                Control kontrol = (Control)sender;
                toolTip1.SetToolTip(kontrol, "Uko�czono");
            }
        }

        private void btnTextBox_MouseHover(object sender, EventArgs e)
        {
            if (TextBoxDone)
            {
                Control kontrol = (Control)sender;
                toolTip1.SetToolTip(kontrol, "Uko�czono");
            }
        }
    }
}
