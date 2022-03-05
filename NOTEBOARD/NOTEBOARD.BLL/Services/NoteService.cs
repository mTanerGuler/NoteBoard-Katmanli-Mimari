using NOTEBOARD.DAL.Repositories;
using NOTEBOARD.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEBOARD.BLL.Services
{
    public class NoteService
    {
        NoteRepository noteRepository;
        public NoteService()
        {
            noteRepository = new NoteRepository();
        }

        public List<Note> GetById(int userID)
        {
            List<Note> notes = new List<Note>();
            if (userID > 0)
            {
                notes = noteRepository.GetById(userID);
            }
            else
            {
                throw new Exception("Parametre değeri uygun değil");
            }
            return notes;
        }

        public Note GetByNoteId(int noteID)
        {
            Note note = new Note();
            CheckNoteID(noteID);
            note = noteRepository.GetByNoteId(noteID);
            return note;
        }

        private static void CheckNoteID(int noteID)
        {
            if (noteID == 0)
            {
                throw new Exception("Parametre değeri uygun değil");
            }
        }

        public bool Insert(Note note)
        {
            CheckTitleContent(note);
//Bu notun userIDsi var mı ????
            note.CreatedDate = DateTime.Now;
            note.IsActive = true;
            return noteRepository.Insert(note);
        }

        private void CheckTitleContent(Note note)
        {
            if (note.Content.Trim().Length == 0 || note.Title.Trim().Length == 0)
            {
                throw new Exception("Title ve Content bilgisi eksik");
            }
        }

        public bool Update(Note note)
        {
            CheckTitleContent(note);
            if (note.ID == 0)
            {
                throw new Exception("Note güncellenirken ID bilgisi mutlaka atanmalıdır");
            }
            return noteRepository.Update(note);
        }

        public bool Delete(int id)
        {
            CheckNoteID(id);
            Note note = GetByNoteId(id);
            return noteRepository.Delete(note);
        }

        public bool Delete(Note note)
        {
            CheckNoteID(note.ID);
            return noteRepository.Delete(note);
        }
    }
}
