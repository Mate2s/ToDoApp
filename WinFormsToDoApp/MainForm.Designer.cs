namespace WinFormsToDoApp
{
    partial class MainForm
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
            topPanel = new System.Windows.Forms.Panel();
            topLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            userTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            userLabel = new System.Windows.Forms.Label();
            userLabel1 = new System.Windows.Forms.Label();
            appNamePanel = new System.Windows.Forms.Panel();
            appLabel = new System.Windows.Forms.Label();
            menuStrip = new System.Windows.Forms.MenuStrip();
            logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mainPanel = new System.Windows.Forms.Panel();
            mainDataGridView = new System.Windows.Forms.DataGridView();
            taskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fulfil = new System.Windows.Forms.DataGridViewButtonColumn();
            mainBottomPanel = new System.Windows.Forms.Panel();
            buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            detailButton = new System.Windows.Forms.Button();
            addButton = new System.Windows.Forms.Button();
            mainTopPanel = new System.Windows.Forms.Panel();
            statisticTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            completedTasksDscLable = new System.Windows.Forms.Label();
            completedTasksLable = new System.Windows.Forms.Label();
            tasksInProgressDscLabel = new System.Windows.Forms.Label();
            tasksInProgressLabel = new System.Windows.Forms.Label();
            bottomPanel = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            creatorLabel = new System.Windows.Forms.Label();
            versionLabel = new System.Windows.Forms.Label();
            topPanel.SuspendLayout();
            topLayoutPanel.SuspendLayout();
            userTableLayoutPanel.SuspendLayout();
            appNamePanel.SuspendLayout();
            menuStrip.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainDataGridView).BeginInit();
            mainBottomPanel.SuspendLayout();
            buttonTableLayoutPanel.SuspendLayout();
            mainTopPanel.SuspendLayout();
            statisticTableLayoutPanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(topLayoutPanel);
            topPanel.Controls.Add(appNamePanel);
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Location = new System.Drawing.Point(0, 24);
            topPanel.Name = "topPanel";
            topPanel.Size = new System.Drawing.Size(800, 100);
            topPanel.TabIndex = 0;
            // 
            // topLayoutPanel
            // 
            topLayoutPanel.ColumnCount = 3;
            topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            topLayoutPanel.Controls.Add(userTableLayoutPanel, 0, 0);
            topLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            topLayoutPanel.Location = new System.Drawing.Point(0, 30);
            topLayoutPanel.Name = "topLayoutPanel";
            topLayoutPanel.RowCount = 2;
            topLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            topLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            topLayoutPanel.Size = new System.Drawing.Size(800, 70);
            topLayoutPanel.TabIndex = 4;
            // 
            // userTableLayoutPanel
            // 
            userTableLayoutPanel.AutoSize = true;
            userTableLayoutPanel.ColumnCount = 2;
            userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            userTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            userTableLayoutPanel.Controls.Add(userLabel, 1, 0);
            userTableLayoutPanel.Controls.Add(userLabel1, 0, 0);
            userTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            userTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            userTableLayoutPanel.Name = "userTableLayoutPanel";
            userTableLayoutPanel.RowCount = 1;
            userTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            userTableLayoutPanel.Size = new System.Drawing.Size(210, 29);
            userTableLayoutPanel.TabIndex = 3;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            userLabel.Location = new System.Drawing.Point(116, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new System.Drawing.Size(91, 29);
            userLabel.TabIndex = 2;
            userLabel.Text = "Jméno uživatele";
            userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userLabel1
            // 
            userLabel1.AutoSize = true;
            userLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            userLabel1.Location = new System.Drawing.Point(3, 0);
            userLabel1.Name = "userLabel1";
            userLabel1.Size = new System.Drawing.Size(107, 29);
            userLabel1.TabIndex = 1;
            userLabel1.Text = "Přihlášený uživatel:";
            userLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            userLabel1.Click += label1_Click;
            // 
            // appNamePanel
            // 
            appNamePanel.Controls.Add(appLabel);
            appNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            appNamePanel.Location = new System.Drawing.Point(0, 0);
            appNamePanel.Name = "appNamePanel";
            appNamePanel.Size = new System.Drawing.Size(800, 30);
            appNamePanel.TabIndex = 4;
            // 
            // appLabel
            // 
            appLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            appLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            appLabel.Location = new System.Drawing.Point(0, 0);
            appLabel.Name = "appLabel";
            appLabel.Size = new System.Drawing.Size(800, 30);
            appLabel.TabIndex = 0;
            appLabel.Text = "ToDoApp";
            appLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { logoutToolStripMenuItem });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(800, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            logoutToolStripMenuItem.Text = "&Odhlásit se";
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(mainDataGridView);
            mainPanel.Controls.Add(mainBottomPanel);
            mainPanel.Controls.Add(mainTopPanel);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 124);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(800, 311);
            mainPanel.TabIndex = 1;
            // 
            // mainDataGridView
            // 
            mainDataGridView.AllowUserToAddRows = false;
            mainDataGridView.AllowUserToDeleteRows = false;
            mainDataGridView.AllowUserToOrderColumns = true;
            mainDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { taskName, Deadline, State, fulfil });
            mainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            mainDataGridView.Location = new System.Drawing.Point(0, 30);
            mainDataGridView.Name = "mainDataGridView";
            mainDataGridView.RowHeadersVisible = false;
            mainDataGridView.RowTemplate.Height = 25;
            mainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            mainDataGridView.Size = new System.Drawing.Size(800, 235);
            mainDataGridView.TabIndex = 2;
            // 
            // taskName
            // 
            taskName.HeaderText = "Název úkolu";
            taskName.Name = "taskName";
            taskName.ReadOnly = true;
            // 
            // Deadline
            // 
            Deadline.HeaderText = "Termín";
            Deadline.Name = "Deadline";
            Deadline.ReadOnly = true;
            // 
            // State
            // 
            State.HeaderText = "Stav";
            State.Name = "State";
            State.ReadOnly = true;
            State.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            State.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fulfil
            // 
            fulfil.HeaderText = "Splnit";
            fulfil.Name = "fulfil";
            fulfil.Text = "Splnit";
            // 
            // mainBottomPanel
            // 
            mainBottomPanel.AutoSize = true;
            mainBottomPanel.Controls.Add(buttonTableLayoutPanel);
            mainBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            mainBottomPanel.Location = new System.Drawing.Point(0, 265);
            mainBottomPanel.Name = "mainBottomPanel";
            mainBottomPanel.Size = new System.Drawing.Size(800, 46);
            mainBottomPanel.TabIndex = 1;
            // 
            // buttonTableLayoutPanel
            // 
            buttonTableLayoutPanel.AutoSize = true;
            buttonTableLayoutPanel.ColumnCount = 3;
            buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            buttonTableLayoutPanel.Controls.Add(detailButton, 0, 0);
            buttonTableLayoutPanel.Controls.Add(addButton, 2, 0);
            buttonTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
            buttonTableLayoutPanel.RowCount = 1;
            buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            buttonTableLayoutPanel.Size = new System.Drawing.Size(800, 46);
            buttonTableLayoutPanel.TabIndex = 0;
            // 
            // detailButton
            // 
            detailButton.Dock = System.Windows.Forms.DockStyle.Fill;
            detailButton.Location = new System.Drawing.Point(20, 3);
            detailButton.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            detailButton.Name = "detailButton";
            detailButton.Size = new System.Drawing.Size(150, 40);
            detailButton.TabIndex = 0;
            detailButton.Text = "Detail úkolu";
            detailButton.UseVisualStyleBackColor = true;
            detailButton.Click += detailButton_Click;
            // 
            // addButton
            // 
            addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            addButton.Location = new System.Drawing.Point(630, 3);
            addButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(150, 40);
            addButton.TabIndex = 1;
            addButton.Text = "Přidat úkol";
            addButton.UseVisualStyleBackColor = true;
            // 
            // mainTopPanel
            // 
            mainTopPanel.Controls.Add(statisticTableLayoutPanel);
            mainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            mainTopPanel.Location = new System.Drawing.Point(0, 0);
            mainTopPanel.Name = "mainTopPanel";
            mainTopPanel.Size = new System.Drawing.Size(800, 30);
            mainTopPanel.TabIndex = 0;
            // 
            // statisticTableLayoutPanel
            // 
            statisticTableLayoutPanel.ColumnCount = 5;
            statisticTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            statisticTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            statisticTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            statisticTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            statisticTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            statisticTableLayoutPanel.Controls.Add(completedTasksDscLable, 0, 0);
            statisticTableLayoutPanel.Controls.Add(completedTasksLable, 1, 0);
            statisticTableLayoutPanel.Controls.Add(tasksInProgressDscLabel, 3, 0);
            statisticTableLayoutPanel.Controls.Add(tasksInProgressLabel, 4, 0);
            statisticTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            statisticTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            statisticTableLayoutPanel.Name = "statisticTableLayoutPanel";
            statisticTableLayoutPanel.RowCount = 1;
            statisticTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            statisticTableLayoutPanel.Size = new System.Drawing.Size(800, 30);
            statisticTableLayoutPanel.TabIndex = 0;
            // 
            // completedTasksDscLable
            // 
            completedTasksDscLable.AutoSize = true;
            completedTasksDscLable.Dock = System.Windows.Forms.DockStyle.Fill;
            completedTasksDscLable.Location = new System.Drawing.Point(3, 0);
            completedTasksDscLable.Name = "completedTasksDscLable";
            completedTasksDscLable.Size = new System.Drawing.Size(81, 30);
            completedTasksDscLable.TabIndex = 0;
            completedTasksDscLable.Text = "Hotové úkoly:";
            completedTasksDscLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // completedTasksLable
            // 
            completedTasksLable.AutoSize = true;
            completedTasksLable.Dock = System.Windows.Forms.DockStyle.Fill;
            completedTasksLable.Location = new System.Drawing.Point(90, 0);
            completedTasksLable.Name = "completedTasksLable";
            completedTasksLable.Size = new System.Drawing.Size(13, 30);
            completedTasksLable.TabIndex = 1;
            completedTasksLable.Text = "0";
            completedTasksLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tasksInProgressDscLabel
            // 
            tasksInProgressDscLabel.AutoSize = true;
            tasksInProgressDscLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            tasksInProgressDscLabel.Location = new System.Drawing.Point(662, 0);
            tasksInProgressDscLabel.Name = "tasksInProgressDscLabel";
            tasksInProgressDscLabel.Size = new System.Drawing.Size(116, 30);
            tasksInProgressDscLabel.TabIndex = 3;
            tasksInProgressDscLabel.Text = "Rozpracované úkoly:";
            tasksInProgressDscLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tasksInProgressLabel
            // 
            tasksInProgressLabel.AutoSize = true;
            tasksInProgressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            tasksInProgressLabel.Location = new System.Drawing.Point(784, 0);
            tasksInProgressLabel.Name = "tasksInProgressLabel";
            tasksInProgressLabel.Size = new System.Drawing.Size(13, 30);
            tasksInProgressLabel.TabIndex = 4;
            tasksInProgressLabel.Text = "0";
            tasksInProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bottomPanel
            // 
            bottomPanel.AutoSize = true;
            bottomPanel.Controls.Add(tableLayoutPanel1);
            bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            bottomPanel.Location = new System.Drawing.Point(0, 435);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new System.Drawing.Size(800, 15);
            bottomPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(creatorLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(versionLabel, 2, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(800, 15);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // creatorLabel
            // 
            creatorLabel.AutoSize = true;
            creatorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            creatorLabel.Location = new System.Drawing.Point(3, 0);
            creatorLabel.Name = "creatorLabel";
            creatorLabel.Size = new System.Drawing.Size(74, 15);
            creatorLabel.TabIndex = 0;
            creatorLabel.Text = "Vytvořil M.K.";
            creatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            versionLabel.Location = new System.Drawing.Point(768, 0);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new System.Drawing.Size(29, 15);
            versionLabel.TabIndex = 1;
            versionLabel.Text = "V1.0";
            versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(mainPanel);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MinimumSize = new System.Drawing.Size(500, 39);
            Name = "MainForm";
            Text = "ToDoApp";
            topPanel.ResumeLayout(false);
            topLayoutPanel.ResumeLayout(false);
            topLayoutPanel.PerformLayout();
            userTableLayoutPanel.ResumeLayout(false);
            userTableLayoutPanel.PerformLayout();
            appNamePanel.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainDataGridView).EndInit();
            mainBottomPanel.ResumeLayout(false);
            mainBottomPanel.PerformLayout();
            buttonTableLayoutPanel.ResumeLayout(false);
            mainTopPanel.ResumeLayout(false);
            statisticTableLayoutPanel.ResumeLayout(false);
            statisticTableLayoutPanel.PerformLayout();
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label userLabel1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel topLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel userTableLayoutPanel;
        private System.Windows.Forms.Panel mainBottomPanel;
        private System.Windows.Forms.TableLayoutPanel buttonTableLayoutPanel;
        private System.Windows.Forms.Button detailButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel mainTopPanel;
        private System.Windows.Forms.TableLayoutPanel statisticTableLayoutPanel;
        private System.Windows.Forms.Label completedTasksDscLable;
        private System.Windows.Forms.Label completedTasksLable;
        private System.Windows.Forms.Label tasksInProgressDscLabel;
        private System.Windows.Forms.Label tasksInProgressLabel;
        private System.Windows.Forms.Panel appNamePanel;
        private System.Windows.Forms.Label appLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewButtonColumn fulfil;
    }
}
