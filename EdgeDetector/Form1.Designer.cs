namespace EdgeDetector
{
    partial class Form1
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
            this.sourcePictureBox = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.runButton = new System.Windows.Forms.Button();
            this.threadsTrackBar = new System.Windows.Forms.TrackBar();
            this.threadsLabel = new System.Windows.Forms.Label();
            this.asmRadioButton = new System.Windows.Forms.RadioButton();
            this.csRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.resultTimeLabel = new System.Windows.Forms.Label();
            this.openSourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveResultFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadsTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // sourcePictureBox
            // 
            this.sourcePictureBox.Location = new System.Drawing.Point(12, 90);
            this.sourcePictureBox.Name = "sourcePictureBox";
            this.sourcePictureBox.Size = new System.Drawing.Size(320, 180);
            this.sourcePictureBox.TabIndex = 0;
            this.sourcePictureBox.TabStop = false;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 278);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(150, 30);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Załaduj";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButtonClick);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Location = new System.Drawing.Point(420, 90);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(320, 180);
            this.resultPictureBox.TabIndex = 2;
            this.resultPictureBox.TabStop = false;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(182, 278);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(150, 30);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "Uruchom";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButtonClick);
            // 
            // threadsTrackBar
            // 
            this.threadsTrackBar.Location = new System.Drawing.Point(219, 32);
            this.threadsTrackBar.Maximum = 64;
            this.threadsTrackBar.Minimum = 1;
            this.threadsTrackBar.Name = "threadsTrackBar";
            this.threadsTrackBar.Size = new System.Drawing.Size(320, 45);
            this.threadsTrackBar.TabIndex = 6;
            this.threadsTrackBar.Value = 1;
            // 
            // threadsLabel
            // 
            this.threadsLabel.AutoSize = true;
            this.threadsLabel.Location = new System.Drawing.Point(342, 7);
            this.threadsLabel.Name = "threadsLabel";
            this.threadsLabel.Size = new System.Drawing.Size(75, 15);
            this.threadsLabel.TabIndex = 7;
            this.threadsLabel.Text = "Ilość wątków";
            // 
            // asmRadioButton
            // 
            this.asmRadioButton.AutoSize = true;
            this.asmRadioButton.Location = new System.Drawing.Point(12, 361);
            this.asmRadioButton.Name = "asmRadioButton";
            this.asmRadioButton.Size = new System.Drawing.Size(75, 19);
            this.asmRadioButton.TabIndex = 8;
            this.asmRadioButton.TabStop = true;
            this.asmRadioButton.Text = "Asembler";
            this.asmRadioButton.UseVisualStyleBackColor = true;
            // 
            // csRadioButton
            // 
            this.csRadioButton.AutoSize = true;
            this.csRadioButton.Location = new System.Drawing.Point(12, 386);
            this.csRadioButton.Name = "csRadioButton";
            this.csRadioButton.Size = new System.Drawing.Size(40, 19);
            this.csRadioButton.TabIndex = 9;
            this.csRadioButton.TabStop = true;
            this.csRadioButton.Text = "C#";
            this.csRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(590, 278);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 30);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Zapisz jako";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(420, 328);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(94, 15);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "Czas wykonania:";
            this.timeLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // resultTimeLabel
            // 
            this.resultTimeLabel.AutoSize = true;
            this.resultTimeLabel.Location = new System.Drawing.Point(520, 328);
            this.resultTimeLabel.Name = "resultTimeLabel";
            this.resultTimeLabel.Size = new System.Drawing.Size(36, 15);
            this.resultTimeLabel.TabIndex = 12;
            this.resultTimeLabel.Text = "result";
            this.resultTimeLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // openSourceFileDialog
            // 
            this.openSourceFileDialog.FileName = "openSourceFileDialog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultTimeLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.csRadioButton);
            this.Controls.Add(this.asmRadioButton);
            this.Controls.Add(this.threadsLabel);
            this.Controls.Add(this.threadsTrackBar);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.sourcePictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadsTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox sourcePictureBox;
        private Button loadButton;
        private PictureBox resultPictureBox;
        private Button runButton;
        private TrackBar threadsTrackBar;
        private Label threadsLabel;
        private RadioButton asmRadioButton;
        private RadioButton csRadioButton;
        private Button saveButton;
        private Label timeLabel;
        private Label resultTimeLabel;
        private OpenFileDialog openSourceFileDialog;
        private SaveFileDialog saveResultFileDialog;
        private Label label6;
    }
}