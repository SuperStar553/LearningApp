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
                errorProvider1.SetError(btnZatwierdz, "Nie wpisano znaku równa siê");
                return;
            }
            int numerkoniec = kod.IndexOf(";");
            if (numerrowna < 0)
            {
                errorProvider1.SetError(btnZatwierdz, "Nie wpisano œrednika");
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

            errorProvider1.SetError(btnZatwierdz, "B³êdnie wpisana nazwa przycisku");
            return;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            hide_buttons();
            Instrukcje.Location = new Point(50, 120);
            Instrukcje.Text = "Witaj w module dotycz¹cym w³aœciwoœci pozosta³ych kontrolek. Tym razem aby zacz¹æ najpierw wpisujemy wybran¹ przez nas\nnazwê kontrolki. " +
                "Nastêpnie, nie robi¹c odstêpów wpisujemy kropkê, a po nie nazwê w³aœciwoœci któr¹ chcemy zmieniæ.\nZacznijmy od zmiany koloru t³a.W tym celu" +
                "dzia³aniem które chcemy zrobiæ to zmiana parametru BackColor.\nNastêpn¹ czêsci¹ równania jest podanie koloru, który chcemy wybraæ co mo¿na zrobiæ na dwa sposoby. " +
                "Pierwszy z nich to\nwpisanie Color i kropki a nastêpnie nazwy koloru. Drugi to podanie paremetrów rgb barwy czyli ponownie zaczynamy od\nColor i kropki" +
                "ale po tym wpisujemy FromArgb ¿eby zaznaczyæ nasz zamiar u¿ycia innego formatu,\na nastêpnie w nawiasie podajemy 3 liczby odzielone przecinkiem." +
                "\n\nAby kontynuowaæ zmieñ kolor 2 przycisków";
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
            Instrukcje.Text = "Witaj w module przycisku. Jest on jednym z najbardziej podstawowych kontrolek w ka¿dym programie. " +
                "Mo¿na go wykorzystaæ\nna wiele ró¿nych sposobów, a miêdzy innymi do wyœtwietlania nowych elementów, ukrywania poprzednich, " +
                "przejeœcia do innej strony\n i zmiany wygl¹du a tak¿e ma mo¿liwoœæ obs³ugiwania innych opcji zaprogramowanych przez autora aplikacji. Przyciski " +
                "kalulatora\nczy klawiatury s¹ typu Button.\n\n\n Naciœnij Dalej aby kontynuowaæ";
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
            Instrukcje.Text = "Witaj w module dotycz¹cym kontrolki CheckBox. Jest ona czêsto stosowana przy formularzach oraz arkuszach. Ma te¿ ona  " +
                "zastosowanie \nw miejscach, które wymagaj¹ potwierdzenia zaznajomienia siê u¿ytkownika z informacjami" +
                "\n\n\nNaciœnij Dalej aby kontynuowaæ";

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
            Instrukcje.Text = "Witaj w module dotycz¹cym przycisku, aby zacz¹æ zdefiniujmy przycisk i jego nazwê. Aby to zrobiæ nale¿y " +
                "stworzyæ rówanie \nsk³adaj¹ce siê z 2 czêœci. Pierwsza czêœæ to nazwa kontrolki któr¹ chcemy dodaæ czyli w naszym przypadku ComboBox.\n" +
                "Nastêpnie musimy my nadaæ nazwê. Dla potrzeb programu nazwijmy j¹ LearnComboBox. Drug¹ stron¹ równania bêdzie polecenie\nktóre " +
                "nale¿y wykonaæ. Aby podkreœliæ ¿e to nowy przycisk najpierw piszemy new, a nastêonie ponownie nazwê kontrolki\nale tym razem " +
                "zakoñczon¹ nawiasem czyli ComboBox().\n\nAby kontynuowaæ wpisz komendê do pola tekstowego i naciœnij zatwierdŸ.\nW przypadku problemów" +
                "naciœnij przycisk ze wskazówk¹";
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
            Instrukcje.Text = "Witaj w module dotycz¹cym przycisku, aby zacz¹æ zdefiniujmy przycisk i jego nazwê. Aby to zrobiæ nale¿y " +
                "stworzyæ rówanie \nsk³adaj¹ce siê z 2 czêœci. Pierwsza czêœæ to nazwa kontrolki któr¹ chcemy dodaæ czyli w naszym przypadku Label.\n" +
                "Nastêpnie musimy my nadaæ nazwê. Dla potrzeb programu nazwijmy j¹ LearnLabel. Drug¹ stron¹ równania bêdzie polecenie\nktóre " +
                "nale¿y wykonaæ. Aby podkreœliæ ¿e to nowy przycisk najpierw piszemy new, a nastêonie ponownie nazwê kontrolki\nale tym razem " +
                "zakoñczon¹ nawiasem czyli Label().\n\nAby kontynuowaæ wpisz komendê do pola tekstowego i naciœnij zatwierdŸ.\nW przypadku problemów" +
                "naciœnij przycisk ze wskazówk¹";
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
            Instrukcje.Text = "Witaj w module dotycz¹cym przycisku, aby zacz¹æ zdefiniujmy przycisk i jego nazwê. Aby to zrobiæ nale¿y " +
                "stworzyæ rówanie \nsk³adaj¹ce siê z 2 czêœci. Pierwsza czêœæ to nazwa kontrolki któr¹ chcemy dodaæ czyli w naszym przypadku ProgressBar.\n" +
                "Nastêpnie musimy my nadaæ nazwê. Dla potrzeb programu nazwijmy j¹ LearnProgressBar. Drug¹ stron¹ równania bêdzie polecenie\nktóre " +
                "nale¿y wykonaæ. Aby podkreœliæ ¿e to nowy przycisk najpierw piszemy new, a nastêonie ponownie nazwê kontrolki\nale tym razem " +
                "zakoñczon¹ nawiasem czyli ProgressBar().\n\nAby kontynuowaæ wpisz komendê do pola tekstowego i naciœnij zatwierdŸ.\nW przypadku problemów" +
                "naciœnij przycisk ze wskazówk¹";
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
            Instrukcje.Text = "Witaj w module dotycz¹cym przycisku, aby zacz¹æ zdefiniujmy przycisk i jego nazwê. Aby to zrobiæ nale¿y " +
                "stworzyæ rówanie \nsk³adaj¹ce siê z 2 czêœci. Pierwsza czêœæ to nazwa kontrolki któr¹ chcemy dodaæ czyli w naszym przypadku RadioButton.\n" +
                "Nastêpnie musimy my nadaæ nazwê. Dla potrzeb programu nazwijmy j¹ LearnRadioButton. Drug¹ stron¹ równania bêdzie polecenie\nktóre " +
                "nale¿y wykonaæ. Aby podkreœliæ ¿e to nowy przycisk najpierw piszemy new, a nastêonie ponownie nazwê kontrolki\nale tym razem " +
                "zakoñczon¹ nawiasem czyli RadioButton().\n\nAby kontynuowaæ wpisz komendê do pola tekstowego i naciœnij zatwierdŸ.\nW przypadku problemów" +
                "naciœnij przycisk ze wskazówk¹";
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
            Instrukcje.Text = "Witaj w module dotycz¹cym przycisku, aby zacz¹æ zdefiniujmy przycisk i jego nazwê. Aby to zrobiæ nale¿y " +
                "stworzyæ rówanie \nsk³adaj¹ce siê z 2 czêœci. Pierwsza czêœæ to nazwa kontrolki któr¹ chcemy dodaæ czyli w naszym przypadku TextBox.\n" +
                "Nastêpnie musimy my nadaæ nazwê. Dla potrzeb programu nazwijmy j¹ LearnTextBox. Drug¹ stron¹ równania bêdzie polecenie\nktóre " +
                "nale¿y wykonaæ. Aby podkreœliæ ¿e to nowy przycisk najpierw piszemy new, a nastêonie ponownie nazwê kontrolki\nale tym razem " +
                "zakoñczon¹ nawiasem czyli TextBox().\n\nAby kontynuowaæ wpisz komendê do pola tekstowego i naciœnij zatwierdŸ.\nW przypadku problemów" +
                "naciœnij przycisk ze wskazówk¹";
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
                    Instrukcje.Text = "Witaj w module dotycz¹cym przycisku, aby zacz¹æ zdefiniujmy przycisk i jego nazwê. Aby to zrobiæ nale¿y " +
                "stworzyæ rówanie \nsk³adaj¹ce siê z 2 czêœci. Pierwsza czêœæ to nazwa kontrolki któr¹ chcemy dodaæ czyli w naszym przypadku Button.\n" +
                "Nastêpnie musimy my nadaæ nazwê. Dla potrzeb programu nazwijmy j¹ LearnButton. Drug¹ stron¹ równania bêdzie polecenie\nktóre " +
                "nale¿y wykonaæ. Aby podkreœliæ ¿e to nowy przycisk najpierw piszemy new, a nastêonie ponownie nazwê kontrolki\nale tym razem " +
                "zakoñczon¹ nawiasem czyli Button().\n\nAby kontynuowaæ wpisz komendê do pola tekstowego i naciœnij zatwierdŸ.\n\nW przypadku problemów" +
                "naciœnij przycisk ze wskazówk¹";
                    return;
                }
                if (przycisk == 2)
                {
                    Instrukcje.Text = "Witaj w module dotycz¹cym przycisku, aby zacz¹æ zdefiniujmy przycisk i jego nazwê. Aby to zrobiæ nale¿y " +
                "stworzyæ rówanie \nsk³adaj¹ce siê z 2 czêœci. Pierwsza czêœæ to nazwa kontrolki któr¹ chcemy dodaæ czyli w naszym przypadku CheckBox.\n" +
                "Nastêpnie musimy my nadaæ nazwê. Dla potrzeb programu nazwijmy j¹ LearnCheckBox. Drug¹ stron¹ równania bêdzie polecenie\nktóre " +
                "nale¿y wykonaæ. Aby podkreœliæ ¿e to nowy przycisk najpierw piszemy new, a nastêonie ponownie nazwê kontrolki\nale tym razem " +
                "zakoñczon¹ nawiasem czyli CheckBox().\n\nAby kontynuowaæ wpisz komendê do pola tekstowego i naciœnij zatwierdŸ.\n\nW przypadku problemów" +
                "naciœnij przycisk ze wskazówk¹";
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
                toolTip1.SetToolTip(kontrol, "Ukoñczono");
            }
        }

        private void btnCheckBox_MouseHover(object sender, EventArgs e)
        {
            if (CheckBoxDone)
            {
                Control kontrol = (Control)sender;
                toolTip1.SetToolTip(kontrol, "Ukoñczono");
            }

        }

        private void btnComboBox_MouseHover(object sender, EventArgs e)
        {
            if (ComboBoxDone)
            {
                Control kontrol = (Control)sender;
                toolTip1.SetToolTip(kontrol, "Ukoñczono");
            }
        }

        private void btnLabel_MouseHover(object sender, EventArgs e)
        {
            if (LabelDone)
            {
                Control kontrol = (Control)sender;
                toolTip1.SetToolTip(kontrol, "Ukoñczono");
            }
        }

        private void btnProgressBar_MouseHover(object sender, EventArgs e)
        {
            if (ProgressBarDone)
            {
                Control kontrol = (Control)sender;
                toolTip1.SetToolTip(kontrol, "Ukoñczono");
            }
        }

        private void btnRadioButton_MouseHover(object sender, EventArgs e)
        {
            if (RadioButtonDone)
            {
                Control kontrol = (Control)sender;
                toolTip1.SetToolTip(kontrol, "Ukoñczono");
            }
        }

        private void btnTextBox_MouseHover(object sender, EventArgs e)
        {
            if (TextBoxDone)
            {
                Control kontrol = (Control)sender;
                toolTip1.SetToolTip(kontrol, "Ukoñczono");
            }
        }
    }
}
