namespace _11._2_winforms
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
            labelPlaneModel = new Label();
            listBoxPlanes = new ListBox();
            buttonSearch = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            labelDisplay = new Label();
            labelFound = new Label();
            SuspendLayout();
            // 
            // labelPlaneModel
            // 
            labelPlaneModel.AutoSize = true;
            labelPlaneModel.Cursor = Cursors.IBeam;
            labelPlaneModel.Location = new Point(12, 9);
            labelPlaneModel.Name = "labelPlaneModel";
            labelPlaneModel.Size = new Size(142, 20);
            labelPlaneModel.TabIndex = 0;
            labelPlaneModel.Text = "Модели самолетов";
            labelPlaneModel.Click += labelPlaneModel_Click;
            // 
            // listBoxPlanes
            // 
            listBoxPlanes.BackColor = SystemColors.Info;
            listBoxPlanes.Cursor = Cursors.Hand;
            listBoxPlanes.FormattingEnabled = true;
            listBoxPlanes.Location = new Point(12, 32);
            listBoxPlanes.Name = "listBoxPlanes";
            listBoxPlanes.Size = new Size(234, 164);
            listBoxPlanes.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.ButtonFace;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.Location = new Point(53, 202);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(150, 41);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Info;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(331, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(457, 164);
            listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.Info;
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.Location = new Point(12, 279);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(776, 164);
            listBox2.TabIndex = 4;
            // 
            // labelDisplay
            // 
            labelDisplay.AutoSize = true;
            labelDisplay.Cursor = Cursors.IBeam;
            labelDisplay.ForeColor = SystemColors.ActiveCaptionText;
            labelDisplay.Location = new Point(344, 256);
            labelDisplay.Name = "labelDisplay";
            labelDisplay.Size = new Size(84, 20);
            labelDisplay.TabIndex = 5;
            labelDisplay.Text = "Все рейсы:";
            // 
            // labelFound
            // 
            labelFound.AutoSize = true;
            labelFound.Cursor = Cursors.IBeam;
            labelFound.Location = new Point(572, 9);
            labelFound.Name = "labelFound";
            labelFound.Size = new Size(216, 20);
            labelFound.TabIndex = 6;
            labelFound.Text = "Рейсы конкретного самолета:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(799, 472);
            Controls.Add(labelFound);
            Controls.Add(labelDisplay);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(buttonSearch);
            Controls.Add(listBoxPlanes);
            Controls.Add(labelPlaneModel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlaneModel;
        private ListBox listBoxPlanes;
        private Button buttonSearch;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label labelDisplay;
        private Label labelFound;
    }
}
