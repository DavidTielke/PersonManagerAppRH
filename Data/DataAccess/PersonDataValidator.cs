﻿using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Backend.Data.DataAccess;

public class PersonDataValidator : IPersonDataValidator
{
    public void AssertForInsert(Person person)
    {
        ArgumentNullException.ThrowIfNull(nameof(person));
        if (person.Id != 0)
        {
            throw new ArgumentException("Id must be 0 to insert into the storage", nameof(person.Id));
        }
    }
}