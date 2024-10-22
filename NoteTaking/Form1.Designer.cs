namespace NoteTaking
{
    partial class NoteTaking
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
            label1 = new Label();
            label2 = new Label();
            TitleBox = new TextBox();
            NotesBox = new TextBox();
            PreviousNote = new DataGridView();
            Loadbutton = new Button();
            Deletebutton = new Button();
            Savebutton = new Button();
            Newnotebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)PreviousNote).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(422, 40);
            label1.Name = "label1";
            label1.Size = new Size(65, 30);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(422, 129);
            label2.Name = "label2";
            label2.Size = new Size(80, 30);
            label2.TabIndex = 1;
            label2.Text = "Notes:";
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(422, 73);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(369, 31);
            TitleBox.TabIndex = 2;
            // 
            // NotesBox
            // 
            NotesBox.Location = new Point(422, 162);
            NotesBox.Multiline = true;
            NotesBox.Name = "NotesBox";
            NotesBox.Size = new Size(366, 339);
            NotesBox.TabIndex = 3;
            // 
            // PreviousNote
            // 
            PreviousNote.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PreviousNote.BackgroundColor = SystemColors.ButtonHighlight;
            PreviousNote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PreviousNote.Location = new Point(12, 12);
            PreviousNote.Name = "PreviousNote";
            PreviousNote.RowHeadersWidth = 62;
            PreviousNote.RowTemplate.Height = 33;
            PreviousNote.Size = new Size(404, 389);
            PreviousNote.TabIndex = 4;
            PreviousNote.CellContentClick += PreviousNote_CellContentClick;
            PreviousNote.CellDoubleClick += PreviousNote_CellDoubleClick;
            // 
            // Loadbutton
            // 
            Loadbutton.Location = new Point(28, 407);
            Loadbutton.Name = "Loadbutton";
            Loadbutton.Size = new Size(156, 44);
            Loadbutton.TabIndex = 5;
            Loadbutton.Text = "Load";
            Loadbutton.UseVisualStyleBackColor = true;
            Loadbutton.Click += Loadbutton_Click;
            // 
            // Deletebutton
            // 
            Deletebutton.Location = new Point(236, 407);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(156, 44);
            Deletebutton.TabIndex = 6;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = true;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // Savebutton
            // 
            Savebutton.Location = new Point(236, 457);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(156, 44);
            Savebutton.TabIndex = 7;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = true;
            Savebutton.Click += Savebutton_Click;
            // 
            // Newnotebutton
            // 
            Newnotebutton.Location = new Point(28, 457);
            Newnotebutton.Name = "Newnotebutton";
            Newnotebutton.Size = new Size(156, 44);
            Newnotebutton.TabIndex = 8;
            Newnotebutton.Text = "New note";
            Newnotebutton.UseVisualStyleBackColor = true;
            Newnotebutton.Click += Newnotebutton_Click;
            // 
            // NoteTaking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 513);
            Controls.Add(Newnotebutton);
            Controls.Add(Savebutton);
            Controls.Add(Deletebutton);
            Controls.Add(Loadbutton);
            Controls.Add(PreviousNote);
            Controls.Add(NotesBox);
            Controls.Add(TitleBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NoteTaking";
            Text = "Note Taking";
            Load += NoteTaking_Load;
            ((System.ComponentModel.ISupportInitialize)PreviousNote).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TitleBox;
        private TextBox NotesBox;
        private DataGridView PreviousNote;
        private Button Loadbutton;
        private Button Deletebutton;
        private Button Savebutton;
        private Button Newnotebutton;
    }
}