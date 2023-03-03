namespace WinFormsToDoApp
{
    partial class DetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            detailTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            detailTableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            taskNameLabel = new System.Windows.Forms.Label();
            taskNameTextBox = new System.Windows.Forms.TextBox();
            priorityLabel = new System.Windows.Forms.Label();
            priorityCombobox = new System.Windows.Forms.ComboBox();
            descriptionLabel = new System.Windows.Forms.Label();
            descriptionRichTextBox1 = new System.Windows.Forms.RichTextBox();
            detailTableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            saveButton = new System.Windows.Forms.Button();
            stateComboBox = new System.Windows.Forms.ComboBox();
            stateLabel = new System.Windows.Forms.Label();
            deadlineTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            deadlineTimeLabel = new System.Windows.Forms.Label();
            deadlineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            deadlineLabel = new System.Windows.Forms.Label();
            datetimeCheckBox = new System.Windows.Forms.CheckBox();
            detailTableLayoutPanel1.SuspendLayout();
            detailTableLayoutPanel2.SuspendLayout();
            detailTableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // detailTableLayoutPanel1
            // 
            detailTableLayoutPanel1.ColumnCount = 2;
            detailTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            detailTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            detailTableLayoutPanel1.Controls.Add(detailTableLayoutPanel2, 0, 0);
            detailTableLayoutPanel1.Controls.Add(detailTableLayoutPanel3, 1, 0);
            detailTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            detailTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            detailTableLayoutPanel1.Name = "detailTableLayoutPanel1";
            detailTableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            detailTableLayoutPanel1.RowCount = 1;
            detailTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            detailTableLayoutPanel1.Size = new System.Drawing.Size(784, 461);
            detailTableLayoutPanel1.TabIndex = 0;
            // 
            // detailTableLayoutPanel2
            // 
            detailTableLayoutPanel2.ColumnCount = 1;
            detailTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            detailTableLayoutPanel2.Controls.Add(taskNameLabel, 0, 0);
            detailTableLayoutPanel2.Controls.Add(taskNameTextBox, 0, 1);
            detailTableLayoutPanel2.Controls.Add(priorityLabel, 0, 2);
            detailTableLayoutPanel2.Controls.Add(priorityCombobox, 0, 3);
            detailTableLayoutPanel2.Controls.Add(descriptionLabel, 0, 4);
            detailTableLayoutPanel2.Controls.Add(descriptionRichTextBox1, 0, 5);
            detailTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            detailTableLayoutPanel2.Location = new System.Drawing.Point(13, 13);
            detailTableLayoutPanel2.Name = "detailTableLayoutPanel2";
            detailTableLayoutPanel2.RowCount = 6;
            detailTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            detailTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            detailTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            detailTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            detailTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            detailTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            detailTableLayoutPanel2.Size = new System.Drawing.Size(376, 435);
            detailTableLayoutPanel2.TabIndex = 0;
            // 
            // taskNameLabel
            // 
            taskNameLabel.AutoSize = true;
            taskNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            taskNameLabel.Location = new System.Drawing.Point(3, 0);
            taskNameLabel.Name = "taskNameLabel";
            taskNameLabel.Size = new System.Drawing.Size(370, 30);
            taskNameLabel.TabIndex = 0;
            taskNameLabel.Text = "Název úkolu";
            taskNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            taskNameTextBox.Location = new System.Drawing.Point(3, 33);
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new System.Drawing.Size(370, 23);
            taskNameTextBox.TabIndex = 1;
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            priorityLabel.Location = new System.Drawing.Point(3, 60);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(370, 30);
            priorityLabel.TabIndex = 2;
            priorityLabel.Text = "Priorita";
            priorityLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // priorityCombobox
            // 
            priorityCombobox.Dock = System.Windows.Forms.DockStyle.Fill;
            priorityCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            priorityCombobox.FormattingEnabled = true;
            priorityCombobox.Location = new System.Drawing.Point(3, 93);
            priorityCombobox.Name = "priorityCombobox";
            priorityCombobox.Size = new System.Drawing.Size(370, 23);
            priorityCombobox.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            descriptionLabel.Location = new System.Drawing.Point(3, 120);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(370, 30);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Popis";
            descriptionLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // descriptionRichTextBox1
            // 
            descriptionRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            descriptionRichTextBox1.Location = new System.Drawing.Point(3, 153);
            descriptionRichTextBox1.MaxLength = 500;
            descriptionRichTextBox1.Name = "descriptionRichTextBox1";
            descriptionRichTextBox1.Size = new System.Drawing.Size(370, 279);
            descriptionRichTextBox1.TabIndex = 5;
            descriptionRichTextBox1.Text = "";
            descriptionRichTextBox1.WordWrap = false;
            // 
            // detailTableLayoutPanel3
            // 
            detailTableLayoutPanel3.ColumnCount = 1;
            detailTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            detailTableLayoutPanel3.Controls.Add(saveButton, 0, 7);
            detailTableLayoutPanel3.Controls.Add(stateComboBox, 0, 6);
            detailTableLayoutPanel3.Controls.Add(stateLabel, 0, 5);
            detailTableLayoutPanel3.Controls.Add(deadlineTimeDateTimePicker, 0, 4);
            detailTableLayoutPanel3.Controls.Add(deadlineTimeLabel, 0, 3);
            detailTableLayoutPanel3.Controls.Add(deadlineDateTimePicker, 0, 2);
            detailTableLayoutPanel3.Controls.Add(deadlineLabel, 0, 1);
            detailTableLayoutPanel3.Controls.Add(datetimeCheckBox, 0, 0);
            detailTableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            detailTableLayoutPanel3.Location = new System.Drawing.Point(395, 13);
            detailTableLayoutPanel3.Name = "detailTableLayoutPanel3";
            detailTableLayoutPanel3.RowCount = 8;
            detailTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            detailTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            detailTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            detailTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            detailTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            detailTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            detailTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            detailTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            detailTableLayoutPanel3.Size = new System.Drawing.Size(376, 435);
            detailTableLayoutPanel3.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            saveButton.Location = new System.Drawing.Point(80, 325);
            saveButton.Margin = new System.Windows.Forms.Padding(80, 3, 80, 40);
            saveButton.MinimumSize = new System.Drawing.Size(100, 70);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(216, 70);
            saveButton.TabIndex = 4;
            saveButton.Text = "Uložit změny";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // stateComboBox
            // 
            stateComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            stateComboBox.Location = new System.Drawing.Point(3, 183);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new System.Drawing.Size(370, 23);
            stateComboBox.TabIndex = 6;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            stateLabel.Location = new System.Drawing.Point(3, 150);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(370, 30);
            stateLabel.TabIndex = 5;
            stateLabel.Text = "Stav";
            stateLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // deadlineTimeDateTimePicker
            // 
            deadlineTimeDateTimePicker.CustomFormat = "\"hh:mm:ss\"";
            deadlineTimeDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            deadlineTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            deadlineTimeDateTimePicker.Location = new System.Drawing.Point(3, 123);
            deadlineTimeDateTimePicker.Name = "deadlineTimeDateTimePicker";
            deadlineTimeDateTimePicker.ShowUpDown = true;
            deadlineTimeDateTimePicker.Size = new System.Drawing.Size(370, 23);
            deadlineTimeDateTimePicker.TabIndex = 3;
            // 
            // deadlineTimeLabel
            // 
            deadlineTimeLabel.AutoSize = true;
            deadlineTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            deadlineTimeLabel.Location = new System.Drawing.Point(3, 90);
            deadlineTimeLabel.Name = "deadlineTimeLabel";
            deadlineTimeLabel.Size = new System.Drawing.Size(370, 30);
            deadlineTimeLabel.TabIndex = 2;
            deadlineTimeLabel.Text = "Čas termínu";
            deadlineTimeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // deadlineDateTimePicker
            // 
            deadlineDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            deadlineDateTimePicker.Location = new System.Drawing.Point(3, 63);
            deadlineDateTimePicker.Name = "deadlineDateTimePicker";
            deadlineDateTimePicker.Size = new System.Drawing.Size(370, 23);
            deadlineDateTimePicker.TabIndex = 1;
            // 
            // deadlineLabel
            // 
            deadlineLabel.AutoSize = true;
            deadlineLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            deadlineLabel.Location = new System.Drawing.Point(3, 30);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new System.Drawing.Size(370, 30);
            deadlineLabel.TabIndex = 0;
            deadlineLabel.Text = "Termín";
            deadlineLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // datetimeCheckBox
            // 
            datetimeCheckBox.AutoSize = true;
            datetimeCheckBox.Checked = true;
            datetimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            datetimeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            datetimeCheckBox.Location = new System.Drawing.Point(3, 3);
            datetimeCheckBox.Name = "datetimeCheckBox";
            datetimeCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            datetimeCheckBox.Size = new System.Drawing.Size(370, 24);
            datetimeCheckBox.TabIndex = 7;
            datetimeCheckBox.Text = "Použít časový termín";
            datetimeCheckBox.UseVisualStyleBackColor = true;
            datetimeCheckBox.CheckedChanged += datetimeCheckBox_CheckedChanged;
            // 
            // DetailForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 461);
            Controls.Add(detailTableLayoutPanel1);
            MinimumSize = new System.Drawing.Size(450, 350);
            Name = "DetailForm";
            Text = "DetailForm";
            detailTableLayoutPanel1.ResumeLayout(false);
            detailTableLayoutPanel2.ResumeLayout(false);
            detailTableLayoutPanel2.PerformLayout();
            detailTableLayoutPanel3.ResumeLayout(false);
            detailTableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel detailTableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel detailTableLayoutPanel2;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.ComboBox priorityCombobox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox1;
        private System.Windows.Forms.TableLayoutPanel detailTableLayoutPanel3;
        private System.Windows.Forms.Label deadlineLabel;
        private System.Windows.Forms.DateTimePicker deadlineDateTimePicker;
        private System.Windows.Forms.Label deadlineTimeLabel;
        private System.Windows.Forms.DateTimePicker deadlineTimeDateTimePicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.CheckBox datetimeCheckBox;
    }
}