using System.Data;

namespace NoteTaking
{
    public partial class NoteTaking : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;

        public NoteTaking()
        {
            InitializeComponent();
        }

        private void Loadbutton_Click(object sender, EventArgs e)
        {
            TitleBox.Text = notes.Rows[PreviousNote.CurrentCell.RowIndex].ItemArray[0].ToString();
            NotesBox.Text = notes.Rows[PreviousNote.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[PreviousNote.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not a valid note");
            }
        }

        private void Newnotebutton_Click(object sender, EventArgs e)
        {
            TitleBox.Text = "";
            NotesBox.Text = "";
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[PreviousNote.CurrentCell.RowIndex]["Title"] = TitleBox.Text;
                notes.Rows[PreviousNote.CurrentCell.RowIndex]["Notes"] = NotesBox.Text;
            }
            else
            {
                notes.Rows.Add(TitleBox.Text, NotesBox.Text);
            }
            TitleBox.Text = "";
            NotesBox.Text = "";
            editing = false;
        }

        private void NoteTaking_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            PreviousNote.DataSource = notes;
        }

        private void PreviousNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PreviousNote_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TitleBox.Text = notes.Rows[PreviousNote.CurrentCell.RowIndex].ItemArray[0].ToString();
            NotesBox.Text = notes.Rows[PreviousNote.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}