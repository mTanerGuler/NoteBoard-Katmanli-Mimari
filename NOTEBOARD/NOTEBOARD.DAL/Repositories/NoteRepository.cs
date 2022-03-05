using NOTEBOARD.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTEBOARD.DAL.Repositories
{
    public class NoteRepository
    {
        //Note ile ilgili database'e yapılacak bir işlem varsa bu class içerisinde o işleme bir metot tanımlanır.
        //Parametre olarak alınan herşey çok doğru 
        NoteBoardDbContext context;
        public NoteRepository()
        {
            context = new NoteBoardDbContext();
        }

        public List<Note> GetById(int userID)
        {
            return context.Notes.Where(a => a.UserID == userID && a.IsActive).ToList();
        }

        public Note GetByNoteId(int noteID)
        {
            return context.Notes.Where(a => a.ID == noteID).SingleOrDefault();
        }

        public bool Insert(Note note)
        {
            context.Notes.Add(note);
            return context.SaveChanges() > 0;
        }

        public bool Update(Note note)
        {
            Note updatedNote = context.Notes.SingleOrDefault(a => a.ID == note.ID);
            updatedNote.Title = note.Title;
            updatedNote.Content = note.Content;
            return context.SaveChanges() > 0;
        }

        public bool Delete(Note note)
        {
            Note deletedNote = context.Notes.SingleOrDefault(a => a.ID == note.ID);
            deletedNote.IsActive = false;
            return context.SaveChanges() > 0;
        }

    }
}
