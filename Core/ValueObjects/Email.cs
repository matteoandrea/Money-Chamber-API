﻿using Flunt.Validations;
using ProjectS.Core.Core.Objects;

namespace ProjectS.Core.Shared.ValueObjects;

public class Email : ValueObject
{
    #region Constructors

    public Email(string adress)
    {
        Adress = adress.Trim().ToLower();
        //VerificationCode = new();

        AddNotifications(new BasicEmailValidationContract(this));
    }

    #endregion

    #region Propreties

    public string Adress { get; init; }
    //public VerificationCode VerificationCode { get; private set; }

    #endregion

    #region Functions

    public override string ToString() => Adress;

    //public void ResendVerification()
    //{
    //    VerificationCode = new();
    //}

    #endregion
}

public class BasicEmailValidationContract : Contract<Email>
{
    public BasicEmailValidationContract(Email email)
    {
        Requires()
            .IsEmail(email.Adress, "Email", "Ivalid email");

    }
}