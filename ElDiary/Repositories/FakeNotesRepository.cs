using System;
using System.Collections.Generic;
using ElDiary.Entities;

namespace ElDiary.Repositories
{
    public static class FakeNotesRepository
    {
        private static List<Note> notes = new List<Note>
        {
            new Note {ContactId = Guid.Parse("cd3df559-c345-4b43-9e8b-22fd1a6d3d37"),
                Date = "15 october",
                Description = "Вымыть пол",
                Subject = "Уборка",
                Id = Guid.Parse("836aee40-76d2-4e87-94f8-009a4ef8a3ae")},
            new Note
            {
                ContactId = Guid.Parse("cd3df559-c345-4b43-9e8b-22fd1a6d3d37"),
                Date = "16 october",
                Description = "Вымыть дверь",
                Subject = "Уборка",
                Id = Guid.Parse("ef8f2cd2-9240-4964-80f7-a1a243c97bee")
            },
             new Note
            {
                ContactId = Guid.Parse("cd3df559-c345-4b43-9e8b-22fd1a6d3d37"),
                Date = "16 october",
                Description = "По словам председателя комиссии по безопасности " +
                              "Мосгордумы Инны Святенко, на новом ресурсе граждане " +
                              "смогут размещать записи с видеорегистраторов, на " +
                              "основании которых правоохранительные органы смогут " +
                              "проводить проверку и выявлять виновных в нарушениях " +
                              "ПДД и других законов. Ориентировочно, сайт, о котором" +
                              " идет речь, будет запущен уже в этом году. ",
                Subject = "Уборка",
                Id = Guid.Parse("f68d3b0e-9a95-41da-a375-f3792814912f")
            },
             new Note
            {
                ContactId = Guid.Parse("3fd315eb-79fe-4a53-93c2-8f8a8c9979da"),
                Date = "16 october",
                Description = "Вымыть дверь",
                Subject = "Уборка",
                Id = Guid.Parse("b800c515-8398-47b7-8a7d-05f7d03578f6")
            },
             new Note
            {
                ContactId = Guid.Parse("3fd315eb-79fe-4a53-93c2-8f8a8c9979da"),
                Date = "16 october",
                Description = "Вымыть дверь",
                Subject = "Уборка",
                Id = Guid.Parse("8c542703-9e6e-47f7-9f46-4400ebeeee18")
            },
             new Note
            {
                ContactId = Guid.Parse("3fd315eb-79fe-4a53-93c2-8f8a8c9979da"),
                Date = "16 october",
                Description = "Вымыть дверь",
                Subject = "Уборка",
                Id = Guid.Parse("84a5359b-1ac3-4d6a-9e48-e03a318e1504")
            },
             new Note
            {
                ContactId = Guid.Parse("836aee40-76d2-4e87-94f8-009a4ef8a3ae"),
                Date = "16 october",
                Description = "Вымыть дверь",
                Subject = "Уборка",
                Id = Guid.Parse("8654405f-ab14-49a8-8650-e6ccc0dd07aa")
            },
             new Note
            {
                ContactId = Guid.Parse("8cfa2bad-dee1-45ef-8b86-e72d168aba1c"),
                Date = "16 october",
                Description = "Вымыть дверь",
                Subject = "Уборка",
                Id = Guid.Parse("59d49587-660d-4a7d-b0d2-a9bf12e778f0")
            },
             new Note
            {
                ContactId = Guid.Parse("61bf9c72-b4d8-41e6-a60b-33b21119eb7e"),
                Date = "16 october",
                Description = "Вымыть дверь",
                Subject = "Уборка",
                Id = Guid.Parse("29590010-0cfe-4e65-87ae-5f45938dc942")
            },
             new Note
            {
                ContactId = Guid.Parse("836aee40-76d2-4e87-94f8-009a4ef8a3ae"),
                Date = "16 october",
                Description = "Вымыть дверь",
                Subject = "Уборка",
                Id = Guid.Parse("25b755bf-6b6e-4853-b5b2-2e73f4f515ea")
            },
             new Note
            {
                ContactId = Guid.Parse("61bf9c72-b4d8-41e6-a60b-33b21119eb7e"),
                Date = "16 october",
                Description = "Вымыть дверь",
                Subject = "Уборка",
                Id = Guid.Parse("74022537-d4ba-472e-9402-4133a6e33250")
            },
             new Note
            {
                ContactId = Guid.Parse("836aee40-76d2-4e87-94f8-009a4ef8a3ae"),
                Date = "16 october",
                Description = "Вымыть дверь",
                Subject = "Уборка",
                Id = Guid.Parse("47fd382d-2a87-4889-9397-a7d15fd944a4")
            }
        };

        public static IEnumerable<Note> Notes => notes;

        public static void Create(Note note)
        {
            notes.Add(note);
        }

        public static void Delete(Guid guidOfNote)
        {
            foreach (var item in notes)
            {
                if(item.Id == guidOfNote)

                notes.Remove(item);
                break;
            }
        }
    }
}