using System.Drawing;
using System.Windows.Forms;

namespace SatteliteManagment
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.buttonClearLogs = new System.Windows.Forms.Button();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSnrInfoB = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.radioButtonSeparatorNothing = new System.Windows.Forms.RadioButton();
            this.radioButtonSeparatorDollar = new System.Windows.Forms.RadioButton();
            this.buttonSendCommand = new System.Windows.Forms.Button();
            this.textBoxSendCommand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSnrInfoA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOpenCloseServer = new System.Windows.Forms.Button();
            this.labelComPortConnectionInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRadioControl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRadioControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClearLogs
            // 
            this.buttonClearLogs.Location = new System.Drawing.Point(993, 3);
            this.buttonClearLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClearLogs.Name = "buttonClearLogs";
            this.buttonClearLogs.Size = new System.Drawing.Size(83, 23);
            this.buttonClearLogs.TabIndex = 4;
            this.buttonClearLogs.Text = "Очистить";
            this.buttonClearLogs.UseVisualStyleBackColor = true;
            this.buttonClearLogs.Click += new System.EventHandler(this.buttonClearLogs_Click);
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Location = new System.Drawing.Point(243, 30);
            this.dataGridViewLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.RowHeadersWidth = 51;
            this.dataGridViewLogs.RowTemplate.Height = 29;
            this.dataGridViewLogs.Size = new System.Drawing.Size(832, 308);
            this.dataGridViewLogs.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSnrInfoB);
            this.groupBox1.Controls.Add(this.label61);
            this.groupBox1.Controls.Add(this.radioButtonSeparatorNothing);
            this.groupBox1.Controls.Add(this.radioButtonSeparatorDollar);
            this.groupBox1.Controls.Add(this.buttonSendCommand);
            this.groupBox1.Controls.Add(this.textBoxSendCommand);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelSnrInfoA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonOpenCloseServer);
            this.groupBox1.Controls.Add(this.labelComPortConnectionInfo);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(230, 196);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключение и данные";
            // 
            // labelSnrInfoB
            // 
            this.labelSnrInfoB.AutoSize = true;
            this.labelSnrInfoB.Location = new System.Drawing.Point(137, 51);
            this.labelSnrInfoB.Name = "labelSnrInfoB";
            this.labelSnrInfoB.Size = new System.Drawing.Size(13, 13);
            this.labelSnrInfoB.TabIndex = 15;
            this.labelSnrInfoB.Text = "0";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(93, 51);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(45, 13);
            this.label61.TabIndex = 14;
            this.label61.Text = "RSSI B:";
            // 
            // radioButtonSeparatorNothing
            // 
            this.radioButtonSeparatorNothing.AutoSize = true;
            this.radioButtonSeparatorNothing.Location = new System.Drawing.Point(4, 153);
            this.radioButtonSeparatorNothing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSeparatorNothing.Name = "radioButtonSeparatorNothing";
            this.radioButtonSeparatorNothing.Size = new System.Drawing.Size(138, 17);
            this.radioButtonSeparatorNothing.TabIndex = 13;
            this.radioButtonSeparatorNothing.Text = "Без разделителя байт";
            this.radioButtonSeparatorNothing.UseVisualStyleBackColor = true;
            // 
            // radioButtonSeparatorDollar
            // 
            this.radioButtonSeparatorDollar.AutoSize = true;
            this.radioButtonSeparatorDollar.Checked = true;
            this.radioButtonSeparatorDollar.Location = new System.Drawing.Point(4, 134);
            this.radioButtonSeparatorDollar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSeparatorDollar.Name = "radioButtonSeparatorDollar";
            this.radioButtonSeparatorDollar.Size = new System.Drawing.Size(142, 17);
            this.radioButtonSeparatorDollar.TabIndex = 12;
            this.radioButtonSeparatorDollar.TabStop = true;
            this.radioButtonSeparatorDollar.Text = "Разделитель байт - \"$\"";
            this.radioButtonSeparatorDollar.UseVisualStyleBackColor = true;
            // 
            // buttonSendCommand
            // 
            this.buttonSendCommand.Location = new System.Drawing.Point(145, 134);
            this.buttonSendCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSendCommand.Name = "buttonSendCommand";
            this.buttonSendCommand.Size = new System.Drawing.Size(81, 35);
            this.buttonSendCommand.TabIndex = 11;
            this.buttonSendCommand.Text = "Отправить\r\nкоманду";
            this.buttonSendCommand.UseVisualStyleBackColor = true;
            this.buttonSendCommand.Click += new System.EventHandler(this.buttonSendCommand_Click);
            // 
            // textBoxSendCommand
            // 
            this.textBoxSendCommand.Location = new System.Drawing.Point(4, 112);
            this.textBoxSendCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSendCommand.Name = "textBoxSendCommand";
            this.textBoxSendCommand.Size = new System.Drawing.Size(222, 20);
            this.textBoxSendCommand.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Отправка команд:";
            // 
            // labelSnrInfoA
            // 
            this.labelSnrInfoA.AutoSize = true;
            this.labelSnrInfoA.Location = new System.Drawing.Point(49, 51);
            this.labelSnrInfoA.Name = "labelSnrInfoA";
            this.labelSnrInfoA.Size = new System.Drawing.Size(13, 13);
            this.labelSnrInfoA.TabIndex = 8;
            this.labelSnrInfoA.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "RSSI A:";
            // 
            // buttonOpenCloseServer
            // 
            this.buttonOpenCloseServer.Location = new System.Drawing.Point(4, 65);
            this.buttonOpenCloseServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenCloseServer.Name = "buttonOpenCloseServer";
            this.buttonOpenCloseServer.Size = new System.Drawing.Size(220, 29);
            this.buttonOpenCloseServer.TabIndex = 6;
            this.buttonOpenCloseServer.Text = "Включить сервер";
            this.buttonOpenCloseServer.UseVisualStyleBackColor = true;
            this.buttonOpenCloseServer.Click += new System.EventHandler(this.connectToServer_Click);
            // 
            // labelComPortConnectionInfo
            // 
            this.labelComPortConnectionInfo.AutoSize = true;
            this.labelComPortConnectionInfo.Location = new System.Drawing.Point(75, 23);
            this.labelComPortConnectionInfo.Name = "labelComPortConnectionInfo";
            this.labelComPortConnectionInfo.Size = new System.Drawing.Size(85, 13);
            this.labelComPortConnectionInfo.TabIndex = 5;
            this.labelComPortConnectionInfo.Text = "Не подключено";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(49, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 18);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Статус:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Лог:";
            // 
            // panelRadioControl
            // 
            this.panelRadioControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRadioControl.Controls.Add(this.button1);
            this.panelRadioControl.Controls.Add(this.label1);
            this.panelRadioControl.Controls.Add(this.groupBox1);
            this.panelRadioControl.Controls.Add(this.dataGridViewLogs);
            this.panelRadioControl.Controls.Add(this.buttonClearLogs);
            this.panelRadioControl.Location = new System.Drawing.Point(0, 19);
            this.panelRadioControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRadioControl.Name = "panelRadioControl";
            this.panelRadioControl.Size = new System.Drawing.Size(1085, 340);
            this.panelRadioControl.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Чтение команд из файла";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 361);
            this.Controls.Add(this.panelRadioControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SatteliteManagment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRadioControl.ResumeLayout(false);
            this.panelRadioControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CheckBox checkBoxDollar;
        private Button buttonClearLogs;
        private DataGridView dataGridViewLogs;
        private GroupBox groupBox1;
        public Label labelSnrInfoB;
        private Label label61;
        private RadioButton radioButtonSeparatorNothing;
        private RadioButton radioButtonSeparatorDollar;
        private Button buttonSendCommand;
        private TextBox textBoxSendCommand;
        private Label label6;
        public Label labelSnrInfoA;
        private Label label5;
        public Button buttonOpenCloseServer;
        public Label labelComPortConnectionInfo;
        public PictureBox pictureBox1;
        private Label label4;
        private Label label1;
        private Panel panelRadioControl;
        private Button button1;
        private OpenFileDialog openFileDialog1;
    }
}

