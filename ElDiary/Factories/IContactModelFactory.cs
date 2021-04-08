﻿using ElDiary.Entities;

namespace ElDiary.Factories
{
    public interface IContactModelFactory
    {
        ContactModel Create(ContactDto contactDto);
    }
}