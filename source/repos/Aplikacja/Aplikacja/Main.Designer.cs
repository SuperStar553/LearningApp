namespace Aplikacja
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            label1 = new Label();
            boxSettings = new GroupBox();
            label2 = new Label();
            rbProperties = new RadioButton();
            rbTextBox = new RadioButton();
            rbRadioButton = new RadioButton();
            rbProgressBar = new RadioButton();
            rbLabel = new RadioButton();
            rbComboBox = new RadioButton();
            rbCheckBox = new RadioButton();
            rbButton = new RadioButton();
            btnCloseSettings = new Button();
            btnDalej = new Button();
            btnPowrot = new Button();
            btnZatwierdz = new Button();
            btnOpenSettings = new Button();
            btnButton = new Button();
            btnComboBox = new Button();
            btnProgressBar = new Button();
            btnTextBox = new Button();
            btnCheckBox = new Button();
            btnLabel = new Button();
            btnRadioButton = new Button();
            btnProperties = new Button();
            txtKod = new RichTextBox();
            errorProvider1 = new ErrorProvider(components);
            btnTip = new Button();
            lblTipText = new Label();
            toolTip1 = new ToolTip(components);
            boxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ControlText;
            label1.Name = "label1";
            // 
            // boxSettings
            // 
            boxSettings.BackColor = Color.FromArgb(255, 255, 192);
            resources.ApplyResources(boxSettings, "boxSettings");
            boxSettings.Controls.Add(label2);
            boxSettings.Controls.Add(rbProperties);
            boxSettings.Controls.Add(rbTextBox);
            boxSettings.Controls.Add(rbRadioButton);
            boxSettings.Controls.Add(rbProgressBar);
            boxSettings.Controls.Add(rbLabel);
            boxSettings.Controls.Add(rbComboBox);
            boxSettings.Controls.Add(rbCheckBox);
            boxSettings.Controls.Add(rbButton);
            boxSettings.Controls.Add(btnCloseSettings);
            boxSettings.Name = "boxSettings";
            boxSettings.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // rbProperties
            // 
            resources.ApplyResources(rbProperties, "rbProperties");
            rbProperties.Name = "rbProperties";
            rbProperties.TabStop = true;
            rbProperties.UseVisualStyleBackColor = true;
            // 
            // rbTextBox
            // 
            resources.ApplyResources(rbTextBox, "rbTextBox");
            rbTextBox.Name = "rbTextBox";
            rbTextBox.TabStop = true;
            rbTextBox.UseVisualStyleBackColor = true;
            // 
            // rbRadioButton
            // 
            resources.ApplyResources(rbRadioButton, "rbRadioButton");
            rbRadioButton.Name = "rbRadioButton";
            rbRadioButton.TabStop = true;
            rbRadioButton.UseVisualStyleBackColor = true;
            // 
            // rbProgressBar
            // 
            resources.ApplyResources(rbProgressBar, "rbProgressBar");
            rbProgressBar.Name = "rbProgressBar";
            rbProgressBar.TabStop = true;
            rbProgressBar.UseVisualStyleBackColor = true;
            // 
            // rbLabel
            // 
            resources.ApplyResources(rbLabel, "rbLabel");
            rbLabel.Name = "rbLabel";
            rbLabel.TabStop = true;
            rbLabel.UseVisualStyleBackColor = true;
            // 
            // rbComboBox
            // 
            resources.ApplyResources(rbComboBox, "rbComboBox");
            rbComboBox.Name = "rbComboBox";
            rbComboBox.TabStop = true;
            rbComboBox.UseVisualStyleBackColor = true;
            rbComboBox.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rbCheckBox
            // 
            resources.ApplyResources(rbCheckBox, "rbCheckBox");
            rbCheckBox.Name = "rbCheckBox";
            rbCheckBox.TabStop = true;
            rbCheckBox.UseVisualStyleBackColor = true;
            // 
            // rbButton
            // 
            resources.ApplyResources(rbButton, "rbButton");
            rbButton.Name = "rbButton";
            rbButton.TabStop = true;
            rbButton.UseVisualStyleBackColor = true;
            // 
            // btnCloseSettings
            // 
            btnCloseSettings.Cursor = Cursors.Hand;
            resources.ApplyResources(btnCloseSettings, "btnCloseSettings");
            btnCloseSettings.Name = "btnCloseSettings";
            btnCloseSettings.UseVisualStyleBackColor = true;
            btnCloseSettings.Click += btnCloseSettings_Click;
            // 
            // btnDalej
            // 
            resources.ApplyResources(btnDalej, "btnDalej");
            btnDalej.Name = "btnDalej";
            btnDalej.UseVisualStyleBackColor = true;
            btnDalej.Click += btnDalej_Click;
            // 
            // btnPowrot
            // 
            resources.ApplyResources(btnPowrot, "btnPowrot");
            btnPowrot.Name = "btnPowrot";
            btnPowrot.UseVisualStyleBackColor = true;
            btnPowrot.Click += btnPowrot_Click;
            // 
            // btnZatwierdz
            // 
            resources.ApplyResources(btnZatwierdz, "btnZatwierdz");
            btnZatwierdz.Name = "btnZatwierdz";
            btnZatwierdz.UseVisualStyleBackColor = true;
            btnZatwierdz.Click += btnZatwierdz_Click;
            // 
            // btnOpenSettings
            // 
            resources.ApplyResources(btnOpenSettings, "btnOpenSettings");
            btnOpenSettings.Cursor = Cursors.Hand;
            btnOpenSettings.Name = "btnOpenSettings";
            btnOpenSettings.UseVisualStyleBackColor = true;
            btnOpenSettings.Click += btnOpenSettings_Click;
            // 
            // btnButton
            // 
            btnButton.BackColor = SystemColors.Menu;
            btnButton.Cursor = Cursors.Hand;
            resources.ApplyResources(btnButton, "btnButton");
            btnButton.Name = "btnButton";
            btnButton.UseVisualStyleBackColor = false;
            btnButton.Click += btnButton_Click;
            btnButton.MouseHover += CompletedHover;
            // 
            // btnComboBox
            // 
            btnComboBox.Cursor = Cursors.Hand;
            resources.ApplyResources(btnComboBox, "btnComboBox");
            btnComboBox.Name = "btnComboBox";
            btnComboBox.UseVisualStyleBackColor = true;
            btnComboBox.Click += btnComboBox_Click;
            btnComboBox.MouseHover += btnComboBox_MouseHover;
            // 
            // btnProgressBar
            // 
            btnProgressBar.Cursor = Cursors.Hand;
            resources.ApplyResources(btnProgressBar, "btnProgressBar");
            btnProgressBar.Name = "btnProgressBar";
            btnProgressBar.UseVisualStyleBackColor = true;
            btnProgressBar.Click += btnProgressBar_Click;
            btnProgressBar.MouseHover += btnProgressBar_MouseHover;
            // 
            // btnTextBox
            // 
            btnTextBox.Cursor = Cursors.Hand;
            resources.ApplyResources(btnTextBox, "btnTextBox");
            btnTextBox.Name = "btnTextBox";
            btnTextBox.UseVisualStyleBackColor = true;
            btnTextBox.Click += btnTextBox_Click;
            btnTextBox.MouseHover += btnTextBox_MouseHover;
            // 
            // btnCheckBox
            // 
            btnCheckBox.Cursor = Cursors.Hand;
            resources.ApplyResources(btnCheckBox, "btnCheckBox");
            btnCheckBox.Name = "btnCheckBox";
            btnCheckBox.UseVisualStyleBackColor = true;
            btnCheckBox.Click += btnCheckBox_Click;
            btnCheckBox.MouseHover += btnCheckBox_MouseHover;
            // 
            // btnLabel
            // 
            btnLabel.Cursor = Cursors.Hand;
            resources.ApplyResources(btnLabel, "btnLabel");
            btnLabel.Name = "btnLabel";
            btnLabel.UseVisualStyleBackColor = true;
            btnLabel.Click += btnLabel_Click;
            btnLabel.MouseHover += btnLabel_MouseHover;
            // 
            // btnRadioButton
            // 
            btnRadioButton.Cursor = Cursors.Hand;
            resources.ApplyResources(btnRadioButton, "btnRadioButton");
            btnRadioButton.Name = "btnRadioButton";
            btnRadioButton.UseVisualStyleBackColor = true;
            btnRadioButton.Click += btnRadioButton_Click;
            btnRadioButton.MouseHover += btnRadioButton_MouseHover;
            // 
            // btnProperties
            // 
            btnProperties.Cursor = Cursors.Hand;
            resources.ApplyResources(btnProperties, "btnProperties");
            btnProperties.Name = "btnProperties";
            btnProperties.UseVisualStyleBackColor = true;
            btnProperties.Click += button8_Click;
            // 
            // txtKod
            // 
            txtKod.CausesValidation = false;
            txtKod.Cursor = Cursors.IBeam;
            resources.ApplyResources(txtKod, "txtKod");
            txtKod.Name = "txtKod";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnTip
            // 
            resources.ApplyResources(btnTip, "btnTip");
            btnTip.Name = "btnTip";
            btnTip.UseVisualStyleBackColor = true;
            btnTip.Click += btnTip_Click;
            // 
            // lblTipText
            // 
            resources.ApplyResources(lblTipText, "lblTipText");
            lblTipText.Name = "lblTipText";
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            Controls.Add(lblTipText);
            Controls.Add(btnDalej);
            Controls.Add(btnPowrot);
            Controls.Add(btnTip);
            Controls.Add(btnOpenSettings);
            Controls.Add(boxSettings);
            Controls.Add(btnZatwierdz);
            Controls.Add(txtKod);
            Controls.Add(btnProperties);
            Controls.Add(btnRadioButton);
            Controls.Add(btnLabel);
            Controls.Add(btnCheckBox);
            Controls.Add(btnTextBox);
            Controls.Add(btnProgressBar);
            Controls.Add(btnComboBox);
            Controls.Add(btnButton);
            Controls.Add(label1);
            Name = "MainScreen";
            Load += MainScreen_Load;
            boxSettings.ResumeLayout(false);
            boxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnLangaugeChange;
        private HScrollBar hScrollBar1;
        private FlowLayoutPanel flowLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem4;
        private GroupBox boxSettings;
        private Button btnOpenSettings;
        private Button btnCloseSettings;
        private Button btnButton;
        private Button btnComboBox;
        private Button btnProgressBar;
        private Button btnTextBox;
        private Button btnCheckBox;
        private Button btnLabel;
        private Button btnRadioButton;
        private Button btnProperties;
        private Button btnZatwierdz;
        private RichTextBox txtKod;
        private ErrorProvider errorProvider1;
        private Button btnPowrot;
        private Button btnDalej;
        private Button btnTip;
        private Label lblTipText;
        private Label label2;
        private RadioButton rbProperties;
        private RadioButton rbTextBox;
        private RadioButton rbRadioButton;
        private RadioButton rbProgressBar;
        private RadioButton rbLabel;
        private RadioButton rbComboBox;
        private RadioButton rbCheckBox;
        private RadioButton rbButton;
        private ToolTip toolTip1;
    }
}